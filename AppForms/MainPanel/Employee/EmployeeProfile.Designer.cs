namespace ColdChainConnectSystem_ACDP.AppForms.Header.Settings.Employee
{
    partial class EmployeeProfile
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
            this.btnExit = new System.Windows.Forms.Button();
            this.lbl = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.ContactUserControl = new ColdChainConnectSystem_ACDP.AppForms.Header.Settings.PersonalDetails.AccountInformation();
            this.PersonalUserControl = new ColdChainConnectSystem_ACDP.AppForms.Header.Settings.PersonalDetails.Personal_Information();
            this.AddressUserControl = new ColdChainConnectSystem_ACDP.AppForms.Header.Settings.PersonalDetails.AddressInformation();
            this.SuspendLayout();
            // 
            // lblEmpID
            // 
            this.lblEmpID.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpID.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmpID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblEmpID.Location = new System.Drawing.Point(28, 82);
            this.lblEmpID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(450, 18);
            this.lblEmpID.TabIndex = 70;
            this.lblEmpID.Text = "Employee ID:";
            this.lblEmpID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.btnExit.BackgroundImage = global::ColdChainConnectSystem_ACDP.Properties.Resources.Back;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(728, 29);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 28);
            this.btnExit.TabIndex = 71;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbl
            // 
            this.lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lbl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lbl.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.lbl.BorderRadius = 10;
            this.lbl.BorderSize = 0;
            this.lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(24, 15);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(751, 55);
            this.lbl.TabIndex = 72;
            this.lbl.Text = "    Employee Profile";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl.TextColor = System.Drawing.Color.White;
            this.lbl.UseMnemonic = false;
            // 
            // ContactUserControl
            // 
            this.ContactUserControl.BackColor = System.Drawing.Color.White;
            this.ContactUserControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContactUserControl.ConNum = "Ow yeah";
            this.ContactUserControl.EmailInfo = "email";
            this.ContactUserControl.ForeColor = System.Drawing.Color.Black;
            this.ContactUserControl.Location = new System.Drawing.Point(495, 112);
            this.ContactUserControl.Name = "ContactUserControl";
            this.ContactUserControl.PositionInfo = "position";
            this.ContactUserControl.Size = new System.Drawing.Size(280, 431);
            this.ContactUserControl.StatusInfo = "status";
            this.ContactUserControl.TabIndex = 69;
            // 
            // PersonalUserControl
            // 
            this.PersonalUserControl.AgeInfo = "label3";
            this.PersonalUserControl.BackColor = System.Drawing.Color.White;
            this.PersonalUserControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PersonalUserControl.DOBInfo = "label3";
            this.PersonalUserControl.First_NameInfo = "label1";
            this.PersonalUserControl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PersonalUserControl.Last_NameInfo = "label4";
            this.PersonalUserControl.Location = new System.Drawing.Point(28, 112);
            this.PersonalUserControl.Middle_NameInfo = "label2";
            this.PersonalUserControl.Name = "PersonalUserControl";
            this.PersonalUserControl.SexInfo = "label3";
            this.PersonalUserControl.Size = new System.Drawing.Size(450, 200);
            this.PersonalUserControl.TabIndex = 68;
            // 
            // AddressUserControl
            // 
            this.AddressUserControl.BackColor = System.Drawing.Color.White;
            this.AddressUserControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddressUserControl.Barangay = "label2";
            this.AddressUserControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddressUserControl.City = "label4";
            this.AddressUserControl.HouseNum = "label1";
            this.AddressUserControl.Location = new System.Drawing.Point(28, 343);
            this.AddressUserControl.Name = "AddressUserControl";
            this.AddressUserControl.Postal = "label3";
            this.AddressUserControl.Province = "label3";
            this.AddressUserControl.Size = new System.Drawing.Size(450, 200);
            this.AddressUserControl.TabIndex = 67;
            // 
            // EmployeeProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 570);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblEmpID);
            this.Controls.Add(this.ContactUserControl);
            this.Controls.Add(this.PersonalUserControl);
            this.Controls.Add(this.AddressUserControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeProfile";
            this.Text = "EmployeeProfile";
            this.ResumeLayout(false);

        }

        #endregion
        private PersonalDetails.AddressInformation AddressUserControl;
        private PersonalDetails.Personal_Information PersonalUserControl;
        private PersonalDetails.AccountInformation ContactUserControl;
        public System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.Button btnExit;
        private Materials.CustomLabel lbl;
    }
}