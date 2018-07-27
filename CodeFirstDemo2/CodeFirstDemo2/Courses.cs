using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo2
{
    public class Courses
    {
        [Key]
        public int CourseID { get; set; }
        public String CourseName { get; set; }
    }
}
