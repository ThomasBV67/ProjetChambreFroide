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

/// <summary>
/// Ce form fait l'affichage des données sélectionnées dans FormHistorique sous forme de graphique
/// </summary>
namespace UI_ChambreFroide_V1
{
    public partial class FormChart : Form
    {
        /// <summary>
        /// Classe utilisée pour lier les données de températures à un DateTime
        /// </summary>
        public class DateModel
        {
            public System.DateTime DateTime { get; set; }
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
        public FormChart(List<ChartValues<double>> values, List<List<DateTime>> timeStamps, List<String> nameSeries)
        {
            InitializeComponent();

            // permet d'associer au graphique le format DateModel déclaré plus haut
            var dayConfig = Mappers.Xy<DateModel>()
                .X(dayModel => (double)dayModel.DateTime.Ticks / TimeSpan.FromHours(1).Ticks)
                .Y(dayModel => dayModel.Value);

            // ajoute une légende en haut du graphique
            chartTemp.LegendLocation = LegendLocation.Top;
            chartTemp.DefaultLegend.Visibility = System.Windows.Visibility.Visible;

            // boucle servant à ajouter les séries de points au graphique
            // passe dans la boucle pour chaque capteur à afficher
            for(int i = 0; i < values.Count; i++)
            {
                for (int j = 0; j < values[i].Count; j++)
                {
                    chartTemp.Series.Add(new LineSeries
                    {
                        // on ajuste les données pour obtenir un nombre de points affichables
                        Values = GetDateModels(GetAveragedValues(values[i], 250), GetAverageDateTime(timeStamps[i], 250)),
                        // juste la ligne, pas de points
                        PointGeometry = null,
                        // pas de remplissage
                        Fill = Brushes.Transparent,
                        // ajoute un titre lié au nom du capteur
                        Title = nameSeries[i]
                    });
                }
            }
            // on associe l'axe des x du graphique a un format de temps
            chartTemp.AxisX.Add(new Axis
            {
                LabelFormatter = value => new System.DateTime((long)(value * TimeSpan.FromHours(1).Ticks)).ToString("t")
            });
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
                modifCoefficient =0, // coefficient modifié par rapport a la variable reste
                roundedCoefficient =0; // coefficient arrondi pour faire les calculs

            coefficient = (double)vals.Count / (double)numberReturnVals; // Calcul du coefficient de base

            modifCoefficient = coefficient + reste; // calcul du coefficient modifié 
            roundedCoefficient = Math.Round(modifCoefficient); // calcul du coefficient arrondi (donc utilisable)
            reste = modifCoefficient - roundedCoefficient; // calcul du reste

            // boucle qui passe au travers de toutes les valeurs données en entrée
            for (int i = 0; i < vals.Count; i++)
            {
                count++;
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
            double coefficient = 0, // nombre utilisé pour calculer le nombre de valeurs à prendre en compte pour les moyennes
                total = 0, // variable tempon pour les moyennes
                reste = 0, // variable pour ajuster le coefficient
                count = 0, // compte de combien de valeurs sont déja dans le tempon
                modifCoefficient = 0, // coefficient modifié par rapport a la variable reste
                roundedCoefficient = 0; // coefficient arrondi pour faire les calculs

            coefficient = (double)times.Count / (double)numberReturnVals;

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
                    total += times[i].Ticks / roundedCoefficient;
                }
                else // si assez de valeurs en tempon, calcule la moyenne et recalcule tous les coefficients
                {
                    avgTimes.Add(new DateTime((long)total));
                    total = 0D;
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
                dateModels.Add(new DateModel(times[i], vals[i]));
            }

            return dateModels;
        }
    }
}
