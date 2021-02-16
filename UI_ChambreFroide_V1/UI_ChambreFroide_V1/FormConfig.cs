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
    public partial class FormConfig : Form
    {

        public FormTempCourantes pagePrincipale;

        public FormConfig()
        {
            InitializeComponent();

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
                    pagePrincipale.serialPort1.Close();
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

        private void valeurChangeTableau(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FormConfig_Load(object sender, EventArgs e)
        {
            pagePrincipale.serialPort1.BaudRate = 9600;
            pagePrincipale.serialPort1.PortName = "COM3";
            b_ouvertureFermeturePort_Click(sender, e);
        }
    }
}
