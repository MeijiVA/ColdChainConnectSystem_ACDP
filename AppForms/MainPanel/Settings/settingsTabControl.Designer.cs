namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Settings
{
    partial class settingsTabControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPersDetail = new System.Windows.Forms.Label();
            this.lblSecurity = new System.Windows.Forms.Label();
            this.lblExtra3 = new System.Windows.Forms.Label();
            this.lblExtra4 = new System.Windows.Forms.Label();
            this.lblExtra5 = new System.Windows.Forms.Label();
            this.lblExtra6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPersDetail
            // 
            this.lblPersDetail.BackColor = System.Drawing.Color.White;
            this.lblPersDetail.Font = new System.Drawing.Font("Arial", 9F);
            this.lblPersDetail.Location = new System.Drawing.Point(0, 0);
            this.lblPersDetail.Name = "lblPersDetail";
            this.lblPersDetail.Size = new System.Drawing.Size(120, 30);
            this.lblPersDetail.TabIndex = 0;
            this.lblPersDetail.Text = "Personal  Details";
            this.lblPersDetail.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblPersDetail.Click += new System.EventHandler(this.lblPersDetail_Click);
            // 
            // lblSecurity
            // 
            this.lblSecurity.BackColor = System.Drawing.Color.White;
            this.lblSecurity.Font = new System.Drawing.Font("Arial", 9F);
            this.lblSecurity.Location = new System.Drawing.Point(120, 0);
            this.lblSecurity.Name = "lblSecurity";
            this.lblSecurity.Size = new System.Drawing.Size(120, 30);
            this.lblSecurity.TabIndex = 1;
            this.lblSecurity.Text = "Security";
            this.lblSecurity.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblSecurity.Click += new System.EventHandler(this.lblSecurity_Click);
            // 
            // lblExtra3
            // 
            this.lblExtra3.BackColor = System.Drawing.Color.White;
            this.lblExtra3.Font = new System.Drawing.Font("Arial", 9F);
            this.lblExtra3.Location = new System.Drawing.Point(240, 0);
            this.lblExtra3.Name = "lblExtra3";
            this.lblExtra3.Size = new System.Drawing.Size(120, 30);
            this.lblExtra3.TabIndex = 2;
            this.lblExtra3.Text = "Security";
            this.lblExtra3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblExtra3.Click += new System.EventHandler(this.lblExtra3_Click);
            // 
            // lblExtra4
            // 
            this.lblExtra4.BackColor = System.Drawing.Color.White;
            this.lblExtra4.Font = new System.Drawing.Font("Arial", 9F);
            this.lblExtra4.Location = new System.Drawing.Point(360, 0);
            this.lblExtra4.Name = "lblExtra4";
            this.lblExtra4.Size = new System.Drawing.Size(120, 30);
            this.lblExtra4.TabIndex = 3;
            this.lblExtra4.Text = "Security";
            this.lblExtra4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblExtra4.Click += new System.EventHandler(this.lblExtra4_Click);
            // 
            // lblExtra5
            // 
            this.lblExtra5.BackColor = System.Drawing.Color.White;
            this.lblExtra5.Font = new System.Drawing.Font("Arial", 9F);
            this.lblExtra5.Location = new System.Drawing.Point(480, 0);
            this.lblExtra5.Name = "lblExtra5";
            this.lblExtra5.Size = new System.Drawing.Size(120, 30);
            this.lblExtra5.TabIndex = 4;
            this.lblExtra5.Text = "Security";
            this.lblExtra5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblExtra5.Click += new System.EventHandler(this.lblExtra5_Click);
            // 
            // lblExtra6
            // 
            this.lblExtra6.BackColor = System.Drawing.Color.White;
            this.lblExtra6.Font = new System.Drawing.Font("Arial", 9F);
            this.lblExtra6.Location = new System.Drawing.Point(600, 0);
            this.lblExtra6.Name = "lblExtra6";
            this.lblExtra6.Size = new System.Drawing.Size(120, 30);
            this.lblExtra6.TabIndex = 5;
            this.lblExtra6.Text = "Security";
            this.lblExtra6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblExtra6.Click += new System.EventHandler(this.lblExtra6_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.lblSecurity);
            this.panel1.Controls.Add(this.lblExtra3);
            this.panel1.Controls.Add(this.lblExtra6);
            this.panel1.Controls.Add(this.lblPersDetail);
            this.panel1.Controls.Add(this.lblExtra5);
            this.panel1.Controls.Add(this.lblExtra4);
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 30);
            this.panel1.TabIndex = 6;
            // 
            // settingsTabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Name = "settingsTabControl";
            this.Size = new System.Drawing.Size(765, 35);
            this.Load += new System.EventHandler(this.settingsTabControl_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPersDetail;
        private System.Windows.Forms.Label lblSecurity;
        private System.Windows.Forms.Label lblExtra3;
        private System.Windows.Forms.Label lblExtra4;
        private System.Windows.Forms.Label lblExtra5;
        private System.Windows.Forms.Label lblExtra6;
        private System.Windows.Forms.Panel panel1;
    }
}
