namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Sales
{
    partial class AddTransactionSales
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
            this.tcSales = new System.Windows.Forms.TabControl();
            this.btnRemoveTab = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            this.btnAddTab = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            this.lblCustomerName = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.cbCustomerID = new ColdChainConnectSystem_ACDP.Materials.CustomComboBox();
            this.dpSalesDate = new ColdChainConnectSystem_ACDP.Materials.CustomDatePicker();
            this.lbl = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.btnAdd = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            this.lblSalesID = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
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
            this.lblSalesDate.Location = new System.Drawing.Point(440, 85);
            this.lblSalesDate.Name = "lblSalesDate";
            this.lblSalesDate.Size = new System.Drawing.Size(79, 16);
            this.lblSalesDate.TabIndex = 20;
            this.lblSalesDate.Text = "Sales Date";
            // 
            // tcSales
            // 
            this.tcSales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tcSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tcSales.Location = new System.Drawing.Point(24, 157);
            this.tcSales.Name = "tcSales";
            this.tcSales.Padding = new System.Drawing.Point(0, 0);
            this.tcSales.SelectedIndex = 0;
            this.tcSales.Size = new System.Drawing.Size(754, 344);
            this.tcSales.TabIndex = 38;
            // 
            // btnRemoveTab
            // 
            this.btnRemoveTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.btnRemoveTab.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.btnRemoveTab.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRemoveTab.BorderRadius = 0;
            this.btnRemoveTab.BorderSize = 0;
            this.btnRemoveTab.FlatAppearance.BorderSize = 0;
            this.btnRemoveTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveTab.ForeColor = System.Drawing.Color.White;
            this.btnRemoveTab.Location = new System.Drawing.Point(70, 508);
            this.btnRemoveTab.Name = "btnRemoveTab";
            this.btnRemoveTab.Size = new System.Drawing.Size(40, 40);
            this.btnRemoveTab.TabIndex = 40;
            this.btnRemoveTab.TextColor = System.Drawing.Color.White;
            this.btnRemoveTab.UseVisualStyleBackColor = false;
            this.btnRemoveTab.Click += new System.EventHandler(this.btnRemoveTab_Click);
            // 
            // btnAddTab
            // 
            this.btnAddTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.btnAddTab.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.btnAddTab.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddTab.BorderRadius = 0;
            this.btnAddTab.BorderSize = 0;
            this.btnAddTab.FlatAppearance.BorderSize = 0;
            this.btnAddTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTab.ForeColor = System.Drawing.Color.White;
            this.btnAddTab.Location = new System.Drawing.Point(24, 508);
            this.btnAddTab.Name = "btnAddTab";
            this.btnAddTab.Size = new System.Drawing.Size(40, 40);
            this.btnAddTab.TabIndex = 39;
            this.btnAddTab.TextColor = System.Drawing.Color.White;
            this.btnAddTab.UseVisualStyleBackColor = false;
            this.btnAddTab.Click += new System.EventHandler(this.btnAddTab_Click);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.BackColor = System.Drawing.Color.White;
            this.lblCustomerName.BackgroundColor = System.Drawing.Color.White;
            this.lblCustomerName.BorderColor = System.Drawing.Color.Transparent;
            this.lblCustomerName.BorderRadius = 0;
            this.lblCustomerName.BorderSize = 0;
            this.lblCustomerName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCustomerName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblCustomerName.ForeColor = System.Drawing.Color.Black;
            this.lblCustomerName.Location = new System.Drawing.Point(251, 104);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(186, 37);
            this.lblCustomerName.TabIndex = 37;
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCustomerName.TextColor = System.Drawing.Color.Black;
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
            this.cbCustomerID.Size = new System.Drawing.Size(213, 37);
            this.cbCustomerID.TabIndex = 36;
            this.cbCustomerID.Texts = "";
            this.cbCustomerID.OnSelectedIndexChanged += new System.EventHandler(this.cbCustomerID_OnSelectedIndexChanged);
            this.cbCustomerID.Load += new System.EventHandler(this.customComboBox1_Load);
            // 
            // dpSalesDate
            // 
            this.dpSalesDate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dpSalesDate.BorderSize = 0;
            this.dpSalesDate.Enabled = false;
            this.dpSalesDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dpSalesDate.Location = new System.Drawing.Point(443, 104);
            this.dpSalesDate.MinimumSize = new System.Drawing.Size(4, 35);
            this.dpSalesDate.Name = "dpSalesDate";
            this.dpSalesDate.Size = new System.Drawing.Size(213, 35);
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
            this.btnAdd.Text = "Save";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblSalesID
            // 
            this.lblSalesID.AutoSize = true;
            this.lblSalesID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblSalesID.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblSalesID.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.lblSalesID.BorderRadius = 0;
            this.lblSalesID.BorderSize = 0;
            this.lblSalesID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSalesID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblSalesID.ForeColor = System.Drawing.Color.White;
            this.lblSalesID.Location = new System.Drawing.Point(250, 38);
            this.lblSalesID.Name = "lblSalesID";
            this.lblSalesID.Size = new System.Drawing.Size(99, 20);
            this.lblSalesID.TabIndex = 41;
            this.lblSalesID.Text = "Sales ID <-";
            this.lblSalesID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSalesID.TextColor = System.Drawing.Color.White;
            // 
            // AddTransactionSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 570);
            this.Controls.Add(this.lblSalesID);
            this.Controls.Add(this.btnRemoveTab);
            this.Controls.Add(this.btnAddTab);
            this.Controls.Add(this.tcSales);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.cbCustomerID);
            this.Controls.Add(this.lblSalesDate);
            this.Controls.Add(this.dpSalesDate);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddTransactionSales";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "AddItemInventoryForm";
            this.Load += new System.EventHandler(this.AddItemInventoryForm_Load);
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
        private Materials.CustomComboBox cbCustomerID;
        private Materials.CustomLabel lblCustomerName;
        private System.Windows.Forms.TabControl tcSales;
        private Materials.CustomButton btnAddTab;
        private Materials.CustomButton btnRemoveTab;
        private Materials.CustomLabel lblSalesID;
    }
}