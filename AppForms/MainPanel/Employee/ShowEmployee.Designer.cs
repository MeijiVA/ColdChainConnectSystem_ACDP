namespace ColdChainConnectSystem_ACDP.AppForms.Header.Settings.Employee
{
    partial class ShowEmployee
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
            this.posStatus = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPosition = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.lblStatus = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.lblName = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.lblUsername = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.lblEmpID = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.btnEdit = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            this.posStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // posStatus
            // 
            this.posStatus.Controls.Add(this.lblPosition);
            this.posStatus.Controls.Add(this.lblStatus);
            this.posStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posStatus.Location = new System.Drawing.Point(15, 124);
            this.posStatus.Name = "posStatus";
            this.posStatus.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.posStatus.Size = new System.Drawing.Size(200, 34);
            this.posStatus.TabIndex = 7;
            this.posStatus.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.BackColor = System.Drawing.Color.Turquoise;
            this.lblPosition.BackgroundColor = System.Drawing.Color.Turquoise;
            this.lblPosition.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.lblPosition.BorderRadius = 10;
            this.lblPosition.BorderSize = 0;
            this.lblPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPosition.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.lblPosition.ForeColor = System.Drawing.Color.White;
            this.lblPosition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPosition.Location = new System.Drawing.Point(3, 5);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.lblPosition.Size = new System.Drawing.Size(69, 22);
            this.lblPosition.TabIndex = 6;
            this.lblPosition.Text = "Position";
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPosition.TextColor = System.Drawing.Color.White;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(188)))), ((int)(((byte)(59)))));
            this.lblStatus.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(188)))), ((int)(((byte)(59)))));
            this.lblStatus.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.lblStatus.BorderRadius = 10;
            this.lblStatus.BorderSize = 0;
            this.lblStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F);
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(78, 5);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.lblStatus.Size = new System.Drawing.Size(60, 22);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Active";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStatus.TextColor = System.Drawing.Color.White;
            this.lblStatus.TextChanged += new System.EventHandler(this.lblStatus_TextChanged);
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblName.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblName.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.lblName.BorderRadius = 10;
            this.lblName.BorderSize = 0;
            this.lblName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblName.Location = new System.Drawing.Point(17, 57);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(143, 22);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name Here";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblName.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            // 
            // lblUsername
            // 
            this.lblUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUsername.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUsername.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.lblUsername.BorderRadius = 10;
            this.lblUsername.BorderSize = 0;
            this.lblUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsername.Location = new System.Drawing.Point(17, 89);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(133, 22);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Username Here";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsername.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            // 
            // lblEmpID
            // 
            this.lblEmpID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblEmpID.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblEmpID.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.lblEmpID.BorderRadius = 10;
            this.lblEmpID.BorderSize = 0;
            this.lblEmpID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmpID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpID.ForeColor = System.Drawing.Color.White;
            this.lblEmpID.Location = new System.Drawing.Point(12, 11);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(148, 34);
            this.lblEmpID.TabIndex = 3;
            this.lblEmpID.Text = "Employee ID Here";
            this.lblEmpID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEmpID.TextColor = System.Drawing.Color.White;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.BackgroundColor = System.Drawing.Color.White;
            this.btnEdit.BackgroundImage = global::ColdChainConnectSystem_ACDP.Properties.Resources.editBtn;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEdit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEdit.BorderRadius = 10;
            this.btnEdit.BorderSize = 0;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(192, 11);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(41, 34);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.TextColor = System.Drawing.Color.White;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // ShowEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.posStatus);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblEmpID);
            this.Controls.Add(this.btnEdit);
            this.Name = "ShowEmployee";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(241, 178);
            this.posStatus.ResumeLayout(false);
            this.posStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Materials.CustomButton btnEdit;
        private System.Windows.Forms.FlowLayoutPanel posStatus;
        public Materials.CustomLabel lblEmpID;
        public Materials.CustomLabel lblStatus;
        public Materials.CustomLabel lblUsername;
        public Materials.CustomLabel lblPosition;
        public Materials.CustomLabel lblName;
    }
}
