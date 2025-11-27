namespace ColdChainConnectSystem_ACDP.AppForms.Header.Settings.Employee
{
    partial class EmployeeProfile
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            this.tscStatus = new ToggleSlider.ToggleSliderComponent();
            this.btnEdit = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            this.pnlAccount = new ColdChainConnectSystem_ACDP.Materials.CustomPanel();
            this.pnlAddress = new ColdChainConnectSystem_ACDP.Materials.CustomPanel();
            this.lblEmpID = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.pnlPersonal = new ColdChainConnectSystem_ACDP.Materials.CustomPanel();
            this.lbl = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.btnExit.BackgroundImage = global::ColdChainConnectSystem_ACDP.Properties.Resources.Back;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(728, 29);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 28);
            this.btnExit.TabIndex = 71;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.btnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.btnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.BorderRadius = 10;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(626, 79);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 40);
            this.btnSave.TabIndex = 78;
            this.btnSave.Text = "Save";
            this.btnSave.TextColor = System.Drawing.Color.White;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tscStatus
            // 
            this.tscStatus.AutoSize = true;
            this.tscStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.tscStatus.Checked = true;
            this.tscStatus.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.tscStatus.ForeColor = System.Drawing.Color.White;
            this.tscStatus.Location = new System.Drawing.Point(347, 86);
            this.tscStatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tscStatus.Name = "tscStatus";
            this.tscStatus.Size = new System.Drawing.Size(119, 30);
            this.tscStatus.TabIndex = 77;
            this.tscStatus.ToggleBarText = "Active";
            this.tscStatus.ToggleCircleColor = System.Drawing.Color.Green;
            this.tscStatus.ToggleColorBar = System.Drawing.Color.Gray;
            this.tscStatus.CheckChanged += new System.EventHandler(this.tscStatus_CheckChanged);
            this.tscStatus.Load += new System.EventHandler(this.tscStatus_Load);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnEdit.BackgroundImage = global::ColdChainConnectSystem_ACDP.Properties.Resources.editBtn;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEdit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.btnEdit.BorderRadius = 10;
            this.btnEdit.BorderSize = 0;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(732, 79);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(43, 40);
            this.btnEdit.TabIndex = 76;
            this.btnEdit.TextColor = System.Drawing.Color.White;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pnlAccount
            // 
            this.pnlAccount.BackColor = System.Drawing.Color.White;
            this.pnlAccount.BackgroundColor = System.Drawing.Color.White;
            this.pnlAccount.BorderColor = System.Drawing.Color.Empty;
            this.pnlAccount.BorderRadius = 15;
            this.pnlAccount.BorderSize = 0;
            this.pnlAccount.ForeColor = System.Drawing.Color.White;
            this.pnlAccount.Location = new System.Drawing.Point(495, 126);
            this.pnlAccount.Name = "pnlAccount";
            this.pnlAccount.Size = new System.Drawing.Size(280, 432);
            this.pnlAccount.TabIndex = 75;
            this.pnlAccount.TextColor = System.Drawing.Color.White;
            // 
            // pnlAddress
            // 
            this.pnlAddress.BackColor = System.Drawing.Color.White;
            this.pnlAddress.BackgroundColor = System.Drawing.Color.White;
            this.pnlAddress.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pnlAddress.BorderRadius = 15;
            this.pnlAddress.BorderSize = 0;
            this.pnlAddress.ForeColor = System.Drawing.Color.White;
            this.pnlAddress.Location = new System.Drawing.Point(28, 351);
            this.pnlAddress.Name = "pnlAddress";
            this.pnlAddress.Size = new System.Drawing.Size(450, 200);
            this.pnlAddress.TabIndex = 74;
            this.pnlAddress.TextColor = System.Drawing.Color.White;
            // 
            // lblEmpID
            // 
            this.lblEmpID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblEmpID.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblEmpID.BorderColor = System.Drawing.Color.Transparent;
            this.lblEmpID.BorderRadius = 10;
            this.lblEmpID.BorderSize = 0;
            this.lblEmpID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmpID.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmpID.ForeColor = System.Drawing.Color.White;
            this.lblEmpID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEmpID.Location = new System.Drawing.Point(28, 79);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(451, 40);
            this.lblEmpID.TabIndex = 68;
            this.lblEmpID.Text = "   Employee ID Here";
            this.lblEmpID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEmpID.TextColor = System.Drawing.Color.White;
            // 
            // pnlPersonal
            // 
            this.pnlPersonal.BackColor = System.Drawing.Color.Transparent;
            this.pnlPersonal.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnlPersonal.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.pnlPersonal.BorderRadius = 15;
            this.pnlPersonal.BorderSize = 0;
            this.pnlPersonal.ForeColor = System.Drawing.Color.White;
            this.pnlPersonal.Location = new System.Drawing.Point(29, 129);
            this.pnlPersonal.Name = "pnlPersonal";
            this.pnlPersonal.Size = new System.Drawing.Size(450, 200);
            this.pnlPersonal.TabIndex = 73;
            this.pnlPersonal.TextColor = System.Drawing.Color.White;
            // 
            // lbl
            // 
            this.lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lbl.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lbl.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.lbl.BorderRadius = 10;
            this.lbl.BorderSize = 0;
            this.lbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(24, 15);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(751, 55);
            this.lbl.TabIndex = 72;
            this.lbl.Text = "    Employee Profile";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl.TextColor = System.Drawing.Color.White;
            this.lbl.UseMnemonic = false;
            // 
            // EmployeeProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 570);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tscStatus);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.pnlAccount);
            this.Controls.Add(this.pnlAddress);
            this.Controls.Add(this.lblEmpID);
            this.Controls.Add(this.pnlPersonal);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeProfile";
            this.Text = "EmployeeProfile";
            this.Load += new System.EventHandler(this.EmployeeProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private Materials.CustomLabel lbl;
        private Materials.CustomPanel pnlPersonal;
        private Materials.CustomLabel lblEmpID;
        private Materials.CustomPanel pnlAddress;
        private Materials.CustomPanel pnlAccount;
        private Materials.CustomButton btnEdit;
        private ToggleSlider.ToggleSliderComponent tscStatus;
        private Materials.CustomButton btnSave;
    }
}