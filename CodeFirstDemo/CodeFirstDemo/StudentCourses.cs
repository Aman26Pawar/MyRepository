using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstDemo1
{
    public class StudentCourses
    {
        [Key]
        public int RecID { get; set; }
        [ForeignKey("StudentInfo")]
        public int StudentID { get; set; }
        public StudentsInfo StudentInfo { get; set; }
        
        [ForeignKey("Courses")]
        public int CourseID { get; set; }
        public Courses Courses { get; set; }
    }
}
