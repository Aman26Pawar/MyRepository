using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Repository
{
    public class Helper
    {
        private static SqlConnection _connection = null;
        private static string cs;

        private Helper()
        {
            
        }
    }
}
