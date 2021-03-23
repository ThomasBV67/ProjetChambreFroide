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

        public List<Capteur> listCapteurs = new List<Capteur>();
        public ChartValues<double> valuesChart = new ChartValues<double>();

        private int divFactor = 0;
        public enum timeFrameChoice {Day, Week, Month, Other};
        public timeFrameChoice timeFrame = timeFrameChoice.Day;

        FormChoixCapteur objFormChoixCapteur = new FormChoixCapteur();

        DateTime endTime = DateTime.Now;
        DateTime startTime = DateTime.Now.AddDays(-1);
        

        public FormHistorique()
        {
            InitializeComponent();

            objFormChoixCapteur.Hide();
/*
            chartTemp.Series.Add(new LineSeries
            {
                Values = new ChartValues<double> { 3, 4, 6, 3, 2, 6 },
                StrokeThickness = 4,
                StrokeDashArray = new System.Windows.Media.DoubleCollection(20),
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(107, 185, 69)),
                Fill = System.Windows.Media.Brushes.Transparent,
                LineSmoothness = 0,
                PointGeometry = null
            });*/
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

            FormChart test = new FormChart(valuesChart);
            test.Show();
        }

        private void UpdateGraphique()
        {
            AccesDB accesDB = new AccesDB();
            List<String> listTime = new List<String>();
            List<MesureTemp> listTemp = new List<MesureTemp>();

            listCapteurs = AccesDB.GetSetCapteurs();

            valuesChart.Clear();
            //divFactor = 0;

            foreach(Capteur cap in listCapteurs)
            {
                
                if (objFormChoixCapteur.isGroup)
                {
                    if (cap.GroupCapteur == objFormChoixCapteur.returnName)
                    {
                        listTemp.AddRange(accesDB.GetTemperatures(endTime, startTime, cap.Address));
                        foreach (MesureTemp temp in listTemp)
                        {
                            valuesChart.Add(temp.Temperature);
                            listTime.Add(temp.TimeStamp);
                        }
                       
                    }
                }
                else
                {
                    if (cap.Name == objFormChoixCapteur.returnName)
                    {
                        listTemp.AddRange(accesDB.GetTemperatures(startTime, endTime, cap.Address));
                        foreach (MesureTemp temp in listTemp)
                        {
                            //if(divFactor >= 10)
                            //{
                                valuesChart.Add(temp.Temperature);
                                listTime.Add(temp.TimeStamp);
                                divFactor = 0;
                            //}
                            
                            //divFactor++;
                        }
                     
                    }
                }
                listTemp.Clear();
               
            }                
        }
    }
}
