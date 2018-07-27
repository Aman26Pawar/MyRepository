using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationCsharpDemo1.college
{
    class StudentInfo
    {
        private string _stdname;
        private string _course;
        static String department;

        static StudentInfo()
        {
            department = "Computer";
        }


        public StudentInfo(String snm, String crse)
        {
            _stdname = snm;
            _course = crse;
        }
        public string stdname
        {
            set
            {
                _stdname = value;
            }
            get
            {
                return _stdname;
            }
        }

        public string course
        {
            set
            {
                _course = value;
            }
            get
            {
                return _course;
            }
        }

        public void showStudentInfo()
        {
            Console.WriteLine("Student name: {0} \n Student address: {1} \n Department {2} :", stdname,course,department);
        }
    }
}
