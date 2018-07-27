using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstDemo1
{
    public class Courses
    {
       
        [Key]
        public int CourseID { get; set; }
        public String CourseName { get; set; }
    }
}
