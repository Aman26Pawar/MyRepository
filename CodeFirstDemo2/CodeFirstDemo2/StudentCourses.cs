using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo2
{
    public class StudentCourses
    {
        [Key]
        public int RecordID { get; set; }

        [ForeignKey("StudentInfo")]
        public int StudentID { get; set; }
        public StudentInfo StudentInfo { get; set;}

        [ForeignKey("Courses")]
        public int CourseID { get; set;}
        public Courses Courses { get; set;}
    }
}
