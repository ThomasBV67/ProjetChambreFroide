using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using LiveCharts.Configurations;
using Brushes = System.Windows.Media.Brushes;
using System.Windows.Media;

/// <summary>
/// Ce form fait l'affichage des données sélectionnées dans FormHistorique sous forme de graphique
/// </summary>
namespace UI_ChambreFroide_V1
{
    public partial class FormChart : Form
    {
        public DateTime m_timeStartGraph;
        private List<double> m_worstTemp = new List<double>();
        private List<int> m_indexWorstTime = new List<int>();

        Label[] tabLabels;

        /// <summary>
        /// Classe utilisée pour lier les données de températures à un DateTime
        /// </summary>
        public class DateModel
        {
            public DateTime DateTime { get; set; }
            public double Value { get; set; }

            public DateModel(DateTime time, double val)
            {
                DateTime = time;
                Value = val;
            }
        }


        /// <summary>
        /// Form contenant le bouton de retour et le graphique
        /// </summary>
        /// <param name="values"></param>
        /// <param name="timeStamps"></param>
        /// <param name="nameSeries"></param>
        public FormChart(List<ChartValues<double>> values, List<List<DateTime>> timeStamps, List<String> nameSeries, WarningAlert warningAlertLevels, DateTime graphTime)
        {
            InitializeComponent();

            m_worstTemp.Clear();
            m_indexWorstTime.Clear();
            // permet d'associer au graphique le format DateModel déclaré plus haut

            var dayConfig = Mappers.Xy<DateModel>()
                .X(dayModel => (double)dayModel.DateTime.Ticks / TimeSpan.FromDays(1).Ticks)
                .Y(dayModel => dayModel.Value);
            Charting.For<DateModel>(dayConfig, SeriesOrientation.Horizontal);

            // ajoute une légende en haut du graphique
            chartTemp.LegendLocation = LegendLocation.Top;
            chartTemp.DefaultLegend.Visibility = System.Windows.Visibility.Visible;

            m_timeStartGraph = graphTime;

            // boucle servant à ajouter les séries de points au graphique
            // passe dans la boucle pour chaque capteur à afficher
            for (int i = 0; i < values.Count; i++)
            {
                // Final
                    
                chartTemp.Series.Add(new LineSeries
                {
                    // on ajuste les données pour obtenir un nombre de points affichables
                    Values = GetDateModels(GetAveragedValues(values[i], 250), GetAverageDateTime(timeStamps[i], 250)),
                    // juste la ligne, pas de points
                    //PointGeometry = DefaultGeometries.Circle,
                    PointGeometry = null,
                    // pas de remplissage
                    Fill = Brushes.Transparent,
                    // ajoute un titre lié au nom du capteur
                    Title = nameSeries[i]
                });
            }

            /*************** Personnalisation des axes *******************/
            // Section de personnalisation de l'axe des Y
            Axis yAxis = new Axis();
            yAxis.Name = "AxisY";
            yAxis.Title = "Température (oC)";
            yAxis.FontSize = 20;
            yAxis.Foreground = Brushes.Black;
            yAxis.Separator.Step = 0.5;
            yAxis.LabelFormatter = val => val + "°C";
            chartTemp.AxisY.Add(yAxis);

            // Section de personnalisation de l'axe des X
            Axis xAxis = new Axis();
            xAxis.Name = "AxisX";
            xAxis.Title = "Temps";
            xAxis.FontSize = 20;
            xAxis.Foreground = Brushes.Black;
            if(m_timeStartGraph >= DateTime.Now.AddDays(-2))
            {
                xAxis.LabelFormatter = value => new DateTime((long)(value * TimeSpan.FromDays(1).Ticks)).ToString("HH:mm");
            }
            else if(m_timeStartGraph <= DateTime.Now.AddDays(-1) && m_timeStartGraph >= DateTime.Now.AddDays(-3))
            {
                xAxis.LabelFormatter = value => new DateTime((long)(value * TimeSpan.FromDays(1).Ticks)).ToString("dd/MM/yy HH:mm");
            }
            else
            {
                xAxis.LabelFormatter = value => new DateTime((long)(value * TimeSpan.FromDays(1).Ticks)).ToString("dd/MM/yy");
            }
            chartTemp.AxisX.Add(xAxis);


            /*********** Section d'ajout des niveaux de warning *****************/
            // Alerte
            AxisSection alertSection = new AxisSection();
            alertSection.Value = warningAlertLevels.alert;
            alertSection.SectionWidth = warningAlertLevels.alert+50;
            alertSection.StrokeThickness = 1;
            SolidColorBrush brushRed = new SolidColorBrush();
            brushRed.Color = Colors.Red;
            alertSection.Fill = brushRed;
            alertSection.Fill.Opacity = 0.2;
            alertSection.Stroke = brushRed;
            alertSection.StrokeThickness = 0;
            chartTemp.AxisY[0].Sections.Add(alertSection);

            // Warning
            AxisSection warningSection = new AxisSection();
            warningSection.Value = warningAlertLevels.warning;
            warningSection.SectionWidth = Math.Abs(warningAlertLevels.alert - warningAlertLevels.warning);
            warningSection.StrokeThickness = 1;
            SolidColorBrush brushYellow = new SolidColorBrush();
            brushYellow.Color = Colors.Yellow;
            warningSection.Fill = brushYellow;
            warningSection.Fill.Opacity = 0.25;
            warningSection.Stroke = brushYellow;
            warningSection.StrokeThickness = 0;
            chartTemp.AxisY[0].Sections.Add(warningSection);

            // Safe
            AxisSection safeSection = new AxisSection();
            safeSection.Value = -50;
            safeSection.SectionWidth = 50 + warningAlertLevels.warning;
            safeSection.StrokeThickness = 1;
            SolidColorBrush brushGreen = new SolidColorBrush();
            brushGreen.Color = Colors.Green;
            safeSection.Fill = brushGreen;
            safeSection.Fill.Opacity = 0.3;
            safeSection.Stroke = brushGreen;
            safeSection.StrokeThickness = 0;
            chartTemp.AxisY[0].Sections.Add(safeSection);

            /************* Section des labels des pires températures ******************/
            tabLabels = new Label[m_worstTemp.Count];
            for(int i =0; i < m_worstTemp.Count; i++)
            {
                tabLabels[i] = new Label();
                tabLabels[i].Text = nameSeries[i] + " : " + m_worstTemp[i].ToString() + "°C @" + Environment.NewLine + timeStamps[i][m_indexWorstTime[i]].ToString("HH:mm:ss dd/MM/yy");
                tabLabels[i].Name = "lbWorst" + i;
                tabLabels[i].Font = new Font("Microsoft Sans Serif", (float)12.25, FontStyle.Regular);
                tabLabels[i].Height = 50;
                tabLabels[i].Width = 150;
                tabLabels[i].Visible = true;
                tabLabels[i].Location = new Point(860, 150 + i * 50);
                Controls.Add(tabLabels[i]);
            }
        }

