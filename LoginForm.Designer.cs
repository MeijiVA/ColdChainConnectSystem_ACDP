namespace ColdChainConnectSystem_ACDP
{
    partial class LoginForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.PanelLogin = new System.Windows.Forms.Panel();
            this.passLbl = new System.Windows.Forms.Label();
            this.userLbl = new System.Windows.Forms.Label();
            this.usernTbox = new System.Windows.Forms.TextBox();
            this.passTbox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.PanelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SplitPanelLogo_MouseDown);
            this.splitContainer1.Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SplitPanelLogo_MouseMove);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.PanelLogin);
            this.splitContainer1.Size = new System.Drawing.Size(1000, 600);
            this.splitContainer1.SplitterDistance = 577;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // PanelLogin
            // 
            this.PanelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.PanelLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PanelLogin.Controls.Add(this.pictureBox1);
            this.PanelLogin.Controls.Add(this.passLbl);
            this.PanelLogin.Controls.Add(this.userLbl);
            this.PanelLogin.Controls.Add(this.usernTbox);
            this.PanelLogin.Controls.Add(this.passTbox);
            this.PanelLogin.Controls.Add(this.loginBtn);
            this.PanelLogin.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelLogin.Location = new System.Drawing.Point(31, 70);
            this.PanelLogin.Name = "PanelLogin";
            this.PanelLogin.Size = new System.Drawing.Size(350, 460);
            this.PanelLogin.TabIndex = 0;
            // 
            // passLbl
            // 
            this.passLbl.AutoSize = true;
            this.passLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.passLbl.Location = new System.Drawing.Point(52, 225);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(66, 14);
            this.passLbl.TabIndex = 4;
            this.passLbl.Text = "Password";
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.userLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.userLbl.Location = new System.Drawing.Point(52, 142);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(67, 14);
            this.userLbl.TabIndex = 3;
            this.userLbl.Text = "Username";
            // 
            // usernTbox
            // 
            this.usernTbox.Location = new System.Drawing.Point(58, 163);
            this.usernTbox.MinimumSize = new System.Drawing.Size(235, 35);
            this.usernTbox.Name = "usernTbox";
            this.usernTbox.Size = new System.Drawing.Size(235, 35);
            this.usernTbox.TabIndex = 1;
            // 
            // passTbox
            // 
            this.passTbox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.passTbox.Location = new System.Drawing.Point(58, 246);
            this.passTbox.MinimumSize = new System.Drawing.Size(235, 35);
            this.passTbox.Name = "passTbox";
            this.passTbox.PasswordChar = '*';
            this.passTbox.Size = new System.Drawing.Size(235, 35);
            this.passTbox.TabIndex = 1;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.loginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginBtn.Location = new System.Drawing.Point(116, 350);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(124, 51);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ColdChainConnectSystem_ACDP.Properties.Resources.LoginLogoACDP;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(66, 98);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(428, 299);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ColdChainConnectSystem_ACDP.Properties.Resources.CCC_GrayLogo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(132, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(94, 70);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.PanelLogin.ResumeLayout(false);
            this.PanelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Panel PanelLogin;
        private System.Windows.Forms.TextBox usernTbox;
        private System.Windows.Forms.TextBox passTbox;
        private System.Windows.Forms.Label passLbl;
        private System.Windows.Forms.Label userLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

