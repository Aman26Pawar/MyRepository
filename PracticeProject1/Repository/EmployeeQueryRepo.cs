using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class EmployeeQueryRepo : IEmployeeQueryRepository
    {
        public DataTable ShowEmployee()
        {
            SqlDataReader reader1 =  Helper.ExecuteReader
                (
                    "sp_showEmployees",
                    System.Data.CommandType.StoredProcedure
                );

            DataTable dt = new DataTable();
            dt.Load(reader1);
            return dt;
        }
    }
}
