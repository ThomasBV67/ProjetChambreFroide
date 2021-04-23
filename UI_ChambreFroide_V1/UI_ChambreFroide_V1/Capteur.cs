﻿using System;
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
    /// ModuleIndex : Index du capteur dans le module
    /// Ready : Indique si le capteur à déja été setup par l'usager.
    /// </summary>
    public class Capteur
    {
        public String Name, Address, GroupCapteur;
        public double AlertLow, AlertHigh;
        public int Id, Module, ModuleIndex, Ready;

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        /// <param name="pAddresse"></param>
        /// <param name="pModule"></param>
        /// <param name="pIndex"></param>
        public Capteur(String pAddresse, int pModule, int pIndex)
        {
            Address = pAddresse;
            Module = pModule;
            ModuleIndex = pIndex;
            AlertLow = 0;
            AlertHigh = 0;
        }

        /// <summary>
        /// Constructeur complet
        /// </summary>
        /// <param name="pAddresse"></param>
        /// <param name="pModule"></param>
        /// <param name="pIndex"></param>
        /// <param name="pNom"></param>
        /// <param name="pGroupe"></param>
        /// <param name="pLow"></param>
        /// <param name="pHigh"></param>
        public Capteur(String pAddresse, int pModule, int pIndex, String pNom, String pGroupe, double pLow, double pHigh)
        {
            Address = pAddresse;
            Module = pModule;
            ModuleIndex = pIndex;
            Name = pNom;
            GroupCapteur = pGroupe;
            AlertLow = pLow;
            AlertHigh = pHigh;
        }

        /// <summary>
        /// Constructeur vide pour la db
        /// </summary>
        public Capteur() { }
        
    }
    
}
