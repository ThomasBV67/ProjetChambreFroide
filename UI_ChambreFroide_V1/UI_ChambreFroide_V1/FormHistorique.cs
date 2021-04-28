using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_ChambreFroide_V1
{   
    /// <summary>
    /// Ce form contient un listBox et des boutons. Le listBox contient les options de sources pour l'affichage d'un graphique 
    /// d'historique. Le bouton "Retour" permet de retourner au form principal. Les boutons contenant des flèches permettent de
    /// choisir une ligne dans le listBox. Si aucune ligne n'est sélectionnée, la première ligne sera sélectionnée par défaut. 
    /// Le bouton "Groupes", ou "Capteurs" dépendement du mode, permet de changer entre la sélection de groupes de capteurs et
    /// de capteurs individuels. Les trois boutons représentant des moments ("Dernier jour", "Dernière semaine" et "Dernier mois") 
    /// permettent de charger un graphique de toutes les données accumulées dans la plage de temps mentionnée. Le bouton "Plus
    /// d'options" permet d'ouvrir un form pour sélectionner une plage de temps personnalisée.
    /// </summary>
    public partial class FormHistorique : Form
    {
        public List<Capteur> m_listCapteurs = new List<Capteur>(); // liste des capteurs dans la db
        public List<String> m_listGroups = new List<String>();  // liste des groupes dans la db
        public List<ChartValues<double>> m_valuesChart = new List<ChartValues<double>>();   // liste de listes contenant des valeurs double de température
        public List<string> m_selectedCapteurs = new List<string>();    // liste des noms de capteurs sélectionnés
        public List<List<DateTime>> m_dateTimes = new List<List<DateTime>>(); //liste de listes de timestamp
        public List<List<int>> m_unixTimes = new List<List<int>>();
        public WarningAlert m_warningAlertLevels = new WarningAlert(0,0); // Niveaux d'alertes et de warning à envoyer au form de graphique

        // variables tempon pour les time stamps limite du graphique
        public int m_endTime = DateTimeToUnixTimeStamp(DateTime.UtcNow);
        public int m_startTime = DateTimeToUnixTimeStamp(DateTime.UtcNow.AddDays(-1));

        public int toUnix = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;


        /// <summary>
        /// Constructeur
        /// </summary>
        public FormHistorique()
        {
            InitializeComponent();

            m_listCapteurs = AccesDB.GetSetCapteurs(); // Update la liste de capteurs via la db

            foreach (Capteur cap in m_listCapteurs) // Affiche les capteurs dans le listbox
            {
                listBoxChoixCapteur.Items.Add(cap.Name);
            }

        }

        /// <summary>
        /// Retourne au form principal si on appuie sur le bouton "Retour"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
        }

        /// <summary>
        /// Évènement de click des boutons offrant des options pour le temps. Cette fonction set les timeStamps
        /// utilisés pour aller chercher les données de la database, lance une demande de données puis génère le
        /// form de graphique avec ces données
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timeframeBtns_Click(object sender, EventArgs e)
        {
            if(sender.Equals(btnLastDay)) // dernier 24h
            {
                m_endTime = DateTimeToUnixTimeStamp(DateTime.UtcNow);
                m_startTime = DateTimeToUnixTimeStamp(DateTime.UtcNow.AddDays(-1));
            }
            else if(sender.Equals(btnLastWeek)) // dernier 7 jours
            {
                m_endTime = DateTimeToUnixTimeStamp(DateTime.UtcNow);
                m_startTime = DateTimeToUnixTimeStamp(DateTime.UtcNow.AddDays(-7));
            }
            else if (sender.Equals(btnLastMonth)) // dernier mois
            {
                m_endTime = DateTimeToUnixTimeStamp(DateTime.UtcNow);
                m_startTime = DateTimeToUnixTimeStamp(DateTime.UtcNow.AddMonths(-1));
            }
            else if (sender.Equals(btnMoreOptions)) // autre, ouvre le form ayant plus de choix
            {
                FormChoixPlageTemps formGetTime = new FormChoixPlageTemps();
                formGetTime.ShowDialog();

                // Si sélection réussie et form fermé via le bouton de confirmation
                if (formGetTime.DialogResult == DialogResult.OK)
                {
                    m_startTime = DateTimeToUnixTimeStamp(formGetTime.startDateTime.ToUniversalTime());
                    m_endTime = DateTimeToUnixTimeStamp(formGetTime.endDateTime.ToUniversalTime());
                }
                // Si sélection échoue / bouton retour utilisé
                else
                {
                    return;
                }
            }

            try
            {
                
                UpdateGraphique(); // Get les données à afficher
                // Essai de charger le graph avec les données
                FormChart test = new FormChart(m_valuesChart, m_unixTimes, m_selectedCapteurs, m_warningAlertLevels, m_startTime, m_endTime); 
                test.Show();
            }
            catch // Si graphique encontre un problème, affiche un message
            {
                MessageBox.Show("Une erreur est survenue lors de l'affichage du graphique");
            }
        }

        /// <summary>
        /// Cette fonction met à jour les données qui doivent êtres affichées dans le graphique.
        /// La fonction commence par clear les anciennes valeurs de graphique. Ensuite, on passe
        /// au travers de la liste de capteur en demandant à la base de données toutes les données
        /// qui sont dans la plage de temps sélectionnée et qui sont liées au capteur / groupe choisis. 
        /// Les données reçues sont ensuites séprarées en deux, la valeur de température et son timeStamp.
        /// </summary>
        private void UpdateGraphique()
        {
            AccesDB accesDB = new AccesDB(); // objet d'accès à la db
            List<MesureTemp> listTemp = new List<MesureTemp>(); // liste tempon pour transferer les données de db à des listes de températures et timestamp 

            m_listCapteurs = AccesDB.GetSetCapteurs(); // update la liste de capteurs

            //clear toutes les anciennes données
            m_valuesChart.Clear();
            m_dateTimes.Clear();
            m_unixTimes.Clear();
            m_selectedCapteurs.Clear();

            // Si aucun capteur sélectionné, prends le premier
            if(listBoxChoixCapteur.SelectedIndex==-1)
            {
                listBoxChoixCapteur.SelectedIndex = 0;
            }

            // Passe au travers la liste de capteurs
            foreach (Capteur cap in m_listCapteurs)
            {
                // Si en mode groupe
                if (btnGroupName.Text == "Capteurs")
                {
                    // regarde si le groupe voulu est le même que le capteur
                    if (cap.GroupCapteur == listBoxChoixCapteur.Items[listBoxChoixCapteur.SelectedIndex].ToString())
                    {
                        m_selectedCapteurs.Add(cap.Name); // Ajoute le nom du capteur à la liste
                        m_warningAlertLevels.alert = cap.AlertHigh; // garde en mémoire ses niveaux
                        m_warningAlertLevels.warning = cap.AlertLow;
                        listTemp.AddRange(accesDB.GetTemperatures(m_startTime, m_endTime, cap.Address)); // Fait la requete pour les temps à la db

                        ChartValues<double> temp = new ChartValues<double>(); // cré des listes temporaires
                        List<DateTime> lstDate = new List<DateTime>();
                        List<int> lstTime = new List<int>();

                        foreach (MesureTemp temperature in listTemp)
                        {
                            temp.Add(temperature.Temperature); // ajoute les températures et les timestamps aux listes temporaires
                            lstDate.Add(UnixTimeStampToDateTime(temperature.UnixTime));
                            lstTime.Add(temperature.UnixTime);
                        }
                        m_valuesChart.Add(temp); // Ajoute les listes temporaires aux series à afficher
                        m_dateTimes.Add(lstDate);
                        m_unixTimes.Add(lstTime);
                    }
                }
                // si mode capteur individuel
                else
                {
                    // regarde si le nom du capteur est le nom de capteur voulu
                    if (cap.Name == listBoxChoixCapteur.Items[listBoxChoixCapteur.SelectedIndex].ToString())
                    {
                        m_selectedCapteurs.Add(cap.Name);   // Ajoute le nom du capteur à la liste
                        m_warningAlertLevels.alert = cap.AlertHigh;  // garde en mémoire ses niveaux
                        m_warningAlertLevels.warning = cap.AlertLow;
                        listTemp.AddRange(accesDB.GetTemperatures(m_startTime, m_endTime, cap.Address)); // Fait la requete pour les temps à la db

                        ChartValues<double> temp = new ChartValues<double>(); // cré des listes temporaires
                        List<DateTime> lstDate = new List<DateTime>();
                        List<int> lstTime = new List<int>();

                        foreach (MesureTemp temperature in listTemp)
                        {
                            temp.Add(temperature.Temperature); // ajoute les températures et les timestamps aux listes temporaires
                            lstDate.Add(UnixTimeStampToDateTime(temperature.UnixTime));
                            lstTime.Add(temperature.UnixTime);
                        }
                        m_valuesChart.Add(temp); // Ajoute les listes temporaires aux series à afficher
                        m_dateTimes.Add(lstDate);
                        m_unixTimes.Add(lstTime);
                    }
                }
                listTemp.Clear(); // Clear la liste contenant les données de la requete sql
            }                
        }

        /// <summary>
        /// Appuyer sur le bouton UP monte la ligne sélectionnée de 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUp_Click(object sender, EventArgs e)
        {
            if (listBoxChoixCapteur.SelectedIndex > 0)
            {
                listBoxChoixCapteur.SelectedIndex -= 1;
            }
        }

        /// <summary>
        /// Appuyer sur le bouton DOWN baisse la ligne sélectionnée de 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDown_Click(object sender, EventArgs e)
        {
            if (listBoxChoixCapteur.SelectedIndex < listBoxChoixCapteur.Items.Count - 1)
            {
                listBoxChoixCapteur.SelectedIndex += 1;
            }
        }

        /// <summary>
        /// Ce bouton permet de changer la sélection de capteur en sélection de groupe et vice-versa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGroupName_Click(object sender, EventArgs e)
        {
            listBoxChoixCapteur.Items.Clear();

            if (btnGroupName.Text == "Groupes") // passe en mode groupe
            {
                btnGroupName.Text = "Capteurs"; // met Noms comme texte dans le bouton
                labelTitre.Text = "Choix du groupe à étudier";
                m_listGroups = AccesDB.GetGroups(); // Update la liste de groupes via de la db

                foreach (String str in m_listGroups) // Affiche les groupes dans le listbox
                {
                    listBoxChoixCapteur.Items.Add(str);
                }
            }
            else // Passe en mode capteur
            {
                btnGroupName.Text = "Groupes";// met Groupes comme texte dans le bouton
                labelTitre.Text = "Choix du capteur à étudier";
                m_listCapteurs = AccesDB.GetSetCapteurs(); // Update la liste de capteurs via la db

                foreach (Capteur cap in m_listCapteurs) // Affiche les capteurs dans le listbox
                {
                    listBoxChoixCapteur.Items.Add(cap.Name);
                }
            }
        }

        /// <summary>
        /// Fonction servant a mettre a jour la liste dans le cas ou les noms ai été modifiés par le form de config
        /// </summary>
        public void reloadList()
        {
            listBoxChoixCapteur.Items.Clear();

            if (btnGroupName.Text == "Groupes") // en mode capteur
            {
                m_listCapteurs = AccesDB.GetSetCapteurs(); // Update la liste de capteurs via la db

                foreach (Capteur cap in m_listCapteurs) // Affiche les capteurs dans le listbox
                {
                    listBoxChoixCapteur.Items.Add(cap.Name);
                }
            }
            else // en mode groupe
            {
                m_listGroups = AccesDB.GetGroups(); // Update la liste de groupes via de la db

                foreach (String str in m_listGroups) // Affiche les groupes dans le listbox
                {
                    listBoxChoixCapteur.Items.Add(str);
                }
            }
        }

        /// <summary>
        /// Cette fonction permet de convertir un timeStamp unix en datetime local
        /// </summary>
        /// <param name="unixTimeStamp"></param>
        /// <returns></returns>
        public static DateTime UnixTimeStampToDateTime(int unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        /// <summary>
        /// Cette fonction permet de convertir un DateTime en temps unix
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns></returns>
        public static int DateTimeToUnixTimeStamp(DateTime datetime)
        {
            int toUnix = (Int32)(datetime.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            return toUnix;
        }
    }

    /// <summary>
    /// Cette classe permet de combiner les deux niveaux d'alertes en un seul objet
    /// </summary>
    public class WarningAlert
    {
        public double warning, alert;
        public WarningAlert(double warningLevel, double alertLevel)
        {
            warning = warningLevel;
            alert = alertLevel;
        }
    }


}
