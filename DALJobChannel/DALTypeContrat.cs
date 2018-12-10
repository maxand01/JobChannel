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
    class DALTypeContrat
    {
        public string Requete { get; set; }
        public Connection cn { get; set; }
        public List<TypeContrat> Liste { get; set; }

        public DALTypeContrat()
        {
            cn = new Connection();
            Liste = new List<TypeContrat>();
        }
        public List<TypeContrat> GetAllTypePoste()
        {
            Requete = "Select * from TYPE_CONTRAT order by NOM_TYPE_CONTRAT";
            SqlCommand objSelectCommand = new SqlCommand(Requete);
            objSelectCommand.Connection = cn.cn;
            DataTable objDataTable = new DataTable();
            SqlDataAdapter objDataAdapter = new SqlDataAdapter(objSelectCommand);
            objDataAdapter.Fill(objDataTable);
            foreach (DataRow row in objDataTable.Rows)
            {
                TypeContrat contrat = new TypeContrat();
                contrat.IDTypeContrat = Convert.ToInt32(row["ID_TYPE_CONTRAT"]);
                contrat.NomTypeContrat = row["NOM_TYPE_CONTRAT"].ToString();
                Liste.Add(contrat);
            }
            return Liste;
        }
    }
}
