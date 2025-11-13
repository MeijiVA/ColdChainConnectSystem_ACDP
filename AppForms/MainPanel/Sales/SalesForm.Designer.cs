namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Sales
{
    partial class SalesForm
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
            this.searchUC1.BackColor = System.Drawing.Color.Transparent;
            this.searchUC1.Location = new System.Drawing.Point(21, 12);
            this.searchUC1.Name = "searchUC1";
            this.searchUC1.searchTXT = "Search Term";
            this.searchUC1.Size = new System.Drawing.Size(755, 65);
            this.searchUC1.TabIndex = 0;
            // 
            // displayTableUC1
            // 
            this.displayTableUC1.BackColor = System.Drawing.Color.White;
            this.displayTableUC1.Location = new System.Drawing.Point(21, 94);
            this.displayTableUC1.Name = "displayTableUC1";
            this.displayTableUC1.Size = new System.Drawing.Size(755, 442);
            this.displayTableUC1.TabIndex = 1;
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 570);
            this.Controls.Add(this.displayTableUC1);
            this.Controls.Add(this.searchUC1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesForm";
            this.Text = "SalesForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Inventory.SearchUC searchUC1;
        private Inventory.DisplayTableUC displayTableUC1;
    }
}