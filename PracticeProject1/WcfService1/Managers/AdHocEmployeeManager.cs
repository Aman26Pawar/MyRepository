using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeServices.Managers
{
    public class AdHocEmployeeManager : IEmployeeManager
    {
        public int CalculateHourlySalary()
        {
            return 12;
        }
        public int CalculateBonusRate()
        {
            return 3;
        }
    }
}