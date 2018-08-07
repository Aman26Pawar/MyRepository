using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Models;

namespace Demo.Repository.Contracts
{
    public interface IEmployeeCommandRepository
    {
        int SaveEmployee(Employee emp);
        void DeleteEmployee(int id);
    }
}