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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.personal_Information1 = new ColdChainConnectSystem_ACDP.AppForms.Header.Settings.PersonalDetails.Personal_Information();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(15, 245);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(450, 200);
            this.flowLayoutPanel2.TabIndex = 17;
            // 
            // personal_Information1
            // 
            this.personal_Information1.BackColor = System.Drawing.Color.White;
            this.personal_Information1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.personal_Information1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.personal_Information1.Location = new System.Drawing.Point(15, 15);
            this.personal_Information1.Name = "personal_Information1";
            this.personal_Information1.Size = new System.Drawing.Size(450, 200);
            this.personal_Information1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(488, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 428);
            this.panel1.TabIndex = 18;
            // 
            // PersonalDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 455);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.personal_Information1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "PersonalDetailsForm";
            this.Text = "PersonalDetailsForm";
            this.Load += new System.EventHandler(this.PersonalDetailsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private PersonalDetails.Personal_Information personal_Information1;
        private System.Windows.Forms.Panel panel1;
    }
}