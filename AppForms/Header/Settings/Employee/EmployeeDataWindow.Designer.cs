namespace ColdChainConnectSystem_ACDP.AppForms.Header.Settings.Employee
{
    partial class EmployeeDataWindow
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.PersonalUserControl = new ColdChainConnectSystem_ACDP.AppForms.Header.Settings.PersonalDetails.Personal_Information();
            this.AddressUserControl = new ColdChainConnectSystem_ACDP.AppForms.Header.Settings.PersonalDetails.AddressInformation();
            this.ContactUserControl = new ColdChainConnectSystem_ACDP.AppForms.Header.Settings.PersonalDetails.ContactInformation();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // setlbl
            // 
            this.setlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.setlbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.setlbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setlbl.ForeColor = System.Drawing.Color.White;
            this.setlbl.Location = new System.Drawing.Point(0, 0);
            this.setlbl.Name = "setlbl";
            this.setlbl.Size = new System.Drawing.Size(782, 44);
            this.setlbl.TabIndex = 1;
            this.setlbl.Text = "   Employee";
            this.setlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblEmpID);
            this.flowLayoutPanel1.Controls.Add(this.PersonalUserControl);
            this.flowLayoutPanel1.Controls.Add(this.AddressUserControl);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 44);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 25, 10, 25);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(473, 487);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ContactUserControl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(473, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 487);
            this.panel1.TabIndex = 3;
            // 
            // lblEmpID
            // 
            this.lblEmpID.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpID.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmpID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblEmpID.Location = new System.Drawing.Point(12, 25);
            this.lblEmpID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(450, 18);
            this.lblEmpID.TabIndex = 68;
            this.lblEmpID.Text = "Employee ID Here";
            this.lblEmpID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.PersonalUserControl.Location = new System.Drawing.Point(13, 46);
            this.PersonalUserControl.Middle_NameInfo = "label2";
            this.PersonalUserControl.Name = "PersonalUserControl";
            this.PersonalUserControl.SexInfo = "label3";
            this.PersonalUserControl.Size = new System.Drawing.Size(450, 200);
            this.PersonalUserControl.TabIndex = 67;
            // 
            // AddressUserControl
            // 
            this.AddressUserControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddressUserControl.Barangay = "label2";
            this.AddressUserControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddressUserControl.City = "label4";
            this.AddressUserControl.HouseNum = "label1";
            this.AddressUserControl.Location = new System.Drawing.Point(13, 252);
            this.AddressUserControl.Name = "AddressUserControl";
            this.AddressUserControl.Postal = "label3";
            this.AddressUserControl.Province = "label3";
            this.AddressUserControl.Size = new System.Drawing.Size(450, 200);
            this.AddressUserControl.TabIndex = 69;
            // 
            // ContactUserControl
            // 
            this.ContactUserControl.BackColor = System.Drawing.Color.White;
            this.ContactUserControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContactUserControl.ConNum = "Ow yeah";
            this.ContactUserControl.EmailInfo = "email";
            this.ContactUserControl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ContactUserControl.Location = new System.Drawing.Point(14, 28);
            this.ContactUserControl.Name = "ContactUserControl";
            this.ContactUserControl.PositionInfo = "position";
            this.ContactUserControl.Size = new System.Drawing.Size(280, 430);
            this.ContactUserControl.StatusInfo = "status";
            this.ContactUserControl.TabIndex = 66;
            // 
            // EmployeeDataWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 531);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.setlbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeDataWindow";
            this.Text = "EmployeeDataWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label setlbl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEmpID;
        private PersonalDetails.Personal_Information PersonalUserControl;
        private PersonalDetails.AddressInformation AddressUserControl;
        private PersonalDetails.ContactInformation ContactUserControl;
    }
}