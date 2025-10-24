namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Settings
{
    partial class CTextBox
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
            this.txtBoxCust = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxCust
            // 
            this.txtBoxCust.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtBoxCust.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCust.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(96)))));
            this.txtBoxCust.Location = new System.Drawing.Point(0, 0);
            this.txtBoxCust.Name = "txtBoxCust";
            this.txtBoxCust.Size = new System.Drawing.Size(200, 31);
            this.txtBoxCust.TabIndex = 1;
            this.txtBoxCust.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.txtBoxCust);
            this.Name = "CTextBox";
            this.Size = new System.Drawing.Size(200, 30);
            this.Load += new System.EventHandler(this.CTextBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxCust;
    }
}
