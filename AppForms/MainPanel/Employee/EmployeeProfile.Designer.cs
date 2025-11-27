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
            this.tscStatus = new ToggleSlider.ToggleSliderComponent();
            this.customButton1 = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            this.customPanel3 = new ColdChainConnectSystem_ACDP.Materials.CustomPanel();
            this.AccountContainer = new ColdChainConnectSystem_ACDP.AppForms.Header.Settings.PersonalDetails.AccountInformation();
            this.customPanel2 = new ColdChainConnectSystem_ACDP.Materials.CustomPanel();
            this.AddressContainer = new ColdChainConnectSystem_ACDP.AppForms.Header.Settings.PersonalDetails.AddressInformation();
            this.lblEmpID = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.customPanel1 = new ColdChainConnectSystem_ACDP.Materials.CustomPanel();
            this.PersonalContainer = new ColdChainConnectSystem_ACDP.AppForms.Header.Settings.PersonalDetails.Personal_Information();
            this.lbl = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.customPanel3.SuspendLayout();
            this.customPanel2.SuspendLayout();
            this.customPanel1.SuspendLayout();
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
            // tscStatus
            // 
            this.tscStatus.AutoSize = true;
            this.tscStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.tscStatus.Checked = true;
            this.tscStatus.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tscStatus.ForeColor = System.Drawing.Color.White;
            this.tscStatus.Location = new System.Drawing.Point(347, 86);
            this.tscStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tscStatus.Name = "tscStatus";
            this.tscStatus.Size = new System.Drawing.Size(119, 30);
            this.tscStatus.TabIndex = 77;
            this.tscStatus.ToggleBarText = "Active";
            this.tscStatus.ToggleCircleColor = System.Drawing.Color.Green;
            this.tscStatus.ToggleColorBar = System.Drawing.Color.Gray;
            this.tscStatus.CheckChanged += new System.EventHandler(this.tscStatus_CheckChanged);
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.Transparent;
            this.customButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.customButton1.BackgroundImage = global::ColdChainConnectSystem_ACDP.Properties.Resources.editBtn;
            this.customButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.customButton1.BorderColor = System.Drawing.Color.Peru;
            this.customButton1.BorderRadius = 0;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(732, 79);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(43, 40);
            this.customButton1.TabIndex = 76;
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // customPanel3
            // 
            this.customPanel3.BackColor = System.Drawing.Color.White;
            this.customPanel3.BackgroundColor = System.Drawing.Color.White;
            this.customPanel3.BorderColor = System.Drawing.Color.Empty;
            this.customPanel3.BorderRadius = 15;
            this.customPanel3.BorderSize = 0;
            this.customPanel3.Controls.Add(this.AccountContainer);
            this.customPanel3.ForeColor = System.Drawing.Color.White;
            this.customPanel3.Location = new System.Drawing.Point(495, 129);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(280, 422);
            this.customPanel3.TabIndex = 75;
            this.customPanel3.TextColor = System.Drawing.Color.White;
            // 
            // AccountContainer
            // 
            this.AccountContainer.BackColor = System.Drawing.Color.White;
            this.AccountContainer.ConNum = "Contact Number here";
            this.AccountContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccountContainer.EmailInfo = "Email  here";
            this.AccountContainer.ForeColor = System.Drawing.Color.Black;
            this.AccountContainer.Location = new System.Drawing.Point(0, 0);
            this.AccountContainer.Name = "AccountContainer";
            this.AccountContainer.PositionInfo = "Position here";
            this.AccountContainer.Size = new System.Drawing.Size(280, 422);
            this.AccountContainer.StatusInfo = "Status here";
            this.AccountContainer.TabIndex = 65;
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.customPanel2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.customPanel2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customPanel2.BorderRadius = 15;
            this.customPanel2.BorderSize = 0;
            this.customPanel2.Controls.Add(this.AddressContainer);
            this.customPanel2.ForeColor = System.Drawing.Color.White;
            this.customPanel2.Location = new System.Drawing.Point(28, 351);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(450, 200);
            this.customPanel2.TabIndex = 74;
            this.customPanel2.TextColor = System.Drawing.Color.White;
            // 
            // AddressContainer
            // 
            this.AddressContainer.BackColor = System.Drawing.Color.White;
            this.AddressContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddressContainer.Barangay = "BRGY  here";
            this.AddressContainer.City = "City  here";
            this.AddressContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddressContainer.ForeColor = System.Drawing.Color.Black;
            this.AddressContainer.HouseNum = "H.Num here";
            this.AddressContainer.Location = new System.Drawing.Point(0, 0);
            this.AddressContainer.Name = "AddressContainer";
            this.AddressContainer.Postal = "Postal here";
            this.AddressContainer.Province = "Province here";
            this.AddressContainer.Size = new System.Drawing.Size(450, 200);
            this.AddressContainer.TabIndex = 66;
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
            this.lblEmpID.Location = new System.Drawing.Point(28, 79);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(451, 40);
            this.lblEmpID.TabIndex = 68;
            this.lblEmpID.Text = "   Employee ID Here";
            this.lblEmpID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEmpID.TextColor = System.Drawing.Color.White;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.Transparent;
            this.customPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.customPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customPanel1.BorderRadius = 15;
            this.customPanel1.BorderSize = 0;
            this.customPanel1.Controls.Add(this.PersonalContainer);
            this.customPanel1.ForeColor = System.Drawing.Color.White;
            this.customPanel1.Location = new System.Drawing.Point(29, 129);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(450, 200);
            this.customPanel1.TabIndex = 73;
            this.customPanel1.TextColor = System.Drawing.Color.White;
            // 
            // PersonalContainer
            // 
            this.PersonalContainer.AgeInfo = "AGE here";
            this.PersonalContainer.BackColor = System.Drawing.Color.White;
            this.PersonalContainer.DOBInfo = "DOB here";
            this.PersonalContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersonalContainer.First_NameInfo = "FNAME here";
            this.PersonalContainer.ForeColor = System.Drawing.Color.Black;
            this.PersonalContainer.Last_NameInfo = "LNAME here";
            this.PersonalContainer.Location = new System.Drawing.Point(0, 0);
            this.PersonalContainer.Middle_NameInfo = "MNAME here";
            this.PersonalContainer.Name = "PersonalContainer";
            this.PersonalContainer.SexInfo = "GENDER here";
            this.PersonalContainer.Size = new System.Drawing.Size(450, 200);
            this.PersonalContainer.TabIndex = 0;
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
            // EmployeeProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 570);
            this.Controls.Add(this.tscStatus);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.customPanel3);
            this.Controls.Add(this.customPanel2);
            this.Controls.Add(this.lblEmpID);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeProfile";
            this.Text = "EmployeeProfile";
            this.Load += new System.EventHandler(this.EmployeeProfile_Load);
            this.customPanel3.ResumeLayout(false);
            this.customPanel2.ResumeLayout(false);
            this.customPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private Materials.CustomLabel lbl;
        private Materials.CustomPanel customPanel1;
        private PersonalDetails.Personal_Information PersonalContainer;
        private Materials.CustomLabel lblEmpID;
        private Materials.CustomPanel customPanel2;
        private PersonalDetails.AddressInformation AddressContainer;
        private Materials.CustomPanel customPanel3;
        private PersonalDetails.AccountInformation AccountContainer;
        private Materials.CustomButton customButton1;
        private ToggleSlider.ToggleSliderComponent tscStatus;
    }
}