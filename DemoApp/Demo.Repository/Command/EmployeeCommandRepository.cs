using Demo.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Repository.Helpers;
using System.Data.SqlClient;

namespace Demo.Repository.Command
{
    public class EmployeeCommandRepository : IEmployeeCommandRepository
    {
        public int SaveEmployee(Models.Employee emp)
        {
            return Convert.ToInt32(DatabaseHelper.ExecuteScalar
                (
                    "spEmployee_Insert",
                    System.Data.CommandType.StoredProcedure,
                    new SqlParameter("@EmployeeName", emp.EmployeeName),
                    new SqlParameter("@Designation", emp.Designation),
                    new SqlParameter("@EmployeeTypeId", emp.EmployeeType.EmployeeTypeId),
                    new SqlParameter("@HourlyPay", emp.HourlyPay),
                    new SqlParameter("@BonusRate", emp.BonusRate)
                ));           
        }

        public void DeleteEmployee(int id)
        {
            DatabaseHelper.ExecuteScalar
                (
                    "spEmployee_DeleteById",
                    System.Data.CommandType.StoredProcedure,
                    new SqlParameter("@EmployeeId", id)
                );
        }
    }
}