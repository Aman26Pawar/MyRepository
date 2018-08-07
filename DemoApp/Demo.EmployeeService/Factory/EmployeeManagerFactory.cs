using Demo.EmployeeService.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.EmployeeService.Factory
{
    public class EmployeeManagerFactory
    {
        public IEmployeeManager GetManager(int employeeTypeId)
        {
            IEmployeeManager manager = null;

            if (employeeTypeId == 1)
                manager = new PermanentEmployeeManager();
            else if (employeeTypeId == 2)
                manager = new ContractEmployeeManager();

            return manager;
        }
    }
}