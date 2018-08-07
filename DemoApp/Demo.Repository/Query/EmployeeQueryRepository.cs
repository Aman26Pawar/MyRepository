using Demo.Models;
using Demo.Repository.Contracts;
using Demo.Repository.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Repository.Query
{
    public class EmployeeQueryRepository : IEmployeeQueryRepository
    {
        public Models.Employee GetEmployeeById(int EmployeeId)
        {
            Employee emp = null;

            SqlDataReader reader = DatabaseHelper.ExecuteReader("spEmployee_GetById", System.Data.CommandType.StoredProcedure, new SqlParameter("@EmployeeId", EmployeeId));

            if(reader.Read())
            {
                emp = new Employee()
                {
                    EmployeeId = EmployeeId,
                    EmployeeName = reader["EmployeeName"].ToString(),
                    Designation = reader["Designation"].ToString(),
                
                    EmployeeType = new EmployeeType()
                    {
                        EmployeeTypeId = Convert.ToInt32(reader["EmployeeTypeId"].ToString()),
                        EmployeeTypeName = reader["EmployeeTypeName"].ToString()
                    },

                    BonusRate = Convert.ToInt32(reader["BonusRate"].ToString()),
                    HourlyPay = Convert.ToInt32(reader["HourlyPay"].ToString())
                };
            }

            reader.Close();

            return emp;
        }

        public List<Employee> GetAllEmmployees()
        {
            List<Employee> employees = new List<Employee>();

            SqlDataReader reader = DatabaseHelper.ExecuteReader("spEmployee_GetAll", System.Data.CommandType.StoredProcedure);

            while (reader.Read())
            {
                employees.Add(
                    new Employee()
                        {
                            EmployeeId = Convert.ToInt32(reader["EmployeeId"].ToString()),
                            EmployeeName = reader["EmployeeName"].ToString(),
                            Designation = reader["Designation"].ToString(),

                            EmployeeType = new EmployeeType()
                            {
                                EmployeeTypeId = Convert.ToInt32(reader["EmployeeTypeId"].ToString()),
                                EmployeeTypeName = reader["EmployeeTypeName"].ToString()
                            },

                            BonusRate = Convert.ToInt32(reader["BonusRate"].ToString()),
                            HourlyPay = Convert.ToInt32(reader["HourlyPay"].ToString())
                        }
                );
            }

            reader.Close();

            return employees;
        }
    }
}
