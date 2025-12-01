namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Customer
{
    partial class EditCustomer
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
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPaymentTerm = new ColdChainConnectSystem_ACDP.Materials.CustomComboBox();
            this.lblStatus = new ColdChainConnectSystem_ACDP.Materials.CustomComboBox();
            this.lblCustomerName = new CustomControls.RJControls.CustomTextBox();
            this.lblPhoneNumber = new CustomControls.RJControls.CustomTextBox();
            this.customPanel1 = new ColdChainConnectSystem_ACDP.Materials.CustomPanel();
            this.lblProvince = new ColdChainConnectSystem_ACDP.Materials.CustomComboBox();
            this.lblCity = new ColdChainConnectSystem_ACDP.Materials.CustomComboBox();
            this.lblPostal = new CustomControls.RJControls.CustomTextBox();
            this.lblBarangay = new CustomControls.RJControls.CustomTextBox();
            this.lblHouseNumber = new CustomControls.RJControls.CustomTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dpRegistrationDate = new ColdChainConnectSystem_ACDP.Materials.CustomDatePicker();
            this.btnSave = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            this.lblID = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.btnExit = new System.Windows.Forms.Button();
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(11, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 14);
            this.label10.TabIndex = 67;
            this.label10.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(8, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 14);
            this.label5.TabIndex = 63;
            this.label5.Text = "Registration Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(11, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 14);
            this.label2.TabIndex = 62;
            this.label2.Text = "Payment Term";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(11, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 14);
            this.label1.TabIndex = 60;
            this.label1.Text = "Phone Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(11, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 14);
            this.label8.TabIndex = 58;
            this.label8.Text = "Customer Name";
            // 
            // lblPaymentTerm
            // 
            this.lblPaymentTerm.AutoCompleteCustomSource.AddRange(new string[] {
            "GCASH",
            "PAYMAYA"});
            this.lblPaymentTerm.BackColor = System.Drawing.Color.White;
            this.lblPaymentTerm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblPaymentTerm.BorderRadius = 0;
            this.lblPaymentTerm.BorderSize = 2;
            this.lblPaymentTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lblPaymentTerm.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPaymentTerm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblPaymentTerm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblPaymentTerm.Items.AddRange(new object[] {
            "GCASH",
            "CASH",
            "MAYA",
            "BANK"});
            this.lblPaymentTerm.ListBackColor = System.Drawing.Color.White;
            this.lblPaymentTerm.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblPaymentTerm.Location = new System.Drawing.Point(10, 234);
            this.lblPaymentTerm.MinimumSize = new System.Drawing.Size(180, 30);
            this.lblPaymentTerm.Name = "lblPaymentTerm";
            this.lblPaymentTerm.Padding = new System.Windows.Forms.Padding(2);
            this.lblPaymentTerm.Size = new System.Drawing.Size(180, 30);
            this.lblPaymentTerm.TabIndex = 76;
            this.lblPaymentTerm.Texts = "";
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.White;
            this.lblStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblStatus.BorderRadius = 0;
            this.lblStatus.BorderSize = 2;
            this.lblStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblStatus.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblStatus.Items.AddRange(new object[] {
            "Inactive",
            "Active"});
            this.lblStatus.ListBackColor = System.Drawing.Color.White;
            this.lblStatus.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblStatus.Location = new System.Drawing.Point(10, 288);
            this.lblStatus.MinimumSize = new System.Drawing.Size(180, 30);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Padding = new System.Windows.Forms.Padding(2);
            this.lblStatus.Size = new System.Drawing.Size(180, 30);
            this.lblStatus.TabIndex = 75;
            this.lblStatus.Texts = "";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.BackColor = System.Drawing.SystemColors.Window;
            this.lblCustomerName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblCustomerName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(150)))));
            this.lblCustomerName.BorderRadius = 10;
            this.lblCustomerName.BorderSize = 2;
            this.lblCustomerName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCustomerName.Location = new System.Drawing.Point(10, 75);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(4);
            this.lblCustomerName.Multiline = false;
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.lblCustomerName.PasswordChar = false;
            this.lblCustomerName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.lblCustomerName.PlaceholderText = "";
            this.lblCustomerName.Size = new System.Drawing.Size(180, 29);
            this.lblCustomerName.TabIndex = 74;
            this.lblCustomerName.Texts = "";
            this.lblCustomerName.UnderlinedStyle = false;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.BackColor = System.Drawing.SystemColors.Window;
            this.lblPhoneNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblPhoneNumber.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(150)))));
            this.lblPhoneNumber.BorderRadius = 10;
            this.lblPhoneNumber.BorderSize = 2;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPhoneNumber.Location = new System.Drawing.Point(10, 130);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.lblPhoneNumber.Multiline = false;
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.lblPhoneNumber.PasswordChar = false;
            this.lblPhoneNumber.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.lblPhoneNumber.PlaceholderText = "";
            this.lblPhoneNumber.Size = new System.Drawing.Size(180, 29);
            this.lblPhoneNumber.TabIndex = 73;
            this.lblPhoneNumber.Texts = "";
            this.lblPhoneNumber.UnderlinedStyle = false;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BackgroundColor = System.Drawing.Color.White;
            this.customPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customPanel1.BorderRadius = 10;
            this.customPanel1.BorderSize = 2;
            this.customPanel1.Controls.Add(this.lblProvince);
            this.customPanel1.Controls.Add(this.lblCity);
            this.customPanel1.Controls.Add(this.lblPostal);
            this.customPanel1.Controls.Add(this.lblBarangay);
            this.customPanel1.Controls.Add(this.lblHouseNumber);
            this.customPanel1.Controls.Add(this.label9);
            this.customPanel1.Controls.Add(this.label7);
            this.customPanel1.Controls.Add(this.label3);
            this.customPanel1.Controls.Add(this.label6);
            this.customPanel1.Controls.Add(this.label4);
            this.customPanel1.ForeColor = System.Drawing.Color.White;
            this.customPanel1.Location = new System.Drawing.Point(197, 71);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(390, 192);
            this.customPanel1.TabIndex = 65;
            this.customPanel1.TextColor = System.Drawing.Color.White;
            this.customPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.customPanel1_Paint);
            // 
            // lblProvince
            // 
            this.lblProvince.BackColor = System.Drawing.Color.White;
            this.lblProvince.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblProvince.BorderRadius = 0;
            this.lblProvince.BorderSize = 2;
            this.lblProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lblProvince.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblProvince.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblProvince.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblProvince.Items.AddRange(new object[] {
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
            this.lblProvince.ListBackColor = System.Drawing.Color.White;
            this.lblProvince.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblProvince.Location = new System.Drawing.Point(203, 92);
            this.lblProvince.MinimumSize = new System.Drawing.Size(180, 30);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Padding = new System.Windows.Forms.Padding(2);
            this.lblProvince.Size = new System.Drawing.Size(180, 30);
            this.lblProvince.TabIndex = 80;
            this.lblProvince.Texts = "";
            this.lblProvince.OnSelectedIndexChanged += new System.EventHandler(this.customComboBox2_OnSelectedIndexChanged);
            this.lblProvince.Leave += new System.EventHandler(this.lblProvince_Leave);
            // 
            // lblCity
            // 
            this.lblCity.BackColor = System.Drawing.Color.White;
            this.lblCity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblCity.BorderRadius = 0;
            this.lblCity.BorderSize = 2;
            this.lblCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lblCity.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblCity.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblCity.ListBackColor = System.Drawing.Color.White;
            this.lblCity.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblCity.Location = new System.Drawing.Point(10, 92);
            this.lblCity.MinimumSize = new System.Drawing.Size(180, 30);
            this.lblCity.Name = "lblCity";
            this.lblCity.Padding = new System.Windows.Forms.Padding(2);
            this.lblCity.Size = new System.Drawing.Size(180, 30);
            this.lblCity.TabIndex = 77;
            this.lblCity.Texts = "";
            this.lblCity.OnSelectedIndexChanged += new System.EventHandler(this.lblCity_OnSelectedIndexChanged);
            // 
            // lblPostal
            // 
            this.lblPostal.BackColor = System.Drawing.SystemColors.Window;
            this.lblPostal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblPostal.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(150)))));
            this.lblPostal.BorderRadius = 10;
            this.lblPostal.BorderSize = 2;
            this.lblPostal.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPostal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPostal.Location = new System.Drawing.Point(10, 143);
            this.lblPostal.Margin = new System.Windows.Forms.Padding(4);
            this.lblPostal.Multiline = false;
            this.lblPostal.Name = "lblPostal";
            this.lblPostal.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.lblPostal.PasswordChar = false;
            this.lblPostal.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.lblPostal.PlaceholderText = "";
            this.lblPostal.Size = new System.Drawing.Size(180, 29);
            this.lblPostal.TabIndex = 79;
            this.lblPostal.Texts = "";
            this.lblPostal.UnderlinedStyle = false;
            // 
            // lblBarangay
            // 
            this.lblBarangay.BackColor = System.Drawing.SystemColors.Window;
            this.lblBarangay.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblBarangay.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(150)))));
            this.lblBarangay.BorderRadius = 10;
            this.lblBarangay.BorderSize = 2;
            this.lblBarangay.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblBarangay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblBarangay.Location = new System.Drawing.Point(203, 32);
            this.lblBarangay.Margin = new System.Windows.Forms.Padding(4);
            this.lblBarangay.Multiline = false;
            this.lblBarangay.Name = "lblBarangay";
            this.lblBarangay.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.lblBarangay.PasswordChar = false;
            this.lblBarangay.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.lblBarangay.PlaceholderText = "";
            this.lblBarangay.Size = new System.Drawing.Size(180, 29);
            this.lblBarangay.TabIndex = 76;
            this.lblBarangay.Texts = "";
            this.lblBarangay.UnderlinedStyle = false;
            // 
            // lblHouseNumber
            // 
            this.lblHouseNumber.BackColor = System.Drawing.SystemColors.Window;
            this.lblHouseNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblHouseNumber.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(150)))));
            this.lblHouseNumber.BorderRadius = 10;
            this.lblHouseNumber.BorderSize = 2;
            this.lblHouseNumber.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblHouseNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHouseNumber.Location = new System.Drawing.Point(10, 31);
            this.lblHouseNumber.Margin = new System.Windows.Forms.Padding(4);
            this.lblHouseNumber.Multiline = false;
            this.lblHouseNumber.Name = "lblHouseNumber";
            this.lblHouseNumber.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.lblHouseNumber.PasswordChar = false;
            this.lblHouseNumber.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.lblHouseNumber.PlaceholderText = "";
            this.lblHouseNumber.Size = new System.Drawing.Size(180, 29);
            this.lblHouseNumber.TabIndex = 75;
            this.lblHouseNumber.Texts = "";
            this.lblHouseNumber.UnderlinedStyle = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(202, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 14);
            this.label9.TabIndex = 39;
            this.label9.Text = "Province";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(10, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 14);
            this.label7.TabIndex = 37;
            this.label7.Text = "Postal Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(202, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 14);
            this.label3.TabIndex = 35;
            this.label3.Text = "Barangay";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(10, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 14);
            this.label6.TabIndex = 33;
            this.label6.Text = "House Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(10, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 14);
            this.label4.TabIndex = 31;
            this.label4.Text = "City / Municipality";
            // 
            // dpRegistrationDate
            // 
            this.dpRegistrationDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.dpRegistrationDate.BorderSize = 2;
            this.dpRegistrationDate.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dpRegistrationDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.dpRegistrationDate.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.dpRegistrationDate.Location = new System.Drawing.Point(11, 180);
            this.dpRegistrationDate.MinimumSize = new System.Drawing.Size(4, 30);
            this.dpRegistrationDate.Name = "dpRegistrationDate";
            this.dpRegistrationDate.Size = new System.Drawing.Size(180, 30);
            this.dpRegistrationDate.SkinColor = System.Drawing.Color.White;
            this.dpRegistrationDate.TabIndex = 64;
            this.dpRegistrationDate.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.btnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.btnSave.BorderColor = System.Drawing.Color.Empty;
            this.btnSave.BorderRadius = 10;
            this.btnSave.BorderSize = 2;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSave.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSave.GradientTextColor = System.Drawing.Color.Transparent;
            this.btnSave.Location = new System.Drawing.Point(437, 312);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 56;
            this.btnSave.Text = "Save";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblID.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblID.BorderColor = System.Drawing.Color.Black;
            this.lblID.BorderRadius = 10;
            this.lblID.BorderSize = 0;
            this.lblID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblID.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(11, 8);
            this.lblID.Name = "lblID";
            this.lblID.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblID.Size = new System.Drawing.Size(576, 38);
            this.lblID.TabIndex = 55;
            this.lblID.Text = "customLabel1";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblID.TextColor = System.Drawing.Color.White;
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
            this.btnExit.Location = new System.Drawing.Point(552, 14);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(27, 27);
            this.btnExit.TabIndex = 77;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // EditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(600, 365);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblPaymentTerm);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.dpRegistrationDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditCustomer";
            this.Load += new System.EventHandler(this.EditCustomer_Load);
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private Materials.CustomPanel customPanel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private Materials.CustomDatePicker dpRegistrationDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private Materials.CustomButton btnSave;
        private Materials.CustomLabel lblID;
        private CustomControls.RJControls.CustomTextBox lblCustomerName;
        private CustomControls.RJControls.CustomTextBox lblPhoneNumber;
        private CustomControls.RJControls.CustomTextBox lblHouseNumber;
        private CustomControls.RJControls.CustomTextBox lblPostal;
        private CustomControls.RJControls.CustomTextBox lblBarangay;
        private Materials.CustomComboBox lblStatus;
        private Materials.CustomComboBox lblPaymentTerm;
        private Materials.CustomComboBox lblProvince;
        private Materials.CustomComboBox lblCity;
        private System.Windows.Forms.Button btnExit;
    }
}