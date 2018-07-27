using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstDemo1
{
    public class MyContext : DbContext
    {
        public DbSet<StudentsInfo> StdInfo { get; set; }
        public DbSet<Courses> Cors { get; set; }
        public DbSet<Departments> Dept { get; set; }
        public DbSet<StudentCourses> StdCors { get; set; }
    }
}
