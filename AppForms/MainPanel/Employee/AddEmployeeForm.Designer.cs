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
            this.cbxPosition = new ColdChainConnectSystem_ACDP.Materials.CustomComboBox();
            this.btnSave = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            this.tscStatus = new ToggleSlider.ToggleSliderComponent();
            this.lblPosition = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.editPersonalInformation1 = new ColdChainConnectSystem_ACDP.AppForms.Header.Settings.PersonalDetails.EditPersonalInformation();
            this.editAddressInformation1 = new ColdChainConnectSystem_ACDP.AppForms.Header.Settings.Employee.EditAddressInformation();
            this.editAccountInformation1 = new ColdChainConnectSystem_ACDP.AppForms.Header.Settings.PersonalDetails.EditAccountInformation();
            this.lbl = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.btnExit.BackgroundImage = global::ColdChainConnectSystem_ACDP.Properties.Resources.Back;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(728, 29);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(27, 27);
            this.btnExit.TabIndex = 8;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cbxPosition
            // 
            this.cbxPosition.BackColor = System.Drawing.Color.White;
            this.cbxPosition.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.cbxPosition.BorderRadius = 0;
            this.cbxPosition.BorderSize = 2;
            this.cbxPosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.cbxPosition.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.cbxPosition.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbxPosition.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.cbxPosition.Location = new System.Drawing.Point(141, 84);
            this.cbxPosition.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbxPosition.Name = "cbxPosition";
            this.cbxPosition.Padding = new System.Windows.Forms.Padding(1);
            this.cbxPosition.Size = new System.Drawing.Size(200, 31);
            this.cbxPosition.TabIndex = 83;
            this.cbxPosition.Texts = "";
            this.cbxPosition.OnSelectedIndexChanged += new System.EventHandler(this.cbxPosition_OnSelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.btnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.btnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.BorderRadius = 10;
            this.btnSave.BorderSize = 0;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.GradientColor1 = System.Drawing.Color.Transparent;
            this.btnSave.GradientColor2 = System.Drawing.Color.Transparent;
            this.btnSave.GradientTextColor = System.Drawing.Color.Transparent;
            this.btnSave.Location = new System.Drawing.Point(682, 78);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.TabIndex = 82;
            this.btnSave.Text = "Save";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            // lblPosition
            // 
            this.lblPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblPosition.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblPosition.BorderColor = System.Drawing.Color.Transparent;
            this.lblPosition.BorderRadius = 10;
            this.lblPosition.BorderSize = 0;
            this.lblPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPosition.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblPosition.ForeColor = System.Drawing.Color.White;
            this.lblPosition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPosition.Location = new System.Drawing.Point(28, 79);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(451, 40);
            this.lblPosition.TabIndex = 80;
            this.lblPosition.Text = "   Position:";
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPosition.TextColor = System.Drawing.Color.White;
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
            this.editAccountInformation1.Location = new System.Drawing.Point(502, 122);
            this.editAccountInformation1.Name = "editAccountInformation1";
            this.editAccountInformation1.PasswordInfo = "";
            this.editAccountInformation1.PositionInfo = "";
            this.editAccountInformation1.PositionInfoLabel = "position";
            this.editAccountInformation1.Size = new System.Drawing.Size(280, 430);
            this.editAccountInformation1.StatusInfo = "";
            this.editAccountInformation1.TabIndex = 77;
            this.editAccountInformation1.UsernameInfo = "";
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
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 570);
            this.Controls.Add(this.cbxPosition);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tscStatus);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.editPersonalInformation1);
            this.Controls.Add(this.editAddressInformation1);
            this.Controls.Add(this.editAccountInformation1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEmployeeForm";
            this.Text = "AddEmployeeForm";
            this.Load += new System.EventHandler(this.AddEmployeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private Materials.CustomLabel lbl;
        private Header.Settings.PersonalDetails.EditAccountInformation editAccountInformation1;
        private Header.Settings.Employee.EditAddressInformation editAddressInformation1;
        private Header.Settings.PersonalDetails.EditPersonalInformation editPersonalInformation1;
        private Materials.CustomLabel lblPosition;
        private ToggleSlider.ToggleSliderComponent tscStatus;
        private Materials.CustomButton btnSave;
        private Materials.CustomComboBox cbxPosition;
    }
}