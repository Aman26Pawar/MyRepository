using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentsInfo stdin = new StudentsInfo
            {

                StudentID = 2,
                StudentName = "Amar",
                BirthDate = Convert.ToDateTime("1996-08-24"),
                DepartmentRefID = 1
            };


            Departments deptt = new Departments
            {
                DepartmentRefID = 1,
                DepartmentName = "Computer"
            };

            Courses course = new Courses
            {
                CourseID = 102,
                CourseName = "Cyber Security"
            };

            StudentCourses stdcourse = new StudentCourses
            {
                RecID = 1,
                StudentID = 1,
                CourseID = 101
            };


            

            MyContext my = new MyContext();
            my.StdInfo.Add(stdin);
            my.Dept.Add(deptt);
            my.Cors.Add(course);
            my.StdCors.Add(stdcourse);
            
            my.SaveChanges();
        }
    }
}
