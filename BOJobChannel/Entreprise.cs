using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOJobChannel
{
    /// <summary>
    /// Classe métier Entreprise
    /// </summary>
    public class Entreprise
    {
        #region "Propriétés et accesseurs"
        /// <summary>
        /// ID Entreprise
        /// </summary>
        public int IDEntreprise { get; set; }
        /// <summary>
        /// Nom Entreprise
        /// </summary>
        public string NomEntreprise { get; set; }
        /// <summary>
        /// Contact Entreprise
        /// </summary>
        public string ContactEntreprise { get; set; }
        /// <summary>
        /// Telephone Contact
        /// </summary>
        public int NumeroEntreprise { get; set; }
        #endregion
        #region "Constructeurs"
        /// <summary>
        /// Constructeur vide
        /// </summary>
        public Entreprise()
        {

        }
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Entreprise(int idEntreprise, string nomEntreprise, string contactEntreprise, int numeroEntreprise)
        {
            this.IDEntreprise = idEntreprise;
            this.NomEntreprise = nomEntreprise;
            this.ContactEntreprise = contactEntreprise;
            this.NumeroEntreprise = numeroEntreprise;
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
