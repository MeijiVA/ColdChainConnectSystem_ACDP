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
            this.btnExit = new System.Windows.Forms.Button();
            this.lbl = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.customPanel1 = new ColdChainConnectSystem_ACDP.Materials.CustomPanel();
            this.PersonalUserControl = new ColdChainConnectSystem_ACDP.AppForms.Header.Settings.PersonalDetails.Personal_Information();
            this.lblEmpID = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.customPanel2 = new ColdChainConnectSystem_ACDP.Materials.CustomPanel();
            this.AddressUserControl = new ColdChainConnectSystem_ACDP.AppForms.Header.Settings.PersonalDetails.AddressInformation();
            this.customPanel3 = new ColdChainConnectSystem_ACDP.Materials.CustomPanel();
            this.ContactUserControl = new ColdChainConnectSystem_ACDP.AppForms.Header.Settings.PersonalDetails.AccountInformation();
            this.customPanel1.SuspendLayout();
            this.customPanel2.SuspendLayout();
            this.customPanel3.SuspendLayout();
            this.SuspendLayout();
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
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.Transparent;
            this.customPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.customPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customPanel1.BorderRadius = 15;
            this.customPanel1.BorderSize = 0;
            this.customPanel1.Controls.Add(this.PersonalUserControl);
            this.customPanel1.ForeColor = System.Drawing.Color.White;
            this.customPanel1.Location = new System.Drawing.Point(29, 129);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(450, 200);
            this.customPanel1.TabIndex = 73;
            this.customPanel1.TextColor = System.Drawing.Color.White;
            // 
            // PersonalUserControl
            // 
            this.PersonalUserControl.AgeInfo = "label3";
            this.PersonalUserControl.BackColor = System.Drawing.Color.White;
            this.PersonalUserControl.DOBInfo = "label3";
            this.PersonalUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersonalUserControl.First_NameInfo = "label1";
            this.PersonalUserControl.ForeColor = System.Drawing.Color.Black;
            this.PersonalUserControl.Last_NameInfo = "label4";
            this.PersonalUserControl.Location = new System.Drawing.Point(0, 0);
            this.PersonalUserControl.Middle_NameInfo = "label2";
            this.PersonalUserControl.Name = "PersonalUserControl";
            this.PersonalUserControl.SexInfo = "label3";
            this.PersonalUserControl.Size = new System.Drawing.Size(450, 200);
            this.PersonalUserControl.TabIndex = 0;
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
            this.lblEmpID.Location = new System.Drawing.Point(26, 81);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(454, 30);
            this.lblEmpID.TabIndex = 68;
            this.lblEmpID.Text = "   Employee ID Here";
            this.lblEmpID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEmpID.TextColor = System.Drawing.Color.White;
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customPanel2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.customPanel2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customPanel2.BorderRadius = 15;
            this.customPanel2.BorderSize = 0;
            this.customPanel2.Controls.Add(this.AddressUserControl);
            this.customPanel2.ForeColor = System.Drawing.Color.White;
            this.customPanel2.Location = new System.Drawing.Point(28, 351);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(450, 200);
            this.customPanel2.TabIndex = 74;
            this.customPanel2.TextColor = System.Drawing.Color.White;
            // 
            // AddressUserControl
            // 
            this.AddressUserControl.BackColor = System.Drawing.Color.White;
            this.AddressUserControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddressUserControl.Barangay = "test";
            this.AddressUserControl.City = "label4";
            this.AddressUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddressUserControl.ForeColor = System.Drawing.Color.Black;
            this.AddressUserControl.HouseNum = "label1";
            this.AddressUserControl.Location = new System.Drawing.Point(0, 0);
            this.AddressUserControl.Name = "AddressUserControl";
            this.AddressUserControl.Postal = "label3";
            this.AddressUserControl.Province = "label3";
            this.AddressUserControl.Size = new System.Drawing.Size(450, 200);
            this.AddressUserControl.TabIndex = 66;
            // 
            // customPanel3
            // 
            this.customPanel3.BackColor = System.Drawing.Color.White;
            this.customPanel3.BackgroundColor = System.Drawing.Color.White;
            this.customPanel3.BorderColor = System.Drawing.Color.Empty;
            this.customPanel3.BorderRadius = 15;
            this.customPanel3.BorderSize = 0;
            this.customPanel3.Controls.Add(this.ContactUserControl);
            this.customPanel3.ForeColor = System.Drawing.Color.White;
            this.customPanel3.Location = new System.Drawing.Point(495, 110);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(280, 441);
            this.customPanel3.TabIndex = 75;
            this.customPanel3.TextColor = System.Drawing.Color.White;
            // 
            // ContactUserControl
            // 
            this.ContactUserControl.BackColor = System.Drawing.Color.White;
            this.ContactUserControl.ConNum = "Ow yeah";
            this.ContactUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContactUserControl.EmailInfo = "email";
            this.ContactUserControl.ForeColor = System.Drawing.Color.Black;
            this.ContactUserControl.Location = new System.Drawing.Point(0, 0);
            this.ContactUserControl.Name = "ContactUserControl";
            this.ContactUserControl.PositionInfo = "position";
            this.ContactUserControl.Size = new System.Drawing.Size(280, 441);
            this.ContactUserControl.StatusInfo = "status";
            this.ContactUserControl.TabIndex = 65;
            // 
            // EmployeeProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 570);
            this.Controls.Add(this.customPanel3);
            this.Controls.Add(this.customPanel2);
            this.Controls.Add(this.lblEmpID);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeProfile";
            this.Text = "EmployeeProfile";
            this.customPanel1.ResumeLayout(false);
            this.customPanel2.ResumeLayout(false);
            this.customPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private Materials.CustomLabel lbl;
        private Materials.CustomPanel customPanel1;
        private PersonalDetails.Personal_Information PersonalUserControl;
        private Materials.CustomLabel lblEmpID;
        private Materials.CustomPanel customPanel2;
        private PersonalDetails.AddressInformation AddressUserControl;
        private Materials.CustomPanel customPanel3;
        private PersonalDetails.AccountInformation ContactUserControl;
    }
}