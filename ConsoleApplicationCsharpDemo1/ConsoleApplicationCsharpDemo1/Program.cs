using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ConsoleApplicationCsharpDemo1.Mathss;
namespace ConsoleApplicationCsharpDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, c;
            List<Employee> emp1 = new List<Employee>(){
                new Employee("aman", 1),
                new Employee("amar", 2),
                new Employee("aman", 3)
            };

            foreach (Employee e1 in emp1)
            {
                e1.showDetails();
            }

            List<college.StudentInfo> std1 = new List<college.StudentInfo>()
            {
                new college.StudentInfo("pravar", "MP"),
                new college.StudentInfo("aman", "Pune"),
                new college.StudentInfo("aangi", "Surat"),
                new college.StudentInfo("rohan", "Soalpur" ),
                new college.StudentInfo("shivam", "Pune"),
                new college.StudentInfo("suvisha", "Kerala"),
                new college.StudentInfo("shweta", "Nagar"),
            };

            foreach (college.StudentInfo cstd in std1)
            {
                cstd.showStudentInfo();
            }



            Mathss.Calculations cal = new Mathss.Calculations(5);
            cal.AreaCircum(5,out a, out c);


        }



        
        

        
    }
}
