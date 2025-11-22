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
            this.customButton1 = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            this.customButton2 = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            this.customButton3 = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            this.lblEMP = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.SuspendLayout();
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton1.BorderRadius = 0;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(8, 132);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(78, 40);
            this.customButton1.TabIndex = 0;
            this.customButton1.Text = "View";
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton2.BorderRadius = 0;
            this.customButton2.BorderSize = 0;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Location = new System.Drawing.Point(92, 132);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(57, 40);
            this.customButton2.TabIndex = 1;
            this.customButton2.Text = "customButton2";
            this.customButton2.TextColor = System.Drawing.Color.White;
            this.customButton2.UseVisualStyleBackColor = false;
            this.customButton2.Click += new System.EventHandler(this.customButton2_Click);
            // 
            // customButton3
            // 
            this.customButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton3.BorderRadius = 0;
            this.customButton3.BorderSize = 0;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.ForeColor = System.Drawing.Color.White;
            this.customButton3.Location = new System.Drawing.Point(155, 132);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(78, 40);
            this.customButton3.TabIndex = 2;
            this.customButton3.Text = "customButton3";
            this.customButton3.TextColor = System.Drawing.Color.White;
            this.customButton3.UseVisualStyleBackColor = false;
            this.customButton3.Click += new System.EventHandler(this.customButton3_Click);
            // 
            // lblEMP
            // 
            this.lblEMP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblEMP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblEMP.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.lblEMP.BorderRadius = 10;
            this.lblEMP.BorderSize = 0;
            this.lblEMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEMP.ForeColor = System.Drawing.Color.White;
            this.lblEMP.Location = new System.Drawing.Point(8, 5);
            this.lblEMP.Name = "lblEMP";
            this.lblEMP.Size = new System.Drawing.Size(225, 34);
            this.lblEMP.TabIndex = 3;
            this.lblEMP.Text = "customLabel1";
            this.lblEMP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEMP.TextColor = System.Drawing.Color.White;
            // 
            // ShowEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEMP);
            this.Controls.Add(this.customButton3);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.customButton1);
            this.Name = "ShowEmployee";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(241, 180);
            this.ResumeLayout(false);

        }

        #endregion

        private Materials.CustomButton customButton1;
        private Materials.CustomButton customButton2;
        private Materials.CustomButton customButton3;
        private Materials.CustomLabel lblEMP;
    }
}
