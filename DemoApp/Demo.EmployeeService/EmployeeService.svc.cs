using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Demo.Repository.Query;
using Demo.Repository.Contracts;
using Demo.Repository.Command;
using Demo.EmployeeService.Factory;
using Demo.EmployeeService.Managers;

namespace Demo.EmployeeService
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeQueryRepository queryRepository = null;
        private readonly IEmployeeCommandRepository commandRepository = null;

        public EmployeeService()
        {
            queryRepository = new EmployeeQueryRepository();
            commandRepository = new EmployeeCommandRepository();
        }

        public Models.Employee GetEmployeeById(int employeeId)
        {
            return queryRepository.GetEmployeeById(employeeId);
        }

        public int SaveEmployee(Models.Employee employee)
        {
            EmployeeManagerFactory factory = new EmployeeManagerFactory();
            IEmployeeManager manager = factory.GetManager(employee.EmployeeType.EmployeeTypeId);

            employee.HourlyPay = manager.GetHourlyPay();
            employee.BonusRate = manager.GetBonus();

            return commandRepository.SaveEmployee(employee);
        }

        public void DeleteEmployee(int id)
        {
            commandRepository.DeleteEmployee(id);
        }

        public List<Models.Employee> GetAllEmployees()
        {
            return queryRepository.GetAllEmmployees();
        }
    }
}