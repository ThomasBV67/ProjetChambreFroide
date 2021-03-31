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
        public String selectedName; // variables ayant une valeur donnée par le form de choix de capteur
        public bool selectedIsGroup;

        public List<Capteur> m_listCapteurs = new List<Capteur>();
        public List<String> m_listGroups = new List<String>();
        public List<ChartValues<double>> m_valuesChart = new List<ChartValues<double>>();
        public List<string> m_selectedCapteurs = new List<string>();
        public List<List<DateTime>> m_dateTimes = new List<List<DateTime>>();


        private int divFactor = 0;
        public enum timeFrameChoice {Day, Week, Month, Other};
        public timeFrameChoice timeFrame = timeFrameChoice.Day;

        DateTime endTime = DateTime.Now;
        DateTime startTime = DateTime.Now.AddDays(-1);
        

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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timeframeBtns_Click(object sender, EventArgs e)
        {
            if(sender.Equals(btnLastDay))
            {
                timeFrame = timeFrameChoice.Day;
                endTime = DateTime.Now;
                startTime = DateTime.Now.AddDays(-1);
                
            }
            else if(sender.Equals(btnLastWeek))
            {
                timeFrame = timeFrameChoice.Week;
                endTime = DateTime.Now;
                startTime = DateTime.Now.AddDays(-7);
            }
            else if (sender.Equals(btnLastMonth))
            {
                timeFrame = timeFrameChoice.Month;
                endTime = DateTime.Now;
                startTime = DateTime.Now.AddMonths(-1);
            }
            else if (sender.Equals(btnMoreOptions))
            {
                timeFrame = timeFrameChoice.Other;
                endTime = DateTime.Now;
                startTime = DateTime.Now.AddDays(-1);
            }
            UpdateGraphique();

            FormChart test = new FormChart(m_valuesChart, m_dateTimes, m_selectedCapteurs);
            test.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        private void UpdateGraphique()
        {
            AccesDB accesDB = new AccesDB();
            List<DateTime> listTime = new List<DateTime>();
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
                        listTemp.AddRange(accesDB.GetTemperatures(startTime, endTime, cap.Address));
                        ChartValues<double> temp = new ChartValues<double>();
                        foreach (MesureTemp temperature in listTemp)
                        {
                            temp.Add(temperature.Temperature);
                            listTime.Add(Convert.ToDateTime(temperature.TimeStamp));
                        }
                        m_valuesChart.Add(temp);
                        m_dateTimes.Add(listTime);
                    }
                }
                else
                {
                    if (cap.Name == listBoxChoixCapteur.Items[listBoxChoixCapteur.SelectedIndex].ToString())
                    {
                        m_selectedCapteurs.Add(cap.Name);
                        listTemp.AddRange(accesDB.GetTemperatures(startTime, endTime, cap.Address));
                        ChartValues<double> temp = new ChartValues<double>();
                        foreach (MesureTemp temperature in listTemp)
                        {
                            temp.Add(temperature.Temperature);
                            listTime.Add(Convert.ToDateTime(temperature.TimeStamp));
                        }
                        m_valuesChart.Add(temp);
                        m_dateTimes.Add(listTime);
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
    }
}
