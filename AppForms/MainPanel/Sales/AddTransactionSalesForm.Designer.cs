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
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lblSalesDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TrackBar();
            this.lblPriceTitle = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPHP = new System.Windows.Forms.Label();
            this.cbCustomerID = new ColdChainConnectSystem_ACDP.Materials.CustomComboBox();
            this.lblQuantityValue = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.lblUnitPrice = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.cbProductID = new ColdChainConnectSystem_ACDP.Materials.CustomComboBox();
            this.cbStatus = new ColdChainConnectSystem_ACDP.Materials.CustomComboBox();
            this.dpSalesDate = new ColdChainConnectSystem_ACDP.Materials.CustomDatePicker();
            this.lbl = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.btnAdd = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            this.lblCustomerName = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tbQuantity)).BeginInit();
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
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblCustomerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblCustomerID.Location = new System.Drawing.Point(34, 83);
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
            this.lblSalesDate.Location = new System.Drawing.Point(34, 153);
            this.lblSalesDate.Name = "lblSalesDate";
            this.lblSalesDate.Size = new System.Drawing.Size(79, 16);
            this.lblSalesDate.TabIndex = 20;
            this.lblSalesDate.Text = "Sales Date";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblStatus.Location = new System.Drawing.Point(34, 335);
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
            this.lblQuantity.Location = new System.Drawing.Point(34, 278);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(64, 16);
            this.lblQuantity.TabIndex = 22;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblProductID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblProductID.Location = new System.Drawing.Point(34, 217);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(97, 16);
            this.lblProductID.TabIndex = 28;
            this.lblProductID.Text = "Item Batch ID";
            // 
            // tbQuantity
            // 
            this.tbQuantity.BackColor = System.Drawing.Color.White;
            this.tbQuantity.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.tbQuantity.Location = new System.Drawing.Point(37, 303);
            this.tbQuantity.Maximum = 60;
            this.tbQuantity.Minimum = 1;
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(200, 45);
            this.tbQuantity.TabIndex = 30;
            this.tbQuantity.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbQuantity.Value = 1;
            this.tbQuantity.Scroll += new System.EventHandler(this.tbQuantity_Scroll);
            this.tbQuantity.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tbQuantity_MouseMove);
            // 
            // lblPriceTitle
            // 
            this.lblPriceTitle.AutoSize = true;
            this.lblPriceTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblPriceTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblPriceTitle.Location = new System.Drawing.Point(694, 83);
            this.lblPriceTitle.Name = "lblPriceTitle";
            this.lblPriceTitle.Size = new System.Drawing.Size(80, 16);
            this.lblPriceTitle.TabIndex = 31;
            this.lblPriceTitle.Text = "Total Price";
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblPrice.ForeColor = System.Drawing.Color.Green;
            this.lblPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPrice.Location = new System.Drawing.Point(653, 103);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(87, 16);
            this.lblPrice.TabIndex = 32;
            this.lblPrice.Text = "0.00";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPHP
            // 
            this.lblPHP.AutoSize = true;
            this.lblPHP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblPHP.ForeColor = System.Drawing.Color.Green;
            this.lblPHP.Location = new System.Drawing.Point(738, 103);
            this.lblPHP.Name = "lblPHP";
            this.lblPHP.Size = new System.Drawing.Size(36, 16);
            this.lblPHP.TabIndex = 33;
            this.lblPHP.Text = "PHP";
            // 
            // cbCustomerID
            // 
            this.cbCustomerID.BackColor = System.Drawing.Color.White;
            this.cbCustomerID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.cbCustomerID.BorderRadius = 0;
            this.cbCustomerID.BorderSize = 1;
            this.cbCustomerID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbCustomerID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomerID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.cbCustomerID.ForeColor = System.Drawing.Color.DimGray;
            this.cbCustomerID.IconColor = System.Drawing.Color.Navy;
            this.cbCustomerID.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbCustomerID.ListTextColor = System.Drawing.Color.DimGray;
            this.cbCustomerID.Location = new System.Drawing.Point(37, 104);
            this.cbCustomerID.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbCustomerID.Name = "cbCustomerID";
            this.cbCustomerID.Padding = new System.Windows.Forms.Padding(1);
            this.cbCustomerID.Size = new System.Drawing.Size(250, 37);
            this.cbCustomerID.TabIndex = 36;
            this.cbCustomerID.Texts = "";
            this.cbCustomerID.OnSelectedIndexChanged += new System.EventHandler(this.cbCustomerID_OnSelectedIndexChanged);
            this.cbCustomerID.Load += new System.EventHandler(this.customComboBox1_Load);
            // 
            // lblQuantityValue
            // 
            this.lblQuantityValue.AutoSize = true;
            this.lblQuantityValue.BackColor = System.Drawing.Color.White;
            this.lblQuantityValue.BackgroundColor = System.Drawing.Color.White;
            this.lblQuantityValue.BorderColor = System.Drawing.Color.Transparent;
            this.lblQuantityValue.BorderRadius = 0;
            this.lblQuantityValue.BorderSize = 0;
            this.lblQuantityValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblQuantityValue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblQuantityValue.ForeColor = System.Drawing.Color.Black;
            this.lblQuantityValue.Location = new System.Drawing.Point(235, 305);
            this.lblQuantityValue.Name = "lblQuantityValue";
            this.lblQuantityValue.Size = new System.Drawing.Size(15, 16);
            this.lblQuantityValue.TabIndex = 35;
            this.lblQuantityValue.Text = "0";
            this.lblQuantityValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQuantityValue.TextColor = System.Drawing.Color.Black;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.BackColor = System.Drawing.Color.White;
            this.lblUnitPrice.BackgroundColor = System.Drawing.Color.White;
            this.lblUnitPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblUnitPrice.BorderRadius = 15;
            this.lblUnitPrice.BorderSize = 2;
            this.lblUnitPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUnitPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.lblUnitPrice.ForeColor = System.Drawing.Color.Black;
            this.lblUnitPrice.Location = new System.Drawing.Point(243, 238);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(111, 37);
            this.lblUnitPrice.TabIndex = 34;
            this.lblUnitPrice.Text = "0.00";
            this.lblUnitPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUnitPrice.TextColor = System.Drawing.Color.Black;
            // 
            // cbProductID
            // 
            this.cbProductID.BackColor = System.Drawing.Color.White;
            this.cbProductID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.cbProductID.BorderRadius = 0;
            this.cbProductID.BorderSize = 1;
            this.cbProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbProductID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.cbProductID.ForeColor = System.Drawing.Color.DimGray;
            this.cbProductID.IconColor = System.Drawing.Color.Navy;
            this.cbProductID.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbProductID.ListTextColor = System.Drawing.Color.DimGray;
            this.cbProductID.Location = new System.Drawing.Point(37, 238);
            this.cbProductID.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbProductID.Name = "cbProductID";
            this.cbProductID.Padding = new System.Windows.Forms.Padding(1);
            this.cbProductID.Size = new System.Drawing.Size(200, 37);
            this.cbProductID.TabIndex = 29;
            this.cbProductID.Texts = "";
            this.cbProductID.OnSelectedIndexChanged += new System.EventHandler(this.cbProductID_OnSelectedIndexChanged);
            this.cbProductID.Load += new System.EventHandler(this.cbProductID_Load);
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.White;
            this.cbStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.cbStatus.BorderRadius = 0;
            this.cbStatus.BorderSize = 1;
            this.cbStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.cbStatus.ForeColor = System.Drawing.Color.DimGray;
            this.cbStatus.IconColor = System.Drawing.Color.Navy;
            this.cbStatus.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbStatus.ListTextColor = System.Drawing.Color.DimGray;
            this.cbStatus.Location = new System.Drawing.Point(37, 354);
            this.cbStatus.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Padding = new System.Windows.Forms.Padding(1);
            this.cbStatus.Size = new System.Drawing.Size(250, 37);
            this.cbStatus.TabIndex = 27;
            this.cbStatus.Texts = "";
            // 
            // dpSalesDate
            // 
            this.dpSalesDate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dpSalesDate.BorderSize = 0;
            this.dpSalesDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dpSalesDate.Location = new System.Drawing.Point(37, 172);
            this.dpSalesDate.MinimumSize = new System.Drawing.Size(4, 35);
            this.dpSalesDate.Name = "dpSalesDate";
            this.dpSalesDate.Size = new System.Drawing.Size(250, 35);
            this.dpSalesDate.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.dpSalesDate.TabIndex = 19;
            this.dpSalesDate.TextColor = System.Drawing.Color.White;
            this.dpSalesDate.Value = new System.DateTime(2025, 11, 27, 0, 0, 0, 0);
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
            // lblCustomerName
            // 
            this.lblCustomerName.BackColor = System.Drawing.Color.White;
            this.lblCustomerName.BackgroundColor = System.Drawing.Color.White;
            this.lblCustomerName.BorderColor = System.Drawing.Color.Transparent;
            this.lblCustomerName.BorderRadius = 0;
            this.lblCustomerName.BorderSize = 0;
            this.lblCustomerName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCustomerName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.lblCustomerName.ForeColor = System.Drawing.Color.Black;
            this.lblCustomerName.Location = new System.Drawing.Point(293, 104);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(210, 37);
            this.lblCustomerName.TabIndex = 37;
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCustomerName.TextColor = System.Drawing.Color.Black;
            // 
            // AddTransactionSalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 570);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.cbCustomerID);
            this.Controls.Add(this.lblQuantityValue);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblPHP);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblPriceTitle);
            this.Controls.Add(this.cbProductID);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblSalesDate);
            this.Controls.Add(this.dpSalesDate);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbQuantity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddTransactionSalesForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "AddItemInventoryForm";
            this.Load += new System.EventHandler(this.AddItemInventoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Materials.CustomButton btnAdd;
        private Materials.CustomLabel lbl;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCustomerID;
        private Materials.CustomDatePicker dpSalesDate;
        private System.Windows.Forms.Label lblSalesDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblQuantity;
        private Materials.CustomComboBox cbStatus;
        private System.Windows.Forms.Label lblProductID;
        private Materials.CustomComboBox cbProductID;
        private System.Windows.Forms.TrackBar tbQuantity;
        private System.Windows.Forms.Label lblPriceTitle;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPHP;
        private Materials.CustomLabel lblUnitPrice;
        private Materials.CustomLabel lblQuantityValue;
        private Materials.CustomComboBox cbCustomerID;
        private Materials.CustomLabel lblCustomerName;
    }
}