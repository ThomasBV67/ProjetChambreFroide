using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_ChambreFroide_V1
{
    public class Capteur
    {
        public String name = "";
        public int addr = 0;

        public Capteur(String nameCap, int addrCap)
        {
            name = nameCap;
            addr = addrCap;
        }
    }
}
