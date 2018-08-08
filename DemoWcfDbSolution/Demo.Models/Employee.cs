using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
   public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string Designation { get; set; }
        public EmployeeType EmployeeTypeID { get; set; }
        public int HourlySal { get; set; }
        public int BonusRate { get; set; }
    }
}
