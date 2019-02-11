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
    public class DALTypeContrat
    {
        public string Requete { get; set; }
        public List<TypeContrat> Liste { get; set; }

        private Singleton objSingleton;

        public DALTypeContrat()
        {
            Liste = new List<TypeContrat>();
            objSingleton = Singleton.Instance();
        }
        public List<TypeContrat> GetAllTypeContrats()
        {
            Requete = "Select * from TYPE_CONTRAT order by NOM_TYPE_CONTRAT";
            SqlCommand objSelectCommand = new SqlCommand(Requete);
            DataTable objDataTable = objSingleton.ExecuteDataTable(objSelectCommand);
            foreach (DataRow row in objDataTable.Rows)
            {
                TypeContrat contrat = new TypeContrat();
                contrat.IDTypeContrat = Convert.ToInt32(row["ID_TYPE_CONTRAT"]);
                contrat.NomTypeContrat =Convert.ToString( row["NOM_TYPE_CONTRAT"]);
                Liste.Add(contrat);
            }
            return Liste;
        }

        public int AddContrat(string nom)
        {
            SqlCommand objSelectCommand = new SqlCommand();
            objSingleton.Open();
            objSelectCommand.CommandText = "dbo.AddContrat";
            objSelectCommand.CommandType = CommandType.StoredProcedure;
            objSelectCommand.Parameters.AddWithValue("@NOM_TYPE_CONTRAT", nom);
            int nbLignes = objSingleton.ExecuteNonQuery(objSelectCommand);
            objSingleton.Close();
            return nbLignes;
        }
    }
}
