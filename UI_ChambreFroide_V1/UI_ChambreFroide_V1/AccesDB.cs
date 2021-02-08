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
        public static List<Capteur> GetCapteurs()
        {
            using(IDbConnection conn = new SQLiteConnection(GetConnectionString()))
            {
                var output = conn.Query<Capteur>("SELECT * FROM Capteurs");
                return output.ToList();
            }
        }

        /*
        public static List<Capteur> AddNewCapteur()
        {
            using (IDbConnection conn = new SQLiteConnection(GetConnectionString()))
            {
                
            }
        }

        public static List<Capteur> SetCapteur()
        {
            using (IDbConnection conn = new SQLiteConnection(GetConnectionString()))
            {

            }
        }
        */

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
