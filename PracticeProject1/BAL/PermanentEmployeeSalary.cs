using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    class PermanentEmployeeSalary : IEmployeeSalaryManager
    {
        public int HourlySal { get; set; }
        public int BonusRate { get; set; }

        public int CalculateHourlySalary()
        {
            HourlySal = 15;
            return HourlySal;
        }

        public int CalculateBonusRate()
        {
            BonusRate = 5;
            return BonusRate;
        }
    }
}
