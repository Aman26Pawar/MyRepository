using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace Repository.Contracts
{
    public interface IEmployeeCommandReposotory
    {
        void SaveEmployee(Employee emp);
        void DeleteEmployee(Employee emp);
        void UpdateEmployee(Employee emp);
    }
}