        /// <summary>
        /// Ferme le form lorsque le bouton est appuyé
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Cette fonction prends en entrée une liste contenant des valeurs double et un nombre. 
        /// La fonction fait des moyennes de valeurs pour retourner un nombre de valeur défini par
        /// le nombre qui lui est donné en entrée. Ces valeurs sont retournées dans un format prêt à
        /// ajouter au graphique
        /// </summary>
        /// <param name="vals"></param>
        /// <param name="numberReturnVals"></param>
        /// <returns></returns>
        private ChartValues<double> GetAveragedValues(ChartValues<double> vals, int numberReturnVals)
        {
            ChartValues<double> avgVals = new ChartValues<double>(); // liste de toutes les valeurs a retourner
            double coefficient = 0, // nombre utilisé pour calculer le nombre de valeurs à prendre en compte pour les moyennes
                total = 0, // variable tempon pour les moyennes
                reste = 0, // variable pour ajuster le coefficient
                count = 0, // compte de combien de valeurs sont déja dans le tempon
                worstTemp = 0, // température la plus haute enregistrée
                modifCoefficient =0, // coefficient modifié par rapport a la variable reste
                roundedCoefficient =0; // coefficient arrondi pour faire les calculs
            int indexWorstTemp = 0; // index de la température la plus élevée

            if (vals.Count <= numberReturnVals)
            {
                for (int i = 0; i < vals.Count; i++)
                {
                    if (vals[i] > worstTemp)
                    {
                        worstTemp = vals[i];
                        indexWorstTemp = i;
                    }
                }
                m_worstTemp.Add(worstTemp);
                m_indexWorstTime.Add(indexWorstTemp);
                return vals;
            }

            coefficient = (double)vals.Count / (double)numberReturnVals; // Calcul du coefficient de base

            modifCoefficient = coefficient + reste; // calcul du coefficient modifié 
            roundedCoefficient = Math.Round(modifCoefficient); // calcul du coefficient arrondi (donc utilisable)
            reste = modifCoefficient - roundedCoefficient; // calcul du reste

            // boucle qui passe au travers de toutes les valeurs données en entrée
            for (int i = 0; i < vals.Count; i++)
            {
                count++;
                if(vals[i] > worstTemp)
                {
                    worstTemp = vals[i];
                    indexWorstTemp = i;
                }
                // si nombre de valeurs pour la moyenne pas atteint
                if (count < roundedCoefficient)
                {
                    total += vals[i];
                }
                else // si assez de valeurs en tempon, calcule la moyenne et recalcule tous les coefficients
                {
                    avgVals.Add(Math.Round(total / roundedCoefficient,2));
                    total = 0;
                    count = 0;
                    modifCoefficient = coefficient + reste;
                    roundedCoefficient = Math.Round(modifCoefficient);
                }
            }
            m_worstTemp.Add(worstTemp);
            m_indexWorstTime.Add(indexWorstTemp);
            return avgVals; // retourne la liste moyennée
        }

