namespace ColdChainConnectSystem_ACDP
{
    partial class MainForm
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
            this.DisplayPanel = new System.Windows.Forms.Panel();
            this.MainSidePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.userAccountControl1 = new ColdChainConnectSystem_ACDP.AppForms.SidePanel.UserAccountControl();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DisplayPanel
            // 
            this.DisplayPanel.BackColor = System.Drawing.Color.White;
            this.DisplayPanel.Location = new System.Drawing.Point(202, 30);
            this.DisplayPanel.Name = "DisplayPanel";
            this.DisplayPanel.Size = new System.Drawing.Size(798, 570);
            this.DisplayPanel.TabIndex = 0;
            // 
            // MainSidePanel
            // 
            this.MainSidePanel.BackColor = System.Drawing.Color.White;
            this.MainSidePanel.Location = new System.Drawing.Point(0, 200);
            this.MainSidePanel.Name = "MainSidePanel";
            this.MainSidePanel.Size = new System.Drawing.Size(200, 355);
            this.MainSidePanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.logoutBtn);
            this.panel1.Location = new System.Drawing.Point(0, 554);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 46);
            this.panel1.TabIndex = 3;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackgroundImage = global::ColdChainConnectSystem_ACDP.Properties.Resources.LogoutButton;
            this.logoutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.ForeColor = System.Drawing.Color.Transparent;
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.logoutBtn.Location = new System.Drawing.Point(50, 12);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(93, 25);
            this.logoutBtn.TabIndex = 0;
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ColdChainConnectSystem_ACDP.Properties.Resources.ACDPLogo;
            this.pictureBox1.Location = new System.Drawing.Point(21, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ColdChainConnectSystem_ACDP.Properties.Resources.settings;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(971, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(17, 17);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // userAccountControl1
            // 
            this.userAccountControl1.BackColor = System.Drawing.Color.White;
            this.userAccountControl1.Location = new System.Drawing.Point(0, 30);
            this.userAccountControl1.Name = "userAccountControl1";
            this.userAccountControl1.Size = new System.Drawing.Size(200, 170);
            this.userAccountControl1.TabIndex = 5;
            this.userAccountControl1.Load += new System.EventHandler(this.userAccountControl1_Load);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::ColdChainConnectSystem_ACDP.Properties.Resources.notifications;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(940, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(17, 17);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.userAccountControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainSidePanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DisplayPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel DisplayPanel;
        public System.Windows.Forms.Panel MainSidePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button button1;
        private AppForms.SidePanel.UserAccountControl userAccountControl1;
        private System.Windows.Forms.Button button2;
    }
}