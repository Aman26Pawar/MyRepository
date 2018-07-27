using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo2
{
    public class Departments
    {
        [Key]
        public int DepartmentID { get; set; }
        public String DepartmentName { get; set; }
    }
}
