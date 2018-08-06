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
    public partial class UpdateForm : Form
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void txtIDtoUpdate_Click(object sender, EventArgs e)
        {
            EmployeeData eData = new EmployeeData();
            eData._EmployeeID = Convert.ToInt32(txtEmpIDToUpdate.Text);
            eData._NewEmpNm = Convert.ToString(EnteredNameOfEmplyeeUpdate.Text);
            eData._NewDept = Convert.ToString(txtUpdatedDepartment.Text);
            if (UpdatedComboBox.Text == "Permanent")
            {
                eData._NewType = 1;
            }
            else if (UpdatedComboBox.Text == "AdHoc")
            {
                eData._NewType = 2;
            }

            EmployeeManager eMan = new EmployeeManager();
            eMan.UpdateEmployee(eData);


            XmlConfigurator.Configure();   //create proper log file
            _log.Info("this is Info");
            _log.Debug("This is Debug");
            _log.Warn("This is warning");
            _log.Error("This is error");
            _log.Fatal("This is Fatal msg");
        }

        private void Homepage_Click(object sender, EventArgs e)
        {
            HomePage hmpg = new HomePage();
            hmpg.Show();
        }
    }
}
