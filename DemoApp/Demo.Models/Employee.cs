using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    [DataContract]
    public class Employee
    {
        [DataMember]
        public int EmployeeId {get; set;}

        [DataMember]
        public string EmployeeName{get; set;}
        
        [DataMember]
		public string Designation{get; set;}
        
        [DataMember]
        public EmployeeType EmployeeType { get; set; }
        
        [DataMember]
		public int HourlyPay{get; set;}
        
        [DataMember]
		public int BonusRate{get; set;}
    }
}