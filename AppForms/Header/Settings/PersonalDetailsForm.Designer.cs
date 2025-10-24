namespace ColdChainConnectSystem_ACDP.AppForms.Header.Settings
{
    partial class PersonalDetailsForm
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
            this.cTextBox1 = new ColdChainConnectSystem_ACDP.AppForms.MainPanel.Settings.CTextBox();
            this.SuspendLayout();
            // 
            // cTextBox1
            // 
            this.cTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.cTextBox1.Location = new System.Drawing.Point(30, 27);
            this.cTextBox1.Name = "cTextBox1";
            this.cTextBox1.Size = new System.Drawing.Size(200, 30);
            this.cTextBox1.TabIndex = 0;
            // 
            // PersonalDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 458);
            this.Controls.Add(this.cTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonalDetailsForm";
            this.Text = "PersonalDetailsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private MainPanel.Settings.CTextBox cTextBox1;
    }
}