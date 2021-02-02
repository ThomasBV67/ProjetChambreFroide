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
            FormHistorique objFormHistorique = new FormHistorique();
            objFormHistorique.Show();
        }
    }
}
