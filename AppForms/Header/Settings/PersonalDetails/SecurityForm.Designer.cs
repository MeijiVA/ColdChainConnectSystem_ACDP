namespace ColdChainConnectSystem_ACDP.AppForms.Header.Settings.PersonalDetails
{
    partial class SecurityForm
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
            this.lblEmpID = new System.Windows.Forms.Label();
            this.sdUserControl = new ColdChainConnectSystem_ACDP.AppForms.Header.Settings.PersonalDetails.SecurityDetails();
            this.SuspendLayout();
            // 
            // lblEmpID
            // 
            this.lblEmpID.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpID.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmpID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblEmpID.Location = new System.Drawing.Point(16, 15);
            this.lblEmpID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(450, 18);
            this.lblEmpID.TabIndex = 65;
            this.lblEmpID.Text = "Employee ID Here";
            this.lblEmpID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sdUserControl
            // 
            this.sdUserControl.BackColor = System.Drawing.Color.White;
            this.sdUserControl.Location = new System.Drawing.Point(12, 36);
            this.sdUserControl.Name = "sdUserControl";
            this.sdUserControl.PasswordLength = "";
            this.sdUserControl.Size = new System.Drawing.Size(742, 410);
            this.sdUserControl.TabIndex = 66;
            this.sdUserControl.UsernameView = "user";
            // 
            // SecurityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(766, 458);
            this.Controls.Add(this.sdUserControl);
            this.Controls.Add(this.lblEmpID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SecurityForm";
            this.Text = "SecurityForm";
            this.Load += new System.EventHandler(this.SecurityForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEmpID;
        private SecurityDetails sdUserControl;
    }
}