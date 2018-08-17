using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Repository.Contracts;
using Models;

namespace WCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IEmployeeManagerService
    {
        [OperationContract]
        void SaveEmployee(Employee eData);
        [OperationContract]
        void DeleteEmployee(Employee eData);
        [OperationContract]
        void UpdateEmployee(Employee eData);
        [OperationContract]
        List<Employee> ShowEmployee();
  
    }
}
