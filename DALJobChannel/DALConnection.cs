using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DALJobChannel
{
    ///// <summary>
    ///// Classe Connection
    ///// </summary>
    //public class DALConnection
    //{
    //    private static DALConnection _Instance;

    //    private SqlConnection cn;

    //    private DALConnection()
    //    {
    //        try
    //        {
    //            cn = new SqlConnection();
    //            cn.ConnectionString = ConfigurationManager.ConnectionStrings["SQL"].ConnectionString;
    //            cn.Open();
    //        }
    //        catch (SqlException ex)
    //        {

    //            throw new DALException(Properties.Resources.ERROR_CONNECTION, ex);
    //        }
    //    }

    //    public static DALConnection GetInstance()
    //    {
    //        if (_Instance == null)
    //            _Instance = new DALConnection();
    //        return _Instance;
    //    }
    //    private SqlConnection GetConnection()
    //    {
    //        return cn;
    //    }
    //    public DataTable ExecuteDataTable(SqlCommand objSelectCommand)
    //    {
    //        try
    //        {
    //            DataTable objDataTable = new DataTable();
    //            objSelectCommand.Connection = GetConnection();
    //            SqlDataAdapter objDataAdapter = new SqlDataAdapter(objSelectCommand);
    //            objDataAdapter.Fill(objDataTable);
    //            return objDataTable;
    //        }
    //        catch (SqlException ex)
    //        {
    //            throw new DALException(Properties.Resources.ERROR_CONNECTION, ex);
    //        }
    //    }
    //    public int ExecuteNonQuery(SqlCommand objUpdateCommand)
    //    {
    //        SqlConnection cn = GetConnection();
    //        objUpdateCommand.Connection = cn;
    //        return objUpdateCommand.ExecuteNonQuery();
    //    }
    //    public void Close()
    //    {
    //        cn.Close();
    //    }
    /// <summary>
    /// classe outil Connection
    /// </summary>
    public class Connection
    {
        /// <summary>
        /// Propriété SqlConnection cn
        /// </summary>
        //public SqlConnection cn;

        /// <summary>
        /// Constructeur de connexion BDD
        /// </summary>
        //public Connection()
        //{
        //    try
        //    {
        //        cn = new SqlConnection();
        //        cn.ConnectionString = "Data Source=176.31.248.137;Initial Catalog=user18;Persist Security Info=True;User ID=user18;Password=711user18";
        //        cn.Open();
        //    }
        //    catch (Exception)
        //    {

        //        MessageBox.Show("Connection BDD");
        //    }
        //}
    }
}
