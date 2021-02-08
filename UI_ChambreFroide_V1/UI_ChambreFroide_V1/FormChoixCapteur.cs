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
            m_listCapteurs = AccesDB.GetCapteurs();

            dataGridViewCapteurs.DataSource = m_listCapteurs;
            // Objets qui seront utilisés pour la connection à la db SQlite
            /*
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

            // crée un objet de commande:

            db_command = db_conn.CreateCommand();

            // ajout de la commande pour aller chercher les capteurs:

            db_command.CommandText = "SELECT * FROM Capteurs WHERE ";

            // On rempli une dataTable avec le contenu de la table Capteurs

            DataTable dt = new DataTable();
            db_dataAdapt = new SQLiteDataAdapter(db_command);
            db_dataAdapt.Fill(dt);
            dataGridViewCapteurs.DataSource= dt;

            dataGridViewCapteurs.AutoResizeColumns();

            // Fin de connexion

            db_conn.Close();
            */

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
