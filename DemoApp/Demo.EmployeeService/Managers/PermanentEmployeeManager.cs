using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.EmployeeService.Managers
{
    public class PermanentEmployeeManager : IEmployeeManager
    {
        public int GetBonus()
        {
            return 5;
        }

        public int GetHourlyPay()
        {
            return 15;   
        }
    }
}