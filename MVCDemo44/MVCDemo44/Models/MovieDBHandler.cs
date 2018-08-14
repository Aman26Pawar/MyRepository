using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVCDemo44.Models
{
    public class MovieDBHandler
    {
        private static SqlConnection con;
        private static string cs;
        private static SqlConnection Connection
        {
            get
            {
                if(con == null) 
                {
                        cs = ConfigurationManager.ConnectionStrings["MVCMovies"].ToString();
                        con = new SqlConnection(cs);
                }

                if (con.State != System.Data.ConnectionState.Open)
                {
                    con.Open();
                }

                return con;
            }
        }
        // **************** ADD NEW MOVIE *********************
        public void AddMovie(MovieInfo mmodel)
        {
           
            SqlCommand cmd = new SqlCommand("sp_AddMovie", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@MovieName", mmodel.MovieName));
            cmd.Parameters.Add(new SqlParameter("@Theatre", mmodel.Theatre));
            cmd.Parameters.Add(new SqlParameter("@Rate", mmodel.Rate));
            cmd.Parameters.Add(new SqlParameter("@ShowTime", mmodel.ShowTime));


            cmd.ExecuteNonQuery();



        }

        // ********** VIEW Movie DETAILS ********************
        public List<MovieInfo> GetMovie()
        {
            //connection();
            List<MovieInfo> Movielist = new List<MovieInfo>();

            SqlCommand cmd = new SqlCommand("sp_GetMovie", Connection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            //con.Open();
            sd.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                Movielist.Add(
                    new MovieInfo
                    {
                        MovieID = Convert.ToInt32(dr["MovieID"]),
                        MovieName = Convert.ToString(dr["MovieName"]),
                        Theatre = Convert.ToString(dr["Theatre"]),
                        Rate = Convert.ToDecimal(dr["Rate"]),
                        ShowTime = Convert.ToDateTime(dr["ShowTime"])
                    });
            }
            return Movielist;
        }

        // ***************** UPDATE MOvie DETAILS *********************
        public bool UpdateDetails(MovieInfo mmodel)
        {
            //connection();
            SqlCommand cmd = new SqlCommand("sp_UpdateMovie",Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MovieID", mmodel.MovieID);
            cmd.Parameters.AddWithValue("@MovieName", mmodel.MovieName);
            cmd.Parameters.AddWithValue("@Theatre", mmodel.Theatre);
            cmd.Parameters.AddWithValue("@Rate", mmodel.Rate);
            cmd.Parameters.AddWithValue("@ShowTime", mmodel.ShowTime);

            //con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }

        // ********************** DELETE STUDENT DETAILS *******************
        public bool DeleteMovie(int id)
        {
            //connection();
            SqlCommand cmd = new SqlCommand("sp_DeleteMovie", Connection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MovieID", id);

            //con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
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