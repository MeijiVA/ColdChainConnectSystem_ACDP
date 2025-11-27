namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Sales
{
    partial class ViewTransactionSales
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblUnitPrice = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.lblSku = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.lblTotalPrice = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.lblCustomerName = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.btnExitView = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            this.dpSalesDate = new ColdChainConnectSystem_ACDP.Materials.CustomDatePicker();
            this.lblStatus = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.lblQuantity = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.lblProductID = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.lblCustomerID = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.lblID = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sales Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Product ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(198, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 14);
            this.label5.TabIndex = 11;
            this.label5.Text = "Status";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(384, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 14);
            this.label7.TabIndex = 46;
            this.label7.Text = "Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(198, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 14);
            this.label9.TabIndex = 50;
            this.label9.Text = "Unit Price";
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
            this.lblUnitPrice.Location = new System.Drawing.Point(198, 184);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblUnitPrice.Size = new System.Drawing.Size(180, 30);
            this.lblUnitPrice.TabIndex = 49;
            this.lblUnitPrice.Text = "customLabel4";
            this.lblUnitPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUnitPrice.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
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
            this.lblSku.Location = new System.Drawing.Point(192, 129);
            this.lblSku.Name = "lblSku";
            this.lblSku.Size = new System.Drawing.Size(180, 30);
            this.lblSku.TabIndex = 47;
            this.lblSku.Text = "customLabel3";
            this.lblSku.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSku.TextColor = System.Drawing.Color.Black;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.BackColor = System.Drawing.Color.White;
            this.lblTotalPrice.BackgroundColor = System.Drawing.Color.White;
            this.lblTotalPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblTotalPrice.BorderRadius = 10;
            this.lblTotalPrice.BorderSize = 2;
            this.lblTotalPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotalPrice.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblTotalPrice.Location = new System.Drawing.Point(384, 184);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblTotalPrice.Size = new System.Drawing.Size(180, 30);
            this.lblTotalPrice.TabIndex = 45;
            this.lblTotalPrice.Text = "customLabel4";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotalPrice.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.BackColor = System.Drawing.Color.White;
            this.lblCustomerName.BackgroundColor = System.Drawing.Color.White;
            this.lblCustomerName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCustomerName.BorderRadius = 10;
            this.lblCustomerName.BorderSize = 2;
            this.lblCustomerName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCustomerName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCustomerName.ForeColor = System.Drawing.Color.Black;
            this.lblCustomerName.Location = new System.Drawing.Point(192, 74);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(180, 30);
            this.lblCustomerName.TabIndex = 43;
            this.lblCustomerName.Text = "customLabel1";
            this.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCustomerName.TextColor = System.Drawing.Color.Black;
            // 
            // btnExitView
            // 
            this.btnExitView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.btnExitView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.btnExitView.BorderColor = System.Drawing.Color.Empty;
            this.btnExitView.BorderRadius = 10;
            this.btnExitView.BorderSize = 2;
            this.btnExitView.FlatAppearance.BorderSize = 0;
            this.btnExitView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitView.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnExitView.ForeColor = System.Drawing.Color.White;
            this.btnExitView.Location = new System.Drawing.Point(438, 341);
            this.btnExitView.Name = "btnExitView";
            this.btnExitView.Size = new System.Drawing.Size(150, 40);
            this.btnExitView.TabIndex = 42;
            this.btnExitView.Text = "Exit View";
            this.btnExitView.TextColor = System.Drawing.Color.White;
            this.btnExitView.UseVisualStyleBackColor = false;
            this.btnExitView.Click += new System.EventHandler(this.btnExitView_Click);
            // 
            // dpSalesDate
            // 
            this.dpSalesDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.dpSalesDate.BorderSize = 2;
            this.dpSalesDate.CalendarFont = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.dpSalesDate.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dpSalesDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.dpSalesDate.Enabled = false;
            this.dpSalesDate.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.dpSalesDate.Location = new System.Drawing.Point(12, 240);
            this.dpSalesDate.MinimumSize = new System.Drawing.Size(4, 30);
            this.dpSalesDate.Name = "dpSalesDate";
            this.dpSalesDate.Size = new System.Drawing.Size(180, 30);
            this.dpSalesDate.SkinColor = System.Drawing.Color.White;
            this.dpSalesDate.TabIndex = 40;
            this.dpSalesDate.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.White;
            this.lblStatus.BackgroundColor = System.Drawing.Color.White;
            this.lblStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblStatus.BorderRadius = 10;
            this.lblStatus.BorderSize = 2;
            this.lblStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblStatus.Location = new System.Drawing.Point(198, 242);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblStatus.Size = new System.Drawing.Size(180, 30);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "customLabel5";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStatus.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            // 
            // lblQuantity
            // 
            this.lblQuantity.BackColor = System.Drawing.Color.White;
            this.lblQuantity.BackgroundColor = System.Drawing.Color.White;
            this.lblQuantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblQuantity.BorderRadius = 10;
            this.lblQuantity.BorderSize = 2;
            this.lblQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblQuantity.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblQuantity.Location = new System.Drawing.Point(12, 184);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblQuantity.Size = new System.Drawing.Size(180, 30);
            this.lblQuantity.TabIndex = 8;
            this.lblQuantity.Text = "customLabel4";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblQuantity.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
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
            this.lblProductID.Location = new System.Drawing.Point(12, 129);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblProductID.Size = new System.Drawing.Size(180, 30);
            this.lblProductID.TabIndex = 6;
            this.lblProductID.Text = "customLabel3";
            this.lblProductID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblProductID.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.BackColor = System.Drawing.Color.White;
            this.lblCustomerID.BackgroundColor = System.Drawing.Color.White;
            this.lblCustomerID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblCustomerID.BorderRadius = 10;
            this.lblCustomerID.BorderSize = 2;
            this.lblCustomerID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCustomerID.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblCustomerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblCustomerID.Location = new System.Drawing.Point(12, 74);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblCustomerID.Size = new System.Drawing.Size(180, 30);
            this.lblCustomerID.TabIndex = 2;
            this.lblCustomerID.Text = "customLabel1";
            this.lblCustomerID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCustomerID.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblCustomerID.Click += new System.EventHandler(this.customLabel1_Click);
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
            this.lblID.Location = new System.Drawing.Point(12, 10);
            this.lblID.Name = "lblID";
            this.lblID.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblID.Size = new System.Drawing.Size(576, 41);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "customLabel1";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblID.TextColor = System.Drawing.Color.White;
            // 
            // ViewTransactionSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 393);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblSku);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.btnExitView);
            this.Controls.Add(this.dpSalesDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.lblID);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewTransactionSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewTransactionSales";
            this.Load += new System.EventHandler(this.ViewTransactionSales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Materials.CustomLabel lblID;
        private Materials.CustomLabel lblCustomerID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Materials.CustomLabel lblProductID;
        private System.Windows.Forms.Label label4;
        private Materials.CustomLabel lblQuantity;
        private System.Windows.Forms.Label label5;
        private Materials.CustomLabel lblStatus;
        private Materials.CustomDatePicker dpSalesDate;
        private Materials.CustomButton btnExitView;
        private Materials.CustomLabel lblCustomerName;
        private System.Windows.Forms.Label label7;
        private Materials.CustomLabel lblTotalPrice;
        private Materials.CustomLabel lblSku;
        private System.Windows.Forms.Label label9;
        private Materials.CustomLabel lblUnitPrice;
    }
}