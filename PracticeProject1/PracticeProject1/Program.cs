using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeProject1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        [STAThread]
        static void Main()
        {

            XmlConfigurator.Configure();   //create proper log file
            _log.Info("this is Info");
            _log.Debug("This is Debug");
            _log.Warn("This is warning");
            _log.Error("This is error");
            _log.Fatal("This is Fatal msg");



            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HomePage());
        }
    }
}
