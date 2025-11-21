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
            this.lblEmpID = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.sdUserControl = new ColdChainConnectSystem_ACDP.AppForms.Header.Settings.PersonalDetails.SecurityDetails();
            this.customPanel1 = new ColdChainConnectSystem_ACDP.Materials.CustomPanel();
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEmpID
            // 
            this.lblEmpID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblEmpID.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblEmpID.BorderColor = System.Drawing.Color.Transparent;
            this.lblEmpID.BorderRadius = 10;
            this.lblEmpID.BorderSize = 0;
            this.lblEmpID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmpID.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmpID.ForeColor = System.Drawing.Color.White;
            this.lblEmpID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEmpID.Location = new System.Drawing.Point(9, 5);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(745, 30);
            this.lblEmpID.TabIndex = 68;
            this.lblEmpID.Text = "Employee ID Here";
            this.lblEmpID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEmpID.TextColor = System.Drawing.Color.White;
            // 
            // sdUserControl
            // 
            this.sdUserControl.BackColor = System.Drawing.Color.White;
            this.sdUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sdUserControl.ForeColor = System.Drawing.Color.Black;
            this.sdUserControl.Location = new System.Drawing.Point(0, 0);
            this.sdUserControl.Name = "sdUserControl";
            this.sdUserControl.PasswordLength = "";
            this.sdUserControl.Size = new System.Drawing.Size(742, 410);
            this.sdUserControl.TabIndex = 66;
            this.sdUserControl.UsernameView = "user";
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.Transparent;
            this.customPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.customPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.customPanel1.BorderRadius = 15;
            this.customPanel1.BorderSize = 0;
            this.customPanel1.Controls.Add(this.sdUserControl);
            this.customPanel1.ForeColor = System.Drawing.Color.White;
            this.customPanel1.Location = new System.Drawing.Point(12, 38);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(742, 410);
            this.customPanel1.TabIndex = 69;
            this.customPanel1.TextColor = System.Drawing.Color.White;
            // 
            // SecurityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(766, 458);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.lblEmpID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SecurityForm";
            this.Text = "SecurityForm";
            this.Load += new System.EventHandler(this.SecurityForm_Load);
            this.customPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private SecurityDetails sdUserControl;
        private Materials.CustomLabel lblEmpID;
        private Materials.CustomPanel customPanel1;
    }
}