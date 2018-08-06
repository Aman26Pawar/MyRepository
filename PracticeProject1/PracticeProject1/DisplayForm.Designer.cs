namespace PracticeProject1
{
    partial class DisplayForm
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
            this.comboBoxShowTables = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DisplayTableInfo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxShowTables
            // 
            this.comboBoxShowTables.FormattingEnabled = true;
            this.comboBoxShowTables.Items.AddRange(new object[] {
            "EmployeeData",
            "EmployeeType"});
            this.comboBoxShowTables.Location = new System.Drawing.Point(112, 12);
            this.comboBoxShowTables.Name = "comboBoxShowTables";
            this.comboBoxShowTables.Size = new System.Drawing.Size(121, 21);
            this.comboBoxShowTables.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Table";
            // 
            // DisplayTableInfo
            // 
            this.DisplayTableInfo.Location = new System.Drawing.Point(248, 12);
            this.DisplayTableInfo.Name = "DisplayTableInfo";
            this.DisplayTableInfo.Size = new System.Drawing.Size(75, 23);
            this.DisplayTableInfo.TabIndex = 2;
            this.DisplayTableInfo.Text = "Display Info";
            this.DisplayTableInfo.UseVisualStyleBackColor = true;
            this.DisplayTableInfo.Click += new System.EventHandler(this.DisplayTableInfo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(131, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(627, 257);
            this.dataGridView1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Home Page";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 382);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DisplayTableInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxShowTables);
            this.Name = "DisplayForm";
            this.Text = "DisplayForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxShowTables;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DisplayTableInfo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}