namespace Demo.Ui
{
    partial class frmEmployee
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
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.btnGetEmployee = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ddlEmploymentType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHourlyPay = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblBonusRate = new System.Windows.Forms.Label();
            this.btnSaveEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Employee Id";
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Location = new System.Drawing.Point(137, 23);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeId.TabIndex = 1;
            // 
            // btnGetEmployee
            // 
            this.btnGetEmployee.Location = new System.Drawing.Point(244, 23);
            this.btnGetEmployee.Name = "btnGetEmployee";
            this.btnGetEmployee.Size = new System.Drawing.Size(132, 23);
            this.btnGetEmployee.TabIndex = 2;
            this.btnGetEmployee.Text = "Get Employee";
            this.btnGetEmployee.UseVisualStyleBackColor = true;
            this.btnGetEmployee.Click += new System.EventHandler(this.btnGetEmployee_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Employee Name";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(137, 57);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(239, 20);
            this.txtEmployeeName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Designation";
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(137, 92);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(239, 20);
            this.txtDesignation.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Employment Type";
            // 
            // ddlEmploymentType
            // 
            this.ddlEmploymentType.FormattingEnabled = true;
            this.ddlEmploymentType.Items.AddRange(new object[] {
            "Permanent",
            "Contract"});
            this.ddlEmploymentType.Location = new System.Drawing.Point(137, 127);
            this.ddlEmploymentType.Name = "ddlEmploymentType";
            this.ddlEmploymentType.Size = new System.Drawing.Size(121, 21);
            this.ddlEmploymentType.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Hourly Pay";
            // 
            // lblHourlyPay
            // 
            this.lblHourlyPay.AutoSize = true;
            this.lblHourlyPay.Location = new System.Drawing.Point(137, 160);
            this.lblHourlyPay.Name = "lblHourlyPay";
            this.lblHourlyPay.Size = new System.Drawing.Size(16, 13);
            this.lblHourlyPay.TabIndex = 10;
            this.lblHourlyPay.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Bonus Rate";
            // 
            // lblBonusRate
            // 
            this.lblBonusRate.AutoSize = true;
            this.lblBonusRate.Location = new System.Drawing.Point(137, 189);
            this.lblBonusRate.Name = "lblBonusRate";
            this.lblBonusRate.Size = new System.Drawing.Size(16, 13);
            this.lblBonusRate.TabIndex = 12;
            this.lblBonusRate.Text = "...";
            // 
            // btnSaveEmployee
            // 
            this.btnSaveEmployee.Location = new System.Drawing.Point(140, 228);
            this.btnSaveEmployee.Name = "btnSaveEmployee";
            this.btnSaveEmployee.Size = new System.Drawing.Size(118, 23);
            this.btnSaveEmployee.TabIndex = 13;
            this.btnSaveEmployee.Text = "Save Employee";
            this.btnSaveEmployee.UseVisualStyleBackColor = true;
            this.btnSaveEmployee.Click += new System.EventHandler(this.btnSaveEmployee_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(264, 228);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(118, 23);
            this.btnDeleteEmployee.TabIndex = 13;
            this.btnDeleteEmployee.Text = "Delete Employee";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 259);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.btnSaveEmployee);
            this.Controls.Add(this.lblBonusRate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblHourlyPay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ddlEmploymentType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDesignation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGetEmployee);
            this.Controls.Add(this.txtEmployeeId);
            this.Controls.Add(this.label1);
            this.Name = "frmEmployee";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.Button btnGetEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ddlEmploymentType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHourlyPay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblBonusRate;
        private System.Windows.Forms.Button btnSaveEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
    }
}

