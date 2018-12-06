using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOJobChannel
{
    /// <summary>
    /// Classe métier Departement
    /// </summary>
    public class Type_Poste
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
        /// Constructeur par défaut
        /// </summary>
        public Type_Poste()
        {

        }

        /// <summary>
        /// Constructeur complet
        /// </summary>
        /// <param name="idPoste"></param>
        /// <param name="nomPoste"></param>
        public Type_Poste(int idPoste, string nomPoste)
        {
            this.IDTypePoste = idPoste;
            this.NomPoste = nomPoste;
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
