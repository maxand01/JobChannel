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
    public class DALRegion
    {
        public string Requete { get; set; }
        public List<Region> Liste { get; set; }

        private Singleton objSingleton;

        public DALRegion()
        {
            Liste = new List<Region>();
            objSingleton = Singleton.Instance();

        }

        public List<Region> GetAllRegions()
        {
            Requete = "Select * from REGION order by NOM_REGION";
            SqlCommand objSelectCommand = new SqlCommand(Requete);
            DataTable objDataTable = objSingleton.ExecuteDataTable(objSelectCommand);
            foreach (DataRow row in objDataTable.Rows)
            {
                Region region = new Region();
                region.IDRegion = Convert.ToInt32(row["ID_REGION"]);
                region.NomRegion = row["NOM_REGION"].ToString();
                Liste.Add(region);
            }
            return Liste;
        }
    }
}
