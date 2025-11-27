namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Inventory
{
    partial class EditItemInventory
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
            this.label4 = new System.Windows.Forms.Label();
            this.pboxImage = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblSupplierID = new ColdChainConnectSystem_ACDP.Materials.CustomComboBox();
            this.lblUnitPrice = new CustomControls.RJControls.CustomTextBox();
            this.lblWeight = new CustomControls.RJControls.CustomTextBox();
            this.lblQuantity = new CustomControls.RJControls.CustomTextBox();
            this.btnImage = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            this.btnExitView = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            this.customPanel1 = new ColdChainConnectSystem_ACDP.Materials.CustomPanel();
            this.lblDescription = new CustomControls.RJControls.CustomTextBox();
            this.dpExpiry = new ColdChainConnectSystem_ACDP.Materials.CustomDatePicker();
            this.lblID = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.lblSKU = new CustomControls.RJControls.CustomTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ofdSaveImage = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImage)).BeginInit();
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(195, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 14);
            this.label4.TabIndex = 61;
            this.label4.Text = "Supplier ID";
            // 
            // pboxImage
            // 
            this.pboxImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pboxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxImage.Location = new System.Drawing.Point(461, 59);
            this.pboxImage.Name = "pboxImage";
            this.pboxImage.Size = new System.Drawing.Size(125, 125);
            this.pboxImage.TabIndex = 55;
            this.pboxImage.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(195, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 14);
            this.label5.TabIndex = 54;
            this.label5.Text = "Expiry Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 14);
            this.label3.TabIndex = 53;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 14);
            this.label2.TabIndex = 52;
            this.label2.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 14);
            this.label1.TabIndex = 50;
            this.label1.Text = "Weight (KG)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(12, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 14);
            this.label8.TabIndex = 48;
            this.label8.Text = "Unit Price";
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
            this.btnExit.Location = new System.Drawing.Point(550, 19);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(27, 27);
            this.btnExit.TabIndex = 68;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblSupplierID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblSupplierID.BorderRadius = 0;
            this.lblSupplierID.BorderSize = 2;
            this.lblSupplierID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lblSupplierID.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblSupplierID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblSupplierID.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblSupplierID.ListBackColor = System.Drawing.Color.White;
            this.lblSupplierID.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblSupplierID.Location = new System.Drawing.Point(198, 219);
            this.lblSupplierID.MinimumSize = new System.Drawing.Size(200, 30);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Padding = new System.Windows.Forms.Padding(2);
            this.lblSupplierID.Size = new System.Drawing.Size(200, 30);
            this.lblSupplierID.TabIndex = 67;
            this.lblSupplierID.Texts = "";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.BackColor = System.Drawing.SystemColors.Window;
            this.lblUnitPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblUnitPrice.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(150)))));
            this.lblUnitPrice.BorderRadius = 10;
            this.lblUnitPrice.BorderSize = 2;
            this.lblUnitPrice.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblUnitPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUnitPrice.Location = new System.Drawing.Point(12, 218);
            this.lblUnitPrice.Margin = new System.Windows.Forms.Padding(4);
            this.lblUnitPrice.Multiline = false;
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.lblUnitPrice.PasswordChar = false;
            this.lblUnitPrice.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.lblUnitPrice.PlaceholderText = "";
            this.lblUnitPrice.Size = new System.Drawing.Size(180, 29);
            this.lblUnitPrice.TabIndex = 66;
            this.lblUnitPrice.Texts = "";
            this.lblUnitPrice.UnderlinedStyle = false;
            // 
            // lblWeight
            // 
            this.lblWeight.BackColor = System.Drawing.SystemColors.Window;
            this.lblWeight.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblWeight.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(150)))));
            this.lblWeight.BorderRadius = 10;
            this.lblWeight.BorderSize = 2;
            this.lblWeight.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblWeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblWeight.Location = new System.Drawing.Point(8, 270);
            this.lblWeight.Margin = new System.Windows.Forms.Padding(4);
            this.lblWeight.Multiline = false;
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.lblWeight.PasswordChar = false;
            this.lblWeight.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.lblWeight.PlaceholderText = "";
            this.lblWeight.Size = new System.Drawing.Size(180, 29);
            this.lblWeight.TabIndex = 65;
            this.lblWeight.Texts = "";
            this.lblWeight.UnderlinedStyle = false;
            // 
            // lblQuantity
            // 
            this.lblQuantity.BackColor = System.Drawing.SystemColors.Window;
            this.lblQuantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblQuantity.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(150)))));
            this.lblQuantity.BorderRadius = 10;
            this.lblQuantity.BorderSize = 2;
            this.lblQuantity.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblQuantity.Location = new System.Drawing.Point(8, 326);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.lblQuantity.Multiline = false;
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.lblQuantity.PasswordChar = false;
            this.lblQuantity.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.lblQuantity.PlaceholderText = "";
            this.lblQuantity.Size = new System.Drawing.Size(180, 29);
            this.lblQuantity.TabIndex = 64;
            this.lblQuantity.Texts = "";
            this.lblQuantity.UnderlinedStyle = false;
            // 
            // btnImage
            // 
            this.btnImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.btnImage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.btnImage.BorderColor = System.Drawing.Color.Empty;
            this.btnImage.BorderRadius = 10;
            this.btnImage.BorderSize = 2;
            this.btnImage.FlatAppearance.BorderSize = 0;
            this.btnImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImage.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnImage.ForeColor = System.Drawing.Color.White;
            this.btnImage.Location = new System.Drawing.Point(463, 190);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(125, 40);
            this.btnImage.TabIndex = 63;
            this.btnImage.Text = "Select Image";
            this.btnImage.TextColor = System.Drawing.Color.White;
            this.btnImage.UseVisualStyleBackColor = false;
            this.btnImage.Click += new System.EventHandler(this.customButton1_Click);
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
            this.btnExitView.Location = new System.Drawing.Point(438, 342);
            this.btnExitView.Name = "btnExitView";
            this.btnExitView.Size = new System.Drawing.Size(150, 40);
            this.btnExitView.TabIndex = 58;
            this.btnExitView.Text = "Exit View";
            this.btnExitView.TextColor = System.Drawing.Color.White;
            this.btnExitView.UseVisualStyleBackColor = false;
            this.btnExitView.Click += new System.EventHandler(this.btnExitView_Click);
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
            this.customPanel1.Location = new System.Drawing.Point(12, 128);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.customPanel1.Size = new System.Drawing.Size(443, 71);
            this.customPanel1.TabIndex = 62;
            this.customPanel1.TextColor = System.Drawing.Color.White;
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.SystemColors.Window;
            this.lblDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDescription.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDescription.BorderRadius = 10;
            this.lblDescription.BorderSize = 2;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblDescription.Location = new System.Drawing.Point(10, 10);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4);
            this.lblDescription.Multiline = true;
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.lblDescription.PasswordChar = false;
            this.lblDescription.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.lblDescription.PlaceholderText = "";
            this.lblDescription.Size = new System.Drawing.Size(423, 51);
            this.lblDescription.TabIndex = 67;
            this.lblDescription.Texts = "";
            this.lblDescription.UnderlinedStyle = false;
            // 
            // dpExpiry
            // 
            this.dpExpiry.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.dpExpiry.BorderSize = 2;
            this.dpExpiry.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dpExpiry.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.dpExpiry.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.dpExpiry.Location = new System.Drawing.Point(198, 270);
            this.dpExpiry.MinimumSize = new System.Drawing.Size(4, 30);
            this.dpExpiry.Name = "dpExpiry";
            this.dpExpiry.Size = new System.Drawing.Size(198, 30);
            this.dpExpiry.SkinColor = System.Drawing.Color.White;
            this.dpExpiry.TabIndex = 56;
            this.dpExpiry.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
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
            this.lblID.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblID.Size = new System.Drawing.Size(576, 41);
            this.lblID.TabIndex = 46;
            this.lblID.Text = "customLabel1";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblID.TextColor = System.Drawing.Color.White;
            // 
            // lblSKU
            // 
            this.lblSKU.BackColor = System.Drawing.SystemColors.Window;
            this.lblSKU.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblSKU.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(150)))));
            this.lblSKU.BorderRadius = 10;
            this.lblSKU.BorderSize = 2;
            this.lblSKU.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblSKU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSKU.Location = new System.Drawing.Point(15, 78);
            this.lblSKU.Margin = new System.Windows.Forms.Padding(4);
            this.lblSKU.Multiline = false;
            this.lblSKU.Name = "lblSKU";
            this.lblSKU.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.lblSKU.PasswordChar = false;
            this.lblSKU.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.lblSKU.PlaceholderText = "";
            this.lblSKU.Size = new System.Drawing.Size(180, 29);
            this.lblSKU.TabIndex = 70;
            this.lblSKU.Texts = "";
            this.lblSKU.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(19, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 14);
            this.label6.TabIndex = 69;
            this.label6.Text = "SKU Code";
            // 
            // ofdSaveImage
            // 
            this.ofdSaveImage.FileName = "openFileDialog1";
            // 
            // EditItemInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 393);
            this.Controls.Add(this.lblSKU);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblSupplierID);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnExitView);
            this.Controls.Add(this.customPanel1);
            this.Controls.Add(this.dpExpiry);
            this.Controls.Add(this.pboxImage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditItemInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditItemInventoryForm";
            this.Load += new System.EventHandler(this.EditItemInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxImage)).EndInit();
            this.customPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private Materials.CustomButton btnExitView;
        private Materials.CustomPanel customPanel1;
        private Materials.CustomDatePicker dpExpiry;
        private System.Windows.Forms.PictureBox pboxImage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private Materials.CustomLabel lblID;
        private Materials.CustomButton btnImage;
        private CustomControls.RJControls.CustomTextBox lblQuantity;
        private CustomControls.RJControls.CustomTextBox lblWeight;
        private CustomControls.RJControls.CustomTextBox lblUnitPrice;
        private CustomControls.RJControls.CustomTextBox lblDescription;
        private Materials.CustomComboBox lblSupplierID;
        private System.Windows.Forms.Button btnExit;
        private CustomControls.RJControls.CustomTextBox lblSKU;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog ofdSaveImage;
    }
}