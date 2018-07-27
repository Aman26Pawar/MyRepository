using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationCsharpDemo1
{
    class Employee
    {
        private string _empname;
        private int _id;

        public Employee(String name, int Eid)
        {
            _empname = name;
            _id = Eid;
        }

        public int id
        {
            set
            {
                _id = value;
            }
            get
            {
                return _id;
            }
        }

        public string empname
        {
            set
            {
                _empname = value;
            }
            get
            {
                return _empname;
            }
        }
        public void showDetails()
        {
            Console.WriteLine("Employee name :{0} \nId :{1}",empname,id);
        }

        
    }
}
