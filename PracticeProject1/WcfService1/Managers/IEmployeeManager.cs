using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeServices.Managers
{
    public interface IEmployeeManager
    {
        int CalculateHourlySalary();
        int CalculateBonusRate();
    }
}
