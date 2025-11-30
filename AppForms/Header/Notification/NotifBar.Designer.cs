namespace ColdChainConnectSystem_ACDP.AppForms.Header.Notification
{
    partial class NotifBar
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
            this.lblEmpID = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.lblDescription = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.SuspendLayout();
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpID.BackgroundColor = System.Drawing.Color.Transparent;
            this.lblEmpID.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.lblEmpID.BorderRadius = 0;
            this.lblEmpID.BorderSize = 0;
            this.lblEmpID.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEmpID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmpID.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmpID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblEmpID.Location = new System.Drawing.Point(10, 10);
            this.lblEmpID.Margin = new System.Windows.Forms.Padding(5);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(118, 14);
            this.lblEmpID.TabIndex = 0;
            this.lblEmpID.Text = "Description Here";
            this.lblEmpID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEmpID.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.BackgroundColor = System.Drawing.Color.Transparent;
            this.lblDescription.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.lblDescription.BorderRadius = 0;
            this.lblDescription.BorderSize = 0;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDescription.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblDescription.Location = new System.Drawing.Point(10, 24);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(5);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(102, 13);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description Here";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDescription.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            // 
            // NotifBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblEmpID);
            this.Name = "NotifBar";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(225, 50);
            this.Load += new System.EventHandler(this.NotifBar_Load);
            this.Click += new System.EventHandler(this.NotifBar_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Materials.CustomLabel lblEmpID;
        public Materials.CustomLabel lblDescription;
    }
}
