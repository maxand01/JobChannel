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
    public class DALTypePoste
    {
        public string Requete { get; set; }
        public Connection cn { get; set; }
        public List<TypePoste> Liste { get; set; }

        public DALTypePoste()
        {
            cn = new Connection();
            Liste = new List<TypePoste>();
        }
        public List<TypePoste> GetAllTypePoste()
        {
            Requete = "Select * from TYPE_POSTE order by NOM_TYPE_POSTE";
            SqlCommand objSelectCommand = new SqlCommand(Requete);
            objSelectCommand.Connection = cn.cn;
            DataTable objDataTable = new DataTable();
            SqlDataAdapter objDataAdapter = new SqlDataAdapter(objSelectCommand);
            objDataAdapter.Fill(objDataTable);
            foreach (DataRow row in objDataTable.Rows)
            {
                TypePoste poste = new TypePoste();
                poste.IDTypePoste = Convert.ToInt32(row["ID_TYPE_POSTE"]);
                poste.NomPoste = row["NOM_TYPE_POSTE"].ToString();
                Liste.Add(poste);
            }
            return Liste;
        }        
    }
}
