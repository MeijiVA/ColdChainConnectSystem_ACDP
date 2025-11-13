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
            this.customTextBox7 = new CustomControls.RJControls.CustomTextBox();
            this.customTextBox8 = new CustomControls.RJControls.CustomTextBox();
            this.customTextBox5 = new CustomControls.RJControls.CustomTextBox();
            this.customTextBox6 = new CustomControls.RJControls.CustomTextBox();
            this.customTextBox3 = new CustomControls.RJControls.CustomTextBox();
            this.customTextBox4 = new CustomControls.RJControls.CustomTextBox();
            this.customTextBox2 = new CustomControls.RJControls.CustomTextBox();
            this.customTextBox1 = new CustomControls.RJControls.CustomTextBox();
            this.btnImage = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            this.lbl = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.btnAdd = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            this.dpExpiry = new ColdChainConnectSystem_ACDP.Materials.CustomDatePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ofdSaveImage
            // 
            this.ofdSaveImage.FileName = "openFileDialog1";
            this.ofdSaveImage.InitialDirectory = "string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.Special" +
    "Folder.UserProfile), \"Downloads\");";
            // 
            // pbxImage
            // 
            this.pbxImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.lblDescription.Location = new System.Drawing.Point(33, 59);
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
            this.label1.Location = new System.Drawing.Point(33, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Unit Price";
            // 
            // customTextBox7
            // 
            this.customTextBox7.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customTextBox7.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(150)))));
            this.customTextBox7.BorderRadius = 10;
            this.customTextBox7.BorderSize = 2;
            this.customTextBox7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.customTextBox7.ForeColor = System.Drawing.Color.Black;
            this.customTextBox7.Location = new System.Drawing.Point(355, 240);
            this.customTextBox7.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBox7.Multiline = false;
            this.customTextBox7.Name = "customTextBox7";
            this.customTextBox7.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox7.PasswordChar = false;
            this.customTextBox7.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox7.PlaceholderText = "";
            this.customTextBox7.Size = new System.Drawing.Size(250, 31);
            this.customTextBox7.TabIndex = 16;
            this.customTextBox7.Texts = "";
            this.customTextBox7.UnderlinedStyle = false;
            // 
            // customTextBox8
            // 
            this.customTextBox8.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customTextBox8.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(150)))));
            this.customTextBox8.BorderRadius = 10;
            this.customTextBox8.BorderSize = 2;
            this.customTextBox8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.customTextBox8.ForeColor = System.Drawing.Color.Black;
            this.customTextBox8.Location = new System.Drawing.Point(355, 191);
            this.customTextBox8.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBox8.Multiline = false;
            this.customTextBox8.Name = "customTextBox8";
            this.customTextBox8.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox8.PasswordChar = false;
            this.customTextBox8.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox8.PlaceholderText = "";
            this.customTextBox8.Size = new System.Drawing.Size(250, 31);
            this.customTextBox8.TabIndex = 15;
            this.customTextBox8.Texts = "";
            this.customTextBox8.UnderlinedStyle = false;
            // 
            // customTextBox5
            // 
            this.customTextBox5.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customTextBox5.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(150)))));
            this.customTextBox5.BorderRadius = 10;
            this.customTextBox5.BorderSize = 2;
            this.customTextBox5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.customTextBox5.ForeColor = System.Drawing.Color.Black;
            this.customTextBox5.Location = new System.Drawing.Point(355, 152);
            this.customTextBox5.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBox5.Multiline = false;
            this.customTextBox5.Name = "customTextBox5";
            this.customTextBox5.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox5.PasswordChar = false;
            this.customTextBox5.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox5.PlaceholderText = "";
            this.customTextBox5.Size = new System.Drawing.Size(250, 31);
            this.customTextBox5.TabIndex = 14;
            this.customTextBox5.Texts = "";
            this.customTextBox5.UnderlinedStyle = false;
            // 
            // customTextBox6
            // 
            this.customTextBox6.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customTextBox6.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(150)))));
            this.customTextBox6.BorderRadius = 10;
            this.customTextBox6.BorderSize = 2;
            this.customTextBox6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.customTextBox6.ForeColor = System.Drawing.Color.Black;
            this.customTextBox6.Location = new System.Drawing.Point(355, 103);
            this.customTextBox6.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBox6.Multiline = false;
            this.customTextBox6.Name = "customTextBox6";
            this.customTextBox6.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox6.PasswordChar = false;
            this.customTextBox6.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox6.PlaceholderText = "";
            this.customTextBox6.Size = new System.Drawing.Size(250, 31);
            this.customTextBox6.TabIndex = 13;
            this.customTextBox6.Texts = "";
            this.customTextBox6.UnderlinedStyle = false;
            // 
            // customTextBox3
            // 
            this.customTextBox3.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customTextBox3.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(150)))));
            this.customTextBox3.BorderRadius = 10;
            this.customTextBox3.BorderSize = 2;
            this.customTextBox3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.customTextBox3.ForeColor = System.Drawing.Color.Black;
            this.customTextBox3.Location = new System.Drawing.Point(81, 240);
            this.customTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBox3.Multiline = false;
            this.customTextBox3.Name = "customTextBox3";
            this.customTextBox3.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox3.PasswordChar = false;
            this.customTextBox3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox3.PlaceholderText = "";
            this.customTextBox3.Size = new System.Drawing.Size(250, 31);
            this.customTextBox3.TabIndex = 12;
            this.customTextBox3.Texts = "";
            this.customTextBox3.UnderlinedStyle = false;
            // 
            // customTextBox4
            // 
            this.customTextBox4.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customTextBox4.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(150)))));
            this.customTextBox4.BorderRadius = 10;
            this.customTextBox4.BorderSize = 2;
            this.customTextBox4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.customTextBox4.ForeColor = System.Drawing.Color.Black;
            this.customTextBox4.Location = new System.Drawing.Point(81, 191);
            this.customTextBox4.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBox4.Multiline = false;
            this.customTextBox4.Name = "customTextBox4";
            this.customTextBox4.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox4.PasswordChar = false;
            this.customTextBox4.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox4.PlaceholderText = "";
            this.customTextBox4.Size = new System.Drawing.Size(250, 31);
            this.customTextBox4.TabIndex = 11;
            this.customTextBox4.Texts = "";
            this.customTextBox4.UnderlinedStyle = false;
            // 
            // customTextBox2
            // 
            this.customTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customTextBox2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(150)))));
            this.customTextBox2.BorderRadius = 10;
            this.customTextBox2.BorderSize = 2;
            this.customTextBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.customTextBox2.ForeColor = System.Drawing.Color.Black;
            this.customTextBox2.Location = new System.Drawing.Point(24, 152);
            this.customTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBox2.Multiline = false;
            this.customTextBox2.Name = "customTextBox2";
            this.customTextBox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox2.PasswordChar = false;
            this.customTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox2.PlaceholderText = "";
            this.customTextBox2.Size = new System.Drawing.Size(250, 31);
            this.customTextBox2.TabIndex = 10;
            this.customTextBox2.Texts = "";
            this.customTextBox2.UnderlinedStyle = false;
            // 
            // customTextBox1
            // 
            this.customTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customTextBox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(150)))));
            this.customTextBox1.BorderRadius = 10;
            this.customTextBox1.BorderSize = 2;
            this.customTextBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.customTextBox1.ForeColor = System.Drawing.Color.Black;
            this.customTextBox1.Location = new System.Drawing.Point(24, 88);
            this.customTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBox1.Multiline = false;
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox1.PasswordChar = false;
            this.customTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox1.PlaceholderText = "";
            this.customTextBox1.Size = new System.Drawing.Size(250, 31);
            this.customTextBox1.TabIndex = 9;
            this.customTextBox1.Texts = "";
            this.customTextBox1.UnderlinedStyle = false;
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
            this.lbl.Size = new System.Drawing.Size(798, 40);
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
            // dpExpiry
            // 
            this.dpExpiry.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dpExpiry.BorderSize = 0;
            this.dpExpiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.dpExpiry.Location = new System.Drawing.Point(419, 287);
            this.dpExpiry.MinimumSize = new System.Drawing.Size(0, 35);
            this.dpExpiry.Name = "dpExpiry";
            this.dpExpiry.Size = new System.Drawing.Size(217, 35);
            this.dpExpiry.SkinColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.dpExpiry.TabIndex = 19;
            this.dpExpiry.TextColor = System.Drawing.Color.White;
            // 
            // AddItemInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 570);
            this.Controls.Add(this.dpExpiry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.customTextBox7);
            this.Controls.Add(this.customTextBox8);
            this.Controls.Add(this.customTextBox5);
            this.Controls.Add(this.customTextBox6);
            this.Controls.Add(this.customTextBox3);
            this.Controls.Add(this.customTextBox4);
            this.Controls.Add(this.customTextBox2);
            this.Controls.Add(this.customTextBox1);
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
        private CustomControls.RJControls.CustomTextBox customTextBox1;
        private CustomControls.RJControls.CustomTextBox customTextBox2;
        private CustomControls.RJControls.CustomTextBox customTextBox3;
        private CustomControls.RJControls.CustomTextBox customTextBox4;
        private CustomControls.RJControls.CustomTextBox customTextBox5;
        private CustomControls.RJControls.CustomTextBox customTextBox6;
        private CustomControls.RJControls.CustomTextBox customTextBox7;
        private CustomControls.RJControls.CustomTextBox customTextBox8;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label label1;
        private Materials.CustomDatePicker dpExpiry;
    }
}