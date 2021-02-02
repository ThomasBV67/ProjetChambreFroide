﻿using System;
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

        public List<Capteur> m_listCapteurs = new List<Capteur>();

        public FormChoixCapteur()
        {
            InitializeComponent();

            for (int i = 0; i < m_listCapteurs.Count; i++)
            {
                String newCap = "";
                newCap = "Capteur " + i;
                Button newBtn = new Button();
                newBtn.Text = m_listCapteurs[i].name;
                m_listButtons.Add(newBtn);
            }
        }
        /// <summary>
        /// Cette fonction met à jour la liste de capteurs
        /// </summary>
        public void updateListeCapteurs()
        {
            // Objets qui seront utilisés pour la connection à la db SQlite

            SQLiteConnection db_conn;
            SQLiteCommand db_command;
            SQLiteDataAdapter db_dataAdapt;

            // Trouve le path de la db en utilisant le path relatif

            string exeFile = (new System.Uri(Assembly.GetEntryAssembly().CodeBase)).AbsolutePath;
            string exeDir = Path.GetDirectoryName(exeFile);
            string fullPath = Path.Combine(exeDir, "..\\..\\dbTestProjet.db");
            string pathDB = "DataSource=" + fullPath;

            // Connection à la db

            db_conn = new SQLiteConnection(pathDB);
            db_conn.Open();

            // create a new SQL command:

            db_command = db_conn.CreateCommand();


            // build a SQL-Query :

            db_command.CommandText = "SELECT * FROM Capteurs";

            DataTable dt = new DataTable();

            db_dataAdapt = new SQLiteDataAdapter(db_command);

            // Now the SQLiteCommand object can give us a DataReader-Object:

            db_dataAdapt.Fill(dt);
            dataGridView1.DataSource= dt;

            // We are ready, now lets cleanup and close our connection:

            db_conn.Close();

        }

        private void btnUpdateCapteurs_Click(object sender, EventArgs e)
        {
            updateListeCapteurs();
        }
    }
}
