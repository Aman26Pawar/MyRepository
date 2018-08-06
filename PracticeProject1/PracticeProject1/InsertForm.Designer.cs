namespace PracticeProject1
{
    partial class InsertForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.Department = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.SaveEmployee = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee name";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(172, 13);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeName.TabIndex = 1;
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.Location = new System.Drawing.Point(34, 52);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(62, 13);
            this.Department.TabIndex = 2;
            this.Department.Text = "Department";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(172, 52);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(100, 20);
            this.txtDepartment.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Employee Type";
            // 
            // ComboBox1
            // 
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Items.AddRange(new object[] {
            "Permanent",
            "AdHoc"});
            this.ComboBox1.Location = new System.Drawing.Point(172, 93);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(121, 21);
            this.ComboBox1.TabIndex = 5;
            // 
            // SaveEmployee
            // 
            this.SaveEmployee.Location = new System.Drawing.Point(42, 159);
            this.SaveEmployee.Name = "SaveEmployee";
            this.SaveEmployee.Size = new System.Drawing.Size(75, 23);
            this.SaveEmployee.TabIndex = 6;
            this.SaveEmployee.Text = "SAVE\r\n";
            this.SaveEmployee.UseVisualStyleBackColor = true;
            this.SaveEmployee.Click += new System.EventHandler(this.SaveEmployee_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Home Page";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 256);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SaveEmployee);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.label1);
            this.Name = "InsertForm";
            this.Text = "InsertForm";
            this.Load += new System.EventHandler(this.InsertForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label Department;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBox1;
        private System.Windows.Forms.Button SaveEmployee;
        private System.Windows.Forms.Button button1;
    }
}