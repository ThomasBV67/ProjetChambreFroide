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
    /// <summary>
    /// Ce form permet de sélectionner un capteur ou un groupe de capteur à observer dans le form d'historique.
    /// </summary>
    public partial class FormChoixCapteur : Form
    { 
        public List<String> m_listGroups = new List<String>(); // Liste de tous les groupes présents dans la db
        public List<Capteur> m_listCapteurs = new List<Capteur>();  // Liste de tous les capteurs initialisés

        public string returnName { get; set; }  // Propriété utilisée pour transferer le nom du capteur ou du groupe choisis au form précédent
        public bool isGroup { get; set; }       // Propriété utilisée pour savoir si le nom transféré est un nom de capteur ou de groupe

        public FormChoixCapteur()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Retour au form précédent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        
        /// <summary>
        /// Appuyer sur le bouton UP monte la ligne sélectionnée de 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUp_Click(object sender, EventArgs e)
        {
            if (listBoxChoixCapteur.SelectedIndex > 0)
            {
                listBoxChoixCapteur.SelectedIndex -= 1;
            }
        }

        /// <summary>
        /// Appuyer sur le bouton DOWN baisse la ligne sélectionnée de 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDown_Click(object sender, EventArgs e)
        {
            
            if (listBoxChoixCapteur.SelectedIndex < listBoxChoixCapteur.Items.Count-1)
            {
                listBoxChoixCapteur.SelectedIndex += 1;
            }
        }

        /// <summary>
        /// Le bouton SELECT envoie le nom du capteur ou du groupe sélectionné au form précédent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {

            this.returnName = listBoxChoixCapteur.SelectedItem.ToString();
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

        /// <summary>
        /// Update la liste des capteurs et les affiche dans le listbox lorque le form charge
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormChoixCapteur_Load(object sender, EventArgs e)
        {
            m_listCapteurs = AccesDB.GetSetCapteurs();
            foreach (Capteur cap in m_listCapteurs)
            {
                listBoxChoixCapteur.Items.Add(cap.Name);
            }
        }

        /// <summary>
        /// Ce bouton permet de changer la sélection de capteur en sélection de groupe et vice-versa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGroupName_Click(object sender, EventArgs e)
        {
            listBoxChoixCapteur.Items.Clear();

            if (btnGroupName.Text == "Groupes") // passe en mode groupe
            {
                btnGroupName.Text = "Noms"; // met Noms comme texte dans le bouton
                labelTitre.Text = "Choix du groupe à étudier";

                m_listGroups = AccesDB.GetGroups(); // Update la liste de groupes via de la db

                foreach (String str in m_listGroups) // Affiche les groupes dans le listbox
                {
                    listBoxChoixCapteur.Items.Add(str);
                }
            }
            else // Passe en mode capteur
            {
                btnGroupName.Text = "Groupes";// met Groupes comme texte dans le bouton
                labelTitre.Text = "Choix du capteur à étudier";

                m_listCapteurs = AccesDB.GetSetCapteurs(); // Update la liste de capteurs via la db

                foreach (Capteur cap in m_listCapteurs) // Affiche les capteurs dans le listbox
                { 
                    listBoxChoixCapteur.Items.Add(cap.Name);
                }
            }
        }
    }
}
