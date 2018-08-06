using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    interface IEmployeeManager
    {
        void SaveEmployee(EmployeeData eData);
    }
}
