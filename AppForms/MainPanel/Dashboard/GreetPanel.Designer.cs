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
            this.SuspendLayout();
            // 
            // greetlbl
            // 
            this.greetlbl.AutoSize = true;
            this.greetlbl.BackColor = System.Drawing.Color.Transparent;
            this.greetlbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.greetlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.greetlbl.Location = new System.Drawing.Point(51, 17);
            this.greetlbl.Name = "greetlbl";
            this.greetlbl.Size = new System.Drawing.Size(125, 16);
            this.greetlbl.TabIndex = 0;
            this.greetlbl.Text = "Good to See you, ";
            // 
            // timelbl
            // 
            this.timelbl.BackColor = System.Drawing.Color.Transparent;
            this.timelbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.timelbl.Location = new System.Drawing.Point(666, 5);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(133, 17);
            this.timelbl.TabIndex = 1;
            // 
            // daylbl
            // 
            this.daylbl.BackColor = System.Drawing.Color.Transparent;
            this.daylbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daylbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(96)))));
            this.daylbl.Location = new System.Drawing.Point(667, 17);
            this.daylbl.Name = "daylbl";
            this.daylbl.Size = new System.Drawing.Size(132, 17);
            this.daylbl.TabIndex = 2;
            // 
            // datelbl
            // 
            this.datelbl.BackColor = System.Drawing.Color.Transparent;
            this.datelbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(96)))));
            this.datelbl.Location = new System.Drawing.Point(667, 30);
            this.datelbl.Name = "datelbl";
            this.datelbl.Size = new System.Drawing.Size(131, 17);
            this.datelbl.TabIndex = 3;
            // 
            // GreetPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.datelbl);
            this.Controls.Add(this.daylbl);
            this.Controls.Add(this.timelbl);
            this.Controls.Add(this.greetlbl);
            this.Name = "GreetPanel";
            this.Size = new System.Drawing.Size(798, 51);
            this.Load += new System.EventHandler(this.GreetPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label greetlbl;
        private System.Windows.Forms.Label timelbl;
        private System.Windows.Forms.Label daylbl;
        private System.Windows.Forms.Label datelbl;
    }
}
