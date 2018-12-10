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
    public class DALEntreprise
    {
        public string Requete { get; set; }
        public Connection cn { get; set; }
        public List<Entreprise> Liste { get; set; }

        public DALEntreprise()
        {
            cn = new Connection();
            Liste = new List<Entreprise>();
        }

        public List<Entreprise> GetAllEntreprises()
        {
            Requete = "Select * from REGION order by NOM_REGION";
            SqlCommand objSelectCommand = new SqlCommand(Requete);
            objSelectCommand.Connection = cn.cn;
            DataTable objDataTable = new DataTable();
            SqlDataAdapter objDataAdapter = new SqlDataAdapter(objSelectCommand);
            objDataAdapter.Fill(objDataTable);
            foreach (DataRow row in objDataTable.Rows)
            {
                Entreprise entreprise = new Entreprise();
                entreprise.IDEntreprise = Convert.ToInt32(row["ID_ENTREPRISE"]);
                entreprise.NomEntreprise = row["NOM_ENTREPRISE"].ToString();
                entreprise.ContactEntreprise = row["CONTACT_ENTREPRISE"].ToString();
                entreprise.TelephoneContact = Convert.ToInt32(row["TELEPHONE_CONTACT"]);
                Liste.Add(entreprise);
            }
            return Liste;
        }

        public int UpdateEntreprise(int numero, string nom)
        {
            SqlCommand objSelectCommand = new SqlCommand();
            objSelectCommand.Connection = cn.cn;
            objSelectCommand.CommandText = "dbo.UpdateEntreprise";
            objSelectCommand.CommandType = CommandType.StoredProcedure;
            objSelectCommand.Parameters.AddWithValue("@ID_ENTREPRISE", numero);
            objSelectCommand.Parameters.AddWithValue("@CONTACT_ENTREPRISE", nom);
            int nbLignes = objSelectCommand.ExecuteNonQuery();
            DataTable objDataTable = new DataTable();
            SqlDataAdapter objDataAdapter = new SqlDataAdapter(objSelectCommand);
            objDataAdapter.Fill(objDataTable);
            foreach (DataRow row in objDataTable.Rows)
            {
                Entreprise entreprise = new Entreprise();
                entreprise.IDEntreprise = Convert.ToInt32(row["ID_ENTREPRISE"]);
                entreprise.NomEntreprise = row["NOM_ENTREPRISE"].ToString();
                entreprise.ContactEntreprise = row["CONTACT_ENTREPRISE"].ToString();
                entreprise.TelephoneContact = Convert.ToInt32(row["TELEPHONE_CONTACT"]);
                Liste.Add(entreprise);
            }
            return nbLignes;
        }
    }
}
