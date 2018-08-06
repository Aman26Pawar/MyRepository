using BAL;
using log4net;
using log4net.Config;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeProject1
{
    public partial class DeleteForm : Form
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void DeleteEmployeeData_Click(object sender, EventArgs e)
        {
            
            EmployeeData eData = new EmployeeData();
            eData._EmployeeID = Convert.ToInt32(txtDelID.Text);

            EmployeeManager eMan = new EmployeeManager();
            eMan.DeleteEmployee(eData);

            XmlConfigurator.Configure();   //create proper log file
            _log.Info("this is Info");
            _log.Debug("This is Debug");
            _log.Warn("This is warning");
            _log.Error("This is error");
            _log.Fatal("This is Fatal msg");

        }

      
    }
}
