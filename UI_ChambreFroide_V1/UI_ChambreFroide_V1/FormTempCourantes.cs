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
        const int NB_BOITES_AFFICHAGE = 15;
        Label[] m_label_pieces = new Label[NB_BOITES_AFFICHAGE];
        RichTextBox[] m_RTB_temp = new RichTextBox[NB_BOITES_AFFICHAGE];

        public FormTempCourantes()
        {
            InitializeComponent();
        }

        private void FormTempCourantes_Load(object sender, EventArgs e)
        {
            Control ctrlSuivant;
            ctrlSuivant = panelTemp;

            for(int i = 0; i < NB_BOITES_AFFICHAGE*2; i++)
            {
                ctrlSuivant = GetNextControl(ctrlSuivant, true);
                if (i % 2 == 0)
                {
                    m_label_pieces[(int)i / 2] = (Label)ctrlSuivant;
                    m_label_pieces[(int)i / 2].Text = "Capteur #" + Convert.ToString((int)(i / 2) + 1);
                }
                else
                {
                    m_RTB_temp[(int)(i / 2)] = (RichTextBox)ctrlSuivant;
                    m_RTB_temp[(int)(i / 2)].Text = "ND";
                }
            }
        }

        private void b_historique_Click(object sender, EventArgs e)
        {
            FormHistorique objFormHistorique = new FormHistorique();
            objFormHistorique.Show();
        }

        private void b_config_Click(object sender, EventArgs e)
        {
            FormConfig objFormConfig = new FormConfig();
            objFormConfig.pagePrincipale = this;
            objFormConfig.temoinOuverture();
            objFormConfig.Show();
        }
    }
}
