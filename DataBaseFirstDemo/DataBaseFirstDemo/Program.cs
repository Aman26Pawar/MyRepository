using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseFirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new CompanyDBEntities())
            {
                // Create new employee data in Empployee table
                Console.WriteLine("Enter the name of the new Employee:");
                var Empname = Console.ReadLine();

                var emp = new Employee {EmpNm =Empname };
                db.Employees.Add(emp);
                db.SaveChanges();

                var query = from e in db.Employees orderby e.EmpID select e;
                Console.WriteLine("All Employess in the Employee table :");

                foreach (var item in query)
                {

                    Console.WriteLine(item.EmpID+" "+item.EmpNm );
                }
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
