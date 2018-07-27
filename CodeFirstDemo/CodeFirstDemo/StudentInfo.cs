using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstDemo1
{
    public class StudentsInfo
    {
        public StudentsInfo()
        {

        }

        [Key]
        public int StudentID {get; set;}
        public String StudentName{get; set;}
        public DateTime? BirthDate{get; set;}
        
        [ForeignKey("Departments")]
        public int DepartmentRefID { get; set; }
        public Departments Departments { get; set; }
        
 
        
    }
}
