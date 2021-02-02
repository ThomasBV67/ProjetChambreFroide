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
        public void updateListeCapteurs()
        {
            // We use these three SQLite objects:

            SQLiteConnection sqlite_conn;

            SQLiteCommand sqlite_cmd;

            SQLiteDataAdapter sqlite_adapt;

            SQLiteDataReader sqlite_datareader;


            // Trouve le fichier de db

            string exeFile = (new System.Uri(Assembly.GetEntryAssembly().CodeBase)).AbsolutePath;

            string exeDir = Path.GetDirectoryName(exeFile);

            string fullPath = Path.Combine(exeDir, "..\\..\\dbTestProjet.db");

            string pathDB = "DataSource=" + fullPath;


            // create a new database connection:
            
            sqlite_conn = new SQLiteConnection(pathDB);



            // open the connection:

            sqlite_conn.Open();



            // create a new SQL command:

            sqlite_cmd = sqlite_conn.CreateCommand();


            // build a SQL-Query :

            sqlite_cmd.CommandText = "SELECT * FROM Capteurs";

            DataTable dt = new DataTable();

            //sqlite_adapt(sqlite_cmd)

            // Now the SQLiteCommand object can give us a DataReader-Object:

            sqlite_datareader = sqlite_cmd.ExecuteReader();



            // The SQLiteDataReader allows us to run through the result lines:

            while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read

            {

                // Print out the content of the text field:

                //System.Console.WriteLine( sqlite_datareader["text"] );



                string myreader = sqlite_datareader.GetString(0);

                MessageBox.Show(myreader);

            }

            // We are ready, now lets cleanup and close our connection:

            sqlite_conn.Close();

        }

        private void btnUpdateCapteurs_Click(object sender, EventArgs e)
        {
            updateListeCapteurs();
        }
    }
}
