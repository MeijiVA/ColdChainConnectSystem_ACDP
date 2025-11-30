namespace ColdChainConnectSystem_ACDP.AppForms.Header.Notification
{
    partial class NotificationDisplay
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
            this.flowLayoutNotif = new System.Windows.Forms.FlowLayoutPanel();
            this.customPanel1 = new ColdChainConnectSystem_ACDP.Materials.CustomPanel();
            this.lbl = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.customPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutNotif
            // 
            this.flowLayoutNotif.AutoScroll = true;
            this.flowLayoutNotif.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutNotif.Location = new System.Drawing.Point(0, 40);
            this.flowLayoutNotif.Name = "flowLayoutNotif";
            this.flowLayoutNotif.Size = new System.Drawing.Size(260, 100);
            this.flowLayoutNotif.TabIndex = 2;
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customPanel1.BorderRadius = 0;
            this.customPanel1.BorderSize = 0;
            this.customPanel1.Controls.Add(this.lbl);
            this.customPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.customPanel1.ForeColor = System.Drawing.Color.White;
            this.customPanel1.Location = new System.Drawing.Point(0, 0);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.customPanel1.Size = new System.Drawing.Size(260, 40);
            this.customPanel1.TabIndex = 1;
            this.customPanel1.TextColor = System.Drawing.Color.White;
            this.customPanel1.Click += new System.EventHandler(this.customPanel1_Click);
            this.customPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.customPanel1_Paint);
            // 
            // lbl
            // 
            this.lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lbl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lbl.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.lbl.BorderRadius = 0;
            this.lbl.BorderSize = 0;
            this.lbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(10, 10);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(126, 20);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Notification";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl.TextColor = System.Drawing.Color.White;
            // 
            // NotificationDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutNotif);
            this.Controls.Add(this.customPanel1);
            this.Name = "NotificationDisplay";
            this.Size = new System.Drawing.Size(260, 140);
            this.Load += new System.EventHandler(this.NotificationDisplay_Load);
            this.customPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Materials.CustomPanel customPanel1;
        private Materials.CustomLabel lbl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutNotif;
    }
}
