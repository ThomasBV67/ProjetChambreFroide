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
    public partial class FormHistorique : Form
    {
        public FormTempCourantes objFormTempCourantes;
        public FormHistorique()
        {
            InitializeComponent();
        }

        private void btnSelectCapteur_Click(object sender, EventArgs e)
        {
            FormChoixCapteur objFormChoixCapteur = new FormChoixCapteur();
            objFormChoixCapteur.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
