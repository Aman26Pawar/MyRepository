namespace PracticeProject1
{
    partial class DeleteForm
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
            this.txtDelID = new System.Windows.Forms.TextBox();
            this.DeleteEmployeeData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID to be delete";
            // 
            // txtDelID
            // 
            this.txtDelID.Location = new System.Drawing.Point(112, 13);
            this.txtDelID.Name = "txtDelID";
            this.txtDelID.Size = new System.Drawing.Size(100, 20);
            this.txtDelID.TabIndex = 1;
            // 
            // DeleteEmployeeData
            // 
            this.DeleteEmployeeData.Location = new System.Drawing.Point(49, 58);
            this.DeleteEmployeeData.Name = "DeleteEmployeeData";
            this.DeleteEmployeeData.Size = new System.Drawing.Size(75, 23);
            this.DeleteEmployeeData.TabIndex = 2;
            this.DeleteEmployeeData.Text = "DeleteEmployee";
            this.DeleteEmployeeData.UseVisualStyleBackColor = true;
            this.DeleteEmployeeData.Click += new System.EventHandler(this.DeleteEmployeeData_Click);
            // 
            // DeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 101);
            this.Controls.Add(this.DeleteEmployeeData);
            this.Controls.Add(this.txtDelID);
            this.Controls.Add(this.label1);
            this.Name = "DeleteForm";
            this.Text = "DeleteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDelID;
        private System.Windows.Forms.Button DeleteEmployeeData;
    }
}