using Demo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.Ui
{
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void btnGetEmployee_Click(object sender, EventArgs e)
        {
            EmployeeService.EmployeeServiceClient client = new EmployeeService.EmployeeServiceClient();
            Employee emp = client.GetEmployeeById(Convert.ToInt32(txtEmployeeId.Text));

            if(emp != null)
            {
                txtEmployeeName.Text = emp.EmployeeName;
                txtDesignation.Text = emp.Designation;
                ddlEmploymentType.SelectedIndex = emp.EmployeeType.EmployeeTypeId - 1;
                lblBonusRate.Text = emp.BonusRate.ToString();
                lblHourlyPay.Text = emp.HourlyPay.ToString();
            }
        }

        private void btnSaveEmployee_Click(object sender, EventArgs e)
        {
            EmployeeService.EmployeeServiceClient client = new EmployeeService.EmployeeServiceClient();
            Employee emp = new Employee()
            {
                EmployeeName = txtEmployeeName.Text,
                Designation = txtDesignation.Text,
                EmployeeType = new EmployeeType()
                {
                    EmployeeTypeId = ddlEmploymentType.SelectedIndex + 1,
                    EmployeeTypeName = ddlEmploymentType.SelectedItem.ToString()
                }
            };

            int id = client.SaveEmployee(emp);
            txtEmployeeId.Text = id.ToString();
            MessageBox.Show("Employee Saved...");
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (txtEmployeeId.Text != string.Empty)
            {
                EmployeeService.EmployeeServiceClient client = new EmployeeService.EmployeeServiceClient();
                int employeeIdToDelete = Convert.ToInt32(txtEmployeeId.Text);

                if(employeeIdToDelete > 0)
                {
                    client.DeleteEmployee(employeeIdToDelete);
                    MessageBox.Show("Employee Deleted...");
                }
            }
        }
    }
}