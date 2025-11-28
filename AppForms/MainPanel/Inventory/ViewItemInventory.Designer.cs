namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Inventory
{
    partial class ViewItemInventory
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
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pboxImage = new System.Windows.Forms.PictureBox();
            this.pboxQR = new System.Windows.Forms.PictureBox();
            this.pboxExpiry = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.customPanel1 = new ColdChainConnectSystem_ACDP.Materials.CustomPanel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblSupplierID = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.btnExitView = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            this.dpExpiry = new ColdChainConnectSystem_ACDP.Materials.CustomDatePicker();
            this.lblQuantity = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.lblWeight = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.lblUnitPrice = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.lblID = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxQR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxExpiry)).BeginInit();
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(12, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 14);
            this.label8.TabIndex = 27;
            this.label8.Text = "Unit Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 14);
            this.label1.TabIndex = 29;
            this.label1.Text = "Weight (KG)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 14);
            this.label2.TabIndex = 31;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 14);
            this.label3.TabIndex = 33;
            this.label3.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(195, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 14);
            this.label5.TabIndex = 37;
            this.label5.Text = "Expiry Date";
            // 
            // pboxImage
            // 
            this.pboxImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pboxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxImage.Location = new System.Drawing.Point(488, 58);
            this.pboxImage.Name = "pboxImage";
            this.pboxImage.Size = new System.Drawing.Size(100, 98);
            this.pboxImage.TabIndex = 38;
            this.pboxImage.TabStop = false;
            this.pboxImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pboxQR
            // 
            this.pboxQR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pboxQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxQR.Location = new System.Drawing.Point(438, 164);
            this.pboxQR.Name = "pboxQR";
            this.pboxQR.Size = new System.Drawing.Size(150, 150);
            this.pboxQR.TabIndex = 40;
            this.pboxQR.TabStop = false;
            // 
            // pboxExpiry
            // 
            this.pboxExpiry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pboxExpiry.Location = new System.Drawing.Point(15, 346);
            this.pboxExpiry.Name = "pboxExpiry";
            this.pboxExpiry.Size = new System.Drawing.Size(35, 35);
            this.pboxExpiry.TabIndex = 42;
            this.pboxExpiry.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(195, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 14);
            this.label4.TabIndex = 44;
            this.label4.Text = "Supplier ID";
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.White;
            this.customPanel1.BackgroundColor = System.Drawing.Color.White;
            this.customPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customPanel1.BorderRadius = 15;
            this.customPanel1.BorderSize = 2;
            this.customPanel1.Controls.Add(this.lblDescription);
            this.customPanel1.ForeColor = System.Drawing.Color.White;
            this.customPanel1.Location = new System.Drawing.Point(12, 75);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.customPanel1.Size = new System.Drawing.Size(470, 71);
            this.customPanel1.TabIndex = 45;
            this.customPanel1.TextColor = System.Drawing.Color.White;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDescription.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblDescription.Location = new System.Drawing.Point(10, 10);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(39, 14);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "label6";
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.BackColor = System.Drawing.Color.White;
            this.lblSupplierID.BackgroundColor = System.Drawing.Color.White;
            this.lblSupplierID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblSupplierID.BorderRadius = 10;
            this.lblSupplierID.BorderSize = 2;
            this.lblSupplierID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSupplierID.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblSupplierID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblSupplierID.Location = new System.Drawing.Point(195, 165);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblSupplierID.Size = new System.Drawing.Size(180, 30);
            this.lblSupplierID.TabIndex = 43;
            this.lblSupplierID.Text = "customLabel4";
            this.lblSupplierID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSupplierID.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            // 
            // btnExitView
            // 
            this.btnExitView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.btnExitView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.btnExitView.BorderColor = System.Drawing.Color.Empty;
            this.btnExitView.BorderRadius = 10;
            this.btnExitView.BorderSize = 2;
            this.btnExitView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitView.FlatAppearance.BorderSize = 0;
            this.btnExitView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitView.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnExitView.ForeColor = System.Drawing.Color.White;
            this.btnExitView.GradientColor1 = System.Drawing.Color.Transparent;
            this.btnExitView.GradientColor2 = System.Drawing.Color.Transparent;
            this.btnExitView.GradientTextColor = System.Drawing.Color.Transparent;
            this.btnExitView.Location = new System.Drawing.Point(438, 341);
            this.btnExitView.Name = "btnExitView";
            this.btnExitView.Size = new System.Drawing.Size(150, 40);
            this.btnExitView.TabIndex = 41;
            this.btnExitView.Text = "Exit View";
            this.btnExitView.TextColor = System.Drawing.Color.White;
            this.btnExitView.UseVisualStyleBackColor = false;
            this.btnExitView.Click += new System.EventHandler(this.btnExitView_Click);
            // 
            // dpExpiry
            // 
            this.dpExpiry.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.dpExpiry.BorderSize = 2;
            this.dpExpiry.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dpExpiry.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.dpExpiry.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.dpExpiry.Location = new System.Drawing.Point(198, 217);
            this.dpExpiry.MinimumSize = new System.Drawing.Size(4, 30);
            this.dpExpiry.Name = "dpExpiry";
            this.dpExpiry.Size = new System.Drawing.Size(198, 30);
            this.dpExpiry.SkinColor = System.Drawing.Color.White;
            this.dpExpiry.TabIndex = 39;
            this.dpExpiry.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
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
            this.lblQuantity.Location = new System.Drawing.Point(12, 271);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblQuantity.Size = new System.Drawing.Size(180, 30);
            this.lblQuantity.TabIndex = 30;
            this.lblQuantity.Text = "customLabel4";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblQuantity.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            // 
            // lblWeight
            // 
            this.lblWeight.BackColor = System.Drawing.Color.White;
            this.lblWeight.BackgroundColor = System.Drawing.Color.White;
            this.lblWeight.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblWeight.BorderRadius = 10;
            this.lblWeight.BorderSize = 2;
            this.lblWeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWeight.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblWeight.Location = new System.Drawing.Point(12, 219);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblWeight.Size = new System.Drawing.Size(180, 30);
            this.lblWeight.TabIndex = 28;
            this.lblWeight.Text = "customLabel4";
            this.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblWeight.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
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
            this.lblUnitPrice.Location = new System.Drawing.Point(12, 167);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblUnitPrice.Size = new System.Drawing.Size(180, 30);
            this.lblUnitPrice.TabIndex = 26;
            this.lblUnitPrice.Text = "customLabel4";
            this.lblUnitPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUnitPrice.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
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
            this.lblID.TabIndex = 0;
            this.lblID.Text = "customLabel1";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblID.TextColor = System.Drawing.Color.White;
            // 
            // ViewItemInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(600, 390);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSupplierID);
            this.Controls.Add(this.pboxExpiry);
            this.Controls.Add(this.btnExitView);
            this.Controls.Add(this.pboxQR);
            this.Controls.Add(this.dpExpiry);
            this.Controls.Add(this.pboxImage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblID);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewItemInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewEditInventoryForm";
            this.Load += new System.EventHandler(this.ViewEditInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxQR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxExpiry)).EndInit();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Materials.CustomLabel lblID;
        private System.Windows.Forms.Label label8;
        private Materials.CustomLabel lblUnitPrice;
        private System.Windows.Forms.Label label1;
        private Materials.CustomLabel lblWeight;
        private System.Windows.Forms.Label label2;
        private Materials.CustomLabel lblQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pboxImage;
        private Materials.CustomDatePicker dpExpiry;
        private System.Windows.Forms.PictureBox pboxQR;
        private Materials.CustomButton btnExitView;
        private System.Windows.Forms.PictureBox pboxExpiry;
        private System.Windows.Forms.Label label4;
        private Materials.CustomLabel lblSupplierID;
        private Materials.CustomPanel customPanel1;
        private System.Windows.Forms.Label lblDescription;
    }
}