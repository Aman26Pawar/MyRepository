using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Models
{
   [DataContract]
    public class EmployeeData
    {
       [DataMember]
        public int _EmployeeID { get; set; }
        
       [DataMember] 
        public string _NewEmpNm { get; set; }

        [DataMember]
        public string _NewDept { get; set; }

        [DataMember]
         public int _NewType { get; set; }

        [DataMember]
         public int _NewHourlydSal { get; set; }

        [DataMember]
         public int _NewBonusRate { get; set; }
    }
}
