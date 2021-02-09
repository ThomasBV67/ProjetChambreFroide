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
        public List<String> m_listGroups = new List<String>();
        public List<Capteur> m_listCapteurs = new List<Capteur>();

        public string Name { get; set; }
        public bool isGroup { get; set; }

        public FormChoixCapteur()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Cette fonction met à jour la liste de capteurs
        /// </summary>
        public void updateListeCapteurs()
        { 
            m_listCapteurs = AccesDB.GetSetCapteurs();
            foreach(Capteur cap in m_listCapteurs)
            {
                listBoxChoixCapteur.Items.Add(cap.Name);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        
        private void btnUp_Click(object sender, EventArgs e)
        {
            if (listBoxChoixCapteur.SelectedIndex > 0)
            {
                listBoxChoixCapteur.SelectedIndex -= 1;
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            
            if (listBoxChoixCapteur.SelectedIndex < listBoxChoixCapteur.Items.Count-1)
            {
                listBoxChoixCapteur.SelectedIndex += 1;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

            this.Name = listBoxChoixCapteur.SelectedItem.ToString();
            if(btnGroupName.Text == "Groupes")
            {
                this.isGroup = false;
            }
            else
            {
                this.isGroup = true;
            }
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FormChoixCapteur_Load(object sender, EventArgs e)
        {
            updateListeCapteurs();
        }

        private void btnGroupName_Click(object sender, EventArgs e)
        {

            listBoxChoixCapteur.Items.Clear();

            if (btnGroupName.Text == "Groupes")
            {
                btnGroupName.Text = "Noms";

                m_listGroups = AccesDB.GetGroups();

                foreach (String str in m_listGroups)
                {
                    listBoxChoixCapteur.Items.Add(str);
                }
            }
            else
            {
                btnGroupName.Text = "Groupes";

                foreach (Capteur cap in m_listCapteurs)
                { 
                    listBoxChoixCapteur.Items.Add(cap.Name);
                }
            }
        }
    }
}
