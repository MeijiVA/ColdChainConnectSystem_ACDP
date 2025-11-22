namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Customer
{
    partial class AddCustomerForm
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
            this.ofdSaveImage = new System.Windows.Forms.OpenFileDialog();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblRegistrationDate = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblPaymenTerm = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.dpExpiry = new ColdChainConnectSystem_ACDP.Materials.CustomDatePicker();
            this.txtCustomerID = new CustomControls.RJControls.CustomTextBox();
            this.txtCustomerName = new CustomControls.RJControls.CustomTextBox();
            this.txtPhoneNumber = new CustomControls.RJControls.CustomTextBox();
            this.lbl = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.btnAdd = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            this.txtAddress = new CustomControls.RJControls.CustomTextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.cbStatus = new ColdChainConnectSystem_ACDP.Materials.CustomComboBox();
            this.cbPaymentTerm = new ColdChainConnectSystem_ACDP.Materials.CustomComboBox();
            this.SuspendLayout();
            // 
            // ofdSaveImage
            // 
            this.ofdSaveImage.InitialDirectory = "string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.Special" +
    "Folder.UserProfile), \"Downloads\");";
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
            this.btnExit.Location = new System.Drawing.Point(732, 36);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(27, 27);
            this.btnExit.TabIndex = 7;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblAddress.Location = new System.Drawing.Point(34, 265);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(65, 16);
            this.lblAddress.TabIndex = 17;
            this.lblAddress.Text = "Address";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblStatus.Location = new System.Drawing.Point(317, 205);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 16);
            this.lblStatus.TabIndex = 18;
            this.lblStatus.Text = "Status";
            // 
            // lblRegistrationDate
            // 
            this.lblRegistrationDate.AutoSize = true;
            this.lblRegistrationDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblRegistrationDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblRegistrationDate.Location = new System.Drawing.Point(317, 370);
            this.lblRegistrationDate.Name = "lblRegistrationDate";
            this.lblRegistrationDate.Size = new System.Drawing.Size(125, 16);
            this.lblRegistrationDate.TabIndex = 20;
            this.lblRegistrationDate.Text = "Registration Date";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblPhoneNumber.Location = new System.Drawing.Point(34, 205);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(106, 16);
            this.lblPhoneNumber.TabIndex = 21;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // lblPaymenTerm
            // 
            this.lblPaymenTerm.AutoSize = true;
            this.lblPaymenTerm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblPaymenTerm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblPaymenTerm.Location = new System.Drawing.Point(34, 370);
            this.lblPaymenTerm.Name = "lblPaymenTerm";
            this.lblPaymenTerm.Size = new System.Drawing.Size(99, 16);
            this.lblPaymenTerm.TabIndex = 22;
            this.lblPaymenTerm.Text = "Paymen Term";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblCustomerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblCustomerID.Location = new System.Drawing.Point(34, 83);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(90, 16);
            this.lblCustomerID.TabIndex = 23;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // dpExpiry
            // 
            this.dpExpiry.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dpExpiry.BorderSize = 0;
            this.dpExpiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dpExpiry.Location = new System.Drawing.Point(310, 397);
            this.dpExpiry.MinimumSize = new System.Drawing.Size(4, 35);
            this.dpExpiry.Name = "dpExpiry";
            this.dpExpiry.Size = new System.Drawing.Size(250, 35);
            this.dpExpiry.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.dpExpiry.TabIndex = 19;
            this.dpExpiry.TextColor = System.Drawing.Color.White;
            this.dpExpiry.Value = new System.DateTime(2025, 11, 27, 0, 0, 0, 0);
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.BackColor = System.Drawing.SystemColors.Window;
            this.txtCustomerID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.txtCustomerID.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(150)))));
            this.txtCustomerID.BorderRadius = 10;
            this.txtCustomerID.BorderSize = 2;
            this.txtCustomerID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.txtCustomerID.ForeColor = System.Drawing.Color.Black;
            this.txtCustomerID.Location = new System.Drawing.Point(35, 103);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerID.Multiline = false;
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCustomerID.PasswordChar = false;
            this.txtCustomerID.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCustomerID.PlaceholderText = "";
            this.txtCustomerID.Size = new System.Drawing.Size(250, 37);
            this.txtCustomerID.TabIndex = 15;
            this.txtCustomerID.Texts = "";
            this.txtCustomerID.UnderlinedStyle = false;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.SystemColors.Window;
            this.txtCustomerName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.txtCustomerName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(150)))));
            this.txtCustomerName.BorderRadius = 10;
            this.txtCustomerName.BorderSize = 2;
            this.txtCustomerName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.txtCustomerName.ForeColor = System.Drawing.Color.Black;
            this.txtCustomerName.Location = new System.Drawing.Point(35, 164);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerName.Multiline = false;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCustomerName.PasswordChar = false;
            this.txtCustomerName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCustomerName.PlaceholderText = "";
            this.txtCustomerName.Size = new System.Drawing.Size(564, 37);
            this.txtCustomerName.TabIndex = 14;
            this.txtCustomerName.Texts = "";
            this.txtCustomerName.UnderlinedStyle = false;
            this.txtCustomerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtPhoneNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.txtPhoneNumber.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(150)))));
            this.txtPhoneNumber.BorderRadius = 10;
            this.txtPhoneNumber.BorderSize = 2;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.Black;
            this.txtPhoneNumber.Location = new System.Drawing.Point(35, 225);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhoneNumber.Multiline = false;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPhoneNumber.PasswordChar = false;
            this.txtPhoneNumber.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPhoneNumber.PlaceholderText = "";
            this.txtPhoneNumber.Size = new System.Drawing.Size(250, 37);
            this.txtPhoneNumber.TabIndex = 13;
            this.txtPhoneNumber.Texts = "";
            this.txtPhoneNumber.UnderlinedStyle = false;
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.customTextBox6_KeyPress);
            // 
            // lbl
            // 
            this.lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lbl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lbl.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.lbl.BorderRadius = 10;
            this.lbl.BorderSize = 0;
            this.lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(20, 20);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(758, 55);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "     Add Customer";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl.TextColor = System.Drawing.Color.White;
            this.lbl.UseMnemonic = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.btnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.btnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(624, 507);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Customer";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.txtAddress.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(150)))));
            this.txtAddress.BorderRadius = 10;
            this.txtAddress.BorderSize = 2;
            this.txtAddress.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.Location = new System.Drawing.Point(35, 285);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtAddress.PasswordChar = false;
            this.txtAddress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.Size = new System.Drawing.Size(564, 81);
            this.txtAddress.TabIndex = 9;
            this.txtAddress.Texts = "";
            this.txtAddress.UnderlinedStyle = false;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblCustomerName.Location = new System.Drawing.Point(34, 144);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(111, 16);
            this.lblCustomerName.TabIndex = 24;
            this.lblCustomerName.Text = "CustomerName";
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.White;
            this.cbStatus.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cbStatus.BorderRadius = 0;
            this.cbStatus.BorderSize = 0;
            this.cbStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbStatus.ForeColor = System.Drawing.Color.DimGray;
            this.cbStatus.IconColor = System.Drawing.Color.Navy;
            this.cbStatus.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbStatus.ListTextColor = System.Drawing.Color.DimGray;
            this.cbStatus.Location = new System.Drawing.Point(310, 225);
            this.cbStatus.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(205, 37);
            this.cbStatus.TabIndex = 26;
            this.cbStatus.Texts = "";
            // 
            // cbPaymentTerm
            // 
            this.cbPaymentTerm.BackColor = System.Drawing.Color.White;
            this.cbPaymentTerm.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cbPaymentTerm.BorderRadius = 0;
            this.cbPaymentTerm.BorderSize = 0;
            this.cbPaymentTerm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbPaymentTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbPaymentTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbPaymentTerm.ForeColor = System.Drawing.Color.DimGray;
            this.cbPaymentTerm.IconColor = System.Drawing.Color.Navy;
            this.cbPaymentTerm.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbPaymentTerm.ListTextColor = System.Drawing.Color.DimGray;
            this.cbPaymentTerm.Location = new System.Drawing.Point(37, 397);
            this.cbPaymentTerm.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbPaymentTerm.Name = "cbPaymentTerm";
            this.cbPaymentTerm.Size = new System.Drawing.Size(205, 37);
            this.cbPaymentTerm.TabIndex = 27;
            this.cbPaymentTerm.Texts = "";
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 570);
            this.Controls.Add(this.cbPaymentTerm);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblPaymenTerm);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblRegistrationDate);
            this.Controls.Add(this.dpExpiry);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCustomerForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "AddItemInventoryForm";
            this.Load += new System.EventHandler(this.AddItemInventoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Materials.CustomButton btnAdd;
        private Materials.CustomLabel lbl;
        private System.Windows.Forms.OpenFileDialog ofdSaveImage;
        private System.Windows.Forms.Button btnExit;
        private CustomControls.RJControls.CustomTextBox txtCustomerName;
        private CustomControls.RJControls.CustomTextBox txtPhoneNumber;
        private CustomControls.RJControls.CustomTextBox txtCustomerID;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblStatus;
        private Materials.CustomDatePicker dpExpiry;
        private System.Windows.Forms.Label lblRegistrationDate;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblPaymenTerm;
        private System.Windows.Forms.Label lblCustomerID;
        private CustomControls.RJControls.CustomTextBox txtAddress;
        private System.Windows.Forms.Label lblCustomerName;
        private Materials.CustomComboBox cbStatus;
        private Materials.CustomComboBox cbPaymentTerm;
    }
}