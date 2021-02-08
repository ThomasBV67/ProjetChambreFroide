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
        public AccesDB()
        {

        }
        public static List<Capteur> GetCapteurs()
        {
            using(IDbConnection conn = new SQLiteConnection(GetConnectionString()))
            {
                var output = conn.Query<Capteur>("SELECT * FROM Capteurs");
                return output.ToList();
            }
        }

        public static List<Capteur> GetUnsetCapteurs()
        {
            List<Capteur> capteurs = new List<Capteur>();
            capteurs = GetCapteurs();
            foreach(Capteur cap in capteurs)
            {
                if(cap.Set == 1)
                {
                    capteurs.Remove(cap);
                }
            }
            return capteurs;
        }

        public static List<Capteur> GetSetCapteurs()
        {
            List<Capteur> capteurs = new List<Capteur>();
            capteurs = GetCapteurs();
            foreach (Capteur cap in capteurs)
            {
                if (cap.Set == 0)
                {
                    capteurs.Remove(cap);
                }
            }
            return capteurs;
        }

        public static void AddNewCapteur(Capteur cap)
        {
            using (IDbConnection conn = new SQLiteConnection(GetConnectionString()))
            {
                conn.Execute("INSERT INTO Capteurs (Id, Module, Index, Set, AlertLow, AlertHigh, Name, Address, Group) " +
                    "values (@Id, @Module, @Index, @Set, @AlertLow, @AlertHigh, @Name, @Address, @Group)", cap);
            }
        }
        
        public static void SetCapteur(Capteur cap)
        {
            using (IDbConnection conn = new SQLiteConnection(GetConnectionString()))
            {

            }
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
