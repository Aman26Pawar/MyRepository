using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DBApplication
{
    class Manager
    {
        static string cs = @"Data Source = .\SqlExpress; Initial Catalog = CompanyDB; Integrated Security =true;";
       
        public int ID { get; set; }
        public string Nm { get; set; }



        public static void PrintManager()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            Manager man;

            SqlCommand cmd = new SqlCommand("spShowManager", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                man = new Manager();

                man.ID = Convert.ToInt32(reader["ManagerID"].ToString());
                man.Nm = reader["ManagerNm"].ToString();

                Console.WriteLine("{0} \t {1}", man.ID, man.Nm);
            }
            reader.Close();
            con.Close();
        }

        public static void AddManager(Manager manager)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            SqlCommand cmd = new SqlCommand("spAddManager", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@ManagerNm", manager.Nm));

            cmd.ExecuteNonQuery();

            Console.WriteLine("record saved.........");
            con.Close();
        }

        public static void DelManager(int id)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            SqlCommand cmd = new SqlCommand("[dbo].[spDeleteManager]", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@ManagerID", id));
            cmd.ExecuteNonQuery();

            con.Close();
        }

        public static void UpdateManager(int id, String newnm)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();

            SqlCommand cmd = new SqlCommand("[dbo].[spUpdateManager]", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@MID", id));
            cmd.Parameters.Add(new SqlParameter("@MNm", newnm));

            cmd.ExecuteNonQuery();

            con.Close();

        }


    }
    
}
