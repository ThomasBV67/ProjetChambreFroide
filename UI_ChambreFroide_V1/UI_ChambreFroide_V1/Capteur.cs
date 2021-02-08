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
        public String Name, Address, Group;
        public float AlertLow, AlertHigh;
        public int Id, Module, Index, Set;

        public Capteur(int idCap, String addrCap, int setCap, String nameCap, float alertLowCap, float alertHighCap, String groupCap, int moduleCap, int indexCap)
        {
            Id = idCap;
            Address = addrCap;
            Set = setCap;
            Name = nameCap;
            AlertLow = alertLowCap;
            AlertHigh = alertHighCap;
            Group = groupCap;
            Module = moduleCap;
            Index = indexCap;
        }
    }
}
