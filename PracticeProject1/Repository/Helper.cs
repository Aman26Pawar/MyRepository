using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Repository
{
    public static class Helper
    {
        private static SqlConnection con = null;
        private static string cs;
        

        private static SqlConnection Connection
        {
            
            get
            {
                //cs = ConfigurationManager.ConnectionStrings["EmpDB"].ToString();
                //con = new SqlConnection(cs);
                if (con == null)
                {
                    cs = ConfigurationManager.ConnectionStrings["EmpDB"].ToString();
                    con = new SqlConnection(cs);
                }

                if (con.State != System.Data.ConnectionState.Open)
                {
                    con.Open();
                }

                return con;
            }
        }

        public static SqlCommand GetCommand(string sql, System.Data.CommandType commandType, params SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.CommandType = commandType;
            foreach (SqlParameter p in parameters)
            {
                cmd.Parameters.Add(p);
            }

            return cmd;
        }

        public static int ExecuteNonQuery(string sql, System.Data.CommandType commandType, params SqlParameter[] parameters)
        {
            return GetCommand(sql, commandType, parameters).ExecuteNonQuery();
        }

        public static SqlDataReader ExecuteReader(string sql, System.Data.CommandType commandType, params SqlParameter[] parameters)
        {
            return GetCommand(sql, commandType, parameters).ExecuteReader();
        }
    }
}
