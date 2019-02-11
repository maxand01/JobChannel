using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALJobChannel
{
    public sealed class Singleton
    {
        private static volatile Singleton instance;
        private static object syncRoot = new object();
        public SqlConnection cn;
        private Singleton()
        {
            try
            {
                cn = new SqlConnection();
                cn.ConnectionString = "Data Source=176.31.248.137;Initial Catalog=user18;Persist Security Info=True;User ID=user18;Password=711user18";
            }
            catch (SqlException ex)
            {

                throw new DALException("Pb de connexion", ex);
                
            }
        }

        public static Singleton Instance()
        {               
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }
                return instance;            
        }

        private SqlConnection GetConnection()
        {
            //Pour lire la chaine de connexion dans le fichier Web.config
            //Le projet a besoin d'une référence sur System.Configuration

            //En mode déconnecté, le système ouvre la connexion, si elle n'est pas ouverte 
            return cn;
        }        

        public DataTable ExecuteDataTable(SqlCommand objSelectCommand)
        {
            try
            {
                DataTable objDataTable = new DataTable();
                objSelectCommand.Connection = GetConnection();
                SqlDataAdapter objDataAdapter = new SqlDataAdapter(objSelectCommand);
                objDataAdapter.Fill(objDataTable);
                return objDataTable;
            }
            catch (SqlException ex)
            {
                throw new DALException("Pb de connexion", ex);
            }
        }

        public int ExecuteNonQuery(SqlCommand objUpdateCommand)
        {
            SqlConnection cn = GetConnection();
            objUpdateCommand.Connection = cn;
            return objUpdateCommand.ExecuteNonQuery();
        }

        public void Close()
        {
            cn.Close();
        }

        public void Open()
        {
            cn.Open();
        }
    }
}
