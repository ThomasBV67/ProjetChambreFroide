using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_ChambreFroide_V1.Properties;
using System.IO;
using System.Reflection;

namespace UI_ChambreFroide_V1
{
    public partial class FormChoixCapteur : Form
    { 
        public List<Button> m_listButtons = new List<Button>();
        public int m_nbCapteurs = 0;

        public int dataGridSelectedIndex = 0;
        public List<Capteur> m_listCapteurs = new List<Capteur>();

        public FormChoixCapteur()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Cette fonction met à jour la liste de capteurs
        /// </summary>
        public void updateListeCapteurs()
        {
            
            Capteur cap = new Capteur();
            cap.Address = "AB 23 G3 33 BB C9 DD KK";
            cap.Ready = 0;
            cap.Module = 2;
            cap.ModuleIndex = 5;
            AccesDB.AddNewCapteur(cap);
            m_listCapteurs = AccesDB.GetCapteurs();
            dataGridViewCapteurs.DataSource = m_listCapteurs;
            cap.InitCapteur("Cuisine 1", "Cuisine", 25.5, 15.3);
            AccesDB.SetCapteur(cap);
            dataGridViewCapteurs.DataSource = m_listCapteurs;
        }

        private void btnUpdateCapteurs_Click(object sender, EventArgs e)
        {
            updateListeCapteurs();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if(dataGridSelectedIndex>0)
            {
                dataGridViewCapteurs.Rows[dataGridSelectedIndex].Selected = false;
                dataGridSelectedIndex--;
                dataGridViewCapteurs.Rows[dataGridSelectedIndex].Selected = true;
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (dataGridSelectedIndex < dataGridViewCapteurs.Rows.Count-1)
            {
                dataGridViewCapteurs.Rows[dataGridSelectedIndex].Selected = false;
                dataGridSelectedIndex++;
                dataGridViewCapteurs.Rows[dataGridSelectedIndex].Selected = true;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FormChoixCapteur_Load(object sender, EventArgs e)
        {
            updateListeCapteurs();
        }
    }
}
