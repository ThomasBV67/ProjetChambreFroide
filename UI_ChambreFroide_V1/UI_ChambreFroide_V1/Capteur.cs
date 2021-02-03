using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_ChambreFroide_V1
{
    /// <summary>
    /// Classe contenant les informations données par la table Capteurs de la db
    /// </summary>
    public class Capteur
    {
        public String name, addr, group;
        public float alertLow, alertHigh;
        public int module, index;

        public Capteur(String addrCap, String nameCap, float alertLowCap, float alertHighCap, String groupCap, int moduleCap, int indexCap)
        {
            name = nameCap;
            addr = addrCap;
            alertLow = alertLowCap;
            alertHigh = alertHighCap;
            group = groupCap;
            module = moduleCap;
            index = indexCap;
        }
    }
}
