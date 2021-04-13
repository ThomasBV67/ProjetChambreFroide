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
    /// Ce form permet d'accéder à un historique de températures lié à un capteur ou un groupe de capteurs.
    /// La sélection se fait via le bouton Sélection du capteur.
    /// </summary>
    public partial class FormHistorique : Form
    {
        public List<Capteur> m_listCapteurs = new List<Capteur>(); // liste des capteurs dans la db
        public List<String> m_listGroups = new List<String>();  // liste des groupes dans la db
        public List<ChartValues<double>> m_valuesChart = new List<ChartValues<double>>();   // liste de listes contenant des valeurs double de température
        public List<string> m_selectedCapteurs = new List<string>();    // liste des noms de capteurs sélectionnés
        public List<List<DateTime>> m_dateTimes = new List<List<DateTime>>(); //liste de listes de timestamp
        public WarningAlert m_warningAlertLevels = new WarningAlert(0,0);
        public timeFrame m_timeFrame = timeFrame.LastDay;

        // variables tempon pour les time stamps limite du graphique
        public DateTime m_endTime = DateTime.Now;
        public DateTime m_startTime = DateTime.Now.AddDays(-1);

        
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
        /// Retourn au form précédent
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
                m_endTime = DateTime.Now;
                m_startTime = DateTime.Now.AddDays(-1);
            }
            else if(sender.Equals(btnLastWeek)) // dernier 7 jours
            {
                m_endTime = DateTime.Now;
                m_startTime = DateTime.Now.AddDays(-7);
            }
            else if (sender.Equals(btnLastMonth)) // dernier mois
            {
                m_endTime = DateTime.Now;
                m_startTime = DateTime.Now.AddMonths(-1);
            }
            else if (sender.Equals(btnMoreOptions)) // autre, ouvre le form ayant plus de choix
            {
                m_endTime = DateTime.Now;
                m_startTime = DateTime.Now.AddDays(-1);
            }

            //try
            //{
                UpdateGraphique();
                FormChart test = new FormChart(m_valuesChart, m_dateTimes, m_selectedCapteurs, m_warningAlertLevels, m_startTime);
                test.Show();
            //}
            //catch
            //{
              //  MessageBox.Show("Veuillez sélectionner un capteur.");
            //}
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateGraphique()
        {
            AccesDB accesDB = new AccesDB();
            List<List<DateTime>> listTime = new List<List<DateTime>>();
            List<MesureTemp> listTemp = new List<MesureTemp>();

            m_listCapteurs = AccesDB.GetSetCapteurs();

            m_valuesChart.Clear();
            m_selectedCapteurs.Clear();
            m_dateTimes.Clear();

            foreach (Capteur cap in m_listCapteurs)
            {
                if (btnGroupName.Text == "Capteurs")
                {
                    if (cap.GroupCapteur == listBoxChoixCapteur.Items[listBoxChoixCapteur.SelectedIndex].ToString())
                    {
                        m_selectedCapteurs.Add(cap.Name);
                        m_warningAlertLevels.alert = cap.AlertHigh;
                        m_warningAlertLevels.warning = cap.AlertLow;
                        listTemp.AddRange(accesDB.GetTemperatures(m_startTime, m_endTime, cap.Address));
                        ChartValues<double> temp = new ChartValues<double>();
                        List<DateTime> lstDate = new List<DateTime>();
                        foreach (MesureTemp temperature in listTemp)
                        {
                            temp.Add(temperature.Temperature);
                            lstDate.Add(Convert.ToDateTime(temperature.TimeStamp));
                        }
                        m_valuesChart.Add(temp);
                        m_dateTimes.Add(lstDate);
                    }
                }
                else
                {
                    if (cap.Name == listBoxChoixCapteur.Items[listBoxChoixCapteur.SelectedIndex].ToString())
                    {
                        m_selectedCapteurs.Add(cap.Name);
                        m_warningAlertLevels.alert = cap.AlertHigh;
                        m_warningAlertLevels.warning = cap.AlertLow;
                        listTemp.AddRange(accesDB.GetTemperatures(m_startTime, m_endTime, cap.Address));
                        ChartValues<double> temp = new ChartValues<double>();
                        List<DateTime> lstDate = new List<DateTime>();
                        foreach (MesureTemp temperature in listTemp)
                        {
                            temp.Add(temperature.Temperature);
                            lstDate.Add(Convert.ToDateTime(temperature.TimeStamp));
                        }
                        m_valuesChart.Add(temp);
                        m_dateTimes.Add(lstDate);
                    }
                }
                listTemp.Clear();
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
    }
    public class WarningAlert
    {
        public double warning, alert;
        public WarningAlert(double warningLevel, double alertLevel)
        {
            warning = warningLevel;
            alert = alertLevel;
        }
    }
    public enum timeFrame
    {
        LastDay, LastWeek, LastMonth, Other
    };
}
