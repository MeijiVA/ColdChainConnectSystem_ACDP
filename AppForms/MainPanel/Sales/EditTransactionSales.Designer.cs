namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Sales
{
    partial class EditTransactionSales
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
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TrackBar();
            this.lblPHP = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPriceTitle = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblQuantity = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.lblCustomerName = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.lblSku = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.lblProductID = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.lblCreatedBy = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.lblStatus = new ColdChainConnectSystem_ACDP.Materials.CustomComboBox();
            this.lblCustomerID = new ColdChainConnectSystem_ACDP.Materials.CustomComboBox();
            this.lblUnitPrice = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.btnSave = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            this.dpSalesDate = new ColdChainConnectSystem_ACDP.Materials.CustomDatePicker();
            this.lblID = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tbQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(240, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 14);
            this.label9.TabIndex = 68;
            this.label9.Text = "Unit Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(240, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 14);
            this.label5.TabIndex = 60;
            this.label5.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 14);
            this.label4.TabIndex = 58;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 56;
            this.label3.Text = "Product ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 14);
            this.label2.TabIndex = 54;
            this.label2.Text = "Sales Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 14);
            this.label1.TabIndex = 53;
            this.label1.Text = "Customer ID";
            // 
            // tbQuantity
            // 
            this.tbQuantity.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbQuantity.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.tbQuantity.Location = new System.Drawing.Point(9, 185);
            this.tbQuantity.Maximum = 60;
            this.tbQuantity.Minimum = 1;
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(183, 45);
            this.tbQuantity.TabIndex = 93;
            this.tbQuantity.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbQuantity.Value = 1;
            this.tbQuantity.Scroll += new System.EventHandler(this.tbQuantity_Scroll);
            // 
            // lblPHP
            // 
            this.lblPHP.AutoSize = true;
            this.lblPHP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblPHP.ForeColor = System.Drawing.Color.Green;
            this.lblPHP.Location = new System.Drawing.Point(545, 79);
            this.lblPHP.Name = "lblPHP";
            this.lblPHP.Size = new System.Drawing.Size(36, 16);
            this.lblPHP.TabIndex = 96;
            this.lblPHP.Text = "PHP";
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblPrice.ForeColor = System.Drawing.Color.Green;
            this.lblPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPrice.Location = new System.Drawing.Point(430, 79);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(117, 16);
            this.lblPrice.TabIndex = 95;
            this.lblPrice.Text = "0.00";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPriceTitle
            // 
            this.lblPriceTitle.AutoSize = true;
            this.lblPriceTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblPriceTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblPriceTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblPriceTitle.Location = new System.Drawing.Point(501, 59);
            this.lblPriceTitle.Name = "lblPriceTitle";
            this.lblPriceTitle.Size = new System.Drawing.Size(80, 16);
            this.lblPriceTitle.TabIndex = 94;
            this.lblPriceTitle.Text = "Total Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(9, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 14);
            this.label6.TabIndex = 100;
            this.label6.Text = "Created By";
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
            this.btnExit.Location = new System.Drawing.Point(550, 17);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(27, 27);
            this.btnExit.TabIndex = 104;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblQuantity.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblQuantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblQuantity.BorderRadius = 10;
            this.lblQuantity.BorderSize = 2;
            this.lblQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblQuantity.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblQuantity.ForeColor = System.Drawing.Color.Black;
            this.lblQuantity.Location = new System.Drawing.Point(190, 181);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(44, 30);
            this.lblQuantity.TabIndex = 105;
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblQuantity.TextColor = System.Drawing.Color.Black;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCustomerName.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCustomerName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCustomerName.BorderRadius = 10;
            this.lblCustomerName.BorderSize = 2;
            this.lblCustomerName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCustomerName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCustomerName.ForeColor = System.Drawing.Color.Black;
            this.lblCustomerName.Location = new System.Drawing.Point(198, 79);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(180, 30);
            this.lblCustomerName.TabIndex = 103;
            this.lblCustomerName.Text = "customLabel3";
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCustomerName.TextColor = System.Drawing.Color.Black;
            // 
            // lblSku
            // 
            this.lblSku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSku.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSku.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSku.BorderRadius = 10;
            this.lblSku.BorderSize = 2;
            this.lblSku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSku.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblSku.ForeColor = System.Drawing.Color.Black;
            this.lblSku.Location = new System.Drawing.Point(198, 128);
            this.lblSku.Name = "lblSku";
            this.lblSku.Size = new System.Drawing.Size(180, 30);
            this.lblSku.TabIndex = 102;
            this.lblSku.Text = "customLabel3";
            this.lblSku.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSku.TextColor = System.Drawing.Color.Black;
            // 
            // lblProductID
            // 
            this.lblProductID.BackColor = System.Drawing.Color.White;
            this.lblProductID.BackgroundColor = System.Drawing.Color.White;
            this.lblProductID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblProductID.BorderRadius = 10;
            this.lblProductID.BorderSize = 2;
            this.lblProductID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProductID.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblProductID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblProductID.Location = new System.Drawing.Point(12, 128);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblProductID.Size = new System.Drawing.Size(180, 30);
            this.lblProductID.TabIndex = 101;
            this.lblProductID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblProductID.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.BackColor = System.Drawing.Color.White;
            this.lblCreatedBy.BackgroundColor = System.Drawing.Color.White;
            this.lblCreatedBy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblCreatedBy.BorderRadius = 10;
            this.lblCreatedBy.BorderSize = 2;
            this.lblCreatedBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCreatedBy.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCreatedBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblCreatedBy.Location = new System.Drawing.Point(9, 299);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblCreatedBy.Size = new System.Drawing.Size(180, 30);
            this.lblCreatedBy.TabIndex = 99;
            this.lblCreatedBy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCreatedBy.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            // 
            // lblStatus
            // 
            this.lblStatus.AutoCompleteCustomSource.AddRange(new string[] {
            "GCASH",
            "PAYMAYA"});
            this.lblStatus.BackColor = System.Drawing.Color.White;
            this.lblStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblStatus.BorderRadius = 0;
            this.lblStatus.BorderSize = 2;
            this.lblStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblStatus.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblStatus.Items.AddRange(new object[] {
            "paid",
            "unpaid"});
            this.lblStatus.ListBackColor = System.Drawing.Color.White;
            this.lblStatus.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblStatus.Location = new System.Drawing.Point(243, 244);
            this.lblStatus.MinimumSize = new System.Drawing.Size(180, 30);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Padding = new System.Windows.Forms.Padding(2);
            this.lblStatus.Size = new System.Drawing.Size(180, 30);
            this.lblStatus.TabIndex = 98;
            this.lblStatus.Texts = "";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoCompleteCustomSource.AddRange(new string[] {
            "GCASH",
            "PAYMAYA"});
            this.lblCustomerID.BackColor = System.Drawing.Color.White;
            this.lblCustomerID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblCustomerID.BorderRadius = 0;
            this.lblCustomerID.BorderSize = 2;
            this.lblCustomerID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lblCustomerID.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCustomerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblCustomerID.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblCustomerID.ListBackColor = System.Drawing.Color.White;
            this.lblCustomerID.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblCustomerID.Location = new System.Drawing.Point(12, 76);
            this.lblCustomerID.MinimumSize = new System.Drawing.Size(180, 30);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Padding = new System.Windows.Forms.Padding(2);
            this.lblCustomerID.Size = new System.Drawing.Size(180, 30);
            this.lblCustomerID.TabIndex = 90;
            this.lblCustomerID.Texts = "";
            this.lblCustomerID.OnSelectedIndexChanged += new System.EventHandler(this.lblPaymentTerm_OnSelectedIndexChanged);
            this.lblCustomerID.Load += new System.EventHandler(this.lblPaymentTerm_Load);
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.BackColor = System.Drawing.Color.White;
            this.lblUnitPrice.BackgroundColor = System.Drawing.Color.White;
            this.lblUnitPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblUnitPrice.BorderRadius = 10;
            this.lblUnitPrice.BorderSize = 2;
            this.lblUnitPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUnitPrice.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblUnitPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblUnitPrice.Location = new System.Drawing.Point(240, 183);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblUnitPrice.Size = new System.Drawing.Size(180, 30);
            this.lblUnitPrice.TabIndex = 67;
            this.lblUnitPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUnitPrice.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
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
            this.btnSave.GradientColor1 = System.Drawing.Color.Transparent;
            this.btnSave.GradientColor2 = System.Drawing.Color.Transparent;
            this.btnSave.GradientTextColor = System.Drawing.Color.Transparent;
            this.btnSave.Location = new System.Drawing.Point(438, 314);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 40);
            this.btnSave.TabIndex = 62;
            this.btnSave.Text = "Save";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnExitView_Click);
            // 
            // dpSalesDate
            // 
            this.dpSalesDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.dpSalesDate.BorderSize = 2;
            this.dpSalesDate.CalendarFont = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.dpSalesDate.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dpSalesDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.dpSalesDate.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.dpSalesDate.Location = new System.Drawing.Point(12, 241);
            this.dpSalesDate.MinimumSize = new System.Drawing.Size(4, 30);
            this.dpSalesDate.Name = "dpSalesDate";
            this.dpSalesDate.Size = new System.Drawing.Size(180, 30);
            this.dpSalesDate.SkinColor = System.Drawing.Color.White;
            this.dpSalesDate.TabIndex = 61;
            this.dpSalesDate.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
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
            this.lblID.Location = new System.Drawing.Point(12, 11);
            this.lblID.Name = "lblID";
            this.lblID.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblID.Size = new System.Drawing.Size(576, 41);
            this.lblID.TabIndex = 51;
            this.lblID.Text = "customLabel1";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblID.TextColor = System.Drawing.Color.White;
            // 
            // EditTransactionSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(600, 365);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblSku);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCreatedBy);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblPHP);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblPriceTitle);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dpSalesDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.tbQuantity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditTransactionSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditTransactionSales";
            this.Load += new System.EventHandler(this.EditTransactionSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private Materials.CustomLabel lblUnitPrice;
        private Materials.CustomButton btnSave;
        private Materials.CustomDatePicker dpSalesDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Materials.CustomLabel lblID;
        private Materials.CustomComboBox lblCustomerID;
        private System.Windows.Forms.TrackBar tbQuantity;
        private System.Windows.Forms.Label lblPHP;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPriceTitle;
        private Materials.CustomComboBox lblStatus;
        private System.Windows.Forms.Label label6;
        private Materials.CustomLabel lblCreatedBy;
        private Materials.CustomLabel lblProductID;
        private Materials.CustomLabel lblSku;
        private Materials.CustomLabel lblCustomerName;
        private System.Windows.Forms.Button btnExit;
        private Materials.CustomLabel lblQuantity;
    }
}