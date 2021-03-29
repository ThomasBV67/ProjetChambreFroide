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

namespace UI_ChambreFroide_V1
{
    public partial class FormChart : Form
    {

        public FormChart(List<ChartValues<double>> vals)
        {
            InitializeComponent();
       
            foreach(ChartValues<double> values in vals)
            {
                chartTemp.Series.Add(new LineSeries
                {
                    Values = values,
                    PointGeometry = null
                }) ;
            }
            
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
                    avgVals.Add(total / roundedCoefficient);
                    total = 0;
                    count = 0;
                    modifCoefficient = coefficient + reste;
                    roundedCoefficient = Math.Round(modifCoefficient);
                }
            }
            return avgVals;
        }
    }
}
