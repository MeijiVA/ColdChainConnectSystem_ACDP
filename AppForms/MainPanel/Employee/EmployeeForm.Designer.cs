namespace ColdChainConnectSystem_ACDP.AppForms.Header.Settings.Employee
{
    partial class EmployeeForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.showEmployee1 = new ColdChainConnectSystem_ACDP.AppForms.Header.Settings.Employee.ShowEmployee();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.showEmployee1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 75);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(766, 483);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // showEmployee1
            // 
            this.showEmployee1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.showEmployee1.EMPID = "";
            this.showEmployee1.Location = new System.Drawing.Point(14, 11);
            this.showEmployee1.Name = "showEmployee1";
            this.showEmployee1.Padding = new System.Windows.Forms.Padding(5);
            this.showEmployee1.Size = new System.Drawing.Size(241, 180);
            this.showEmployee1.TabIndex = 0;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 570);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeForm";
            this.Text = "EmployeeManagementForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private ShowEmployee showEmployee1;
    }
}