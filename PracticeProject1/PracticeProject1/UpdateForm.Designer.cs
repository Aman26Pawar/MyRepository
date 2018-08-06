namespace PracticeProject1
{
    partial class UpdateForm
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
            this.txtEmpIDToUpdate = new System.Windows.Forms.TextBox();
            this.txtIDtoUpdate = new System.Windows.Forms.Button();
            this.EnteredNameOfEmplyeeUpdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UpdatedComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUpdatedDepartment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Homepage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the ID to be update";
            // 
            // txtEmpIDToUpdate
            // 
            this.txtEmpIDToUpdate.Location = new System.Drawing.Point(199, 13);
            this.txtEmpIDToUpdate.Name = "txtEmpIDToUpdate";
            this.txtEmpIDToUpdate.Size = new System.Drawing.Size(100, 20);
            this.txtEmpIDToUpdate.TabIndex = 1;
            // 
            // txtIDtoUpdate
            // 
            this.txtIDtoUpdate.Location = new System.Drawing.Point(46, 176);
            this.txtIDtoUpdate.Name = "txtIDtoUpdate";
            this.txtIDtoUpdate.Size = new System.Drawing.Size(184, 39);
            this.txtIDtoUpdate.TabIndex = 2;
            this.txtIDtoUpdate.Text = "Update Info";
            this.txtIDtoUpdate.UseVisualStyleBackColor = true;
            this.txtIDtoUpdate.Click += new System.EventHandler(this.txtIDtoUpdate_Click);
            // 
            // EnteredNameOfEmplyeeUpdate
            // 
            this.EnteredNameOfEmplyeeUpdate.Location = new System.Drawing.Point(199, 45);
            this.EnteredNameOfEmplyeeUpdate.Name = "EnteredNameOfEmplyeeUpdate";
            this.EnteredNameOfEmplyeeUpdate.Size = new System.Drawing.Size(100, 20);
            this.EnteredNameOfEmplyeeUpdate.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Enter name of the Employee";
            // 
            // UpdatedComboBox
            // 
            this.UpdatedComboBox.FormattingEnabled = true;
            this.UpdatedComboBox.Items.AddRange(new object[] {
            "Permanent",
            "AdHoc"});
            this.UpdatedComboBox.Location = new System.Drawing.Point(199, 112);
            this.UpdatedComboBox.Name = "UpdatedComboBox";
            this.UpdatedComboBox.Size = new System.Drawing.Size(121, 21);
            this.UpdatedComboBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter Type of Employee";
            // 
            // txtUpdatedDepartment
            // 
            this.txtUpdatedDepartment.Location = new System.Drawing.Point(199, 79);
            this.txtUpdatedDepartment.Name = "txtUpdatedDepartment";
            this.txtUpdatedDepartment.Size = new System.Drawing.Size(121, 20);
            this.txtUpdatedDepartment.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter new Department";
            // 
            // Homepage
            // 
            this.Homepage.Location = new System.Drawing.Point(244, 185);
            this.Homepage.Name = "Homepage";
            this.Homepage.Size = new System.Drawing.Size(75, 23);
            this.Homepage.TabIndex = 13;
            this.Homepage.Text = "Home Page";
            this.Homepage.UseVisualStyleBackColor = true;
            this.Homepage.Click += new System.EventHandler(this.Homepage_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 227);
            this.Controls.Add(this.Homepage);
            this.Controls.Add(this.EnteredNameOfEmplyeeUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UpdatedComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUpdatedDepartment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIDtoUpdate);
            this.Controls.Add(this.txtEmpIDToUpdate);
            this.Controls.Add(this.label1);
            this.Name = "UpdateForm";
            this.Text = "UpdateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmpIDToUpdate;
        private System.Windows.Forms.Button txtIDtoUpdate;
        private System.Windows.Forms.TextBox EnteredNameOfEmplyeeUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox UpdatedComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUpdatedDepartment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Homepage;
    }
}