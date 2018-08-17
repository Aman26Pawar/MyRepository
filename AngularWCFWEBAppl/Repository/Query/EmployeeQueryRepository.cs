using Models;
using Repository.Contracts;
using Repository.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Query
{
    public class EmployeeQueryRepository : IEmployeeQueryRepository
    {
        public List<Employee> ShowEmployee()
        {
            SqlDataReader reader = DBHelper.ExecuteReader(
                                                             "spEmployees_GetAll", 
                                                             System.Data.CommandType.StoredProcedure    
                                                         );
            List<Employee> list = new List<Employee>();
            while (reader.Read())
            {
                list.Add(
                    new Employee()
                    {
                        ID = Convert.ToInt32(reader["EmployeeID"].ToString()),
                        Name = reader["EmployeeName"].ToString(),
                        Department = reader["Department"].ToString()
                    });
            }
            return list; 
        }
    }
}
