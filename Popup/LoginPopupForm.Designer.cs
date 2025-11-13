namespace ColdChainConnectSystem_ACDP.Popup
{
    partial class LoginPopupForm
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
            this.btnOK = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            this.txtDb = new CustomControls.RJControls.CustomTextBox();
            this.customPanel1 = new ColdChainConnectSystem_ACDP.Materials.CustomPanel();
            this.lbl = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "The Current Data Source is not specified,\r\n Insert your Database\'s Data Source";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.btnOK.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.btnOK.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnOK.BorderRadius = 10;
            this.btnOK.BorderSize = 0;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(283, 121);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(56, 40);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.TextColor = System.Drawing.Color.White;
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtDb
            // 
            this.txtDb.BackColor = System.Drawing.Color.White;
            this.txtDb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.txtDb.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(150)))));
            this.txtDb.BorderRadius = 10;
            this.txtDb.BorderSize = 2;
            this.txtDb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.txtDb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDb.Location = new System.Drawing.Point(13, 78);
            this.txtDb.Margin = new System.Windows.Forms.Padding(4);
            this.txtDb.Multiline = false;
            this.txtDb.Name = "txtDb";
            this.txtDb.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDb.PasswordChar = false;
            this.txtDb.PlaceholderColor = System.Drawing.Color.DarkGreen;
            this.txtDb.PlaceholderText = "";
            this.txtDb.Size = new System.Drawing.Size(324, 39);
            this.txtDb.TabIndex = 1;
            this.txtDb.Texts = "";
            this.txtDb.UnderlinedStyle = false;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customPanel1.BorderRadius = 0;
            this.customPanel1.BorderSize = 0;
            this.customPanel1.Controls.Add(this.lbl);
            this.customPanel1.Controls.Add(this.btnExit);
            this.customPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.customPanel1.ForeColor = System.Drawing.Color.White;
            this.customPanel1.Location = new System.Drawing.Point(0, 0);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(350, 30);
            this.customPanel1.TabIndex = 0;
            this.customPanel1.TextColor = System.Drawing.Color.White;
            this.customPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.customPanel1_MouseDown);
            this.customPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.customPanel1_MouseMove);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(20, 7);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(75, 16);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "Database ";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(314, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(27, 30);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // LoginPopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 170);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtDb);
            this.Controls.Add(this.customPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginPopupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPopupForm";
            this.Load += new System.EventHandler(this.LoginPopupForm_Load);
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Materials.CustomPanel customPanel1;
        private CustomControls.RJControls.CustomTextBox txtDb;
        private Materials.CustomButton btnOK;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label1;
    }
}