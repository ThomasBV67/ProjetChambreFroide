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
/// Ce form fait automatiquement l'affichage des données sélectionnées dans FormHistorique sous forme de graphique.
/// Le graphique charge automatiquement lors de la création du form. Une légende est présente dans le haut du graphique
/// pour savoir quelle ligne représente quel capteur lorsqu'un groupe est observé. Les zones d'avertissement et d'alertes 
/// sont affichées en arrière plan. Le fond vert est la zone acceptable, la jaune la zone d'avertissement et la rouge la
/// zone d'alerte. Sur la droite, on peut voir la pire température enregistrée pour chaque capteur lors de la plage de temps.
/// Le bouton retour retourne, bien évidement, au form d'avant.
/// </summary>
namespace UI_ChambreFroide_V1
{
    public partial class FormChart : Form
    {
        private List<double> m_worstTemp = new List<double>();  // Listes contenant les températures les plus hautes 
        private List<double> m_bestTemp = new List<double>();   // et les plus basses de chaque capteur

        private List<int> m_worstTime = new List<int>();   // Timestamps lié aux valeurs les plus hautes et plus basses
        private List<int> m_bestTime = new List<int>();    

        private double m_maxTemp = 0;   // Variables contenant la température la plus 
        private double m_minTemp = 0;   // haute et plus basse à afficher sur le graphique

