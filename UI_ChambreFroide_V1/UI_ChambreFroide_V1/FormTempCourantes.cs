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
        public bool decouverteEnCours = false;
        int capteurEnCours = 0;
        int nbModules = 1;

        int tempsAttente = 20;

        const int NB_BOITES_AFFICHAGE = 15;
        Label[] m_label_pieces = new Label[NB_BOITES_AFFICHAGE];
        RichTextBox[] m_RTB_temp = new RichTextBox[NB_BOITES_AFFICHAGE];
        public List<Capteur> lst_Capteurs = new List<Capteur>();

        FormConfig objFormConfig = new FormConfig();

        String retourSerie = "";

        private delegate void monProtoDelegate();//définir prototype de fonction... paramètres d'entrée et de retour
        monProtoDelegate objDelegate;//on se déclare un objet delegate. (i.e. un pointeur de fonction ayant ce prototype)


        public FormTempCourantes()
        {
            InitializeComponent();

            objDelegate = delegate_getLoRa;
            objFormConfig.Hide();
            objFormConfig.pagePrincipale = this;
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
                    m_RTB_temp[(int)(i / 2)].Text = "--";
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
            objFormConfig.temoinOuverture();
            objFormConfig.Show();
        }
        /// <summary>
        /// Interprète les commandes reçues en série
        /// </summary>
        private void delegate_getLoRa()
        {
            String[] capteursModule = new String[20];
            int nbCapteurs = 0;
            bool existe = false;

            if (decouverteEnCours)//Si en mode découverte
            {
                t_timeoutScan.Stop();//pas de timeout possible
                nbModules++;
                for (int i = 0; i < retourSerie.Length; i++)//compte le nombre de capteurs sur le module interrogé
                {
                    if (retourSerie.Substring(i, 1) == "#")//compte le nb. de capteurs présents
                        nbCapteurs++;
                }

                capteursModule = retourSerie.Split('#');//divise le message d'entrée par capteurs

                for (int i = 0; i < nbCapteurs; i++)//Capteurs à ajouter
                {
                    for (int j = 0; j < lst_Capteurs.Count; j++)//Lit la liste
                    {
                        if(lst_Capteurs[j].Address == capteursModule[i])//Si déjà présent dans la liste, est à ignorer
                        {
                            existe = true;
                        }
                    }
                    if (!existe)//si n'existe pas déjà
                    {
                        lst_Capteurs.Add(new Capteur(capteursModule[i], nbModules-1, i));//nouvel objet et ajout dans la grille
                        objFormConfig.listeCapteurs.Rows.Insert(0);
                        objFormConfig.listeCapteurs.Rows[0].Cells[0].Value = lst_Capteurs[lst_Capteurs.Count - 1].Address.ToUpper();
                        objFormConfig.listeCapteurs.Rows[0].Cells[1].Value = lst_Capteurs[lst_Capteurs.Count - 1].Module;
                        objFormConfig.listeCapteurs.Rows[0].Cells[2].Value = lst_Capteurs[lst_Capteurs.Count - 1].ModuleIndex;
                        AccesDB.AddNewCapteur(lst_Capteurs[lst_Capteurs.Count - 1]);
                    }
                    existe = false;
                }
                objFormConfig.scanModule(nbModules);//Lit le prochain module
            }
            else
            {
                t_timeoutScan.Stop();
                m_RTB_temp[capteurEnCours].Text = retourSerie;
                if (Convert.ToDouble(m_RTB_temp[capteurEnCours].Text.Replace('.', ',')) < lst_Capteurs[capteurEnCours].AlertLow)
                {
                    m_RTB_temp[capteurEnCours].BackColor = Color.LightGreen;
                    AccesDB.EnregistreTemp(lst_Capteurs[capteurEnCours].Address, Convert.ToDouble(m_RTB_temp[capteurEnCours].Text.Replace('.', ',')),0);
                }
                else if(Convert.ToDouble(m_RTB_temp[capteurEnCours].Text.Replace('.', ',')) >= lst_Capteurs[capteurEnCours].AlertHigh)
                {
                    m_RTB_temp[capteurEnCours].BackColor = Color.Red;
                    AccesDB.EnregistreTemp(lst_Capteurs[capteurEnCours].Address, Convert.ToDouble(m_RTB_temp[capteurEnCours].Text.Replace('.', ',')), 2);
                }
                else if (Convert.ToDouble(m_RTB_temp[capteurEnCours].Text.Replace('.', ',')) >= lst_Capteurs[capteurEnCours].AlertLow)
                {
                    m_RTB_temp[capteurEnCours].BackColor = Color.Yellow;
                    AccesDB.EnregistreTemp(lst_Capteurs[capteurEnCours].Address, Convert.ToDouble(m_RTB_temp[capteurEnCours].Text.Replace('.', ',')), 1);
                }

                capteurEnCours++;
                if (capteurEnCours < NB_BOITES_AFFICHAGE && capteurEnCours < lst_Capteurs.Count)
                {
                    reqTemp(lst_Capteurs[capteurEnCours].Module, lst_Capteurs[capteurEnCours].ModuleIndex);
                }
                else
                {
                    t_checkTemps.Start();
                    tempsAttente = 20;
                }
            }
        }
        /// <summary>
        /// Lecture du port série
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void getLoRa(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            retourSerie = serialPort1.ReadLine();
            BeginInvoke(objDelegate);
        }
        /// <summary>
        /// Timeout correspodant à la fin de la découverte du réseau
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void t_timeoutScan_Tick(object sender, EventArgs e)
        {
            if (decouverteEnCours)
            {
                nbModules = 1;//reset du nombre de module découvert
                t_timeoutScan.Stop();//Arret du timer
                decouverteEnCours = false;
                MessageBox.Show("Découverte terminée");
            }
            else
            {

                startGetTemp();
            }
            
        }

        public void MAJListeCapteurs()
        {
            for (int i = 0; i < lst_Capteurs.Count; i++)//Ajoute les noms aux objets
            {
                lst_Capteurs[i].Name = (string)objFormConfig.listeCapteurs.Rows[lst_Capteurs.Count - 1 - i].Cells[3].Value;//ordre de la grille par rapport à la liste inversé. 
                //Doit passer pas soustraction pour que les noms correspondent.
                lst_Capteurs[i].AlertLow = Convert.ToDouble(objFormConfig.listeCapteurs.Rows[lst_Capteurs.Count - 1 - i].Cells[5].Value);
                lst_Capteurs[i].AlertHigh = Convert.ToDouble(objFormConfig.listeCapteurs.Rows[lst_Capteurs.Count - 1 - i].Cells[6].Value);
            }

            for (int i = 0; i < NB_BOITES_AFFICHAGE; i++)//Affiche les noms existants sinon, mets ND
            {
                try
                {
                    m_label_pieces[i].Text = lst_Capteurs[i].Name;
                }
                catch
                {
                    m_label_pieces[i].Text = "ND";
                }
            }
        }

        private void t_checkTemps_Tick(object sender, EventArgs e)
        {
            tempsAttente--;
            l_tempsRestant.Text = "Temps avant la prochaine mise à jour: " + Convert.ToString(tempsAttente);
            if (tempsAttente == 0)
            {
                startGetTemp();
            }
        }

        public void startGetTemp()
        {
            capteurEnCours = 0;
            reqTemp(lst_Capteurs[0].Module, lst_Capteurs[0].ModuleIndex);
            t_checkTemps.Stop();
        }

        private void reqTemp(int module, int capteur)
        {
            l_tempsRestant.Text = "Mise à jour du capteur # " + Convert.ToString(module) + " : " + Convert.ToString(capteur);
            serialPort1.Write(Convert.ToString(module) + "getTemp-" + Convert.ToString(capteur));
            t_timeoutScan.Start();
        }
    }
}
