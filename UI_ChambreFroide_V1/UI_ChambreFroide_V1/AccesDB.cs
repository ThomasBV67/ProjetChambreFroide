using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_ChambreFroide_V1
{
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
        /// été mis en place dans le système
        /// </summary>
        /// <returns></returns>
        public static List<Capteur> GetUnsetCapteurs()
        {
            List<Capteur> capteurs = new List<Capteur>();
            capteurs = GetCapteurs();

            foreach(Capteur cap in capteurs)
            {
                if(cap.Ready == 1)
                {
                    capteurs.Remove(cap);
                }
            }
            return capteurs;
        }

        /// <summary>
        /// Cette fonction retourne la liste de tous les capteurs mis en place dans le systeme
        /// </summary>
        /// <returns></returns>
        public static List<Capteur> GetSetCapteurs()
        {
            List<Capteur> capteurs = new List<Capteur>();
            capteurs = GetCapteurs();

            foreach (Capteur cap in capteurs)
            {
                if (cap.Ready == 0)
                {
                    capteurs.Remove(cap);
                }
            }
            return capteurs;
        }

        /// <summary>
        /// Cette fonction vérifie si un capteur donné est dans la dataBase. Si il est présent, 
        /// elle retourne false. Si le capteur n'est pas présent, elle l'ajoute à la dataBase
        /// </summary>
        /// <param name="newCap"></param>
        /// <returns></returns>
        public static bool AddNewCapteur(Capteur newCap)
        {
            List<Capteur> capteurs = new List<Capteur>();
            capteurs = GetCapteurs();

            foreach (Capteur cap in capteurs)
            {
                if (newCap.Address == cap.Address)
                {
                    return false;
                }
            }

            using (SQLiteConnection conn = new SQLiteConnection(GetConnectionString()))
            {
                SQLiteCommand sqlite_cmd;
                conn.Open();
                sqlite_cmd = conn.CreateCommand();
                sqlite_cmd.CommandText = "INSERT INTO Capteurs(Address, Ready, Module, ModuleIndex) VALUES (@Address, @Ready, @Module, @ModuleIndex)";

                sqlite_cmd.Parameters.Add("@Address", DbType.String, -1);
                sqlite_cmd.Parameters["@Address"].Value = newCap.Address;

                sqlite_cmd.Parameters.Add("@Ready", DbType.Int64, -1);
                sqlite_cmd.Parameters["@Ready"].Value = newCap.Ready;

                sqlite_cmd.Parameters.Add("@Module", DbType.Int64, -1);
                sqlite_cmd.Parameters["@Module"].Value = newCap.Module;

                sqlite_cmd.Parameters.Add("@ModuleIndex", DbType.Int64, -1);
                sqlite_cmd.Parameters["@ModuleIndex"].Value = newCap.ModuleIndex;

                sqlite_cmd.ExecuteNonQuery();
                conn.Close();
            }

            return true;
        }
        
        public static bool SetCapteur(Capteur capToSet)
        {
            using (SQLiteConnection conn = new SQLiteConnection(GetConnectionString()))
            {
                //try
                //{
                    SQLiteCommand sqlite_cmd;
                    conn.Open();
                    sqlite_cmd = conn.CreateCommand();
                    sqlite_cmd.CommandText = "UPDATE Capteurs SET Name = @Name, GroupCapteur = @GroupCapteur, AlertHigh = @AlertHigh, AlertLow = @AlertLow, Ready = 1 WHERE Id = @Id";

                    sqlite_cmd.Parameters.Add("@Name", DbType.String, -1);
                    sqlite_cmd.Parameters["@Name"].Value = capToSet.Name;

                    sqlite_cmd.Parameters.Add("@GroupCapteur", DbType.String, -1);
                    sqlite_cmd.Parameters["@GroupCapteur"].Value = capToSet.GroupCapteur;

                    sqlite_cmd.Parameters.Add("@AlertHigh", DbType.Double, -1);
                    sqlite_cmd.Parameters["@AlertHigh"].Value = capToSet.AlertHigh;

                    sqlite_cmd.Parameters.Add("@AlertLow", DbType.Double, -1);
                    sqlite_cmd.Parameters["@AlertLow"].Value = capToSet.AlertLow;

                    sqlite_cmd.Parameters.Add("@Id", DbType.Int64, -1);
                    sqlite_cmd.Parameters["@Id"].Value = capToSet.Id;

                    sqlite_cmd.ExecuteNonQuery();
                    conn.Close();
               /* }
                catch
                {
                    return false;
                }*/
            }
            return true;
        }
        
        

        /// <summary>
        /// Cette fonction permet d'avoir acces au connection string de la db
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private static string GetConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
