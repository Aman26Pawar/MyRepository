using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace DBApplication
{
    
    class Program
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);   
        static void Main(string[] args)
        {
            XmlConfigurator.Configure();
            _log.Info("this is info");
            _log.Debug("This is Debug");
            _log.Warn("This is warning");
            _log.Error("This is error");
            _log.Fatal("This is Fatal msg");
            
            int ch;

            do
            {
                Console.WriteLine("Main menu:");
                Console.WriteLine("1. Print manager data");
                Console.WriteLine("2. Insert manager data");
                Console.WriteLine("3. Delete manager data");
                Console.WriteLine("4. Update manager data");
                Console.WriteLine("5. Exit");

                Console.WriteLine("Enter the operation");

                ch = Convert.ToInt32(Console.ReadLine());
                   switch(ch)
                {
                    case 1:
                        Manager.PrintManager();
                        Console.ReadLine();
                        break;

                    case 2:
                        Manager man = new Manager();

                        Console.WriteLine("Enter the name of the manager");
                       man.Nm = Console.ReadLine();

                        Manager.AddManager(man);
                        break;

                    case 3:
                        int id;
                                   Console.WriteLine("Enter manager Id to Delete: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        Manager.DelManager(id);
                        break;

                    case 4:
                        String changedNm;
                        Console.WriteLine("Enter manager Id to Update  manager data: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter manager name to Update  manager data: ");
                       changedNm = Console.ReadLine();
                       Manager.UpdateManager(id, changedNm);
                        break;
               }

           } while (ch != 5);
           
        }

       
    }
    
}
