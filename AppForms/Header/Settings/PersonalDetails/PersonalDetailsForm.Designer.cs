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
            this.lblEmpID = new System.Windows.Forms.Label();
            this.ContactUserControl = new ColdChainConnectSystem_ACDP.AppForms.Header.Settings.PersonalDetails.ContactInformation();
            this.PersonalUserControl = new ColdChainConnectSystem_ACDP.AppForms.Header.Settings.PersonalDetails.Personal_Information();
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
            // lblEmpID
            // 
            this.lblEmpID.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpID.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmpID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblEmpID.Location = new System.Drawing.Point(16, 15);
            this.lblEmpID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(450, 18);
            this.lblEmpID.TabIndex = 64;
            this.lblEmpID.Text = "Employee ID Here";
            this.lblEmpID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ContactUserControl
            // 
            this.ContactUserControl.BackColor = System.Drawing.Color.White;
            this.ContactUserControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContactUserControl.ConNum = "Ow yeah";
            this.ContactUserControl.EmailInfo = "email";
            this.ContactUserControl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ContactUserControl.Location = new System.Drawing.Point(474, 15);
            this.ContactUserControl.Name = "ContactUserControl";
            this.ContactUserControl.PositionInfo = "position";
            this.ContactUserControl.Size = new System.Drawing.Size(280, 430);
            this.ContactUserControl.StatusInfo = "status";
            this.ContactUserControl.TabIndex = 65;
            // 
            // PersonalUserControl
            // 
            this.PersonalUserControl.AgeInfo = "label3";
            this.PersonalUserControl.BackColor = System.Drawing.Color.White;
            this.PersonalUserControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PersonalUserControl.DOBInfo = "label3";
            this.PersonalUserControl.First_NameInfo = "label1";
            this.PersonalUserControl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.PersonalUserControl.Last_NameInfo = "label4";
            this.PersonalUserControl.Location = new System.Drawing.Point(16, 36);
            this.PersonalUserControl.Middle_NameInfo = "label2";
            this.PersonalUserControl.Name = "PersonalUserControl";
            this.PersonalUserControl.SexInfo = "label3";
            this.PersonalUserControl.Size = new System.Drawing.Size(450, 200);
            this.PersonalUserControl.TabIndex = 0;
            // 
            // PersonalDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(766, 458);
            this.Controls.Add(this.ContactUserControl);
            this.Controls.Add(this.lblEmpID);
            this.Controls.Add(this.PersonalUserControl);
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
        private PersonalDetails.Personal_Information PersonalUserControl;
        private System.Windows.Forms.Label lblEmpID;
        private PersonalDetails.ContactInformation ContactUserControl;
    }
}