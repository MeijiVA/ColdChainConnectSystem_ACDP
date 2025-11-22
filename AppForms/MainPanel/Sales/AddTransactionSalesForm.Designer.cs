namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Sales
{
    partial class AddTransactionSalesForm
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
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblSalesDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblSKU = new System.Windows.Forms.Label();
            this.dpSalesDate = new ColdChainConnectSystem_ACDP.Materials.CustomDatePicker();
            this.txtSales = new CustomControls.RJControls.CustomTextBox();
            this.txtQuantity = new CustomControls.RJControls.CustomTextBox();
            this.txtCustomerID = new CustomControls.RJControls.CustomTextBox();
            this.lbl = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.btnAdd = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            this.cbStatus = new ColdChainConnectSystem_ACDP.Materials.CustomComboBox();
            this.lblProductID = new System.Windows.Forms.Label();
            this.cbProductID = new ColdChainConnectSystem_ACDP.Materials.CustomComboBox();
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
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblCustomerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblCustomerID.Location = new System.Drawing.Point(307, 83);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(90, 16);
            this.lblCustomerID.TabIndex = 17;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // lblSalesDate
            // 
            this.lblSalesDate.AutoSize = true;
            this.lblSalesDate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblSalesDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblSalesDate.Location = new System.Drawing.Point(307, 206);
            this.lblSalesDate.Name = "lblSalesDate";
            this.lblSalesDate.Size = new System.Drawing.Size(79, 16);
            this.lblSalesDate.TabIndex = 20;
            this.lblSalesDate.Text = "Sales Date";
            this.lblSalesDate.Click += new System.EventHandler(this.lblExpiry_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblStatus.Location = new System.Drawing.Point(307, 144);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 16);
            this.lblStatus.TabIndex = 21;
            this.lblStatus.Text = "Status";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblQuantity.Location = new System.Drawing.Point(34, 205);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(64, 16);
            this.lblQuantity.TabIndex = 22;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblSKU
            // 
            this.lblSKU.AutoSize = true;
            this.lblSKU.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblSKU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblSKU.Location = new System.Drawing.Point(34, 83);
            this.lblSKU.Name = "lblSKU";
            this.lblSKU.Size = new System.Drawing.Size(62, 16);
            this.lblSKU.TabIndex = 23;
            this.lblSKU.Text = "Sales ID";
            // 
            // dpSalesDate
            // 
            this.dpSalesDate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dpSalesDate.BorderSize = 0;
            this.dpSalesDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dpSalesDate.Location = new System.Drawing.Point(310, 225);
            this.dpSalesDate.MinimumSize = new System.Drawing.Size(4, 35);
            this.dpSalesDate.Name = "dpSalesDate";
            this.dpSalesDate.Size = new System.Drawing.Size(250, 35);
            this.dpSalesDate.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.dpSalesDate.TabIndex = 19;
            this.dpSalesDate.TextColor = System.Drawing.Color.White;
            this.dpSalesDate.Value = new System.DateTime(2025, 11, 27, 0, 0, 0, 0);
            // 
            // txtSales
            // 
            this.txtSales.BackColor = System.Drawing.SystemColors.Window;
            this.txtSales.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.txtSales.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(150)))));
            this.txtSales.BorderRadius = 10;
            this.txtSales.BorderSize = 2;
            this.txtSales.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.txtSales.ForeColor = System.Drawing.Color.Black;
            this.txtSales.Location = new System.Drawing.Point(35, 103);
            this.txtSales.Margin = new System.Windows.Forms.Padding(4);
            this.txtSales.Multiline = false;
            this.txtSales.Name = "txtSales";
            this.txtSales.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSales.PasswordChar = false;
            this.txtSales.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSales.PlaceholderText = "";
            this.txtSales.Size = new System.Drawing.Size(250, 37);
            this.txtSales.TabIndex = 15;
            this.txtSales.Texts = "";
            this.txtSales.UnderlinedStyle = false;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.Window;
            this.txtQuantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.txtQuantity.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(150)))));
            this.txtQuantity.BorderRadius = 10;
            this.txtQuantity.BorderSize = 2;
            this.txtQuantity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.txtQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtQuantity.Location = new System.Drawing.Point(35, 225);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantity.Multiline = false;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtQuantity.PasswordChar = false;
            this.txtQuantity.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtQuantity.PlaceholderText = "";
            this.txtQuantity.Size = new System.Drawing.Size(250, 37);
            this.txtQuantity.TabIndex = 14;
            this.txtQuantity.Texts = "";
            this.txtQuantity.UnderlinedStyle = false;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
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
            this.txtCustomerID.Location = new System.Drawing.Point(310, 103);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerID.Multiline = true;
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCustomerID.PasswordChar = false;
            this.txtCustomerID.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtCustomerID.PlaceholderText = "";
            this.txtCustomerID.Size = new System.Drawing.Size(250, 37);
            this.txtCustomerID.TabIndex = 9;
            this.txtCustomerID.Texts = "";
            this.txtCustomerID.UnderlinedStyle = false;
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
            this.lbl.Text = "     Add Transaction (Sales)";
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
            this.cbStatus.Location = new System.Drawing.Point(310, 163);
            this.cbStatus.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(205, 37);
            this.cbStatus.TabIndex = 27;
            this.cbStatus.Texts = "";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblProductID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblProductID.Location = new System.Drawing.Point(34, 144);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(78, 16);
            this.lblProductID.TabIndex = 28;
            this.lblProductID.Text = "Product ID";
            // 
            // cbProductID
            // 
            this.cbProductID.BackColor = System.Drawing.Color.White;
            this.cbProductID.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cbProductID.BorderRadius = 0;
            this.cbProductID.BorderSize = 0;
            this.cbProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbProductID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbProductID.ForeColor = System.Drawing.Color.DimGray;
            this.cbProductID.IconColor = System.Drawing.Color.Navy;
            this.cbProductID.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbProductID.ListTextColor = System.Drawing.Color.DimGray;
            this.cbProductID.Location = new System.Drawing.Point(37, 165);
            this.cbProductID.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbProductID.Name = "cbProductID";
            this.cbProductID.Size = new System.Drawing.Size(248, 37);
            this.cbProductID.TabIndex = 29;
            this.cbProductID.Texts = "";

            // 
            // AddTransactionSalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 570);
            this.Controls.Add(this.cbProductID);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.lblSKU);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblSalesDate);
            this.Controls.Add(this.dpSalesDate);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.txtSales);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddTransactionSalesForm";
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
        private CustomControls.RJControls.CustomTextBox txtCustomerID;
        private CustomControls.RJControls.CustomTextBox txtQuantity;
        private CustomControls.RJControls.CustomTextBox txtSales;
        private System.Windows.Forms.Label lblCustomerID;
        private Materials.CustomDatePicker dpSalesDate;
        private System.Windows.Forms.Label lblSalesDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblSKU;
        private Materials.CustomComboBox cbStatus;
        private System.Windows.Forms.Label lblProductID;
        private Materials.CustomComboBox cbProductID;
    }
}