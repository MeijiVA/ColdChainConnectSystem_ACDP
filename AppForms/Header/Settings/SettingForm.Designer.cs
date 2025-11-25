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
            this.tabsSetting = new ColdChainConnectSystem_ACDP.AppForms.MainPanel.Settings.settingsTabControl();
            this.pnlDisplaySettings = new ColdChainConnectSystem_ACDP.Materials.CustomPanel();
            this.lblSettings = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.SuspendLayout();
            // 
            // tabsSetting
            // 
            this.tabsSetting.BackColor = System.Drawing.Color.White;
            this.tabsSetting.Location = new System.Drawing.Point(22, 62);
            this.tabsSetting.Name = "tabsSetting";
            this.tabsSetting.Size = new System.Drawing.Size(756, 35);
            this.tabsSetting.TabIndex = 0;
            this.tabsSetting.Load += new System.EventHandler(this.tabsSetting_Load);
            // 
            // pnlDisplaySettings
            // 
            this.pnlDisplaySettings.BackColor = System.Drawing.SystemColors.Control;
            this.pnlDisplaySettings.BackgroundColor = System.Drawing.SystemColors.Control;
            this.pnlDisplaySettings.BorderColor = System.Drawing.Color.Transparent;
            this.pnlDisplaySettings.BorderRadius = 15;
            this.pnlDisplaySettings.BorderSize = 1;
            this.pnlDisplaySettings.ForeColor = System.Drawing.Color.White;
            this.pnlDisplaySettings.Location = new System.Drawing.Point(18, 96);
            this.pnlDisplaySettings.Name = "pnlDisplaySettings";
            this.pnlDisplaySettings.Size = new System.Drawing.Size(766, 458);
            this.pnlDisplaySettings.TabIndex = 0;
            this.pnlDisplaySettings.TextColor = System.Drawing.Color.White;
            // 
            // lblSettings
            // 
            this.lblSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblSettings.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblSettings.BorderColor = System.Drawing.Color.Transparent;
            this.lblSettings.BorderRadius = 10;
            this.lblSettings.BorderSize = 0;
            this.lblSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSettings.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblSettings.ForeColor = System.Drawing.Color.White;
            this.lblSettings.Location = new System.Drawing.Point(18, 15);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(765, 44);
            this.lblSettings.TabIndex = 0;
            this.lblSettings.Text = "   Settings";
            this.lblSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSettings.TextColor = System.Drawing.Color.White;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 570);
            this.Controls.Add(this.pnlDisplaySettings);
            this.Controls.Add(this.tabsSetting);
            this.Controls.Add(this.lblSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingForm";
            this.ResumeLayout(false);

        }

        #endregion
        private settingsTabControl tabsSetting;
        public Materials.CustomPanel pnlDisplaySettings;
        private Materials.CustomLabel lblSettings;
    }
}