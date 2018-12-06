using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOJobChannel
{
    /// <summary>
    /// Classe métier Offre
    /// </summary>
    public class Offre
    {
        #region "Propriétés et accesseurs"
        /// <summary>
        /// ID Offre
        /// </summary>
        public int IDOffre { get; set; }
        /// <summary>
        /// Titre Offre Emploi
        /// </summary>
        public string TitreOffre { get; set; }
        /// <summary>
        /// Description offre
        /// </summary>
        public string DescriptionOffre { get; set; }
        /// <summary>
        /// Date offre
        /// </summary>
        public DateTime DateOffre { get; set; }
        /// <summary>
        /// Lien Web
        /// </summary>
        public string LienWeb { get; set; }
        #endregion
        #region "Constructeurs"
        /// <summary>
        /// Constructeur vide
        /// </summary>
        public Offre()
        {

        }
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        /// <param name="idOffre"></param>
        /// <param name="titreOffre"></param>
        /// <param name="descriptionOffre"></param>
        /// <param name="dateOffre"></param>
        /// <param name="lienWeb"></param>
        public Offre(int idOffre, string titreOffre, string descriptionOffre, DateTime dateOffre, string lienWeb)
        {
            this.IDOffre = idOffre;
            this.TitreOffre = titreOffre;
            this.DescriptionOffre = descriptionOffre;
            this.DateOffre = dateOffre;
            this.LienWeb = lienWeb;
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