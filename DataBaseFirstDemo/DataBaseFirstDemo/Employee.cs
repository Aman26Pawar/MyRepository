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
    
    public partial class Employee
    {
        public int EmpID { get; set; }
        public string EmpNm { get; set; }
        public string Designation { get; set; }
        public Nullable<int> ProjectID { get; set; }
        public Nullable<int> ManagerID { get; set; }
        public int AdressID { get; set; }
        public int DepartmentID { get; set; }
        public int Salary { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
    
        public virtual AdressTable AdressTable { get; set; }
        public virtual Department Department { get; set; }
        public virtual Manager Manager { get; set; }
        public virtual Project Project { get; set; }
    }
}
