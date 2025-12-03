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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnNotif = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.notificationDisplay1 = new ColdChainConnectSystem_ACDP.AppForms.Header.Notification.NotificationDisplay();
            this.uacUserProfile = new ColdChainConnectSystem_ACDP.AppForms.SidePanel.UserAccountControl();
            this.sidePanel1 = new ColdChainConnectSystem_ACDP.AppForms.SidePanel.SidePanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DisplayPanel
            // 
            this.DisplayPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.DisplayPanel.Location = new System.Drawing.Point(237, 30);
            this.DisplayPanel.Name = "DisplayPanel";
            this.DisplayPanel.Size = new System.Drawing.Size(799, 570);
            this.DisplayPanel.TabIndex = 0;
            this.DisplayPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DisplayPanel_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ColdChainConnectSystem_ACDP.Properties.Resources.ACDPLogo;
            this.pictureBox1.Location = new System.Drawing.Point(48, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSettings
            // 
            this.btnSettings.BackgroundImage = global::ColdChainConnectSystem_ACDP.Properties.Resources.settings;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.Color.Transparent;
            this.btnSettings.Location = new System.Drawing.Point(1008, 6);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(17, 17);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnNotif
            // 
            this.btnNotif.BackgroundImage = global::ColdChainConnectSystem_ACDP.Properties.Resources.notifications;
            this.btnNotif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNotif.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotif.FlatAppearance.BorderSize = 0;
            this.btnNotif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotif.ForeColor = System.Drawing.Color.Transparent;
            this.btnNotif.Location = new System.Drawing.Point(977, 6);
            this.btnNotif.Name = "btnNotif";
            this.btnNotif.Size = new System.Drawing.Size(17, 17);
            this.btnNotif.TabIndex = 6;
            this.btnNotif.UseVisualStyleBackColor = true;
            this.btnNotif.Click += new System.EventHandler(this.btnNotif_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackgroundImage = global::ColdChainConnectSystem_ACDP.Properties.Resources.LogoutButton;
            this.logoutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.ForeColor = System.Drawing.Color.Transparent;
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.logoutBtn.Location = new System.Drawing.Point(61, 568);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(79, 16);
            this.logoutBtn.TabIndex = 0;
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // notificationDisplay1
            // 
            this.notificationDisplay1.BackColor = System.Drawing.Color.White;
            this.notificationDisplay1.Location = new System.Drawing.Point(728, 23);
            this.notificationDisplay1.Name = "notificationDisplay1";
            this.notificationDisplay1.Size = new System.Drawing.Size(266, 141);
            this.notificationDisplay1.TabIndex = 0;
            this.notificationDisplay1.Visible = false;
            this.notificationDisplay1.Load += new System.EventHandler(this.notificationDisplay1_Load_1);
            // 
            // uacUserProfile
            // 
            this.uacUserProfile.AccountName = "Name";
            this.uacUserProfile.BackColor = System.Drawing.Color.Transparent;
            this.uacUserProfile.Location = new System.Drawing.Point(12, 49);
            this.uacUserProfile.Name = "uacUserProfile";
            this.uacUserProfile.Padding = new System.Windows.Forms.Padding(27, 0, 27, 0);
            this.uacUserProfile.Size = new System.Drawing.Size(177, 163);
            this.uacUserProfile.TabIndex = 5;
            this.uacUserProfile.Load += new System.EventHandler(this.userAccountControl1_Load);
            // 
            // sidePanel1
            // 
            this.sidePanel1.BackColor = System.Drawing.Color.Transparent;
            this.sidePanel1.Location = new System.Drawing.Point(0, 199);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(231, 355);
            this.sidePanel1.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.BackgroundImage = global::ColdChainConnectSystem_ACDP.Properties.Resources.MainForm1;
            this.ClientSize = new System.Drawing.Size(1035, 600);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.notificationDisplay1);
            this.Controls.Add(this.uacUserProfile);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.btnNotif);
            this.Controls.Add(this.btnSettings);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel DisplayPanel;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnNotif;
        public AppForms.SidePanel.UserAccountControl uacUserProfile;
        private System.Windows.Forms.Button logoutBtn;
        public AppForms.SidePanel.SidePanel sidePanel1;
        private AppForms.Header.Notification.NotificationDisplay notificationDisplay1;
    }
}