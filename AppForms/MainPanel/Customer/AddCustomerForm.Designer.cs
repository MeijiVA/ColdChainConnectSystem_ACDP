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
            this.btnExit = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblRegistrationDate = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblPaymenTerm = new System.Windows.Forms.Label();
            this.dpRegDate = new ColdChainConnectSystem_ACDP.Materials.CustomDatePicker();
            this.txtCustomerName = new CustomControls.RJControls.CustomTextBox();
            this.txtPhoneNumber = new CustomControls.RJControls.CustomTextBox();
            this.lbl = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.btnAdd = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.cbxStatus = new ColdChainConnectSystem_ACDP.Materials.CustomComboBox();
            this.cbxPaymentTerm = new ColdChainConnectSystem_ACDP.Materials.CustomComboBox();
            this.customPanel1 = new ColdChainConnectSystem_ACDP.Materials.CustomPanel();
            this.cbxProvince = new ColdChainConnectSystem_ACDP.Materials.CustomComboBox();
            this.txtPostalCode = new CustomControls.RJControls.CustomTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxCity = new ColdChainConnectSystem_ACDP.Materials.CustomComboBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtBarangay = new CustomControls.RJControls.CustomTextBox();
            this.txtHouseNum = new CustomControls.RJControls.CustomTextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.customPanel2 = new ColdChainConnectSystem_ACDP.Materials.CustomPanel();
            this.lblgeen = new System.Windows.Forms.Label();
            this.customPanel1.SuspendLayout();
            this.customPanel2.SuspendLayout();
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
            this.btnExit.Location = new System.Drawing.Point(732, 36);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(27, 27);
            this.btnExit.TabIndex = 7;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblStatus.Location = new System.Drawing.Point(31, 257);
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
            this.lblRegistrationDate.Location = new System.Drawing.Point(30, 133);
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
            this.lblPhoneNumber.Location = new System.Drawing.Point(22, 73);
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
            this.lblPaymenTerm.Location = new System.Drawing.Point(28, 193);
            this.lblPaymenTerm.Name = "lblPaymenTerm";
            this.lblPaymenTerm.Size = new System.Drawing.Size(104, 16);
            this.lblPaymenTerm.TabIndex = 22;
            this.lblPaymenTerm.Text = "Payment Term";
            // 
            // dpRegDate
            // 
            this.dpRegDate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dpRegDate.BorderSize = 0;
            this.dpRegDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dpRegDate.Location = new System.Drawing.Point(23, 155);
            this.dpRegDate.MinimumSize = new System.Drawing.Size(4, 35);
            this.dpRegDate.Name = "dpRegDate";
            this.dpRegDate.Size = new System.Drawing.Size(250, 35);
            this.dpRegDate.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.dpRegDate.TabIndex = 19;
            this.dpRegDate.TextColor = System.Drawing.Color.White;
            this.dpRegDate.Value = new System.DateTime(2025, 11, 23, 16, 55, 3, 0);
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
            this.txtCustomerName.Location = new System.Drawing.Point(23, 33);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerName.Multiline = false;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCustomerName.PasswordChar = false;
            this.txtCustomerName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCustomerName.PlaceholderText = "";
            this.txtCustomerName.Size = new System.Drawing.Size(250, 37);
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
            this.txtPhoneNumber.Location = new System.Drawing.Point(23, 93);
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
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblCustomerName.Location = new System.Drawing.Point(22, 13);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(115, 16);
            this.lblCustomerName.TabIndex = 24;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // cbxStatus
            // 
            this.cbxStatus.BackColor = System.Drawing.Color.White;
            this.cbxStatus.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cbxStatus.BorderRadius = 0;
            this.cbxStatus.BorderSize = 0;
            this.cbxStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbxStatus.ForeColor = System.Drawing.Color.DimGray;
            this.cbxStatus.IconColor = System.Drawing.Color.Navy;
            this.cbxStatus.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbxStatus.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxStatus.Location = new System.Drawing.Point(24, 277);
            this.cbxStatus.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.Size = new System.Drawing.Size(212, 37);
            this.cbxStatus.TabIndex = 26;
            this.cbxStatus.Texts = "";
            // 
            // cbxPaymentTerm
            // 
            this.cbxPaymentTerm.BackColor = System.Drawing.Color.White;
            this.cbxPaymentTerm.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cbxPaymentTerm.BorderRadius = 0;
            this.cbxPaymentTerm.BorderSize = 0;
            this.cbxPaymentTerm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbxPaymentTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPaymentTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbxPaymentTerm.ForeColor = System.Drawing.Color.DimGray;
            this.cbxPaymentTerm.IconColor = System.Drawing.Color.Navy;
            this.cbxPaymentTerm.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbxPaymentTerm.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxPaymentTerm.Location = new System.Drawing.Point(23, 216);
            this.cbxPaymentTerm.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbxPaymentTerm.Name = "cbxPaymentTerm";
            this.cbxPaymentTerm.Size = new System.Drawing.Size(213, 37);
            this.cbxPaymentTerm.TabIndex = 27;
            this.cbxPaymentTerm.Texts = "";
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BackgroundColor = System.Drawing.Color.White;
            this.customPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customPanel1.BorderRadius = 15;
            this.customPanel1.BorderSize = 2;
            this.customPanel1.Controls.Add(this.cbxProvince);
            this.customPanel1.Controls.Add(this.txtPostalCode);
            this.customPanel1.Controls.Add(this.label7);
            this.customPanel1.Controls.Add(this.cbxCity);
            this.customPanel1.Controls.Add(this.lbl4);
            this.customPanel1.Controls.Add(this.lbl2);
            this.customPanel1.Controls.Add(this.txtBarangay);
            this.customPanel1.Controls.Add(this.txtHouseNum);
            this.customPanel1.Controls.Add(this.lbl1);
            this.customPanel1.Controls.Add(this.lbl3);
            this.customPanel1.ForeColor = System.Drawing.Color.White;
            this.customPanel1.Location = new System.Drawing.Point(403, 106);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.customPanel1.Size = new System.Drawing.Size(371, 369);
            this.customPanel1.TabIndex = 71;
            this.customPanel1.TextColor = System.Drawing.Color.White;
            // 
            // cbxProvince
            // 
            this.cbxProvince.BackColor = System.Drawing.Color.White;
            this.cbxProvince.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.cbxProvince.BorderRadius = 0;
            this.cbxProvince.BorderSize = 1;
            this.cbxProvince.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbxProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProvince.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.cbxProvince.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.cbxProvince.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.cbxProvince.Items.AddRange(new object[] {
            "Abra",
            "Agusan del Norte",
            "Agusan del Sur",
            "Aklan",
            "Albay",
            "Antique",
            "Apayao",
            "Aurora",
            "Basilan",
            "Bataan",
            "Batanes",
            "Batangas",
            "Benguet",
            "Biliran",
            "Bohol",
            "Bukidnon",
            "Bulacan",
            "Cagayan",
            "Camarines Norte",
            "Camarines Sur",
            "Camiguin",
            "Capiz",
            "Catanduanes",
            "Cavite",
            "Cebu",
            "Cotabato",
            "Davao de Oro",
            "Davao del Norte",
            "Davao del Sur",
            "Davao Occidental",
            "Davao Oriental",
            "Dinagat Islands",
            "Eastern Samar",
            "Guimaras",
            "Ifugao",
            "Ilocos Norte",
            "Ilocos Sur",
            "Iloilo",
            "Isabela",
            "Kalinga",
            "La Union",
            "Laguna",
            "Lanao del Norte",
            "Lanao del Sur",
            "Leyte",
            "Maguindanao",
            "Marinduque",
            "Masbate",
            "Misamis Occidental",
            "Misamis Oriental",
            "Mountain Province",
            "Negros Occidental",
            "Negros Oriental",
            "Northern Samar",
            "Nueva Ecija",
            "Nueva Vizcaya",
            "Occidental Mindoro",
            "Oriental Mindoro",
            "Palawan",
            "Pampanga",
            "Pangasinan",
            "Quezon",
            "Quirino",
            "Rizal",
            "Romblon",
            "Samar",
            "Sarangani",
            "Siquijor",
            "Sorsogon",
            "South Cotabato",
            "Southern Leyte",
            "Sultan Kudarat",
            "Sulu",
            "Surigao del Norte",
            "Surigao del Sur",
            "Tarlac",
            "Tawi-Tawi",
            "Zambales",
            "Zamboanga del Norte",
            "Zamboanga del Sur",
            "Zamboanga Sibugay"});
            this.cbxProvince.ListBackColor = System.Drawing.Color.White;
            this.cbxProvince.ListTextColor = System.Drawing.Color.Black;
            this.cbxProvince.Location = new System.Drawing.Point(17, 33);
            this.cbxProvince.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbxProvince.Name = "cbxProvince";
            this.cbxProvince.Padding = new System.Windows.Forms.Padding(1);
            this.cbxProvince.Size = new System.Drawing.Size(231, 37);
            this.cbxProvince.TabIndex = 76;
            this.cbxProvince.Texts = "";
            this.cbxProvince.OnSelectedIndexChanged += new System.EventHandler(this.cbxProvince_OnSelectedIndexChanged_1);
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtPostalCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.txtPostalCode.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(150)))));
            this.txtPostalCode.BorderRadius = 10;
            this.txtPostalCode.BorderSize = 2;
            this.txtPostalCode.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.txtPostalCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.txtPostalCode.Location = new System.Drawing.Point(17, 274);
            this.txtPostalCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtPostalCode.Multiline = false;
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPostalCode.PasswordChar = false;
            this.txtPostalCode.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPostalCode.PlaceholderText = "";
            this.txtPostalCode.Size = new System.Drawing.Size(180, 37);
            this.txtPostalCode.TabIndex = 75;
            this.txtPostalCode.Texts = "";
            this.txtPostalCode.UnderlinedStyle = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.label7.Location = new System.Drawing.Point(14, 254);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 16);
            this.label7.TabIndex = 73;
            this.label7.Text = "  Postal Code";
            // 
            // cbxCity
            // 
            this.cbxCity.BackColor = System.Drawing.Color.White;
            this.cbxCity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.cbxCity.BorderRadius = 0;
            this.cbxCity.BorderSize = 1;
            this.cbxCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.cbxCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.cbxCity.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.cbxCity.ListBackColor = System.Drawing.Color.White;
            this.cbxCity.ListTextColor = System.Drawing.Color.Black;
            this.cbxCity.Location = new System.Drawing.Point(17, 93);
            this.cbxCity.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbxCity.Name = "cbxCity";
            this.cbxCity.Padding = new System.Windows.Forms.Padding(1);
            this.cbxCity.Size = new System.Drawing.Size(231, 37);
            this.cbxCity.TabIndex = 29;
            this.cbxCity.Texts = "";
            // 
            // lbl4
            // 
            this.lbl4.BackColor = System.Drawing.Color.Transparent;
            this.lbl4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbl4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lbl4.Location = new System.Drawing.Point(14, 13);
            this.lbl4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(225, 16);
            this.lbl4.TabIndex = 73;
            this.lbl4.Text = "  Province";
            // 
            // lbl2
            // 
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lbl2.Location = new System.Drawing.Point(14, 73);
            this.lbl2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(225, 16);
            this.lbl2.TabIndex = 72;
            this.lbl2.Text = "  City / Municipality";
            // 
            // txtBarangay
            // 
            this.txtBarangay.BackColor = System.Drawing.SystemColors.Window;
            this.txtBarangay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.txtBarangay.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(150)))));
            this.txtBarangay.BorderRadius = 10;
            this.txtBarangay.BorderSize = 2;
            this.txtBarangay.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.txtBarangay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.txtBarangay.Location = new System.Drawing.Point(17, 214);
            this.txtBarangay.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarangay.Multiline = false;
            this.txtBarangay.Name = "txtBarangay";
            this.txtBarangay.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBarangay.PasswordChar = false;
            this.txtBarangay.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtBarangay.PlaceholderText = "";
            this.txtBarangay.Size = new System.Drawing.Size(339, 37);
            this.txtBarangay.TabIndex = 71;
            this.txtBarangay.Texts = "";
            this.txtBarangay.UnderlinedStyle = false;
            // 
            // txtHouseNum
            // 
            this.txtHouseNum.BackColor = System.Drawing.SystemColors.Window;
            this.txtHouseNum.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.txtHouseNum.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(150)))));
            this.txtHouseNum.BorderRadius = 10;
            this.txtHouseNum.BorderSize = 2;
            this.txtHouseNum.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.txtHouseNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.txtHouseNum.Location = new System.Drawing.Point(17, 153);
            this.txtHouseNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtHouseNum.Multiline = false;
            this.txtHouseNum.Name = "txtHouseNum";
            this.txtHouseNum.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtHouseNum.PasswordChar = false;
            this.txtHouseNum.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtHouseNum.PlaceholderText = "";
            this.txtHouseNum.Size = new System.Drawing.Size(180, 37);
            this.txtHouseNum.TabIndex = 70;
            this.txtHouseNum.Texts = "";
            this.txtHouseNum.UnderlinedStyle = false;
            // 
            // lbl1
            // 
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lbl1.Location = new System.Drawing.Point(14, 194);
            this.lbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(225, 16);
            this.lbl1.TabIndex = 66;
            this.lbl1.Text = "  Barangay";
            // 
            // lbl3
            // 
            this.lbl3.BackColor = System.Drawing.Color.Transparent;
            this.lbl3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbl3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lbl3.Location = new System.Drawing.Point(14, 133);
            this.lbl3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(131, 16);
            this.lbl3.TabIndex = 65;
            this.lbl3.Text = "  House No.";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblAddress.Location = new System.Drawing.Point(417, 87);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(65, 16);
            this.lblAddress.TabIndex = 70;
            this.lblAddress.Text = "Address";
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.White;
            this.customPanel2.BackgroundColor = System.Drawing.Color.White;
            this.customPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customPanel2.BorderRadius = 15;
            this.customPanel2.BorderSize = 2;
            this.customPanel2.Controls.Add(this.cbxStatus);
            this.customPanel2.Controls.Add(this.txtPhoneNumber);
            this.customPanel2.Controls.Add(this.txtCustomerName);
            this.customPanel2.Controls.Add(this.cbxPaymentTerm);
            this.customPanel2.Controls.Add(this.lblStatus);
            this.customPanel2.Controls.Add(this.dpRegDate);
            this.customPanel2.Controls.Add(this.lblCustomerName);
            this.customPanel2.Controls.Add(this.lblRegistrationDate);
            this.customPanel2.Controls.Add(this.lblPaymenTerm);
            this.customPanel2.Controls.Add(this.lblPhoneNumber);
            this.customPanel2.ForeColor = System.Drawing.Color.White;
            this.customPanel2.Location = new System.Drawing.Point(23, 106);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.customPanel2.Size = new System.Drawing.Size(371, 424);
            this.customPanel2.TabIndex = 76;
            this.customPanel2.TextColor = System.Drawing.Color.White;
            // 
            // lblgeen
            // 
            this.lblgeen.AutoSize = true;
            this.lblgeen.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblgeen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblgeen.Location = new System.Drawing.Point(43, 87);
            this.lblgeen.Name = "lblgeen";
            this.lblgeen.Size = new System.Drawing.Size(140, 16);
            this.lblgeen.TabIndex = 77;
            this.lblgeen.Text = "General Information";
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 570);
            this.Controls.Add(this.lblgeen);
            this.Controls.Add(this.customPanel2);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCustomerForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "AddItemInventoryForm";
            this.Load += new System.EventHandler(this.AddItemInventoryForm_Load);
            this.customPanel1.ResumeLayout(false);
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Materials.CustomButton btnAdd;
        private Materials.CustomLabel lbl;
        private System.Windows.Forms.Button btnExit;
        private CustomControls.RJControls.CustomTextBox txtCustomerName;
        private CustomControls.RJControls.CustomTextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblStatus;
        private Materials.CustomDatePicker dpRegDate;
        private System.Windows.Forms.Label lblRegistrationDate;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblPaymenTerm;
        private System.Windows.Forms.Label lblCustomerName;
        private Materials.CustomComboBox cbxStatus;
        private Materials.CustomComboBox cbxPaymentTerm;
        private Materials.CustomPanel customPanel1;
        private CustomControls.RJControls.CustomTextBox txtPostalCode;
        private System.Windows.Forms.Label label7;
        private Materials.CustomComboBox cbxCity;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl2;
        private CustomControls.RJControls.CustomTextBox txtBarangay;
        private CustomControls.RJControls.CustomTextBox txtHouseNum;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lblAddress;
        private Materials.CustomPanel customPanel2;
        private System.Windows.Forms.Label lblgeen;
        private Materials.CustomComboBox cbxProvince;
    }
}