using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_ChambreFroide_V1
{
    public partial class FormZoneTexte : Form
    {
        public FormZoneTexte()
        {
            InitializeComponent();
        }

        private void FormZoneTexte_Load(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"c:\Temp\OSK.exe");
            }
            catch (Exception error)
            {
                string err = error.ToString();
            }
        }
    }
}
