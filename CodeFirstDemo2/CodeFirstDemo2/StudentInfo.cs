using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CodeFirstDemo2
{
    public class StudentInfo
    {
        [Key]
        public int StudentID { get; set; }
        public String StudentName { get; set; }
        public DateTime? BirthDate { get; set; }

        [ForeignKey("Departments")]
        public int DepartmentID { get; set; }
        public Departments Departments { get; set; }

    }
}
