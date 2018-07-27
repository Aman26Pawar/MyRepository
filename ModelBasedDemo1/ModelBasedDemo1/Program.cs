using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelBasedDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ModelBasedModel1Container())
            {
                Departments.showDepartments();
                Console.Read();
            }
        }

       
    }
}
