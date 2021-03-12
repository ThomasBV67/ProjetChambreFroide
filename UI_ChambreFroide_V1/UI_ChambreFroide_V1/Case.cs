using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace UI_ChambreFroide_V1
{
    class Case
    {
        public Color couleurCase;
        public double temperature;
        public String nomPiece;

        public Case(Color pColor, double pTemperature, String pNomPiece)
        {
            couleurCase = pColor;
            temperature = pTemperature;
            nomPiece = pNomPiece;
        }
    }
}
