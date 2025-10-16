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
            this.btnSettings = new System.Windows.Forms.Button();
            this.userAccountControl1 = new ColdChainConnectSystem_ACDP.AppForms.SidePanel.UserAccountControl();
            this.btnNotif = new System.Windows.Forms.Button();
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
            // btnSettings
            // 
            this.btnSettings.BackgroundImage = global::ColdChainConnectSystem_ACDP.Properties.Resources.settings;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.Color.Transparent;
            this.btnSettings.Location = new System.Drawing.Point(971, 6);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(17, 17);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
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
            // btnNotif
            // 
            this.btnNotif.BackgroundImage = global::ColdChainConnectSystem_ACDP.Properties.Resources.notifications;
            this.btnNotif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNotif.FlatAppearance.BorderSize = 0;
            this.btnNotif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotif.ForeColor = System.Drawing.Color.Transparent;
            this.btnNotif.Location = new System.Drawing.Point(940, 6);
            this.btnNotif.Name = "btnNotif";
            this.btnNotif.Size = new System.Drawing.Size(17, 17);
            this.btnNotif.TabIndex = 6;
            this.btnNotif.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btnNotif);
            this.Controls.Add(this.userAccountControl1);
            this.Controls.Add(this.btnSettings);
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
        private System.Windows.Forms.Button btnSettings;
        private AppForms.SidePanel.UserAccountControl userAccountControl1;
        private System.Windows.Forms.Button btnNotif;
    }
}