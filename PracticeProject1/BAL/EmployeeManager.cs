using Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class EmployeeManager : IEmployeeManager
    {
        private readonly IEmployeeCommandRepository commandRepo = null;
        private readonly IEmployeeQueryRepository queryRepo = null;

        public EmployeeManager()
        {
            commandRepo = new EmployeeCommandRepo();
            queryRepo = new EmployeeQueryRepo();          
        }





        public void SaveEmployee(EmployeeData eData)
        {
            if (eData._NewType == 1)
            {
             
                PermanentEmployeeSalary pes = new PermanentEmployeeSalary();
                eData._NewBonusRate = pes.CalculateBonusRate();
                eData._NewHourlydSal = pes.CalculateHourlySalary();
            }
            else if (eData._NewType == 2)
            {
                AdHocEmployeeSalary aes = new AdHocEmployeeSalary();
                eData._NewBonusRate = aes.CalculateBonusRate();
                eData._NewHourlydSal = aes.CalculateHourlySalary();
            }

            commandRepo.SaveEmployee(eData);
        }



        public void DeleteEmployee(EmployeeData eData)
        {
            commandRepo.DeleteEmployee(eData);
        }



        public void UpdateEmployee(EmployeeData eData)
        {
            if (eData._NewType == 1)
            {
                PermanentEmployeeSalary pes = new PermanentEmployeeSalary();
                eData._NewBonusRate = pes.CalculateBonusRate();
                eData._NewHourlydSal = pes.CalculateHourlySalary();
            }
            else if (eData._NewType == 2)
            {
                AdHocEmployeeSalary aes = new AdHocEmployeeSalary();
                eData._NewBonusRate = aes.CalculateBonusRate();
                eData._NewHourlydSal = aes.CalculateHourlySalary();
            }

            commandRepo.UpdateEmployee(eData);
        }




        public DataTable DisplayTable()
        {
            DataTable dispEmpTable = queryRepo.ShowEmployee();
            return dispEmpTable;
        }


  

       
    }
}
