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
        private Singleton objSingleton;
        public string Requete { get; set; }
        public List<TypePoste> Liste { get; set; }

        public DALTypePoste()
        {
            Liste = new List<TypePoste>();
            objSingleton = Singleton.Instance();
        }
        public List<TypePoste> GetAllTypePostes()
        {
            Requete = "Select * from TYPE_POSTE order by NOM_TYPE_POSTE";
            SqlCommand objSelectCommand = new SqlCommand(Requete);
            DataTable objDataTable = objSingleton.ExecuteDataTable(objSelectCommand);
            foreach (DataRow row in objDataTable.Rows)
            {
                TypePoste poste = new TypePoste();
                poste.IDTypePoste = Convert.ToInt32(row["ID_TYPE_POSTE"]);
                poste.NomPoste = row["NOM_TYPE_POSTE"].ToString();
                Liste.Add(poste);
            }
            return Liste;
        }
        public int AddPoste(string nom)
        {
            SqlCommand objSelectCommand = new SqlCommand();
            objSingleton.Open();
            objSelectCommand.CommandText = "dbo.AddPoste";
            objSelectCommand.CommandType = CommandType.StoredProcedure;
            objSelectCommand.Parameters.AddWithValue("@NOM_TYPE_POSTE", nom);
            int nbLignes = objSingleton.ExecuteNonQuery(objSelectCommand);
            objSingleton.Close();
            return nbLignes;
        }
    }
}
