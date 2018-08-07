using Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Repository.Contracts
{
    public interface IEmployeeQueryRepository
    {
        Employee GetEmployeeById(int EmployeeId);
        List<Employee> GetAllEmmployees();
    }
}
