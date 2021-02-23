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
        public String m_name = "", m_group = "";
        public double m_warning = 0.0, m_alert = 0.0;
        public enum properties { name, group, warning, alert };
        FormZoneTexte objFormZoneTexte = new FormZoneTexte();

        public FormModifCapteur()
        {
            InitializeComponent();

            objFormZoneTexte.Hide();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void FormModifCapteur_Load(object sender, EventArgs e)
        {
            lbNom.Text = "Nom : " + m_name;
            lbGroupe.Text = "Groupe : " + m_group;
            lbWarning.Text = "Niveau d'avertissement : " + m_warning.ToString() + "oC";
            lbAlerte.Text = "Niveau d'alerte : " + m_alert.ToString() + "oC";
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnModifWarning_Click(object sender, EventArgs e)
        {
            objFormZoneTexte.currentProp = (FormZoneTexte.properties)properties.warning;
            objFormZoneTexte.Show();
        }
        private void btnModifAlerte_Click(object sender, EventArgs e)
        {
            objFormZoneTexte.currentProp = (FormZoneTexte.properties)properties.alert;
            objFormZoneTexte.Show();
        }
        private void btnModifNom_Click(object sender, EventArgs e)
        {
            objFormZoneTexte.currentProp = (FormZoneTexte.properties)properties.name;
            objFormZoneTexte.Show();
        }
        private void btnModifGroupe_Click(object sender, EventArgs e)
        {
            objFormZoneTexte.currentProp = (FormZoneTexte.properties)properties.group;
            objFormZoneTexte.Show();
        }
    }
}
