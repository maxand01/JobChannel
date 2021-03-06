﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOJobChannel
{
    /// <summary>
    /// Classe métier Departement
    /// </summary>
    public class TypePoste
    {

        #region "Propriétés et accesseurs"

        /// <summary>
        /// ID Type Poste
        /// </summary>
        public int IDTypePoste { get; set; }

        /// <summary>
        /// Nom Type poste
        /// </summary>
        public string NomPoste { get; set; }

        #endregion
        #region "Constructeurs"
        /// <summary>
        /// Constructeur vide
        /// </summary>
        public TypePoste()
        {

        }

        /// <summary>
        /// Constructeur par de défaut
        /// </summary>
        /// <param name="idPoste"></param>
        /// <param name="nomPoste"></param>
        public TypePoste(int idPoste, string nomPoste)
        {
            this.IDTypePoste = idPoste;
            this.NomPoste = nomPoste;
        }
        #endregion
        #region "Methodes"
        #endregion
        #region "Methodes héritées et substituées"

        public override string ToString()
        {
            return NomPoste;
        }

        #endregion
        #region "Methodes à implementer pour les interfaces"

        #endregion
    }
}
