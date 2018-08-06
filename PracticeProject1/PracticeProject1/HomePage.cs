using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeProject1
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            InsertForm insertForm = new InsertForm();
            insertForm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateForm updtfrm = new UpdateForm();
            updtfrm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteForm dltFrm = new DeleteForm();
            dltFrm.Show();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            DisplayForm dispfrm = new DisplayForm();
            dispfrm.Show();
        }
    }
}
