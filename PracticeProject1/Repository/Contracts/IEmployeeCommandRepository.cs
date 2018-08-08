using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace Repository.Contracts
{
    public interface IEmployeeCommandRepository
    {
        void SaveEmployee(EmployeeData eData);
        void DeleteEmployee(EmployeeData eData);
        void UpdateEmployee(EmployeeData eData);
    }
}
