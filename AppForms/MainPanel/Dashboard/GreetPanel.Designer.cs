namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Dashboard
{
    partial class GreetPanel
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
            this.greetlbl = new System.Windows.Forms.Label();
            this.timelbl = new System.Windows.Forms.Label();
            this.daylbl = new System.Windows.Forms.Label();
            this.datelbl = new System.Windows.Forms.Label();
            this.customPanel1 = new ColdChainConnectSystem_ACDP.Materials.CustomPanel();
            this.div = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // greetlbl
            // 
            this.greetlbl.AutoSize = true;
            this.greetlbl.BackColor = System.Drawing.Color.Transparent;
            this.greetlbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.greetlbl.ForeColor = System.Drawing.Color.White;
            this.greetlbl.Location = new System.Drawing.Point(63, 16);
            this.greetlbl.Name = "greetlbl";
            this.greetlbl.Size = new System.Drawing.Size(125, 16);
            this.greetlbl.TabIndex = 0;
            this.greetlbl.Text = "Good to See you, ";
            // 
            // timelbl
            // 
            this.timelbl.BackColor = System.Drawing.Color.Transparent;
            this.timelbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelbl.ForeColor = System.Drawing.Color.White;
            this.timelbl.Location = new System.Drawing.Point(661, 3);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(116, 17);
            this.timelbl.TabIndex = 1;
            this.timelbl.Text = "time";
            // 
            // daylbl
            // 
            this.daylbl.BackColor = System.Drawing.Color.Transparent;
            this.daylbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daylbl.ForeColor = System.Drawing.Color.White;
            this.daylbl.Location = new System.Drawing.Point(662, 18);
            this.daylbl.Name = "daylbl";
            this.daylbl.Size = new System.Drawing.Size(115, 17);
            this.daylbl.TabIndex = 2;
            this.daylbl.Text = "month";
            // 
            // datelbl
            // 
            this.datelbl.BackColor = System.Drawing.Color.Transparent;
            this.datelbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelbl.ForeColor = System.Drawing.Color.White;
            this.datelbl.Location = new System.Drawing.Point(662, 33);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(114, 17);
            this.datelbl.TabIndex = 3;
            this.datelbl.Text = "longdate";
            // 
            // customPanel1
            // 
            this.customPanel1.Angle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.customPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customPanel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customPanel1.BorderRadius = 25;
            this.customPanel1.BorderSize = 0;
            this.customPanel1.Controls.Add(this.div);
            this.customPanel1.Controls.Add(this.pictureBox1);
            this.customPanel1.Controls.Add(this.datelbl);
            this.customPanel1.Controls.Add(this.greetlbl);
            this.customPanel1.Controls.Add(this.timelbl);
            this.customPanel1.Controls.Add(this.daylbl);
            this.customPanel1.ForeColor = System.Drawing.Color.White;
            this.customPanel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customPanel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(163)))));
            this.customPanel1.GradientTextColor = System.Drawing.Color.Transparent;
            this.customPanel1.Location = new System.Drawing.Point(2, 3);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(792, 48);
            this.customPanel1.TabIndex = 4;
            this.customPanel1.TextColor = System.Drawing.Color.White;
            this.customPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.customPanel1_Paint);
            // 
            // div
            // 
            this.div.BackColor = System.Drawing.SystemColors.Control;
            this.div.Location = new System.Drawing.Point(653, -2);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(3, 50);
            this.div.TabIndex = 5;
            this.div.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBox1.BackgroundImage = global::ColdChainConnectSystem_ACDP.Properties.Resources.GreetIcon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(25, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 25);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // GreetPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customPanel1);
            this.Name = "GreetPanel";
            this.Size = new System.Drawing.Size(798, 55);
            this.Load += new System.EventHandler(this.GreetPanel_Load);
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label greetlbl;
        private System.Windows.Forms.Label timelbl;
        private System.Windows.Forms.Label daylbl;
        private System.Windows.Forms.Label datelbl;
        private Materials.CustomPanel customPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label div;
    }
}
