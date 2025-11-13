namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Inventory
{
    partial class AddItemInventoryForm
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
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblExpiry = new System.Windows.Forms.Label();
            this.lblKG = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblSKU = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dpExpiry = new ColdChainConnectSystem_ACDP.Materials.CustomDatePicker();
            this.txtSKU = new CustomControls.RJControls.CustomTextBox();
            this.txtQuantity = new CustomControls.RJControls.CustomTextBox();
            this.txtWeight = new CustomControls.RJControls.CustomTextBox();
            this.txtUnitPrice = new CustomControls.RJControls.CustomTextBox();
            this.txtDescription = new CustomControls.RJControls.CustomTextBox();
            this.btnImage = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            this.lbl = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.btnAdd = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ofdSaveImage
            // 
            this.ofdSaveImage.InitialDirectory = "string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.Special" +
    "Folder.UserProfile), \"Downloads\");";
            // 
            // pbxImage
            // 
            this.pbxImage.BackgroundImage = global::ColdChainConnectSystem_ACDP.Properties.Resources.NoImage1;
            this.pbxImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxImage.Location = new System.Drawing.Point(636, 59);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(150, 150);
            this.pbxImage.TabIndex = 2;
            this.pbxImage.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(759, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(27, 27);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblDescription.Location = new System.Drawing.Point(45, 114);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(85, 16);
            this.lblDescription.TabIndex = 17;
            this.lblDescription.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.label1.Location = new System.Drawing.Point(48, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Unit Price";
            // 
            // lblExpiry
            // 
            this.lblExpiry.AutoSize = true;
            this.lblExpiry.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblExpiry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblExpiry.Location = new System.Drawing.Point(45, 454);
            this.lblExpiry.Name = "lblExpiry";
            this.lblExpiry.Size = new System.Drawing.Size(50, 16);
            this.lblExpiry.TabIndex = 20;
            this.lblExpiry.Text = "Expiry";
            // 
            // lblKG
            // 
            this.lblKG.AutoSize = true;
            this.lblKG.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblKG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblKG.Location = new System.Drawing.Point(44, 324);
            this.lblKG.Name = "lblKG";
            this.lblKG.Size = new System.Drawing.Size(89, 16);
            this.lblKG.TabIndex = 21;
            this.lblKG.Text = "Weight (KG)";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblQuantity.Location = new System.Drawing.Point(45, 387);
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
            this.lblSKU.Location = new System.Drawing.Point(48, 55);
            this.lblSKU.Name = "lblSKU";
            this.lblSKU.Size = new System.Drawing.Size(76, 16);
            this.lblSKU.TabIndex = 23;
            this.lblSKU.Text = "SKU Code";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(-15, -15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // dpExpiry
            // 
            this.dpExpiry.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dpExpiry.BorderSize = 0;
            this.dpExpiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dpExpiry.Location = new System.Drawing.Point(39, 477);
            this.dpExpiry.MinimumSize = new System.Drawing.Size(4, 35);
            this.dpExpiry.Name = "dpExpiry";
            this.dpExpiry.Size = new System.Drawing.Size(250, 35);
            this.dpExpiry.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.dpExpiry.TabIndex = 19;
            this.dpExpiry.TextColor = System.Drawing.Color.White;
            this.dpExpiry.Value = new System.DateTime(2025, 11, 27, 0, 0, 0, 0);
            // 
            // txtSKU
            // 
            this.txtSKU.BackColor = System.Drawing.SystemColors.Window;
            this.txtSKU.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.txtSKU.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(150)))));
            this.txtSKU.BorderRadius = 10;
            this.txtSKU.BorderSize = 2;
            this.txtSKU.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.txtSKU.ForeColor = System.Drawing.Color.Black;
            this.txtSKU.Location = new System.Drawing.Point(39, 75);
            this.txtSKU.Margin = new System.Windows.Forms.Padding(4);
            this.txtSKU.Multiline = false;
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSKU.PasswordChar = false;
            this.txtSKU.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSKU.PlaceholderText = "";
            this.txtSKU.Size = new System.Drawing.Size(250, 31);
            this.txtSKU.TabIndex = 15;
            this.txtSKU.Texts = "";
            this.txtSKU.UnderlinedStyle = false;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.Window;
            this.txtQuantity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.txtQuantity.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(150)))));
            this.txtQuantity.BorderRadius = 10;
            this.txtQuantity.BorderSize = 2;
            this.txtQuantity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.txtQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtQuantity.Location = new System.Drawing.Point(39, 407);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantity.Multiline = false;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtQuantity.PasswordChar = false;
            this.txtQuantity.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtQuantity.PlaceholderText = "";
            this.txtQuantity.Size = new System.Drawing.Size(250, 31);
            this.txtQuantity.TabIndex = 14;
            this.txtQuantity.Texts = "";
            this.txtQuantity.UnderlinedStyle = false;
            // 
            // txtWeight
            // 
            this.txtWeight.BackColor = System.Drawing.SystemColors.Window;
            this.txtWeight.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.txtWeight.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(150)))));
            this.txtWeight.BorderRadius = 10;
            this.txtWeight.BorderSize = 2;
            this.txtWeight.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.txtWeight.ForeColor = System.Drawing.Color.Black;
            this.txtWeight.Location = new System.Drawing.Point(39, 344);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(4);
            this.txtWeight.Multiline = false;
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtWeight.PasswordChar = false;
            this.txtWeight.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtWeight.PlaceholderText = "";
            this.txtWeight.Size = new System.Drawing.Size(250, 31);
            this.txtWeight.TabIndex = 13;
            this.txtWeight.Texts = "";
            this.txtWeight.UnderlinedStyle = false;
            this.txtWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.customTextBox6_KeyPress);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.BackColor = System.Drawing.SystemColors.Window;
            this.txtUnitPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.txtUnitPrice.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(150)))));
            this.txtUnitPrice.BorderRadius = 10;
            this.txtUnitPrice.BorderSize = 2;
            this.txtUnitPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.txtUnitPrice.ForeColor = System.Drawing.Color.Black;
            this.txtUnitPrice.Location = new System.Drawing.Point(39, 277);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtUnitPrice.Multiline = false;
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUnitPrice.PasswordChar = false;
            this.txtUnitPrice.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUnitPrice.PlaceholderText = "";
            this.txtUnitPrice.Size = new System.Drawing.Size(250, 31);
            this.txtUnitPrice.TabIndex = 10;
            this.txtUnitPrice.Texts = "";
            this.txtUnitPrice.UnderlinedStyle = false;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.txtDescription.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(150)))));
            this.txtDescription.BorderRadius = 10;
            this.txtDescription.BorderSize = 2;
            this.txtDescription.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.Location = new System.Drawing.Point(39, 134);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDescription.PasswordChar = false;
            this.txtDescription.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDescription.PlaceholderText = "";
            this.txtDescription.Size = new System.Drawing.Size(575, 110);
            this.txtDescription.TabIndex = 9;
            this.txtDescription.Texts = "";
            this.txtDescription.UnderlinedStyle = false;
            // 
            // btnImage
            // 
            this.btnImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.btnImage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.btnImage.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnImage.BorderRadius = 10;
            this.btnImage.BorderSize = 0;
            this.btnImage.FlatAppearance.BorderSize = 0;
            this.btnImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImage.ForeColor = System.Drawing.Color.White;
            this.btnImage.Location = new System.Drawing.Point(636, 215);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(150, 40);
            this.btnImage.TabIndex = 8;
            this.btnImage.Text = "Select Image";
            this.btnImage.TextColor = System.Drawing.Color.White;
            this.btnImage.UseVisualStyleBackColor = false;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // lbl
            // 
            this.lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lbl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lbl.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.lbl.BorderRadius = 0;
            this.lbl.BorderSize = 0;
            this.lbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(0, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(801, 40);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "     Add Item (Inventory)";
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
            this.btnAdd.Location = new System.Drawing.Point(636, 518);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddItemInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(801, 570);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblSKU);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblKG);
            this.Controls.Add(this.lblExpiry);
            this.Controls.Add(this.dpExpiry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtSKU);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pbxImage);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddItemInventoryForm";
            this.Text = "AddItemInventoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Materials.CustomButton btnAdd;
        private Materials.CustomLabel lbl;
        private System.Windows.Forms.OpenFileDialog ofdSaveImage;
        private System.Windows.Forms.PictureBox pbxImage;
        private System.Windows.Forms.Button btnExit;
        private Materials.CustomButton btnImage;
        private CustomControls.RJControls.CustomTextBox txtDescription;
        private CustomControls.RJControls.CustomTextBox txtUnitPrice;
        private CustomControls.RJControls.CustomTextBox txtQuantity;
        private CustomControls.RJControls.CustomTextBox txtWeight;
        private CustomControls.RJControls.CustomTextBox txtSKU;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label1;
        private Materials.CustomDatePicker dpExpiry;
        private System.Windows.Forms.Label lblExpiry;
        private System.Windows.Forms.Label lblKG;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblSKU;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}