        Label[] tabLabels;  // tableau de label pour afficher dynamiquement les labels de pires temp

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
        /// Constructeur du form contenant le graphique
        /// </summary>
        /// <param name="values"></param>
        /// <param name="timeStamps"></param>
        /// <param name="nameSeries"></param>
        public FormChart(List<ChartValues<double>> values, List<List<int>> timeStamps, List<String> nameSeries, WarningAlert warningAlertLevels, int graphStart, int graphEnd)
        {
            InitializeComponent();

            m_worstTemp.Clear();
            m_worstTime.Clear();
            // permet d'associer au graphique le format DateModel déclaré plus haut

            var dayConfig = Mappers.Xy<DateModel>()
                .X(dayModel => (double)dayModel.DateTime.Ticks / TimeSpan.FromDays(1).Ticks)
                .Y(dayModel => dayModel.Value);
            Charting.For<DateModel>(dayConfig, SeriesOrientation.Horizontal);

            // ajoute une légende en haut du graphique
            chartTemp.LegendLocation = LegendLocation.Top;
            chartTemp.DefaultLegend.Visibility = System.Windows.Visibility.Visible;

            // boucle servant à ajouter les séries de points au graphique
            // passe dans la boucle pour chaque capteur à afficher
            for (int i = 0; i < values.Count; i++)
            {
                // Final
                    
                chartTemp.Series.Add(new LineSeries
                {
                    // on ajuste les données pour obtenir un nombre de points affichables
                    Values = GetDateModels2(values[i], timeStamps[i], 1000 / nameSeries.Count),
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

            m_maxTemp = m_worstTemp[0];
            foreach(double d in m_worstTemp)
            {
                if(d > m_maxTemp)
                {
                    m_maxTemp = d;
                }
            }
            m_minTemp = m_bestTemp[0];
            foreach (double d in m_bestTemp)
            {
                if (d < m_minTemp)
                {
                    m_minTemp = d;
                }
            }

            if ((m_maxTemp - m_minTemp) <= 5)
            {
                yAxis.Separator.Step = 0.5;
            }
            else if ((m_maxTemp - m_minTemp) > 5 && ((m_maxTemp - m_minTemp) <= 10))
            {
                yAxis.Separator.Step = 1;
            }
            else if ((m_maxTemp - m_minTemp) > 10 && ((m_maxTemp - m_minTemp) <= 20))
            {
                yAxis.Separator.Step = 2;
            }
            else
            {
                yAxis.Separator.Step = 5;
            }
            yAxis.LabelFormatter = val => val + "°C";
            chartTemp.AxisY.Add(yAxis);

            // Section de personnalisation de l'axe des X
            Axis xAxis = new Axis();
            xAxis.Name = "AxisX";
            xAxis.Title = "Temps";
            xAxis.FontSize = 20;
            xAxis.Foreground = Brushes.Black;
            if(FormHistorique.UnixTimeStampToDateTime(graphStart) >= FormHistorique.UnixTimeStampToDateTime(graphEnd).AddDays(-1))
            {
                xAxis.LabelFormatter = value => new DateTime((long)(value * TimeSpan.FromDays(1).Ticks)).ToString("HH:mm");
            }
            else if (FormHistorique.UnixTimeStampToDateTime(graphStart) <= FormHistorique.UnixTimeStampToDateTime(graphEnd).AddDays(-1) 
                && FormHistorique.UnixTimeStampToDateTime(graphStart) >= FormHistorique.UnixTimeStampToDateTime(graphEnd).AddDays(-3))
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
                tabLabels[i].Text = nameSeries[i] + " : " + m_worstTemp[i].ToString() + "°C @" + Environment.NewLine + 
                    FormHistorique.UnixTimeStampToDateTime(m_worstTime[i]).ToString("HH:mm:ss dd/MM/yy");
                tabLabels[i].Name = "lbWorst" + i;
                tabLabels[i].Font = new Font("Microsoft Sans Serif", (float)11.25, FontStyle.Regular);
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
        /// Cette fonction prends en entrée une liste contenant des valeurs double, une liste de temps Unix et un nombre. 
        /// La fonction ignore les valeurs répétées pour réduire la quantité de valeurs inutiles et fait des moyennes de 
        /// valeurs et des temps Unix si il y en a plus que la valeur entrée en paramêtre. Après ces filtres, la fonction
        /// retourne une liste d'objets contenant les valeurs et les timestamps associés, prêts à êtres affichés par le
        /// graphique. 
        /// </summary>
        /// <param name="vals"></param>
        /// <param name="times"></param>
        /// <param name="numberReturnVals"></param>
        /// <returns></returns>
        ChartValues<DateModel> GetDateModels2(ChartValues<double> vals, List<int> times, int numberReturnVals)
        {
            ChartValues<double> avgVals = new ChartValues<double>(); // liste de toutes les valeurs a retourner
            List<int> avgTimes = new List<int>();
            ChartValues<DateModel> dataGraph = new ChartValues<DateModel>();


            double coefficient = 0, // nombre utilisé pour calculer le nombre de valeurs à prendre en compte pour les moyennes
                totalVals = 0, // variable tempon pour les moyennes
                totalTimes = 0,
                reste = 0, // variable pour ajuster le coefficient
                count = 0, // compte de combien de valeurs sont déja dans le tempon
                worstTemp = 0, // température la plus haute enregistrée
                bestTemp = 50,
                modifCoefficient = 0, // coefficient modifié par rapport a la variable reste
                roundedCoefficient = 0; // coefficient arrondi pour faire les calculs
            int indexWorstTemp = 0, // index de la température la plus élevée
                indexBestTemp = 0;

            avgVals.Add(vals[0]);
            avgTimes.Add(times[0]);

            for (int i = 1; i < vals.Count; i++)
            {
                if (vals[i] != vals[i - 1])
                {
                    avgVals.Add(vals[i]);
                    avgTimes.Add(times[i]);

                    if (vals[i] > worstTemp)
                    {
                        worstTemp = vals[i];
                        indexWorstTemp = times[i];
                    }
                    else if( vals[i] < bestTemp)
                    {
                        bestTemp = vals[i];
                        indexBestTemp = times[i];
                    }
                }
            }

            if (avgVals.Count < numberReturnVals)
            {
                for (int i = 0; i < avgVals.Count; i++)
                {
                    dataGraph.Add(new DateModel(FormHistorique.UnixTimeStampToDateTime(avgTimes[i]), avgVals[i]));
                }
                m_worstTemp.Add(worstTemp);
                m_bestTemp.Add(bestTemp);
                m_worstTime.Add(indexWorstTemp);
                m_bestTime.Add(indexBestTemp);
                return dataGraph;
            }

            coefficient = (double)vals.Count / (double)numberReturnVals; // Calcul du coefficient de base
            modifCoefficient = coefficient + reste; // calcul du coefficient modifié 
            roundedCoefficient = Math.Round(modifCoefficient); // calcul du coefficient arrondi (donc utilisable)
            reste = modifCoefficient - roundedCoefficient; // calcul du reste

            
            // boucle qui passe au travers de toutes les valeurs données en entrée
            for (int i = 0; i < avgVals.Count; i++)
            {
                count++;
                
                // si nombre de valeurs pour la moyenne pas atteint
                if (count <= roundedCoefficient)
                {
                    totalVals += avgVals[i];
                    totalTimes += avgTimes[i];
                }
                else // si assez de valeurs en tempon, calcule la moyenne et recalcule tous les coefficients
                {
                    dataGraph.Add(new DateModel(FormHistorique.UnixTimeStampToDateTime((int)(totalTimes / roundedCoefficient)), Math.Round(totalVals / roundedCoefficient, 2)));
                    totalVals = 0;
                    totalTimes = 0;
                    count = 0;
                    modifCoefficient = coefficient + reste;
                    roundedCoefficient = Math.Round(modifCoefficient);
                }
            }

            m_worstTemp.Add(worstTemp);
            m_bestTemp.Add(bestTemp);
            m_worstTime.Add(indexWorstTemp);
            m_bestTime.Add(indexBestTemp);

            return dataGraph; // retourne la liste moyennée
        }
    }
}
