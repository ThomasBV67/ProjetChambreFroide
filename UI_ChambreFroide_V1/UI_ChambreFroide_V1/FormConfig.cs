using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Permet de configuere le port série et l'ensemble des capteurs sur le réseau.
/// La page de configuration regroupe les paramètres du port série ainsi que les paramètres de découverte/modification de capteurs.
/// Il est possible pour l'utilisateur de découvrir les capteurs disponibles sur le réseau. Il est aussi possible de naviguer parmi
/// les capteurs présents pour modifier leur configuration individuelle.
/// </summary>
namespace UI_ChambreFroide_V1
{
    /// <summary>
    /// Ce form permet de détecter tous les capteurs présents dans le systeme et d'avoir accès au configurateur du port série.
    /// </summary>
    public partial class FormConfig : Form
    {
        public FormTempCourantes pagePrincipale; // lien vers le formTempCourantes
        public FormModifCapteur objFormModifCapteur = new FormModifCapteur();  
        int selectedIndex = 0; // valeur utilisée pour déterminer quel capteur est sélectionné dans le dataGridView

        public FormConfig()
        {
            InitializeComponent();
            objFormModifCapteur.Hide();
        }

        /// <summary>
        /// Ferme la page en mettant à jour les labels d'affichage de la page 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            pagePrincipale.MAJListeCapteurs();
            this.Hide();
            pagePrincipale.Show();
            pagePrincipale.BringToFront();
            pagePrincipale.MAJAffichageTemps();
        }

        /// <summary>
        /// Ouvre une boite de dialogue qui permet de configurer le port série
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_configSerie_Click(object sender, EventArgs e)
        {
            Configuration config = new Configuration(pagePrincipale.serialPort1.PortName, pagePrincipale.serialPort1.BaudRate, pagePrincipale.serialPort1.DataBits, pagePrincipale.serialPort1.Parity, pagePrincipale.serialPort1.StopBits);
            if (config.ShowDialog() == DialogResult.OK)//Si l'utilisateur confirme
            {
                if (pagePrincipale.serialPort1.IsOpen)//vérifie la validité des parametres et les appliques
                { 
                    pagePrincipale.serialPort1.Close();
                    etatPortActuel.ForeColor = Color.Red;//affiche Fermé en rouge
                    etatPortActuel.Text = "Fermé";
                    b_ouvertureFermeturePort.Text = "Ouvrir le port";
                }
                try
                {
                    pagePrincipale.serialPort1.PortName = config.m_nom;
                }
                catch
                {
                    MessageBox.Show("Port Invalide.\n\nLe port est probalement:\n-Déjà utilisé par une autre application\n-Innexistant");
                }
                try
                {
                    pagePrincipale.serialPort1.BaudRate = config.m_vitesse;
                }
                catch
                {
                    MessageBox.Show("Vitesse Invalide");
                }
                try
                {
                    pagePrincipale.serialPort1.Parity = config.m_parite;
                }
                catch
                {
                    MessageBox.Show("Parité Invalide");
                }
                try
                {
                    pagePrincipale.serialPort1.DataBits = config.m_nbBit;
                }
                catch
                {
                    MessageBox.Show("Nombre de bits invalide");
                }
                try
                {
                    pagePrincipale.serialPort1.StopBits = config.m_stopBit;
                }
                catch
                {
                    MessageBox.Show("Stop bit Invalide");
                }

            }
        }

        /// <summary>
        /// MAJ de la barre d'état du port série dans le bas de la page de config
        /// </summary>
        public void temoinOuverture()
        {   //affiche les parametres appliqués au port série
            infoPortActuel.Text = pagePrincipale.serialPort1.PortName + ";" + Convert.ToString(pagePrincipale.serialPort1.BaudRate) + ";" + Convert.ToString(pagePrincipale.serialPort1.Parity) + ";" + Convert.ToString(pagePrincipale.serialPort1.DataBits) + ";" + Convert.ToString(pagePrincipale.serialPort1.StopBits);

            if (pagePrincipale.serialPort1.IsOpen)
            {
                etatPortActuel.ForeColor = Color.Green;//affiche "Ouvert" en vert
                etatPortActuel.Text = "Ouvert";
                b_ouvertureFermeturePort.Text = "Fermer le port";
            }
            else
            {
                etatPortActuel.ForeColor = Color.Red;//affiche Fermé en rouge
                etatPortActuel.Text = "Fermé";
                b_ouvertureFermeturePort.Text = "Ouvrir le port";
            }
        }

        /// <summary>
        /// Ouvre et ferme le port série
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_ouvertureFermeturePort_Click(object sender, EventArgs e)
        {
            if (pagePrincipale.serialPort1.IsOpen)
            {
                pagePrincipale.serialPort1.Close();
            }else{
                try{
                    pagePrincipale.serialPort1.Open();
                }catch{
                    MessageBox.Show("Erreur lors de l'ouverture du port série");
                }
            }
            temoinOuverture();
        }

        /// <summary>
        /// Envoie la première commande de get Addr. au module via série
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_decouverte_Click(object sender, EventArgs e)
        {
            if (pagePrincipale.serialPort1.IsOpen)
            {
                pagePrincipale.decouverteEnCours = true;
                scanModule(1);
            }
            else
            {
                MessageBox.Show("Le port série doit etre ouvert");
            }
        }

