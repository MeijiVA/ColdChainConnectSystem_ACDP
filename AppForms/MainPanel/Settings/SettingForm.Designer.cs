namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Settings
{
    partial class SettingForm
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
            this.setlbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // setlbl
            // 
            this.setlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.setlbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setlbl.ForeColor = System.Drawing.Color.White;
            this.setlbl.Location = new System.Drawing.Point(18, 14);
            this.setlbl.Name = "setlbl";
            this.setlbl.Size = new System.Drawing.Size(765, 44);
            this.setlbl.TabIndex = 0;
            this.setlbl.Text = "   Settings";
            this.setlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.setlbl.Click += new System.EventHandler(this.setlbl_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(19, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 35);
            this.panel1.TabIndex = 1;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.setlbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label setlbl;
        private System.Windows.Forms.Panel panel1;
    }
}