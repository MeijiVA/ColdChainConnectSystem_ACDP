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
            this.LoginSplContainer = new System.Windows.Forms.SplitContainer();
            this.LogoACDPpBox = new System.Windows.Forms.PictureBox();
            this.PanelLogin = new System.Windows.Forms.Panel();
            this.usernTbox = new System.Windows.Forms.TextBox();
            this.passTbox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.passLbl = new System.Windows.Forms.Label();
            this.userLbl = new System.Windows.Forms.Label();
            this.CCCpBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LoginSplContainer)).BeginInit();
            this.LoginSplContainer.Panel1.SuspendLayout();
            this.LoginSplContainer.Panel2.SuspendLayout();
            this.LoginSplContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoACDPpBox)).BeginInit();
            this.PanelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CCCpBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginSplContainer
            // 
            this.LoginSplContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginSplContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.LoginSplContainer.IsSplitterFixed = true;
            this.LoginSplContainer.Location = new System.Drawing.Point(0, 0);
            this.LoginSplContainer.Name = "LoginSplContainer";
            // 
            // LoginSplContainer.Panel1
            // 
            this.LoginSplContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.LoginSplContainer.Panel1.Controls.Add(this.LogoACDPpBox);
            this.LoginSplContainer.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginSplContainer_Panel1_MouseDown);
            this.LoginSplContainer.Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginSplContainer_Panel1_MouseMove);
            // 
            // LoginSplContainer.Panel2
            // 
            this.LoginSplContainer.Panel2.Controls.Add(this.PanelLogin);
            this.LoginSplContainer.Size = new System.Drawing.Size(1000, 600);
            this.LoginSplContainer.SplitterDistance = 577;
            this.LoginSplContainer.SplitterWidth = 1;
            this.LoginSplContainer.TabIndex = 0;
            // 
            // LogoACDPpBox
            // 
            this.LogoACDPpBox.BackgroundImage = global::ColdChainConnectSystem_ACDP.Properties.Resources.LoginLogoACDP;
            this.LogoACDPpBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogoACDPpBox.Location = new System.Drawing.Point(66, 98);
            this.LogoACDPpBox.Name = "LogoACDPpBox";
            this.LogoACDPpBox.Size = new System.Drawing.Size(428, 299);
            this.LogoACDPpBox.TabIndex = 0;
            this.LogoACDPpBox.TabStop = false;
            // 
            // PanelLogin
            // 
            this.PanelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.PanelLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PanelLogin.Controls.Add(this.usernTbox);
            this.PanelLogin.Controls.Add(this.passTbox);
            this.PanelLogin.Controls.Add(this.loginBtn);
            this.PanelLogin.Controls.Add(this.passLbl);
            this.PanelLogin.Controls.Add(this.userLbl);
            this.PanelLogin.Controls.Add(this.CCCpBox);
            this.PanelLogin.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelLogin.Location = new System.Drawing.Point(31, 70);
            this.PanelLogin.Name = "PanelLogin";
            this.PanelLogin.Size = new System.Drawing.Size(350, 460);
            this.PanelLogin.TabIndex = 0;
            // 
            // usernTbox
            // 
            this.usernTbox.Location = new System.Drawing.Point(58, 163);
            this.usernTbox.MinimumSize = new System.Drawing.Size(235, 35);
            this.usernTbox.Name = "usernTbox";
            this.usernTbox.Size = new System.Drawing.Size(235, 35);
            this.usernTbox.TabIndex = 1;
            this.usernTbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.usernTbox_KeyDown);
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
            this.passTbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passTbox_KeyDown);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.loginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginBtn.Location = new System.Drawing.Point(119, 324);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(124, 51);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // passLbl
            // 
            this.passLbl.AutoSize = true;
            this.passLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.passLbl.Location = new System.Drawing.Point(52, 223);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(74, 16);
            this.passLbl.TabIndex = 4;
            this.passLbl.Text = "Password";
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.userLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.userLbl.Location = new System.Drawing.Point(52, 140);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(76, 16);
            this.userLbl.TabIndex = 3;
            this.userLbl.Text = "Username";
            // 
            // CCCpBox
            // 
            this.CCCpBox.BackgroundImage = global::ColdChainConnectSystem_ACDP.Properties.Resources.CCC_GrayLogo;
            this.CCCpBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CCCpBox.Location = new System.Drawing.Point(132, 15);
            this.CCCpBox.Name = "CCCpBox";
            this.CCCpBox.Size = new System.Drawing.Size(94, 70);
            this.CCCpBox.TabIndex = 0;
            this.CCCpBox.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.LoginSplContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.LoginSplContainer.Panel1.ResumeLayout(false);
            this.LoginSplContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LoginSplContainer)).EndInit();
            this.LoginSplContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoACDPpBox)).EndInit();
            this.PanelLogin.ResumeLayout(false);
            this.PanelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CCCpBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer LoginSplContainer;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Panel PanelLogin;
        private System.Windows.Forms.TextBox usernTbox;
        private System.Windows.Forms.TextBox passTbox;
        private System.Windows.Forms.Label passLbl;
        private System.Windows.Forms.Label userLbl;
        private System.Windows.Forms.PictureBox CCCpBox;
        private System.Windows.Forms.PictureBox LogoACDPpBox;
    }
}

