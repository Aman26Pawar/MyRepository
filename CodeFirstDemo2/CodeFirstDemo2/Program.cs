using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentInfo stdinfo = new StudentInfo
            {
                StudentID = 1,
                StudentName = "Aman",
                BirthDate = Convert.ToDateTime("1997-01-26"),
                DepartmentID = 101,

            };

            Departments deptt = new Departments
            {
                DepartmentID = 101,
                DepartmentName = "Computer"
            };

            Courses corss = new Courses
            {
                CourseID = 01,
                CourseName = "Cyber Security"
            };

            StudentCourses stdcorss = new StudentCourses
            {
                RecordID = 1,
                CourseID = 01,
                StudentID = 1
            };

            CodeFirstModel2 cf = new CodeFirstModel2();
            cf.StdInf.Add(stdinfo);
            cf.Dept.Add(deptt);
            cf.Cors.Add(corss);
            cf.StdCors.Add(stdcorss);

            cf.SaveChanges();
        }
    }
}