        /// <summary>
        /// Cette fonction prends en entrée une liste contenant des valeurs de temps et un nombre. 
        /// La fonction fait des moyennes de valeurs pour retourner un nombre de valeur défini par
        /// le nombre qui lui est donné en entrée. Ces valeurs sont retournées dans un format prêt à
        /// ajouter au graphique
        /// </summary>
        /// <param name="times"></param>
        /// <param name="numberReturnVals"></param>
        /// <returns></returns>
        private List<DateTime> GetAverageDateTime(List<DateTime> times, int numberReturnVals)
        {
            List<DateTime> avgTimes = new List<DateTime>(); // liste de toutes les valeurs à retourner
            decimal coefficient = 0, // nombre utilisé pour calculer le nombre de valeurs à prendre en compte pour les moyennes
                
                reste = 0, // variable pour ajuster le coefficient
                count = 0, // compte de combien de valeurs sont déja dans le tempon
                modifCoefficient = 0, // coefficient modifié par rapport a la variable reste
                roundedCoefficient = 0; // coefficient arrondi pour faire les calculs
            decimal total = 0; // variable tempon pour les moyennes

            if(times.Count <= numberReturnVals)
            {
                return times;
            }

            coefficient = (decimal)times.Count / (decimal)numberReturnVals;

            modifCoefficient = coefficient + reste; // calcul du coefficient modifié 
            roundedCoefficient = Math.Round(modifCoefficient); // calcul du coefficient arrondi (donc utilisable)
            reste = modifCoefficient - roundedCoefficient; // calcul du reste

            // boucle qui passe au travers de toutes les valeurs données en entrée
            for (int i = 0; i < times.Count; i++)
            {
                count++;
                // si nombre de valeurs pour la moyenne pas atteint
                if (count < roundedCoefficient)
                {
                    //total += times[i].Ticks / roundedCoefficient;
                }
                else // si assez de valeurs en tempon, calcule la moyenne et recalcule tous les coefficients
                {
                    total = Math.Round(total);
                    avgTimes.Add(times[i - (int)roundedCoefficient/2]);
                    total = 0;
                    count = 0;
                    modifCoefficient = coefficient + reste;
                    roundedCoefficient = Math.Round(modifCoefficient);
                }
            }
            return avgTimes;// retourne la liste moyennée
        }

        /// <summary>
        /// Fonction qui crée et retourne une liste de valeurs de graphique dans le format : double en y et DateTime en x
        /// Cette liste prends les valeurs de deux listes de ces types données en entrée
        /// </summary>
        /// <param name="vals"></param>
        /// <param name="times"></param>
        /// <returns></returns>
        private ChartValues<DateModel> GetDateModels(ChartValues<double> vals, List<DateTime> times)
        {
            ChartValues<DateModel> dateModels = new ChartValues<DateModel>(); // création de la liste
            //ajout des valeurs dans la liste
            for(int i = 0; i < vals.Count; i++)
            {
                try
                {
                    dateModels.Add(new DateModel(times[i], vals[i]));
                }
                catch
                {

                }
                
            }
            return dateModels;
        }
    }
}
