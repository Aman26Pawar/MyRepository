namespace UIForm
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
           
            this.InsertEmployee = new System.Windows.Forms.Button();
            this.Show = new System.Windows.Forms.Button();
            this.UpdateEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
           
          
            // txtEmpNm
            // 
            this.txtEmpNm.Location = new System.Drawing.Point(162, 24);
            this.txtEmpNm.Name = "txtEmpNm";
            this.txtEmpNm.Size = new System.Drawing.Size(100, 20);
            this.txtEmpNm.TabIndex = 3;
            this.txtEmpNm.TextChanged += new System.EventHandler(this.InsertEmployee_Click);
            // 
            // txtEmpType
            // 
            this.txtEmpType.Location = new System.Drawing.Point(162, 56);
            this.txtEmpType.Name = "txtEmpType";
            this.txtEmpType.Size = new System.Drawing.Size(100, 20);
            this.txtEmpType.TabIndex = 4;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(162, 83);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(100, 20);
            this.txtDepartment.TabIndex = 5;
            // 
            // InsertEmployee
            // 
            this.InsertEmployee.Location = new System.Drawing.Point(136, 25);
            this.InsertEmployee.Name = "InsertEmployee";
            this.InsertEmployee.Size = new System.Drawing.Size(75, 23);
            this.InsertEmployee.TabIndex = 6;
            this.InsertEmployee.Text = "Insert";
            this.InsertEmployee.UseVisualStyleBackColor = true;
            this.InsertEmployee.Click += new System.EventHandler(this.InsertEmployee_Click);
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(136, 139);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(75, 23);
            this.Show.TabIndex = 7;
            this.Show.Text = "Display";
            this.Show.UseVisualStyleBackColor = true;
            // 
            // UpdateEmployee
            // 
            this.UpdateEmployee.Location = new System.Drawing.Point(136, 68);
            this.UpdateEmployee.Name = "UpdateEmployee";
            this.UpdateEmployee.Size = new System.Drawing.Size(75, 23);
            this.UpdateEmployee.TabIndex = 8;
            this.UpdateEmployee.Text = "Update";
            this.UpdateEmployee.UseVisualStyleBackColor = true;
            // 
            // EmployeeInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(606, 291);
            this.Controls.Add(this.UpdateEmployee);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.InsertEmployee);
            this.Name = "EmployeeInput";
            this.Text = "Home Page";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmpNm;
        private System.Windows.Forms.TextBox txtEmpType;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Button InsertEmployee;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.Button UpdateEmployee;

        
    }
}

