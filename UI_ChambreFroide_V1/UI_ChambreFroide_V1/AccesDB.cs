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

            using (IDbConnection conn = new SQLiteConnection(GetConnectionString()))
            {
                //conn.Execute("INSERT INTO Capteurs(Address, Ready, Module, Index) VALUES (@Address, @Ready, @Module, @Index)", newCap);
                conn.Execute("INSERT INTO Capteurs (Address, Ready, Module, Index) VALUES ('ab cd', 0, 1, 1)");
            }

            return true;
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
