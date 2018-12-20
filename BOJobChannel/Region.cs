using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOJobChannel
{
    /// <summary>
    /// Classe Région
    /// </summary>
    public class Region
    {
        #region "Propriétés et accesseurs"
        /// <summary>
        /// ID Région
        /// </summary>
        public int IDRegion { get; set; }
        /// <summary>
        /// Nom Région
        /// </summary>
        public string NomRegion { get; set; }
        #endregion
        #region "Constructeurs"
        /// <summary>
        /// Constructeur vide
        /// </summary>
        public Region()
        {

        }
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        /// <param name="idRegion"></param>
        /// <param name="nomRegion"></param>
        public Region(int idRegion, string nomRegion)
        {
            this.IDRegion = idRegion;
            this.NomRegion = nomRegion;
        }
        #endregion
        #region "Methodes"
        #endregion
        #region "Methodes héritées et substituées"

        public override string ToString()
        {
            return NomRegion;
        }
        #endregion
        #region "Methodes à implementer pour les interfaces"
        #endregion

    }
}
