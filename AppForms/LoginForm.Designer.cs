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
            this.testButton = new System.Windows.Forms.Button();
            this.LogoACDPpBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlLogin = new ColdChainConnectSystem_ACDP.Materials.CustomPanel();
            this.btnTogglePassword = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            this.txtUser = new CustomControls.RJControls.CustomTextBox();
            this.btnLogin = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            this.CCCpBox = new System.Windows.Forms.PictureBox();
            this.userLbl = new System.Windows.Forms.Label();
            this.passLbl = new System.Windows.Forms.Label();
            this.txtPass = new CustomControls.RJControls.CustomTextBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LoginSplContainer)).BeginInit();
            this.LoginSplContainer.Panel1.SuspendLayout();
            this.LoginSplContainer.Panel2.SuspendLayout();
            this.LoginSplContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoACDPpBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlLogin.SuspendLayout();
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
            this.LoginSplContainer.Panel1.Controls.Add(this.testButton);
            this.LoginSplContainer.Panel1.Controls.Add(this.LogoACDPpBox);
            this.LoginSplContainer.Panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginSplContainer_Panel1_MouseDown);
            this.LoginSplContainer.Panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginSplContainer_Panel1_MouseMove);
            // 
            // LoginSplContainer.Panel2
            // 
            this.LoginSplContainer.Panel2.Controls.Add(this.panel1);
            this.LoginSplContainer.Panel2.Controls.Add(this.btnExit);
            this.LoginSplContainer.Panel2.Padding = new System.Windows.Forms.Padding(0, 30, 0, 30);
            this.LoginSplContainer.Size = new System.Drawing.Size(1000, 600);
            this.LoginSplContainer.SplitterDistance = 577;
            this.LoginSplContainer.SplitterWidth = 1;
            this.LoginSplContainer.TabIndex = 0;
            // 
            // testButton
            // 
            this.testButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(120)))));
            this.testButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.testButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.testButton.FlatAppearance.BorderSize = 0;
            this.testButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.testButton.Location = new System.Drawing.Point(23, 537);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(74, 51);
            this.testButton.TabIndex = 4;
            this.testButton.Text = "Login";
            this.testButton.UseVisualStyleBackColor = false;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
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
            // panel1
            // 
            this.panel1.BackgroundImage = global::ColdChainConnectSystem_ACDP.Properties.Resources.ShadowsTravelingGRRR;
            this.panel1.Controls.Add(this.pnlLogin);
            this.panel1.Location = new System.Drawing.Point(25, 53);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(370, 480);
            this.panel1.TabIndex = 2;
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.White;
            this.pnlLogin.BackgroundColor = System.Drawing.Color.White;
            this.pnlLogin.BorderColor = System.Drawing.Color.Gray;
            this.pnlLogin.BorderRadius = 15;
            this.pnlLogin.BorderSize = 1;
            this.pnlLogin.Controls.Add(this.btnTogglePassword);
            this.pnlLogin.Controls.Add(this.txtUser);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.CCCpBox);
            this.pnlLogin.Controls.Add(this.userLbl);
            this.pnlLogin.Controls.Add(this.passLbl);
            this.pnlLogin.Controls.Add(this.txtPass);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogin.ForeColor = System.Drawing.Color.White;
            this.pnlLogin.Location = new System.Drawing.Point(10, 10);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(350, 460);
            this.pnlLogin.TabIndex = 2;
            this.pnlLogin.TextColor = System.Drawing.Color.White;
            // 
            // btnTogglePassword
            // 
            this.btnTogglePassword.BackColor = System.Drawing.Color.Transparent;
            this.btnTogglePassword.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnTogglePassword.BackgroundImage = global::ColdChainConnectSystem_ACDP.Properties.Resources.passhide;
            this.btnTogglePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTogglePassword.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTogglePassword.BorderRadius = 0;
            this.btnTogglePassword.BorderSize = 0;
            this.btnTogglePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTogglePassword.FlatAppearance.BorderSize = 0;
            this.btnTogglePassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnTogglePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnTogglePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTogglePassword.ForeColor = System.Drawing.Color.White;
            this.btnTogglePassword.GradientColor1 = System.Drawing.Color.Empty;
            this.btnTogglePassword.GradientColor2 = System.Drawing.Color.Empty;
            this.btnTogglePassword.Location = new System.Drawing.Point(265, 266);
            this.btnTogglePassword.Name = "btnTogglePassword";
            this.btnTogglePassword.Size = new System.Drawing.Size(25, 29);
            this.btnTogglePassword.TabIndex = 4;
            this.btnTogglePassword.TextColor = System.Drawing.Color.White;
            this.btnTogglePassword.UseVisualStyleBackColor = false;
            this.btnTogglePassword.Click += new System.EventHandler(this.btnTogglePassword_Click);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.White;
            this.txtUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.txtUser.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(96)))));
            this.txtUser.BorderRadius = 10;
            this.txtUser.BorderSize = 2;
            this.txtUser.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.txtUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUser.Location = new System.Drawing.Point(50, 188);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Multiline = false;
            this.txtUser.Name = "txtUser";
            this.txtUser.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUser.PasswordChar = false;
            this.txtUser.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtUser.PlaceholderText = "";
            this.txtUser.Size = new System.Drawing.Size(250, 39);
            this.txtUser.TabIndex = 1;
            this.txtUser.Texts = "";
            this.txtUser.UnderlinedStyle = false;
            this.txtUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUser_KeyDown);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.btnLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.btnLogin.BorderColor = System.Drawing.Color.Empty;
            this.btnLogin.BorderRadius = 10;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.GradientColor1 = System.Drawing.Color.Empty;
            this.btnLogin.GradientColor2 = System.Drawing.Color.Empty;
            this.btnLogin.Location = new System.Drawing.Point(115, 326);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(124, 51);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.TextColor = System.Drawing.Color.White;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // CCCpBox
            // 
            this.CCCpBox.BackgroundImage = global::ColdChainConnectSystem_ACDP.Properties.Resources.CCC_GrayLogo;
            this.CCCpBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CCCpBox.Location = new System.Drawing.Point(127, 22);
            this.CCCpBox.Name = "CCCpBox";
            this.CCCpBox.Size = new System.Drawing.Size(94, 70);
            this.CCCpBox.TabIndex = 0;
            this.CCCpBox.TabStop = false;
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.userLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.userLbl.Location = new System.Drawing.Point(54, 157);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(76, 16);
            this.userLbl.TabIndex = 3;
            this.userLbl.Text = "Username";
            // 
            // passLbl
            // 
            this.passLbl.AutoSize = true;
            this.passLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.passLbl.Location = new System.Drawing.Point(54, 240);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(74, 16);
            this.passLbl.TabIndex = 4;
            this.passLbl.Text = "Password";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.White;
            this.txtPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.txtPass.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(96)))));
            this.txtPass.BorderRadius = 10;
            this.txtPass.BorderSize = 2;
            this.txtPass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPass.Location = new System.Drawing.Point(50, 260);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Multiline = false;
            this.txtPass.Name = "txtPass";
            this.txtPass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPass.PasswordChar = true;
            this.txtPass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtPass.PlaceholderText = "";
            this.txtPass.Size = new System.Drawing.Size(250, 39);
            this.txtPass.TabIndex = 2;
            this.txtPass.Texts = "";
            this.txtPass.UnderlinedStyle = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.btnExit.Location = new System.Drawing.Point(385, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 35);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "22g";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.LoginSplContainer.Panel1.ResumeLayout(false);
            this.LoginSplContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LoginSplContainer)).EndInit();
            this.LoginSplContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoACDPpBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CCCpBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer LoginSplContainer;
        private System.Windows.Forms.PictureBox LogoACDPpBox;
        private System.Windows.Forms.Button testButton;
        private System.Windows.Forms.Button btnExit;
        private Materials.CustomPanel pnlLogin;
        private Materials.CustomButton btnLogin;
        private System.Windows.Forms.PictureBox CCCpBox;
        private System.Windows.Forms.Label userLbl;
        private System.Windows.Forms.Label passLbl;
        private CustomControls.RJControls.CustomTextBox txtUser;
        private CustomControls.RJControls.CustomTextBox txtPass;
        private Materials.CustomButton btnTogglePassword;
        private System.Windows.Forms.Panel panel1;
    }
}

