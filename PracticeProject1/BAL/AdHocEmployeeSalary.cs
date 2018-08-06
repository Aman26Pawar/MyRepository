using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    class AdHocEmployeeSalary : IEmployeeSalaryManager
    {
        public int HourlySal { get; set; }
        public int BonusRate { get; set; }
     
        public int CalculateHourlySalary()
        {
            HourlySal = 12;
            return HourlySal;
        }
        public int CalculateBonusRate()
        {
            BonusRate = 3;
            return BonusRate;
        }
    }
}
