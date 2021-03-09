using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_ChambreFroide_V1
{
    public class MesureTemp
    {
        public int Id, Alert;
        public String TimeStamp, Capteur;
        public double Temperature;

        /// <summary>
        /// Constructeur pour la db
        /// </summary>
        public MesureTemp() { }
        
        /// <summary>
        /// Contructeur manuel
        /// </summary>
        public MesureTemp(int newId, String newCapteur, double newTemperature, int newAlert, String newTimeStamp)
        {
            Id = newId;
            Alert = newAlert;
            TimeStamp = newTimeStamp;
            Capteur = newCapteur;
            Temperature = newTemperature;
        }
    }
}
