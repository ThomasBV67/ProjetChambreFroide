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
    /// <summary>
    /// Ce form permet d'accéder à un historique de températures lié à un capteur ou un groupe de capteurs.
    /// La sélection se fait via le bouton Sélection du capteur.
    /// </summary>
    public partial class FormHistorique : Form
    {
        public String selectedName; // variables ayant une valeur donnée par le form de choix de capteur
        public bool selectedIsGroup;

        public enum timeFrameChoice {Day, Week, Month, Other};
        public timeFrameChoice timeFrame = timeFrameChoice.Day;
        FormChoixCapteur objFormChoixCapteur = new FormChoixCapteur();

        public FormHistorique()
        {
            InitializeComponent();

            objFormChoixCapteur.Hide();
        }

        /// <summary>
        /// Appuyer sur le bouton de choix de capteur ouvre le form de choix de capteur. Lorque le form
        /// se ferme avec le bouton select, on reçoit le capteur ou groupe qui à été selectionné.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectCapteur_Click(object sender, EventArgs e)
        {
            objFormChoixCapteur.Show();
            if(objFormChoixCapteur.DialogResult == DialogResult.OK)
            {
                selectedName = objFormChoixCapteur.returnName;
                selectedIsGroup = objFormChoixCapteur.isGroup;
            }
        }

        /// <summary>
        /// Retourn au form précédent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void FormHistorique_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timeframeBtns_Click(object sender, EventArgs e)
        {
            if(sender.Equals(btnLastDay))
            {
                timeFrame = timeFrameChoice.Day;
            }
            else if(sender.Equals(btnLastWeek))
            {
                timeFrame = timeFrameChoice.Week;
            }
            else if (sender.Equals(btnLastMonth))
            {
                timeFrame = timeFrameChoice.Month;
            }
            else if (sender.Equals(btnMoreOptions))
            {
                timeFrame = timeFrameChoice.Other;
            }
            UpdateGraphique();
        }

        private void UpdateGraphique()
        {

        }
    }
}
