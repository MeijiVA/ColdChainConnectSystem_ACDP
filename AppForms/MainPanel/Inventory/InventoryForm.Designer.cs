namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Inventory
{
    partial class InventoryForm
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
            this.searchUC1 = new ColdChainConnectSystem_ACDP.AppForms.MainPanel.Inventory.SearchUC();
            this.displayTableUC1 = new ColdChainConnectSystem_ACDP.AppForms.MainPanel.Inventory.DisplayTableUC();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchUC1
            // 
            this.searchUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(95)))));
            this.searchUC1.Location = new System.Drawing.Point(22, 12);
            this.searchUC1.Name = "searchUC1";
            this.searchUC1.Size = new System.Drawing.Size(755, 65);
            this.searchUC1.TabIndex = 0;
            this.searchUC1.Load += new System.EventHandler(this.searchUC1_Load);
            // 
            // displayTableUC1
            // 
            this.displayTableUC1.BackColor = System.Drawing.Color.White;
            this.displayTableUC1.Location = new System.Drawing.Point(22, 81);
            this.displayTableUC1.Name = "displayTableUC1";
            this.displayTableUC1.Size = new System.Drawing.Size(755, 442);
            this.displayTableUC1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(22, 529);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 25);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "legends : ";
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.displayTableUC1);
            this.Controls.Add(this.searchUC1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventoryForm";
            this.Text = "InventoryForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SearchUC searchUC1;
        private DisplayTableUC displayTableUC1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}