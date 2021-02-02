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
    public partial class FormTempCourantes : Form
    {
     //   GroupBox[] m_pannauxPrincipaux = new GroupBox[];

        public FormTempCourantes()
        {
            InitializeComponent();
        }

        private void FormTempCourantes_Load(object sender, EventArgs e)
        {
            Control ctrlSuivant;
        }

        private void b_historique_Click(object sender, EventArgs e)
        {
            var frm = new FormHistorique();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }
    }
}
