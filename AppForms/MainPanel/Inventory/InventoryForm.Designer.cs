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
            this.SuspendLayout();
            // 
            // searchUC1
            // 
            this.searchUC1.BackColor = System.Drawing.SystemColors.Control;
            this.searchUC1.Location = new System.Drawing.Point(0, 0);
            this.searchUC1.Name = "searchUC1";
            this.searchUC1.Size = new System.Drawing.Size(798, 65);
            this.searchUC1.TabIndex = 0;
            // 
            // displayTableUC1
            // 
            this.displayTableUC1.Location = new System.Drawing.Point(0, 71);
            this.displayTableUC1.Name = "displayTableUC1";
            this.displayTableUC1.Size = new System.Drawing.Size(798, 470);
            this.displayTableUC1.TabIndex = 1;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 570);
            this.Controls.Add(this.displayTableUC1);
            this.Controls.Add(this.searchUC1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventoryForm";
            this.Text = "InventoryForm";
            this.ResumeLayout(false);

        }

        #endregion

        private SearchUC searchUC1;
        private DisplayTableUC displayTableUC1;
    }
}