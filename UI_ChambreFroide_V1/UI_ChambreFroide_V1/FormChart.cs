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
<<<<<<< Updated upstream
                chartTemp.Series.Add(new LineSeries
                {
                    Values = values,
                    PointGeometry = null
                }) ;
            }
            
=======
                Values = val,
                PointGeometry = null,
                
            }) ;
>>>>>>> Stashed changes
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
