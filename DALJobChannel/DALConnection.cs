using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALJobChannel
{
    /// <summary>
    /// Classe Connection
    /// </summary>
    public class DALConnection
    {
        private static DALConnection _Instance;

        private SqlConnection cn;

        private DALConnection()
        {
            try
            {
                cn = new SqlConnection();
                cn.ConnectionString = ConfigurationManager.ConnectionStrings["SQL"].ConnectionString;
                cn.Open();
            }
            catch (SqlException ex)
            {

                throw new DALException(Properties.Resources.ERROR_CONNECTION, ex);
            }
        }
    }
}
