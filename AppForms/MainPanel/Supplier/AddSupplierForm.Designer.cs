namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Supplier
{
    partial class AddSupplierForm
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
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblContactPerson = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.txtSKU = new CustomControls.RJControls.CustomTextBox();
            this.txtContactNumber = new CustomControls.RJControls.CustomTextBox();
            this.txtContactPerson = new CustomControls.RJControls.CustomTextBox();
            this.lbl = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.btnAdd = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            this.txtCompanyName = new CustomControls.RJControls.CustomTextBox();
            this.txtAddress = new CustomControls.RJControls.CustomTextBox();
            this.lblPaymenTerm = new System.Windows.Forms.Label();
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
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblCompanyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblCompanyName.Location = new System.Drawing.Point(39, 145);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(113, 16);
            this.lblCompanyName.TabIndex = 17;
            this.lblCompanyName.Text = "Company Name";
            // 
            // lblContactPerson
            // 
            this.lblContactPerson.AutoSize = true;
            this.lblContactPerson.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblContactPerson.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblContactPerson.Location = new System.Drawing.Point(39, 206);
            this.lblContactPerson.Name = "lblContactPerson";
            this.lblContactPerson.Size = new System.Drawing.Size(110, 16);
            this.lblContactPerson.TabIndex = 18;
            this.lblContactPerson.Text = "Contact Person";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblContactNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblContactNumber.Location = new System.Drawing.Point(39, 267);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(117, 16);
            this.lblContactNumber.TabIndex = 21;
            this.lblContactNumber.Text = "Contact Number";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblAddress.Location = new System.Drawing.Point(39, 328);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(65, 16);
            this.lblAddress.TabIndex = 22;
            this.lblAddress.Text = "Address";
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblSupplierID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblSupplierID.Location = new System.Drawing.Point(39, 83);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(82, 16);
            this.lblSupplierID.TabIndex = 23;
            this.lblSupplierID.Text = "Supplier ID";
            // 
            // txtSKU
            // 
            this.txtSKU.BackColor = System.Drawing.SystemColors.Window;
            this.txtSKU.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.txtSKU.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(150)))));
            this.txtSKU.BorderRadius = 10;
            this.txtSKU.BorderSize = 2;
            this.txtSKU.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.txtSKU.ForeColor = System.Drawing.Color.Black;
            this.txtSKU.Location = new System.Drawing.Point(22, 103);
            this.txtSKU.Margin = new System.Windows.Forms.Padding(4);
            this.txtSKU.Multiline = false;
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSKU.PasswordChar = false;
            this.txtSKU.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSKU.PlaceholderText = "";
            this.txtSKU.Size = new System.Drawing.Size(250, 37);
            this.txtSKU.TabIndex = 15;
            this.txtSKU.Texts = "";
            this.txtSKU.UnderlinedStyle = false;
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.BackColor = System.Drawing.SystemColors.Window;
            this.txtContactNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.txtContactNumber.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(150)))));
            this.txtContactNumber.BorderRadius = 10;
            this.txtContactNumber.BorderSize = 2;
            this.txtContactNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.txtContactNumber.ForeColor = System.Drawing.Color.Black;
            this.txtContactNumber.Location = new System.Drawing.Point(24, 287);
            this.txtContactNumber.Margin = new System.Windows.Forms.Padding(4);
            this.txtContactNumber.Multiline = false;
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtContactNumber.PasswordChar = false;
            this.txtContactNumber.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtContactNumber.PlaceholderText = "";
            this.txtContactNumber.Size = new System.Drawing.Size(250, 37);
            this.txtContactNumber.TabIndex = 13;
            this.txtContactNumber.Texts = "";
            this.txtContactNumber.UnderlinedStyle = false;
            this.txtContactNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.customTextBox6_KeyPress);
            // 
            // txtContactPerson
            // 
            this.txtContactPerson.BackColor = System.Drawing.SystemColors.Window;
            this.txtContactPerson.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.txtContactPerson.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(150)))));
            this.txtContactPerson.BorderRadius = 10;
            this.txtContactPerson.BorderSize = 2;
            this.txtContactPerson.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.txtContactPerson.ForeColor = System.Drawing.Color.Black;
            this.txtContactPerson.Location = new System.Drawing.Point(24, 226);
            this.txtContactPerson.Margin = new System.Windows.Forms.Padding(4);
            this.txtContactPerson.Multiline = false;
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtContactPerson.PasswordChar = false;
            this.txtContactPerson.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtContactPerson.PlaceholderText = "";
            this.txtContactPerson.Size = new System.Drawing.Size(564, 37);
            this.txtContactPerson.TabIndex = 10;
            this.txtContactPerson.Texts = "";
            this.txtContactPerson.UnderlinedStyle = false;
            this.txtContactPerson.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitPrice_KeyPress);
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
            this.lbl.Text = "     Add Supplier";
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
            this.btnAdd.Text = "Add Item";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.BackColor = System.Drawing.SystemColors.Window;
            this.txtCompanyName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.txtCompanyName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(150)))));
            this.txtCompanyName.BorderRadius = 10;
            this.txtCompanyName.BorderSize = 2;
            this.txtCompanyName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.txtCompanyName.ForeColor = System.Drawing.Color.Black;
            this.txtCompanyName.Location = new System.Drawing.Point(22, 165);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompanyName.Multiline = false;
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCompanyName.PasswordChar = false;
            this.txtCompanyName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCompanyName.PlaceholderText = "";
            this.txtCompanyName.Size = new System.Drawing.Size(566, 37);
            this.txtCompanyName.TabIndex = 24;
            this.txtCompanyName.Texts = "";
            this.txtCompanyName.UnderlinedStyle = false;
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
            this.txtAddress.Location = new System.Drawing.Point(24, 348);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtAddress.PasswordChar = false;
            this.txtAddress.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtAddress.PlaceholderText = "";
            this.txtAddress.Size = new System.Drawing.Size(564, 81);
            this.txtAddress.TabIndex = 25;
            this.txtAddress.Texts = "";
            this.txtAddress.UnderlinedStyle = false;
            // 
            // lblPaymenTerm
            // 
            this.lblPaymenTerm.AutoSize = true;
            this.lblPaymenTerm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblPaymenTerm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblPaymenTerm.Location = new System.Drawing.Point(39, 433);
            this.lblPaymenTerm.Name = "lblPaymenTerm";
            this.lblPaymenTerm.Size = new System.Drawing.Size(99, 16);
            this.lblPaymenTerm.TabIndex = 26;
            this.lblPaymenTerm.Text = "Paymen Term";
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
            this.cbPaymentTerm.Location = new System.Drawing.Point(24, 461);
            this.cbPaymentTerm.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbPaymentTerm.Name = "cbPaymentTerm";
            this.cbPaymentTerm.Size = new System.Drawing.Size(205, 37);
            this.cbPaymentTerm.TabIndex = 28;
            this.cbPaymentTerm.Texts = "";
            // 
            // AddSupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 570);
            this.Controls.Add(this.cbPaymentTerm);
            this.Controls.Add(this.lblPaymenTerm);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.lblSupplierID);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblContactNumber);
            this.Controls.Add(this.lblContactPerson);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.txtSKU);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.txtContactPerson);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddSupplierForm";
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
        private CustomControls.RJControls.CustomTextBox txtContactPerson;
        private CustomControls.RJControls.CustomTextBox txtContactNumber;
        private CustomControls.RJControls.CustomTextBox txtSKU;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblContactPerson;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblSupplierID;
        private CustomControls.RJControls.CustomTextBox txtCompanyName;
        private CustomControls.RJControls.CustomTextBox txtAddress;
        private System.Windows.Forms.Label lblPaymenTerm;
        private Materials.CustomComboBox cbPaymentTerm;
    }
}