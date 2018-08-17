using Repository.Commands;
using Repository.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Repository.Contracts;
using Repository.Commands;
using Repository.Query;
using Models;


namespace WCFService
{
    
    public class EmployeeManager : IEmployeeManagerService
    {
        private readonly IEmployeeCommandReposotory commandRepository = null;
        private readonly IEmployeeQueryRepository queryRepository = null;

        public EmployeeManager()
        {
            commandRepository = new EmployeeCommandRepository();
            queryRepository = new EmployeeQueryRepository();
        }

        public void SaveEmployee(Employee emp)
        {
            commandRepository.SaveEmployee(emp);
        }
        public void DeleteEmployee(Employee emp)
        {
            commandRepository.DeleteEmployee(emp);
        }

        public void UpdateEmployee(Employee emp)
        {
            commandRepository.UpdateEmployee(emp);
        }
        public List<Employee> ShowEmployee()
        {
            return queryRepository.ShowEmployee();
        }
    }
}
