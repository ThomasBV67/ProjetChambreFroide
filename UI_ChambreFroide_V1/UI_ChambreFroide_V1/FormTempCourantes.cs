using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace UI_ChambreFroide_V1
{
    /// <summary>
    /// Ce form est le form principal de l'application. Sur ce form on peut voir en léger différé les températures des
    /// capteurs de températures. On peut accéder à l'historique et à la configuration des capteurs à partir de ce form.
    /// </summary>
    public partial class FormTempCourantes : Form
    {
        public bool decouverteEnCours = false;
        bool pingEnCours = false;
        bool demandeArret = false;
        int capteurEnCours = -1;//Valeur à -1 pour signifier au programme qu'aucun scan est en cours
        int nbModules = 1;
        int nbErr = 0;
        int page = 0;

        ///////////////////////////////////////Marqueurs temporaires
        int e = 0;
        int eMod1 = 0;
        int eMod2 = 0;
        int eCritMod1 = 0;
        int eCritMod2 = 0;
        int nbCycles = 0;

        int tempsAttente = 20;

        const int NB_BOITES_AFFICHAGE = 15;
        const int TEMPS_ATTENTE = 1;


        Label[] m_label_pieces = new Label[NB_BOITES_AFFICHAGE];
        RichTextBox[] m_RTB_temp = new RichTextBox[NB_BOITES_AFFICHAGE];
        public List<Capteur> lst_Capteurs = new List<Capteur>();
        public List<Capteur> lst_CapteursDB = new List<Capteur>();
        private List<Case> lst_cases = new List<Case>();



        FormZoneTexte objFormZoneTexte = new FormZoneTexte();


        FormConfig objFormConfig = new FormConfig();
        FormHistorique objFormHistorique = new FormHistorique();


        String retourSerie = "";
        List<String> debug = new List<String>();

        private delegate void monProtoDelegate();//définir prototype de fonction... paramètres d'entrée et de retour
        monProtoDelegate objDelegate;//on se déclare un objet delegate. (i.e. un pointeur de fonction ayant ce prototype)


        public FormTempCourantes()
        {
            InitializeComponent();

            objDelegate = delegate_getLoRa;
            objFormConfig.Hide();
            objFormHistorique.Hide();
            objFormConfig.pagePrincipale = this;//Envoi de la page en cours à pa page de config pour que les deux puissent s'échanger des informations
            objFormConfig.objFormModifCapteur.pagePrincipale = this;//Pour le ping
            
            
        }
        /// <summary>
        /// Mets tout les labels de noms des pieces et les labels de température dans un tableau. Leur donne ensuite un nom par défaut unique
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormTempCourantes_Load(object sender, EventArgs e)
        {
            Control ctrlSuivant;
            ctrlSuivant = panelTemp;

            for(int i = 0; i < NB_BOITES_AFFICHAGE*2; i++)
            {
                ctrlSuivant = GetNextControl(ctrlSuivant, true);
                if (i % 2 == 0)//Selon le tab index, un sur deux est un titre et l'autre est une case de température.
                {
                    m_label_pieces[(int)i / 2] = (Label)ctrlSuivant;
                    m_label_pieces[(int)i / 2].Text = "Capteur #" + Convert.ToString((int)(i / 2) + 1);//Nom par défaut
                }
                else
                {
                    m_RTB_temp[(int)(i / 2)] = (RichTextBox)ctrlSuivant;
                    m_RTB_temp[(int)(i / 2)].Text = "--";//Température par défaut
                }
            }

            b_precedent.Enabled = false;//Désactive les boutons de page, il n'y a pas de capteur d'actif
            b_suivant.Enabled = false;

            serialPort1.BaudRate = 115200;
            serialPort1.PortName = "COM3";//Tente d'ouvrir le port série au démarrage

            l_state.Text = "Système à l'arret";
            loadCapteursFromDB();//Lit la configuration sauvegardée

            try//Tente un démarrage automatique
            {
                serialPort1.Open();
                demarreTimerTemp();
                b_arretDepart.Text = "Arreter";
            }
            catch {//Si ne réussi pas, indique à l'utilisateur qu'une configuration est requise pour continuer
                l_state.Text = "Configuration requise";
            }

        }
        /// <summary>
        /// Devine
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_historique_Click(object sender, EventArgs e)
        {
            objFormHistorique.Show();
        }

        /// <summary>
        /// Ouvre la page de config et met à jour la barre d'état du port série dans la page de config
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_config_Click(object sender, EventArgs e)
        {
            loadCapteursFromDB();
            objFormConfig.temoinOuverture();
            objFormConfig.Show();
        }
        /// <summary>
        /// Interprète les commandes reçues en série. Est appelé apres chaque réception. La fonction gere la découverte de réseau et la prise de température par deux modes distincts.
        /// </summary>
        private void delegate_getLoRa()
        {
            //Variables mode découverte:
            String[] capteursModule = new String[20];//Contient un maximum de 20 addresses qui seront retounés par les modules lors de la découverte
            int nbCapteurs = 0;//Nb de capteurs retournés
            bool existe = false;//Si un capteur est retourné une seconde fois lors de la découverte.

            //Variable mode retour température
            double temperature = 0;//temprature retournée

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
                    for (int j = 0; j < lst_Capteurs.Count; j++)//Lit la liste à la recherche du capteur à ajouter
                    {
                        if (lst_Capteurs[j].Address == capteursModule[i])//Si déjà présent dans la liste, est à ignorer
                        {
                            existe = true;
                        }
                    }
                    if (!existe)//si n'existe pas déjà, est ajouté avec les propriétés par défaut
                    {
                        lst_Capteurs.Add(new Capteur(capteursModule[i], nbModules - 1, i));//nouvel objet et ajout dans la grille
                        objFormConfig.listeCapteurs.Rows.Insert(objFormConfig.listeCapteurs.Rows.Count);
                        objFormConfig.listeCapteurs.Rows[objFormConfig.listeCapteurs.Rows.Count - 1].Cells[0].Value = lst_Capteurs[lst_Capteurs.Count - 1].Address.ToUpper();//Addresse
                        objFormConfig.listeCapteurs.Rows[objFormConfig.listeCapteurs.Rows.Count - 1].Cells[1].Value = lst_Capteurs[lst_Capteurs.Count - 1].Module;//Numéro de module
                        objFormConfig.listeCapteurs.Rows[objFormConfig.listeCapteurs.Rows.Count - 1].Cells[2].Value = lst_Capteurs[lst_Capteurs.Count - 1].ModuleIndex;//Numéro de capteur
                        objFormConfig.listeCapteurs.Rows[objFormConfig.listeCapteurs.Rows.Count - 1].Cells[5].Value = "5";//Valeur avertissement par défaut
                        objFormConfig.listeCapteurs.Rows[objFormConfig.listeCapteurs.Rows.Count - 1].Cells[6].Value = "10";//Valeur alerte par défaut
                        AccesDB.AddNewCapteur(lst_Capteurs[lst_Capteurs.Count - 1]);
                    }
                    existe = false;
                }
                objFormConfig.scanModule(nbModules);//Lit le prochain module
            }
            else if(pingEnCours)//Réception d'un ping
            {
                String[] trame = new String[20];
                trame = retourSerie.Split('#');//Divise l'adresse de la température
                t_timeoutScan.Stop();//donnée reçue, plus de timeout possible
                MessageBox.Show("Le capteur " + trame[1].ToUpper() + " indique une température de " + trame[0]);//Affiche l'adresse du capteur et la temp.
                pingEnCours = false;//désactive le marqueur de ping
            }
            else//est en mode req. temps.
            {
                if (!t_checkTemps.Enabled)//Pour éviter de reçevoir des messages qui viennent de sources inconnues sans que le programme ne soit pret (Messages aléatopires qui arrivent à tout moment)
                {
                    t_timeoutScan.Stop();//arrete le timer de timeout, la réponse est reçue
                    temperature = receptTemp(retourSerie, capteurEnCours);//Vérifie la validité de la réponse. Est invalide si -127

                    if (temperature != -127)//Si aucun code d'erreur
                    {
                        nbErr = 0;
                        if (temperature < lst_Capteurs[capteurEnCours].AlertLow)//Si temp. est ok
                        {
                            lst_cases.Add(new Case(Color.Green, temperature, lst_Capteurs[capteurEnCours].Name));
                            AccesDB.EnregistreTemp(lst_Capteurs[capteurEnCours].Address, temperature, 0);
                        }
                        else if (temperature >= lst_Capteurs[capteurEnCours].AlertHigh)//alerte haute
                        {
                            lst_cases.Add(new Case(Color.Red, temperature, lst_Capteurs[capteurEnCours].Name));
                            AccesDB.EnregistreTemp(lst_Capteurs[capteurEnCours].Address, temperature, 2);
                        }
                        else if (temperature >= lst_Capteurs[capteurEnCours].AlertLow)//Alerte moyen
                        {
                            lst_cases.Add(new Case(Color.Yellow, temperature, lst_Capteurs[capteurEnCours].Name));
                            AccesDB.EnregistreTemp(lst_Capteurs[capteurEnCours].Address, temperature, 1);
                        }
                        MAJAffichageTemps();//Affiche les températures mises à jour apres chaque nouveau capteur

                        capteurEnCours++;//prochain capteur
                        if (capteurEnCours < lst_Capteurs.Count)//Lit le prochain si existe
                        {
                            reqTemp(lst_Capteurs[capteurEnCours].Module, lst_Capteurs[capteurEnCours].ModuleIndex);//Envoie la prochaine requete
                        }
                        else
                        {
                            demarreTimerTemp();//Sinon, est arrivé à la fin et démarre le minuteur pour le prochain scan
                            capteurEnCours = -1;//plus de scan
                            if (demandeArret)//Arrete le systeme si une demande était en attente
                            {
                                arretDepartLecture(null, null);
                            }
                        }

                    }
                    else//Réponse invalide, erreur
                    {
                        reqFailed();
                    }
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
            if (decouverteEnCours)//Timeout du mode découverte
            {
                nbModules = 1;//reset du nombre de module découvert
                t_timeoutScan.Stop();//Arret du timer
                decouverteEnCours = false;
                MessageBox.Show("Découverte terminée");
            }
            else if (pingEnCours)
            {
                MessageBox.Show("ping échoué");
                t_timeoutScan.Stop();
                pingEnCours = false;
            }
            else//Timeout du mode température
            {
                reqFailed();//Aucune réponse, erreur
            }
            
        }
        /// <summary>
        /// Met à jour la liste des capteurs ainsi que la BD qui y est associé à partir du datagridview dans formConfig
        /// </summary>
        public void MAJListeCapteurs()
        {
            for (int i = 0; i < lst_Capteurs.Count; i++)//Ajoute les noms aux objets
            {
                lst_Capteurs[i].Name = (string)objFormConfig.listeCapteurs.Rows[i].Cells[3].Value;
                if (lst_Capteurs[i].Name == null)
                {
                    lst_Capteurs[i].Name = "";
                }
                lst_Capteurs[i].AlertLow = Convert.ToDouble(objFormConfig.listeCapteurs.Rows[i].Cells[5].Value);//Ajoute les limites aux objets
                lst_Capteurs[i].AlertHigh = Convert.ToDouble(objFormConfig.listeCapteurs.Rows[i].Cells[6].Value);
                AccesDB.SetCapteur(lst_Capteurs[i]);
            }
            MAJAffichageTemps();
        }

        /// <summary>
        /// Décrémente le timer principal de 1 sec et démarre la prise de température si arrive à 0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void t_checkTemps_Tick(object sender, EventArgs e)
        {
            tempsAttente--;
            l_state.Text = "Temps avant la prochaine mise à jour: " + Convert.ToString(tempsAttente);
            if (tempsAttente == 0)
            {
                startGetTemp();
            }
        }
        /// <summary>
        /// Démarre le cycle de prise de température
        /// </summary>
        public void startGetTemp()
        {
            lbNbCycles.Text = "Combre de cycles : " + Convert.ToString(++nbCycles);
            capteurEnCours = 0;//commence au c. 0
            reqTemp(lst_Capteurs[0].Module, lst_Capteurs[0].ModuleIndex);
            t_checkTemps.Stop();//Arrete le timer principal
            lst_cases.Clear();//Prépare la liste de cases à recevoir les nouvelles valeurs
        }
        /// <summary>
        /// Requete de température sur un capteur spécifique
        /// </summary>
        /// <param name="module"></param>
        /// <param name="capteur"></param>
        private void reqTemp(int module, int capteur)
        {
            l_state.Text = "Mise à jour du capteur # " + Convert.ToString(module) + " : " + Convert.ToString(capteur);
            try
            {
                serialPort1.Write(Convert.ToString(module) + "getTemp-" + Convert.ToString(capteur));
            }
            catch
            {
                try
                {
                    serialPort1.Write(Convert.ToString(module) + "getTemp-" + Convert.ToString(capteur));
                    serialPort1.Open();
                }
                catch
                {
                    l_state.Text = "Échec de mise à jour du capteur # " + Convert.ToString(module) + " : " + Convert.ToString(capteur);
                }
            }
            t_timeoutScan.Start();
        }

        /// <summary>
        /// Tente une nouvelle requete de température jusqu'à concurence de 3. Apres 3, le capteur est passé
        /// et sa case de température est marqué (*) pour signifier qu'une erreur est survenue à la précédente lecture
        /// </summary>
        private void reqFailed()
        {
            t_timeoutScan.Stop();
            nbErr++;    //nombre d'essai faits ++
            e++;        //nombre d'erreurs totale

            if(lst_Capteurs[capteurEnCours].Module == 1) // Si l'erreur vient du module 1
            {
                eMod1++;
            }
            else    // erreur vient du module 2
            {
                eMod2++;
            }


            if (nbErr < 4)//3 tentatives
            {
                reqTemp(lst_Capteurs[capteurEnCours].Module, lst_Capteurs[capteurEnCours].ModuleIndex);
            }
            else//Apres 3 affiche le thermometre comme étant défectueux
            {
                lst_cases.Add(new Case(Color.Purple, -127, lst_Capteurs[capteurEnCours].Name));
                MAJAffichageTemps();
                nbErr = 0;

                if (lst_Capteurs[capteurEnCours].Module == 1)   // Erreur vient du module 1
                {
                    eCritMod1++;
                }
                else    //Erreur vient du module 2
                {
                    eCritMod2++;
                }

                if (++capteurEnCours >= lst_Capteurs.Count)//Si est à la fin de la liste, redémarre l'attente
                {
                    demarreTimerTemp();
                }
                else//sinon démarre la lecture du prochain capteur
                {
                    reqTemp(lst_Capteurs[capteurEnCours].Module, lst_Capteurs[capteurEnCours].ModuleIndex);
                }
            }

            // Affichage du nombre d'erreur régulières et critiques de chaque module
            lbErr.Text = "Erreurs : " + Convert.ToString(e);
            lbErrMod1.Text = "Erreurs Module 1 : " + Convert.ToString(eMod1);
            lbErrMod2.Text = "Erreurs Module 2 : " + Convert.ToString(eMod2);
            lbCritErrMod1.Text = "Erreurs Critiques Module 1: " + Convert.ToString(eCritMod1);
            lbCritErrMod2.Text = "Erreurs Critiques Module 2: " + Convert.ToString(eCritMod2);

        }

        /// <summary>
        /// Vérifie la validité de la valeur de température, si est valide, retopurne la température. Sinon retourne -127 pour signifier l'erreur
        /// </summary>
        /// <param name="retour"></param>
        /// <param name="capteur"></param>
        /// <returns></returns>
        private double receptTemp(String retour, int capteur)
        {
            String[] trame = new String[20];
            trame = retour.Split('#');
            try
            {
                if (lst_Capteurs[capteur].Address == trame[1].Trim())//L'adresse du capteur agit comme checksum
                {
                    return Convert.ToDouble(trame[0].Replace(".",NumberFormatInfo.CurrentInfo.NumberDecimalSeparator));
                }
            }
            catch{}
            
            return -127;//retourne code d'erreur au besoin
        }
        /// <summary>
        /// Démarre le timer principal et reset le délais d'attente. Le timer déparre seulement si le port série est ouvert et des capteurs sont chargés
        /// </summary>
        private void demarreTimerTemp()
        {
            if(lst_Capteurs.Count > 0 && serialPort1.IsOpen)//Si des capteurs sont présents et port pret
            {
                t_checkTemps.Start();
                tempsAttente = TEMPS_ATTENTE;//Temps d'attente par défaut
                b_config.Enabled = false;
            }
            else
            {
                b_arretDepart.Text = "Démarrer";
                l_state.Text = "Système à l'arret";
                capteurEnCours = -1;
                b_config.Enabled = true;
            }
        }
        /// <summary>
        /// Controle de l'arret / départ du cycle de lecture des capteurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void arretDepartLecture(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Open();
                }
                catch { }
            }
            //La variable capteurEnCours est à -1 si aucun scan est en cours
            if (capteurEnCours != -1 && !demandeArret)//Si un scan est en cours et aucun arret est en cours
            {
                demandeArret = true;//Définit un arret comme étant en attente
                b_arretDepart.Text = "Arret à la fin du cycle\nAppuyer pour annuler";
            }else if (capteurEnCours != -1 && demandeArret)//Annule la demande d'arret
            {
                demandeArret = false;
                b_arretDepart.Text = "Arreter";
            }
            else//Si pas de scan en cours
            {
                demandeArret = false;
                if (!t_checkTemps.Enabled)//Activer/désactiver(activer:)
                {
                    demarreTimerTemp();//démarre
                    b_arretDepart.Text = "Démarrage...";
                    if (!t_checkTemps.Enabled)//vérifie si le démarrage a reussi
                    {//Si n'a pas réussi:
                        b_config.Enabled = true;
                        b_arretDepart.Text = "Démarrer";
                        l_state.Text = "Système à l'arret";
                        MessageBox.Show("Une erreur s'est produite au démarrage du cycle de lecture");
                    }
                    else//reussi:
                    {
                        b_arretDepart.Text = "Arreter";
                    }
                }
                else//désactiver:
                {
                    b_config.Enabled = true;
                    b_arretDepart.Text = "Démarrer";
                    t_checkTemps.Stop();
                    l_state.Text = "Système à l'arret";
                }
            }
            
        }
        /// <summary>
        /// Page de capteurs précédente, verouille le bouton si ne peut aller plus loin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_precedent_Click(object sender, EventArgs e)
        {
            if (page > 0)
            {
                page--;
                b_suivant.Enabled = true;
                MAJAffichageTemps();//Affiche les températures de la nouvelle page
                if (page == 0)
                {
                    b_precedent.Enabled = false;
                }
            }
            MAJTemoinPage();
        }
        /// <summary>
        /// Page de capteurs suivante, verouille le bouton si ne peut aller plus loin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void b_suivant_Click(object sender, EventArgs e)
        {
            if (NB_BOITES_AFFICHAGE * (page + 1) < lst_Capteurs.Count)
            {
                page++;
                b_precedent.Enabled = true;
                MAJAffichageTemps();//Affiche les températures de la nouvelle page
                if (page > lst_Capteurs.Count / NB_BOITES_AFFICHAGE || lst_Capteurs.Count <= 1)
                {
                    b_suivant.Enabled = false;
                }
            }
            MAJTemoinPage();
        }

        /// <summary>
        /// Affiche les températures dans la page spécifiée
        /// </summary>
        public void MAJAffichageTemps()
        {
            for (int i = 0; i < NB_BOITES_AFFICHAGE; i++)//pour toutes les cases
            {
                try//essaie de lire le contenu
                {
                    m_label_pieces[i].Text = lst_cases[i + NB_BOITES_AFFICHAGE * page].nomPiece;//Titre
                    if (lst_cases[i + NB_BOITES_AFFICHAGE * page].temperature != -127)//affiche erreur si erreur. Sinon affiche température
                    {
                        m_RTB_temp[i].Text = Convert.ToString(Math.Round(lst_cases[i + NB_BOITES_AFFICHAGE * page].temperature, 1)) + "°";
                    }
                    else
                    {
                        m_RTB_temp[i].Text = "ERR";
                    }
                    m_RTB_temp[i].BackColor = lst_cases[i + NB_BOITES_AFFICHAGE * page].couleurCase;//couleur
                }
                catch//sinon on est probablement à la fin de la liste
                {
                    try{
                        m_label_pieces[i].Text = lst_Capteurs[i + NB_BOITES_AFFICHAGE * page].Name;//Si la config a été faite mais aucune donnée à afficher, affiche seulement le nom sans afficher la température(qui n'existe pas encore)
                    }
                    catch//Dans le cas que le programme ait passé tout les capteurs et il reste des cases à traiter, vide les cases. Permet d'éviter que des températures soient affichées en double
                    {
                        if (lst_Capteurs.Count <= i + NB_BOITES_AFFICHAGE * page)//Vide la case seulement si la case est passée le nombre de capteurs
                        {
                            m_label_pieces[i].Text = "";
                            m_RTB_temp[i].Text = "";
                            m_RTB_temp[i].BackColor = Color.White;
                        }
                    }
                }
            }
            MAJTemoinPage();
            MAJEtatBoutonsPage();
        }
        /// <summary>
        /// Met à jour l'affichage de x/y page
        /// </summary>
        private void MAJTemoinPage()
        {
            l_page.Text = "Page " + Convert.ToString(page + 1) + "/" + Convert.ToString((lst_Capteurs.Count / NB_BOITES_AFFICHAGE) + 1);
        }
        /// <summary>
        /// Active ou désactive les boutons de page dépendamment de l'index de page et du nombre de pages disponibles. 
        /// </summary>
        private void MAJEtatBoutonsPage()
        {

            b_suivant.Enabled = true;
            if (NB_BOITES_AFFICHAGE * (page + 1) > lst_Capteurs.Count)
            {
                b_suivant.Enabled = false;
            }

            if (page == 0)
            {
                b_precedent.Enabled = false;
            }
        }
        /// <summary>
        /// Suprime le capteur de la BD et de la liste
        /// </summary>
        /// <param name="index"></param>
        public void supprimeCapteur(int index)
        {
            AccesDB.DeleteCapteur(lst_Capteurs[index].Address);
            lst_Capteurs.RemoveAt(index);
            objFormConfig.listeCapteurs.Rows.RemoveAt(index);//Supprime du gridview pour pas qu'il ne revienne apres avoir appuyé sur retour
        }
        /// <summary>
        /// Envoie un "Ping" au capteur
        /// </summary>
        /// <param name="module"></param>
        /// <param name="capteur"></param>
        public void ping(int module, int capteur)
        {
            pingEnCours = true;//Prépare le programme à recevoir un ping puis envoie la commande 
            reqTemp(module, capteur);
        }
        /// <summary>
        /// Lit les capteurs disponibles dans la BD et les ajoute à la liste de capteurs actifs
        /// </summary>
        private void loadCapteursFromDB()
        {
            List<Capteur> configSauvegardee = new List<Capteur>();//Ouvre la liste de capteurs dans la BD
            configSauvegardee = AccesDB.GetCapteurs();

            objFormConfig.listeCapteurs.Rows.Clear();//Efface la liste des capteurs dans le datagridview...
            foreach (Capteur c in configSauvegardee)
            {
                objFormConfig.listeCapteurs.Rows.Insert(objFormConfig.listeCapteurs.Rows.Count);//... et les réaffiche 
                objFormConfig.listeCapteurs.Rows[objFormConfig.listeCapteurs.Rows.Count - 1].Cells[0].Value = c.Address;
                objFormConfig.listeCapteurs.Rows[objFormConfig.listeCapteurs.Rows.Count - 1].Cells[1].Value = c.Module;
                objFormConfig.listeCapteurs.Rows[objFormConfig.listeCapteurs.Rows.Count - 1].Cells[2].Value = c.ModuleIndex;
                objFormConfig.listeCapteurs.Rows[objFormConfig.listeCapteurs.Rows.Count - 1].Cells[3].Value = c.Name;
                objFormConfig.listeCapteurs.Rows[objFormConfig.listeCapteurs.Rows.Count - 1].Cells[4].Value = c.GroupCapteur;
                objFormConfig.listeCapteurs.Rows[objFormConfig.listeCapteurs.Rows.Count - 1].Cells[5].Value = c.AlertLow;
                objFormConfig.listeCapteurs.Rows[objFormConfig.listeCapteurs.Rows.Count - 1].Cells[6].Value = c.AlertHigh;

                if (!lst_Capteurs.Exists(x => x.Address == c.Address))//Ajoute le capteurs à la liste interne seulement si il n'y est pas déjà
                {
                    lst_Capteurs.Add(new Capteur(c.Address, c.Module, c.ModuleIndex, c.Name, c.GroupCapteur, c.AlertLow, c.AlertHigh));
                }
            }

            MAJAffichageTemps();//Affiche la grille avec les vouveaux capteurs

        }
    }
}
