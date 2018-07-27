namespace CodeFirstDemo2
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CodeFirstModel2 : DbContext
    {
        public CodeFirstModel2()
            : base("name=CodeFirst2")
        {

        }
            public DbSet<StudentInfo> StdInf { get; set; }
            public DbSet<Departments> Dept { get; set; }
            public DbSet<Courses> Cors { get; set; }
            public DbSet<StudentCourses> StdCors { get; set; }
        


       protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

    }
}
