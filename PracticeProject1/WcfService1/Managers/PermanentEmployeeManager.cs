using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeServices.Managers
{
    public class PermanentEmployeeManager : IEmployeeManager
    {
        public int CalculateHourlySalary()
        {
          
            return 15;
        }

        public int CalculateBonusRate()
        {
           
            return 5;
        }
    }
}