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
    public partial class FormModifCapteur : Form
    {
        public String m_name, m_group;
        public double m_warning, m_alert;

        public FormModifCapteur()
        {
            lbNom.Text = "Nom : " + m_name;
            lbGroupe.Text = "Groupe : " + m_group;
            lbWarning.Text = "Niveau d'avertissement : " + m_warning.ToString() + "oC";
            lbAlerte.Text = "Niveau d'alerte : " + m_alert.ToString() + "oC";

            InitializeComponent();
        }

        private void btnModifGroupe_Click(object sender, EventArgs e)
        {

        }
    }
}
