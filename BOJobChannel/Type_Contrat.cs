using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOJobChannel
{
    /// <summary>
    /// Classe métier Type Contrat
    /// </summary>
    public class Type_Contrat
    {
        #region "Propriétés et accesseurs"
        /// <summary>
        /// ID Type Contrat
        /// </summary>
        public int IDTypeContrat { get; set; }

        /// <summary>
        /// Nom Type Contrat
        /// </summary>
        public string NomTypeContrat { get; set; }

        #endregion
        #region "Constructeurs"

        /// <summary>
        /// Constructeur a vide
        /// </summary>
        public Type_Contrat()
        {

        }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        /// <param name="idTypeContrat"></param>
        /// <param name="nomTypeContrat"></param>
        public Type_Contrat(int idTypeContrat, string nomTypeContrat)
        {
            this.IDTypeContrat = idTypeContrat;
            this.NomTypeContrat = nomTypeContrat;
        }

        #endregion
        #region "Methodes"
        #endregion
        #region "Methodes héritées et substituées"
        #endregion
        #region "Methodes à implementer pour les interfaces"
        #endregion

    }
}
