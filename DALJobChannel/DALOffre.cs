using BOJobChannel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALJobChannel
{
    public class DALOffre
    {
        public string Requete { get; set; }
        public Connection cn { get; set; }
        public List<Offre> Liste { get; set; }

        public DALOffre()
        {
            cn = new Connection();
            Liste = new List<Offre>();
        }
        public List<Offre> GetAllOffres()
        {
            Requete = "Select * from OFFRE order by ID_OFFRE";
            SqlCommand objSelectCommand = new SqlCommand(Requete);
            objSelectCommand.Connection = cn.cn;
            DataTable objDataTable = new DataTable();
            SqlDataAdapter objDataAdapter = new SqlDataAdapter(objSelectCommand);
            objDataAdapter.Fill(objDataTable);
            foreach (DataRow row in objDataTable.Rows)
            {
                Offre offre = new Offre();
                offre.IDOffre = Convert.ToInt32(row["ID_OFFRE"]);
                offre.IDRegion = Convert.ToInt32(row["ID_REGION"]);
                offre.IDTypeContrat = Convert.ToInt32(row["ID_TYPE_CONTRAT"]);
                offre.IDTypePoste = Convert.ToInt32(row["ID_TYPE_POSTE"]);
                offre.IDEntreprise = Convert.ToInt32(row["ID_ENTREPRISE"]);
                offre.TitreOffre = row["TITRE_OFFRE_EMPLOI"].ToString();
                offre.DescriptionOffre = row["DESCRIPTION_OFFRE"].ToString();
                offre.DateOffre = Convert.ToDateTime(row["DATE_OFFRE"]);
                offre.LienWeb = row["LIEN_WEB"].ToString();
                Liste.Add(offre);
            }
            return Liste;
        }
    }
}
