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
            this.flpEmployee = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpEmployee
            // 
            this.flpEmployee.AutoScroll = true;
            this.flpEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpEmployee.Location = new System.Drawing.Point(12, 47);
            this.flpEmployee.Name = "flpEmployee";
            this.flpEmployee.Padding = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.flpEmployee.Size = new System.Drawing.Size(766, 483);
            this.flpEmployee.TabIndex = 0;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 570);
            this.Controls.Add(this.flpEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeForm";
            this.Text = "EmployeeManagementForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpEmployee;
    }
}