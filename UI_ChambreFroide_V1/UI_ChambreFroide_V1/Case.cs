using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace UI_ChambreFroide_V1
{
    /// <summary>
    /// Classe qui représente le contenu des cases de l'affichage des températures courantes
    /// </summary>
    class Case
    {
        public Color couleurCase;
        public double temperature;
        public String nomPiece;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="pColor"></param>
        /// <param name="pTemperature"></param>
        /// <param name="pNomPiece"></param>
        public Case(Color pColor, double pTemperature, String pNomPiece)
        {
            couleurCase = pColor;
            temperature = pTemperature;
            nomPiece = pNomPiece;
        }
    }
}
