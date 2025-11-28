namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Employee
{
    partial class AddEmployeeForm
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
            this.btnSave = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            this.tscStatus = new ToggleSlider.ToggleSliderComponent();
            this.lblEmpID = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.editPersonalInformation1 = new ColdChainConnectSystem_ACDP.AppForms.Header.Settings.PersonalDetails.EditPersonalInformation();
            this.editAddressInformation1 = new ColdChainConnectSystem_ACDP.AppForms.Header.Settings.Employee.EditAddressInformation();
            this.editAccountInformation1 = new ColdChainConnectSystem_ACDP.AppForms.Header.Settings.PersonalDetails.EditAccountInformation();
            this.lbl = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.customTextBox1 = new CustomControls.RJControls.CustomTextBox();
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
            this.btnExit.Size = new System.Drawing.Size(27, 27);
            this.btnExit.TabIndex = 8;
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.btnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.btnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.BorderRadius = 10;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(682, 80);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.TabIndex = 82;
            this.btnSave.Text = "Save";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
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
            this.tscStatus.TabIndex = 81;
            this.tscStatus.ToggleBarText = "Active";
            this.tscStatus.ToggleCircleColor = System.Drawing.Color.Green;
            this.tscStatus.ToggleColorBar = System.Drawing.Color.Gray;
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
            this.lblEmpID.TabIndex = 80;
            this.lblEmpID.Text = "   Employee ID:";
            this.lblEmpID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEmpID.TextColor = System.Drawing.Color.White;
            // 
            // editPersonalInformation1
            // 
            this.editPersonalInformation1.AgeInfo = "";
            this.editPersonalInformation1.BackColor = System.Drawing.Color.White;
            this.editPersonalInformation1.DOBInfo = new System.DateTime(2025, 11, 28, 9, 2, 33, 207);
            this.editPersonalInformation1.First_NAMEInfo = "";
            this.editPersonalInformation1.Last_NAMEInfo = "";
            this.editPersonalInformation1.Location = new System.Drawing.Point(31, 349);
            this.editPersonalInformation1.Middle_NAMEInfo = "";
            this.editPersonalInformation1.Name = "editPersonalInformation1";
            this.editPersonalInformation1.SexInfo = "";
            this.editPersonalInformation1.Size = new System.Drawing.Size(450, 203);
            this.editPersonalInformation1.TabIndex = 79;
            // 
            // editAddressInformation1
            // 
            this.editAddressInformation1.BackColor = System.Drawing.Color.White;
            this.editAddressInformation1.Barangay = "";
            this.editAddressInformation1.HouseNum = "";
            this.editAddressInformation1.Location = new System.Drawing.Point(28, 122);
            this.editAddressInformation1.Municipality = "";
            this.editAddressInformation1.Name = "editAddressInformation1";
            this.editAddressInformation1.Postal = "";
            this.editAddressInformation1.Province = "";
            this.editAddressInformation1.Size = new System.Drawing.Size(450, 200);
            this.editAddressInformation1.TabIndex = 78;
            // 
            // editAccountInformation1
            // 
            this.editAccountInformation1.BackColor = System.Drawing.Color.White;
            this.editAccountInformation1.ContactInfo = "";
            this.editAccountInformation1.EmailInfo = "";
            this.editAccountInformation1.Location = new System.Drawing.Point(495, 122);
            this.editAccountInformation1.Name = "editAccountInformation1";
            this.editAccountInformation1.PositionInfo = "label3";
            this.editAccountInformation1.Size = new System.Drawing.Size(280, 430);
            this.editAccountInformation1.StatusInfo = "label3";
            this.editAccountInformation1.TabIndex = 77;
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
            this.lbl.Size = new System.Drawing.Size(758, 55);
            this.lbl.TabIndex = 73;
            this.lbl.Text = "    Add Employee";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl.TextColor = System.Drawing.Color.White;
            this.lbl.UseMnemonic = false;
            // 
            // customTextBox1
            // 
            this.customTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.customTextBox1.BorderRadius = 0;
            this.customTextBox1.BorderSize = 2;
            this.customTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customTextBox1.Location = new System.Drawing.Point(141, 84);
            this.customTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBox1.Multiline = false;
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox1.PasswordChar = false;
            this.customTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox1.PlaceholderText = "";
            this.customTextBox1.Size = new System.Drawing.Size(151, 31);
            this.customTextBox1.TabIndex = 83;
            this.customTextBox1.Texts = "";
            this.customTextBox1.UnderlinedStyle = false;
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 570);
            this.Controls.Add(this.customTextBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tscStatus);
            this.Controls.Add(this.lblEmpID);
            this.Controls.Add(this.editPersonalInformation1);
            this.Controls.Add(this.editAddressInformation1);
            this.Controls.Add(this.editAccountInformation1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEmployeeForm";
            this.Text = "AddEmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private Materials.CustomLabel lbl;
        private Header.Settings.PersonalDetails.EditAccountInformation editAccountInformation1;
        private Header.Settings.Employee.EditAddressInformation editAddressInformation1;
        private Header.Settings.PersonalDetails.EditPersonalInformation editPersonalInformation1;
        private Materials.CustomLabel lblEmpID;
        private ToggleSlider.ToggleSliderComponent tscStatus;
        private Materials.CustomButton btnSave;
        private CustomControls.RJControls.CustomTextBox customTextBox1;
    }
}