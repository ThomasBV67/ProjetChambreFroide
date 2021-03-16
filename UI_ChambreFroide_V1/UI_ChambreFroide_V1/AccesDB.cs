using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_ChambreFroide_V1
{
    /// <summary>
    /// Cette classe permet d'avoir acces à la database SQLite3 du projet.
    /// </summary>
    public class AccesDB
    {
        /// <summary>
        /// Cette fonction retourne la liste de tous les capteurs dans la dataBase
        /// </summary>
        /// <returns></returns>
        public static List<Capteur> GetCapteurs()
        {
            using(IDbConnection conn = new SQLiteConnection(GetConnectionString()))
            {
                var output = conn.Query<Capteur>("SELECT * FROM Capteurs");
                return output.ToList();
            }
        }

        /// <summary>
        /// Cette fonction retourne la liste de tous les capteurs connectés qui n'ont pas encore 
        /// été mis en place dans le système (pas de nom / alertes)
        /// </summary>
        /// <returns> Retourne la liste des capteurs non-initialisés </returns>
        public static List<Capteur> GetUnsetCapteurs()
        {
            List<Capteur> capteurs, setCapteurs = new List<Capteur>();
            capteurs = GetCapteurs(); // get la liste complete

            foreach(Capteur cap in capteurs) // filtre la liste
            {
                if(cap.Ready == 0)
                {
                    setCapteurs.Add(cap);
                }
            }
            return setCapteurs;
        }

        /// <summary>
        /// Cette fonction retourne la liste de tous les capteurs mis en place dans le systeme
        /// </summary>
        /// <returns> Retourne la liste des capteurs initialisés </returns>
        public static List<Capteur> GetSetCapteurs()
        {
            List<Capteur> capteurs, setCapteurs = new List<Capteur>();
            capteurs = GetCapteurs(); // get la liste complete

            foreach (Capteur cap in capteurs) // filtre la liste
            {
                if (cap.Ready == 1)
                {
                    setCapteurs.Add(cap);
                }
            }
            return setCapteurs;
        }

        /// <summary>
        /// Cette fonction vérifie si un capteur donné est dans la dataBase. Si il est présent, 
        /// elle retourne false. Si le capteur n'est pas présent, elle l'ajoute à la dataBase
        /// </summary>
        /// <param name="newCap"> Objet capteur qui contient minimalement une adresse, un numéro de module et un numéro d'index sur le module </param>
        /// <returns></returns>
        public static bool AddNewCapteur(Capteur newCap)
        {
            List<Capteur> capteurs = new List<Capteur>();
            capteurs = GetCapteurs(); // Get la liste des capteurs

            foreach (Capteur cap in capteurs)   // Vérifie si le capteur existe déja
            {
                if (newCap.Address == cap.Address)
                {
                    return false;
                }
            }

            using (SQLiteConnection conn = new SQLiteConnection(GetConnectionString())) // ouvre une connection
            {
                SQLiteCommand sqlite_cmd;
                conn.Open();

                // Crée la commande SQL
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = "INSERT INTO Capteurs(Address, Ready, Module, ModuleIndex) VALUES (@Address, 0, @Module, @ModuleIndex)";

                // Set les valeurs à celles voulues
                sqlite_cmd.Parameters.Add("@Address", DbType.String, -1);
                sqlite_cmd.Parameters["@Address"].Value = newCap.Address; 

                sqlite_cmd.Parameters.Add("@Module", DbType.Int64, -1);
                sqlite_cmd.Parameters["@Module"].Value = newCap.Module;

                sqlite_cmd.Parameters.Add("@ModuleIndex", DbType.Int64, -1);
                sqlite_cmd.Parameters["@ModuleIndex"].Value = newCap.ModuleIndex;

                sqlite_cmd.ExecuteNonQuery();
                conn.Close();
            }
            return true;
        }
        
        /// <summary>
        /// Cette fonction permet d'ajouter un nom, un groupe et des niveaux d'alerte à un capteur non-initialisé
        /// </summary>
        /// <param name="capToSet"></param>
        /// <returns></returns>
        public static bool SetCapteur(Capteur capToSet)
        {
            using (SQLiteConnection conn = new SQLiteConnection(GetConnectionString()))
            {
                try
                {
                    SQLiteCommand sqlite_cmd;
                    conn.Open();

                    // Crée la commande SQL
                    sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = "UPDATE Capteurs SET Name = @Name, GroupCapteur = @GroupCapteur, AlertHigh = @AlertHigh, AlertLow = @AlertLow, Ready = 1 WHERE Address = @Address";

                    // Set les valeurs à celles voulues
                    sqlite_cmd.Parameters.Add("@Name", DbType.String, -1);
                    sqlite_cmd.Parameters["@Name"].Value = capToSet.Name;

                    sqlite_cmd.Parameters.Add("@GroupCapteur", DbType.String, -1);
                    sqlite_cmd.Parameters["@GroupCapteur"].Value = capToSet.GroupCapteur;

                    sqlite_cmd.Parameters.Add("@AlertHigh", DbType.Double, -1);
                    sqlite_cmd.Parameters["@AlertHigh"].Value = capToSet.AlertHigh;

                    sqlite_cmd.Parameters.Add("@AlertLow", DbType.Double, -1);
                    sqlite_cmd.Parameters["@AlertLow"].Value = capToSet.AlertLow;

                    sqlite_cmd.Parameters.Add("@Address", DbType.String, -1);
                    sqlite_cmd.Parameters["@Address"].Value = capToSet.Address;

                    sqlite_cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Cette fonction permet de changer le nom d'un capteur dans la base de donnée
        /// </summary>
        /// <param name="capToSet"></param>
        /// <returns></returns>
        public static bool ChangeName(Capteur capToSet)
        {
            using (SQLiteConnection conn = new SQLiteConnection(GetConnectionString()))
            {
                try
                {
                    conn.Open();

                    // Cré une commande SQL
                    SQLiteCommand sqlite_cmd;
                    sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = "UPDATE Capteurs SET Name = @Name WHERE Id = @Id";

                    // Set les valeurs à celles voulues
                    sqlite_cmd.Parameters.Add("@Name", DbType.String, -1);
                    sqlite_cmd.Parameters["@Name"].Value = capToSet.Name;

                    sqlite_cmd.Parameters.Add("@Id", DbType.Int64, -1);
                    sqlite_cmd.Parameters["@Id"].Value = capToSet.Id;

                    sqlite_cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Cette fonction retourne une liste de string contenant les noms des groupes présents dans la database
        /// </summary>
        /// <returns></returns>
        public static List<String> GetGroups()
        {
            List<String> temp1, temp2 = new List<String>(); // 2 listes pour pouvoir filtrer facilement le contenu 

            using (IDbConnection conn = new SQLiteConnection(GetConnectionString()))
            {
                // Get tous les groupes uniques
                var output = conn.Query<String>("SELECT DISTINCT GroupCapteur FROM Capteurs");
                temp1 = output.ToList();

                // Retire le groupe NULL si il est présent
                foreach(String str in temp1)
                {
                    if(str != null)
                    {
                        temp2.Add(str);
                    }
                }

                // Retourne la liste de groupes
                return temp2;
            }
        }

        /// <summary>
        /// Cette fonction enregistre une entrée de température dans la db
        /// </summary>
        /// <param name="newCap"></param>
        /// <returns></returns>
        public static bool EnregistreTemp(String addr, double temp, int alert)
        {
            using (SQLiteConnection conn = new SQLiteConnection(GetConnectionString())) // ouvre une connection
            {
                SQLiteCommand sqlite_cmd;
                conn.Open();

                // Crée la commande SQL
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = "INSERT INTO Historique (Capteur, Temperature, Alert, TimeStamp) VALUES (@Capteur, @Temperature, @Alert, @TimeStamp)";

                // Set les valeurs à celles voulues
                sqlite_cmd.Parameters.Add("@Capteur", DbType.String, -1);
                sqlite_cmd.Parameters["@Capteur"].Value = addr;

                sqlite_cmd.Parameters.Add("@Temperature", DbType.Double, -1);
                sqlite_cmd.Parameters["@Temperature"].Value = temp;

                sqlite_cmd.Parameters.Add("@Alert", DbType.Int64, -1);
                sqlite_cmd.Parameters["@Alert"].Value = alert;

                sqlite_cmd.Parameters.Add("@TimeStamp", DbType.String, -1);
                sqlite_cmd.Parameters["@TimeStamp"].Value = DateTime.Now.ToString();

                sqlite_cmd.ExecuteNonQuery();
                conn.Close();
            }
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="addrCap"></param>
        /// <returns></returns>
        public List<MesureTemp> GetTemperatures(DateTime startTime, DateTime endTime, string addrCap)
        {
            List<MesureTemp> listTemp = new List<MesureTemp>();


            String sql = "SELECT * FROM Historique WHERE Capteur = '" + addrCap + "' AND TimeStamp > '" + startTime.ToString("yyyy-MM-dd HH:mm:ss")
                + "' AND TimeStamp < '" + endTime.ToString("yyyy-MM-dd HH:mm:ss") + "'";
            using (IDbConnection conn = new SQLiteConnection(GetConnectionString()))
            {
                // Get tous les groupes uniques
                var output = conn.Query<MesureTemp>(sql);
                listTemp = output.ToList();
            }
            return listTemp;
        }

        /// <summary>
        /// Cette fonction permet d'avoir acces au connection string de la db (contient le path du fichier .db
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private static string GetConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
