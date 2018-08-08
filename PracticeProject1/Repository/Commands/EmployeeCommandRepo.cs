using Models;
using Repository.Contracts;
using Repository.Helpers;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Commands
{
    public class EmployeeCommandRepo : IEmployeeCommandRepository
    {
        public void SaveEmployee(EmployeeData eData)
        {
          Helper.ExecuteNonQuery
              (
              "sp_AddEmployeeDetail",
              System.Data.CommandType.StoredProcedure, 
              new SqlParameter("@_EmpName",eData._NewEmpNm),
              new SqlParameter("@_DepartmentName",eData._NewDept),
              new SqlParameter("@_TypeID",eData._NewType),
              new SqlParameter("@_HourlySal",eData._NewHourlydSal),
              new SqlParameter("@_BonusRate",eData._NewBonusRate)
              );

          Console.WriteLine("Employee Added Successfully............");
        }

        public void DeleteEmployee(EmployeeData eData)
        {
            Helper.ExecuteNonQuery
               (
               "sp_deleteEmployee",
               System.Data.CommandType.StoredProcedure,
               new SqlParameter("@_EmpID", eData._EmployeeID)
               );
            Console.WriteLine("Employee Deleted Successfully............");
        }




        public void UpdateEmployee(EmployeeData eData)
        {
            Helper.ExecuteNonQuery
                (
                    "spUpdateEmployeeDetail",
                     System.Data.CommandType.StoredProcedure,
                    new SqlParameter("@_EmpID", eData._EmployeeID),
                    new SqlParameter("@_EmpNm", eData._NewEmpNm),
                    new SqlParameter("@_DepartmentName", eData._NewDept),
                    new SqlParameter("@_TypeID", eData._NewType),
                    new SqlParameter("@_HourlySal", eData._NewHourlydSal),
                    new SqlParameter("@_BonusRate", eData._NewBonusRate)
                );
        }


    }
}
