namespace ColdChainConnectSystem_ACDP.AppForms.SidePanel
{
    partial class UserAccountControl
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
            this.UAC_namelbl = new System.Windows.Forms.Label();
            this.UAC_positionlbl = new System.Windows.Forms.Label();
            this.rjCircularPictureBox1 = new ColdChainConnectSystem_ACDP.Materials.CircularPictureBox();
            this.pbxUser = new ColdChainConnectSystem_ACDP.Materials.CircularPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).BeginInit();
            this.SuspendLayout();
            // 
            // UAC_namelbl
            // 
            this.UAC_namelbl.BackColor = System.Drawing.Color.Transparent;
            this.UAC_namelbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UAC_namelbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UAC_namelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.UAC_namelbl.Location = new System.Drawing.Point(0, 140);
            this.UAC_namelbl.Name = "UAC_namelbl";
            this.UAC_namelbl.Size = new System.Drawing.Size(200, 15);
            this.UAC_namelbl.TabIndex = 1;
            this.UAC_namelbl.Text = "Name";
            this.UAC_namelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UAC_namelbl.Click += new System.EventHandler(this.UAC_namelbl_Click);
            // 
            // UAC_positionlbl
            // 
            this.UAC_positionlbl.BackColor = System.Drawing.Color.Transparent;
            this.UAC_positionlbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UAC_positionlbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UAC_positionlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.UAC_positionlbl.Location = new System.Drawing.Point(0, 155);
            this.UAC_positionlbl.Name = "UAC_positionlbl";
            this.UAC_positionlbl.Size = new System.Drawing.Size(200, 15);
            this.UAC_positionlbl.TabIndex = 2;
            this.UAC_positionlbl.Text = "Position";
            this.UAC_positionlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(25, 2);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(135, 135);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 3;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // pbxUser
            // 
            this.pbxUser.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.pbxUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.pbxUser.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(197)))));
            this.pbxUser.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.pbxUser.BorderSize = 5;
            this.pbxUser.GradientAngle = 20F;
            this.pbxUser.Image = global::ColdChainConnectSystem_ACDP.Properties.Resources.NoImage1;
            this.pbxUser.Location = new System.Drawing.Point(32, 3);
            this.pbxUser.Name = "pbxUser";
            this.pbxUser.Size = new System.Drawing.Size(135, 135);
            this.pbxUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxUser.TabIndex = 3;
            this.pbxUser.TabStop = false;
            // 
            // UserAccountControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbxUser);
            this.Controls.Add(this.UAC_namelbl);
            this.Controls.Add(this.UAC_positionlbl);
            this.Size = new System.Drawing.Size(200, 170);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label UAC_namelbl;
        public System.Windows.Forms.Label UAC_positionlbl;
        private Materials.CircularPictureBox rjCircularPictureBox1;
        private Materials.CircularPictureBox pbxUser;
    }
}
