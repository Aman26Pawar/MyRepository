using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LoggingDemo
{
    class Program
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
       

        static void Main(string[] args)
        {
             XmlConfigurator.Configure();   //create proper log file
               _log.Info("this is info");
               _log.Debug("This is Debug");
               _log.Warn("This is warning");
               _log.Error("This is error");
               _log.Fatal("This is Fatal msg");

            // call from Custom class
               CustomClass.LogMessage();
          
            //call to static method of this class
            crtfil();
        }

        private static void crtfil()
        {   
            Console.WriteLine("Enter the name of the file:");
            String fnm = Console.ReadLine();

            try
            {

                if (File.Exists(fnm))
                {
                    File.Delete(fnm);
                }



                using (FileStream fs = File.Create(fnm))
                {

                    Byte[] title = new UTF8Encoding(true).GetBytes("New Text File");
                    fs.Write(title, 0, title.Length);
                    byte[] author = new UTF8Encoding(true).GetBytes("Aman");
                    fs.Write(author, 0, author.Length);
                }

                using (StreamReader sr = File.OpenText(fnm))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }

            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }  

        }

  }
}

