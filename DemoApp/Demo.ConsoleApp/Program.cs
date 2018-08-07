using Demo.ConsoleApp.EmployeeService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeService.EmployeeServiceClient client = new EmployeeService.EmployeeServiceClient();
            List<Employee> employees = client.GetAllEmployees().ToList();

            foreach (Employee emp in employees)
            {
                Console.WriteLine("{0}, {1}, {2}", emp.EmployeeId, emp.EmployeeName, emp.Designation);
            }
        }
    }
}
