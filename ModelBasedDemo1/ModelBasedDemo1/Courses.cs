//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelBasedDemo1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Courses
    {
        public Courses()
        {
            this.StudentInfoes = new HashSet<StudentInfo>();
        }
    
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int DepartmentsDepartmentId { get; set; }
        public int DepartmentsDepartmentId1 { get; set; }
        public int DepartmentsDepartmentId2 { get; set; }
    
        public virtual Departments Department { get; set; }
        public virtual ICollection<StudentInfo> StudentInfoes { get; set; }
    }
}
