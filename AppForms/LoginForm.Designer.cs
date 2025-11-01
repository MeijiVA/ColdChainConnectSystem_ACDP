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
            this.customTextBox1 = new CustomControls.RJControls.CustomTextBox();
            this.testButton = new System.Windows.Forms.Button();
            this.LogoACDPpBox = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlLogin = new ColdChainConnectSystem_ACDP.Materials.CustomPanel();
            this.btnLogin = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            this.CCCpBox = new System.Windows.Forms.PictureBox();
            this.userLbl = new System.Windows.Forms.Label();
            this.passLbl = new System.Windows.Forms.Label();
            this.customTextBox2 = new CustomControls.RJControls.CustomTextBox();
            this.customButton1 = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.LoginSplContainer)).BeginInit();
            this.LoginSplContainer.Panel1.SuspendLayout();
            this.LoginSplContainer.Panel2.SuspendLayout();
            this.LoginSplContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoACDPpBox)).BeginInit();
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
            this.LoginSplContainer.Panel2.Controls.Add(this.btnExit);
            this.LoginSplContainer.Panel2.Controls.Add(this.pnlLogin);
            this.LoginSplContainer.Size = new System.Drawing.Size(1000, 600);
            this.LoginSplContainer.SplitterDistance = 577;
            this.LoginSplContainer.SplitterWidth = 1;
            this.LoginSplContainer.TabIndex = 0;
            // 
            // customTextBox1
            // 
            this.customTextBox1.BackColor = System.Drawing.Color.White;
            this.customTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customTextBox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(96)))));
            this.customTextBox1.BorderRadius = 10;
            this.customTextBox1.BorderSize = 2;
            this.customTextBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.customTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customTextBox1.Location = new System.Drawing.Point(50, 188);
            this.customTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBox1.Multiline = false;
            this.customTextBox1.Name = "customTextBox1";
            this.customTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox1.PasswordChar = false;
            this.customTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox1.PlaceholderText = "";
            this.customTextBox1.Size = new System.Drawing.Size(250, 39);
            this.customTextBox1.TabIndex = 2;
            this.customTextBox1.Texts = "";
            this.customTextBox1.UnderlinedStyle = false;
            // 
            // testButton
            // 
            this.testButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(120)))));
            this.testButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.testButton.FlatAppearance.BorderSize = 0;
            this.testButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.testButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.testButton.Location = new System.Drawing.Point(23, 537);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(74, 51);
            this.testButton.TabIndex = 1;
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
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Copperplate Gothic Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.btnExit.Location = new System.Drawing.Point(375, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 35);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.White;
            this.pnlLogin.BackgroundColor = System.Drawing.Color.White;
            this.pnlLogin.BorderColor = System.Drawing.Color.Gray;
            this.pnlLogin.BorderRadius = 15;
            this.pnlLogin.BorderSize = 1;
            this.pnlLogin.Controls.Add(this.customButton1);
            this.pnlLogin.Controls.Add(this.customTextBox2);
            this.pnlLogin.Controls.Add(this.customTextBox1);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.CCCpBox);
            this.pnlLogin.Controls.Add(this.userLbl);
            this.pnlLogin.Controls.Add(this.passLbl);
            this.pnlLogin.ForeColor = System.Drawing.Color.White;
            this.pnlLogin.Location = new System.Drawing.Point(34, 53);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(350, 460);
            this.pnlLogin.TabIndex = 2;
            this.pnlLogin.TextColor = System.Drawing.Color.White;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.btnLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.btnLogin.BorderColor = System.Drawing.Color.Empty;
            this.btnLogin.BorderRadius = 10;
            this.btnLogin.BorderSize = 0;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(115, 326);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(124, 51);
            this.btnLogin.TabIndex = 5;
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
            // customTextBox2
            // 
            this.customTextBox2.BackColor = System.Drawing.Color.White;
            this.customTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customTextBox2.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(96)))));
            this.customTextBox2.BorderRadius = 10;
            this.customTextBox2.BorderSize = 2;
            this.customTextBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.customTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customTextBox2.Location = new System.Drawing.Point(50, 260);
            this.customTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.customTextBox2.Multiline = false;
            this.customTextBox2.Name = "customTextBox2";
            this.customTextBox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.customTextBox2.PasswordChar = false;
            this.customTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customTextBox2.PlaceholderText = "";
            this.customTextBox2.Size = new System.Drawing.Size(250, 39);
            this.customTextBox2.TabIndex = 6;
            this.customTextBox2.Texts = "";
            this.customTextBox2.UnderlinedStyle = false;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.White;
            this.customButton1.BackgroundColor = System.Drawing.Color.White;
            this.customButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton1.BorderRadius = 0;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(259, 264);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(32, 32);
            this.customButton1.TabIndex = 7;
            this.customButton1.Text = "customButton1";
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
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
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.LoginSplContainer.Panel1.ResumeLayout(false);
            this.LoginSplContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LoginSplContainer)).EndInit();
            this.LoginSplContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoACDPpBox)).EndInit();
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
        private CustomControls.RJControls.CustomTextBox customTextBox1;
        private CustomControls.RJControls.CustomTextBox customTextBox2;
        private Materials.CustomButton customButton1;
    }
}

