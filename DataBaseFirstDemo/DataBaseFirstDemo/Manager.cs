//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataBaseFirstDemo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Manager
    {
        public Manager()
        {
            this.Employees = new HashSet<Employee>();
            this.Projects = new HashSet<Project>();
        }
    
        public int ManagerID { get; set; }
        public string ManagerNm { get; set; }
    
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}
