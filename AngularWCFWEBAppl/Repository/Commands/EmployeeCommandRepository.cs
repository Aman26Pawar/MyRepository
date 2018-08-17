using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Contracts;
using Models;
using System.Data.SqlClient;
using Repository.Helpers;
namespace Repository.Commands
{
    public class EmployeeCommandRepository : IEmployeeCommandReposotory
    {
        public void SaveEmployee(Employee eData)
        {
            DBHelper.ExecuteNonQuery
                (
                "sp_AddEmployee",
                System.Data.CommandType.StoredProcedure,
                new SqlParameter("@EmployeeName", eData.Name),
                new SqlParameter("@Department", eData.Department)
                );

            Console.WriteLine("Employee Added Successfully............");
        }

        public void DeleteEmployee(Employee eData)
        {
            DBHelper.ExecuteNonQuery
               (
               "sp_DeleteEmployee",
               System.Data.CommandType.StoredProcedure,
               new SqlParameter("@EmployeeID", eData.ID)
               );
            Console.WriteLine("Employee Deleted Successfully............");
        }




        public void UpdateEmployee(Employee eData)
        {
            DBHelper.ExecuteNonQuery
                (
                    "sp_UpdateEmployee",
                     System.Data.CommandType.StoredProcedure,
                     new SqlParameter("@EmployeeID", eData.ID),
                    new SqlParameter("@EmployeeName", eData.Name),
                    new SqlParameter("@Department", eData.Department)
                );
        }
    }
}
