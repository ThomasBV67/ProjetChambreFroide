using LiveCharts;
using LiveCharts.Defaults;
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

        public List<Capteur> listCapteurs = new List<Capteur>();
        public List<MesureTemp> listTemp = new List<MesureTemp>();
        
        public enum timeFrameChoice {Day, Week, Month, Other};
        public timeFrameChoice timeFrame = timeFrameChoice.Day;

        FormChoixCapteur objFormChoixCapteur = new FormChoixCapteur();

        DateTime endTime = DateTime.Now;
        DateTime startTime = DateTime.Now.AddDays(-1);
        

        public FormHistorique()
        {
            InitializeComponent();

            objFormChoixCapteur.Hide();

            chartTemp.Series.Clear();
        }

        /// <summary>
        /// Appuyer sur le bouton de choix de capteur ouvre le form de choix de capteur. Lorque le form
        /// se ferme avec le bouton select, on reçoit le capteur ou groupe qui à été selectionné.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectCapteur_Click(object sender, EventArgs e)
        {
            objFormChoixCapteur.Show();
            if(objFormChoixCapteur.DialogResult == DialogResult.OK)
            {
                selectedName = objFormChoixCapteur.returnName;
                selectedIsGroup = objFormChoixCapteur.isGroup;
            }
            objFormChoixCapteur.DialogResult = DialogResult.None;
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
        }

        private void UpdateGraphique()
        {
            AccesDB accesDB = new AccesDB();
            List<String> listTime = new List<String>();
            ChartValues<double> valuesChart = new ChartValues<double>();

            listCapteurs = AccesDB.GetSetCapteurs();
            listTemp.Clear();

            if (objFormChoixCapteur.isGroup)
            {
                foreach(Capteur cap in listCapteurs)
                {
                    valuesChart.Clear();
                    if (cap.GroupCapteur == objFormChoixCapteur.returnName)
                    {
                        listTemp.AddRange(accesDB.GetTemperatures(endTime, startTime, cap.Address));
                    }

                    

                    foreach (MesureTemp temp in listTemp)
                    {
                        valuesChart.Add(temp.Temperature);
                        listTime.Add(temp.TimeStamp);
                    }

                    createLineSeries(valuesChart, cap.Name);
                }                
            }
            else
            {
                foreach (Capteur cap in listCapteurs)
                {
                    valuesChart.Clear();
                    if (cap.Name == objFormChoixCapteur.returnName)
                    {
                        listTemp.AddRange(accesDB.GetTemperatures(startTime, endTime, cap.Address));
                    }

                    foreach(MesureTemp temp in listTemp)
                    {
                        valuesChart.Add(temp.Temperature);
                        listTime.Add(temp.TimeStamp);
                    }
                    createLineSeries(valuesChart, cap.Name);
                }
            }          
        }
        void createLineSeries(ChartValues<double> values, String name)
        {
            LineSeries series = new LineSeries
            {
                Title = name,
                Fill = System.Windows.Media.Brushes.Transparent,
                Values = values
            };
            chartTemp.Series.Add(series);
        }

    }
}
