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
            this.UserpBox = new System.Windows.Forms.PictureBox();
            this.UAC_namelbl = new System.Windows.Forms.Label();
            this.UAC_positionlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UserpBox)).BeginInit();
            this.SuspendLayout();
            // 
            // UserpBox
            // 
            this.UserpBox.BackgroundImage = global::ColdChainConnectSystem_ACDP.Properties.Resources.Sherma;
            this.UserpBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UserpBox.Location = new System.Drawing.Point(40, 15);
            this.UserpBox.Name = "UserpBox";
            this.UserpBox.Size = new System.Drawing.Size(120, 120);
            this.UserpBox.TabIndex = 0;
            this.UserpBox.TabStop = false;
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
            // UserAccountControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UAC_namelbl);
            this.Controls.Add(this.UAC_positionlbl);
            this.Controls.Add(this.UserpBox);
            this.Name = "UserAccountControl";
            this.Size = new System.Drawing.Size(200, 170);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserpBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox UserpBox;
        public System.Windows.Forms.Label UAC_namelbl;
        public System.Windows.Forms.Label UAC_positionlbl;
    }
}
