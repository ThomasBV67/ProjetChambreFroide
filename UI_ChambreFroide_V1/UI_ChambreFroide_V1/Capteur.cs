using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_ChambreFroide_V1
{
    /// <summary>
    /// Classe contenant les informations données par la table Capteurs de la db
    /// Name : Nom donné par l'usager au capteur
    /// Address : Addresse de 8 Bytes unique au capteur
    /// Group : Nom de grouppage donné au capteur par l'usager
    /// AlertLow : Température minimale permise avant qu'une alerte ne soit lancée
    /// AlertHigh : Température maximale permise avant qu'une alerte ne soit lancée
    /// Id : Id dans la dataBase
    /// Module : # du module duquel vient le capteur
    /// Index : Index du capteur dans le module
    /// Set : Indique si le capteur à déja été setup par l'usager.
    /// </summary>
    public class Capteur
    {
        public String Name, Address, Group;
        public double AlertLow, AlertHigh;
        public int Id, Module, Index, Set;
    }
}
