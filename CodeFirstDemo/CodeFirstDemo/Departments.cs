using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstDemo1
{
    public class Departments
    {
       
        [Key]
        public int DepartmentRefID { get; set; }
        public String DepartmentName { get; set;}
       
    }
}