        /// <summary>
        /// Envoie la requete d'addressage au module spécifié puis démarre le timer de timeout
        /// </summary>
        /// <param name="module"></param>
        public void scanModule(int module)
        {
            pagePrincipale.serialPort1.WriteLine(Convert.ToString(module) + "getAddr");
            pagePrincipale.t_timeoutScan.Start();
        }

        /// <summary>
        /// Appuyer sur le bouton de modification affiche le formModifCapteur avec les valeurs
        /// du capteur qui est sélectionné dans le dataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_modifyCapteur_Click(object sender, EventArgs e)
        {
            // fait rien si aucun capteurs ne sont dans le dataGridView
            if (listeCapteurs.Rows.Count == 0)
                return;

            // si erreur de sélection, prends le dernier
            if (selectedIndex >= listeCapteurs.Rows.Count)
            {
                selectedIndex = listeCapteurs.Rows.Count - 1;
            }

            // si déja un nom associé : transfert le nom
            if (listeCapteurs.Rows[selectedIndex].Cells[3].Value != null)
            {
                objFormModifCapteur.m_name = listeCapteurs.Rows[selectedIndex].Cells[3].Value.ToString();
            }
            else // si pas de nom, laisse le champ vide
            {
                objFormModifCapteur.m_name = "";
            }

            // si déja un nom de groupe : transfert le nom de groupe
            if (listeCapteurs.Rows[selectedIndex].Cells[4].Value != null)
            {
                objFormModifCapteur.m_group = listeCapteurs.Rows[selectedIndex].Cells[4].Value.ToString();
            }
            else // si pas de nom de groupe, laisse le champ vide
            {
                objFormModifCapteur.m_group = "";
            }

            // si déja un niveau d'avertissement : transfert la valeur
            if (listeCapteurs.Rows[selectedIndex].Cells[5].Value != null)
            {
                objFormModifCapteur.m_warning = Convert.ToDouble(listeCapteurs.Rows[selectedIndex].Cells[5].Value);
            }
            else // si pas de valeur d'avertissement : met 5 de base 
            {
                objFormModifCapteur.m_warning = 5;
            }

            // si déja un niveau d'alerte : transfert la valeur
            if (listeCapteurs.Rows[selectedIndex].Cells[6].Value != null)
            {
                objFormModifCapteur.m_alert = Convert.ToDouble(listeCapteurs.Rows[selectedIndex].Cells[6].Value);
            }
            else // si pas de valeur d'alerte : met 8 de base 
            {
                objFormModifCapteur.m_alert = 8;
            }

            objFormModifCapteur.m_module = Convert.ToInt32(listeCapteurs.Rows[selectedIndex].Cells[1].Value);
            objFormModifCapteur.m_capteur = Convert.ToInt32(listeCapteurs.Rows[selectedIndex].Cells[2].Value);

            objFormModifCapteur.FormModifCapteur_Load(sender, e);
            objFormModifCapteur.ShowDialog();
            if(objFormModifCapteur.DialogResult == DialogResult.OK)//Bouton Appliquer
            {
                listeCapteurs.Rows[selectedIndex].Cells[3].Value = objFormModifCapteur.m_name;
                listeCapteurs.Rows[selectedIndex].Cells[4].Value = objFormModifCapteur.m_group;
                listeCapteurs.Rows[selectedIndex].Cells[5].Value = objFormModifCapteur.m_warning;
                listeCapteurs.Rows[selectedIndex].Cells[6].Value = objFormModifCapteur.m_alert;
            }else if(objFormModifCapteur.DialogResult == DialogResult.Abort)//Bouton supprimer capteur
            {
                pagePrincipale.supprimeCapteur(selectedIndex);
            }
        }

        /// <summary>
        /// Évenement de click du bouton haut. Lorsque le bouton est appuyé, si le capteur sélectionné
        /// n'est pas celui le plus haut, on monte de 1 dans la liste de capteurs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_up_Click(object sender, EventArgs e)
        {
            if(selectedIndex>0)
            {
                listeCapteurs.Enabled = true;
                listeCapteurs.Rows[selectedIndex].Selected = false;
                selectedIndex--;
                listeCapteurs.Rows[selectedIndex].Selected = true;

                if (!listeCapteurs.Rows[selectedIndex].Displayed)
                {
                    listeCapteurs.FirstDisplayedScrollingRowIndex = selectedIndex;
                }
                listeCapteurs.Enabled = false;
            }
        }

        /// <summary>
        /// Évenement de click du bouton bas. Lorsque le bouton est appuyé, si le capteur sélectionné
        /// n'est pas celui le plus bas, on descend de 1 dans la liste de capteurs.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_down_Click(object sender, EventArgs e)
        {
            if(selectedIndex < listeCapteurs.Rows.Count-1)
            {
                listeCapteurs.Enabled = true;
                listeCapteurs.Rows[selectedIndex].Selected = false;
                selectedIndex++;
                listeCapteurs.Rows[selectedIndex].Selected = true;

                if(listeCapteurs.Rows.Count - selectedIndex > 1)
                {
                    if (!listeCapteurs.Rows[selectedIndex + 1].Displayed)
                    {
                        listeCapteurs.FirstDisplayedScrollingRowIndex = selectedIndex;
                    }
                }
                listeCapteurs.Enabled = false;
            }
        }
    }
}
