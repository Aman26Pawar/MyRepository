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
    public partial class InsertForm : Form
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        public InsertForm()
        {
            InitializeComponent();
        }

        private void SaveEmployee_Click(object sender, EventArgs e)
        {
            EmployeeData Edata = new EmployeeData();
            Edata._NewEmpNm = Convert.ToString(txtEmployeeName.Text);
            Edata._NewDept = Convert.ToString(txtDepartment.Text);
            if(ComboBox1.Text == "Permanent")
            {
                Edata._NewType = 1;
            }
            else if (ComboBox1.Text == "AdHoc")
            {
                Edata._NewType = 2;
            }

            EmployeeManager empMan = new EmployeeManager();
            empMan.SaveEmployee(Edata);

            XmlConfigurator.Configure();   //create proper log file
            _log.Info("this is Info");
            _log.Debug("This is Debug");
            _log.Warn("This is warning");
            _log.Error("This is error");
            _log.Fatal("This is Fatal msg");
        }

        private void InsertForm_Load(object sender, EventArgs e)
        {

        }

    }
}
