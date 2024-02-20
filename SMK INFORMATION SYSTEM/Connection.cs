using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMK_INFORMATION_SYSTEM
{
    internal class Connection
    {
        public SqlConnection GetConn()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=PULUNG\\SQLEXPRESS;Initial Catalog=DATADICTIONARY;Integrated Security=True";
            return conn;
        }

        //public static SqlConnection conn = new SqlConnection("Data Source=PULUNG\\SQLEXPRESS;Initial Catalog=DATADICTIONARY;Integrated Security=True");
        //public static SqlCommand cmd = new SqlCommand("", conn);

        //public static Object exQuery(String query)
        //{
        //    try
        //    {
        //        conn.Open();
        //        cmd.CommandText = query;
        //        cmd.ExecuteNonQuery();
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        conn.Close();

        //    }
        //    return "Berhasil";
        //}

        //public static DataAdapter getQuery(String query)
        //{
        //    DataAdapter da = new DataAdapter();
        //    try
        //    {
        //        conn.Open();
        //        cmd.CommandText = query;
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        //da.Fill(ds);
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return da;
        //}
    }
}
