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
    public partial class FormTempCourantes : Form
    {
        public bool decouverteEnCours = false;
        int nbModules = 1;

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
        private void delegate_getLoRa()
        {
            String[] capteursModule = new String[20];
            int nbCapteurs = 0;
            bool existe = false;

            if (decouverteEnCours)
            {
                t_timeoutScan.Stop();
                nbModules++;
                for (int i = 0; i < retourSerie.Length; i++)//compte le nombre de capteurs sur le module interrogé
                {
                    if (retourSerie.Substring(i, 1) == "#")
                        nbCapteurs++;
                }

                capteursModule = retourSerie.Split('#');

                for (int i = 0; i < nbCapteurs; i++)//Capteurs à ajouter
                {
                    for (int j = 0; j < lst_Capteurs.Count; j++)//Lit la liste
                    {
                        if(lst_Capteurs[j].Address == capteursModule[i])
                        {
                            existe = true;
                        }
                    }
                    if (!existe)
                    {
                        lst_Capteurs.Add(new Capteur(capteursModule[i], nbModules-1, i));
                        objFormConfig.listeCapteurs.Rows.Insert(0);
                        objFormConfig.listeCapteurs.Rows[0].Cells[0].Value = lst_Capteurs[lst_Capteurs.Count - 1].Address.ToUpper();
                        objFormConfig.listeCapteurs.Rows[0].Cells[1].Value = lst_Capteurs[lst_Capteurs.Count - 1].Module;
                        objFormConfig.listeCapteurs.Rows[0].Cells[2].Value = lst_Capteurs[lst_Capteurs.Count - 1].ModuleIndex;
                    }
                    existe = false;
                }
                /*
                for (int i = 0; i < nbCapteurs; i++)
                {
                    for (int j = 0; j < objFormConfig.listeCapteurs.Rows.Count; j++)
                    {
                        if ((string)objFormConfig.listeCapteurs.Rows[j].Cells[0].Value == lst_Capteurs[i].Address.ToUpper())//Si existe déjà dans la grille
                        {
                            existe = true;
                        }
                    }
                    if (!existe)
                    {
                        objFormConfig.listeCapteurs.Rows.Insert(0);
                        objFormConfig.listeCapteurs.Rows[0].Cells[0].Value = lst_Capteurs[i].Address.ToUpper();
                        objFormConfig.listeCapteurs.Rows[0].Cells[1].Value = lst_Capteurs[i].Module;
                        objFormConfig.listeCapteurs.Rows[0].Cells[2].Value = lst_Capteurs[i].ModuleIndex;
                    }

                    existe = false;
                }
                */
                objFormConfig.scanModule(nbModules);
            }
        }

        private void getLoRa(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            retourSerie = serialPort1.ReadLine();
            BeginInvoke(objDelegate);
        }

        private void t_timeoutScan_Tick(object sender, EventArgs e)
        {
            nbModules = 1;
            t_timeoutScan.Stop();
            decouverteEnCours = false;
            MessageBox.Show("Découverte terminée");
        }

        public void MAJLabels()
        {
            for (int i = 0; i < lst_Capteurs.Count; i++)
            {
                lst_Capteurs[i].Name = (string)objFormConfig.listeCapteurs.Rows[i].Cells[3].Value;
            }

            for (int i = 0; i < NB_BOITES_AFFICHAGE; i++)
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
    }
}
