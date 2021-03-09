﻿using System;
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
            lbWarning.Text = "Niveau d'avertissement : " + m_warning.ToString() + "°";
            lbAlerte.Text = "Niveau d'alerte : " + m_alert.ToString() + "°";
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnModifWarning_Click(object sender, EventArgs e)
        {
            objFormZoneTexte.chgMode(1);
            objFormZoneTexte.tbModif.Text = Convert.ToString(m_warning);
            objFormZoneTexte.ShowDialog();
            if(objFormZoneTexte.DialogResult == DialogResult.OK)
            {
                m_warning = Convert.ToDouble(objFormZoneTexte.retour);
            }
        }
        private void btnModifAlerte_Click(object sender, EventArgs e)
        {
            objFormZoneTexte.chgMode(1);
            objFormZoneTexte.tbModif.Text = Convert.ToString(m_alert);
            objFormZoneTexte.ShowDialog();
            if (objFormZoneTexte.DialogResult == DialogResult.OK)
            {
                m_alert = Convert.ToDouble(objFormZoneTexte.retour);
            }
        }
        private void btnModifNom_Click(object sender, EventArgs e)
        {
            objFormZoneTexte.chgMode(0);
            objFormZoneTexte.tbModif.Text = m_name;
            objFormZoneTexte.ShowDialog();
            if (objFormZoneTexte.DialogResult == DialogResult.OK)
            {
                m_name = objFormZoneTexte.retour;
            }
        }
        private void btnModifGroupe_Click(object sender, EventArgs e)
        {
            objFormZoneTexte.chgMode(0);
            objFormZoneTexte.tbModif.Text = Convert.ToString(m_group);
            objFormZoneTexte.ShowDialog();
            if (objFormZoneTexte.DialogResult == DialogResult.OK)
            {
                m_group = objFormZoneTexte.retour;
            }
        }
    }
}
