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

        public FormChart(List<ChartValues<double>> values, List<List<DateTime>> timeStamps, List<String> nameSeries)
        {
            InitializeComponent();

            var dayConfig = Mappers.Xy<DateModel>()
                .X(dayModel => (double)dayModel.DateTime.Ticks / TimeSpan.FromHours(1).Ticks)
                .Y(dayModel => dayModel.Value);

            chartTemp.LegendLocation = LegendLocation.Top;
            chartTemp.DefaultLegend.Visibility = System.Windows.Visibility.Visible;

            //int i = 0;
            
            for(int i = 0; i < values.Count; i++)
            {
                for (int j = 0; j < values[i].Count; j++)
                {
                    chartTemp.Series.Add(new LineSeries
                    {
                        Values = GetDateModels(GetAveragedValues(values[i], 250), GetAverageDateTime(timeStamps[i], 250)),
                        PointGeometry = null,
                        Fill = Brushes.Transparent,
                        Title = nameSeries[i]
                    });
                }
            }
            chartTemp.AxisX.Add(new Axis
            {
                LabelFormatter = value => new System.DateTime((long)(value * TimeSpan.FromHours(1).Ticks)).ToString("t")
            });
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private ChartValues<double> GetAveragedValues(ChartValues<double> vals, int numberReturnVals)
        {
            ChartValues<double> avgVals = new ChartValues<double>();
            double coefficient = 0, total = 0, reste = 0, count = 0, modifCoefficient =0, roundedCoefficient =0; 

            coefficient = (double)vals.Count / (double)numberReturnVals;

            modifCoefficient = coefficient + reste;
            roundedCoefficient = Math.Round(modifCoefficient);
            reste = modifCoefficient - roundedCoefficient;

            for (int i = 0; i < vals.Count; i++)
            {
                count++;
                if (count < roundedCoefficient)
                {
                    total += vals[i];
                }
                else
                {
                    avgVals.Add(Math.Round(total / roundedCoefficient,2));
                    total = 0;
                    count = 0;
                    modifCoefficient = coefficient + reste;
                    roundedCoefficient = Math.Round(modifCoefficient);
                }
            }
            return avgVals;
        }
        
        private List<DateTime> GetAverageDateTime(List<DateTime> times, int numberReturnVals)
        {
            List<DateTime> avgTimes = new List<DateTime>();
            double coefficient = 0, total = 0D, reste = 0, count = 0, modifCoefficient = 0, roundedCoefficient = 0;

            coefficient = (double)times.Count / (double)numberReturnVals;

            modifCoefficient = coefficient + reste;
            roundedCoefficient = Math.Round(modifCoefficient);
            reste = modifCoefficient - roundedCoefficient;

            for (int i = 0; i < times.Count; i++)
            {
                count++;
                if (count < roundedCoefficient)
                {
                    total += times[i].Ticks / roundedCoefficient;
                }
                else
                {
                    avgTimes.Add(new DateTime((long)total));
                    total = 0D;
                    count = 0;
                    modifCoefficient = coefficient + reste;
                    roundedCoefficient = Math.Round(modifCoefficient);
                }
            }
            return avgTimes;
        }
        private ChartValues<DateModel> GetDateModels(ChartValues<double> vals, List<DateTime> times)
        {
            ChartValues<DateModel> dateModels = new ChartValues<DateModel>();
            for(int i = 0; i < vals.Count; i++)
            {
                dateModels.Add(new DateModel(times[i], vals[i]));
            }

            return dateModels;
        }
    }
}
