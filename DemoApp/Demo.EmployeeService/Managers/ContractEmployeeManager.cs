using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.EmployeeService.Managers
{
    public class ContractEmployeeManager : IEmployeeManager
    {
        public int GetBonus()
        {
            return 3;
        }

        public int GetHourlyPay()
        {
            return 12;
        }
    }
}