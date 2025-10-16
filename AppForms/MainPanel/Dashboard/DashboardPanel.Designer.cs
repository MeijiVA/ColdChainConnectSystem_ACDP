namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Dashboard
{
    partial class DashboardPanel
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
            this.greetPanel1 = new ColdChainConnectSystem_ACDP.AppForms.MainPanel.Dashboard.GreetPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.profitGenpnl = new System.Windows.Forms.Panel();
            this.totalSales = new System.Windows.Forms.Panel();
            this.totalCustpnl = new System.Windows.Forms.Panel();
            this.totalProdpnl = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // greetPanel1
            // 
            this.greetPanel1.Location = new System.Drawing.Point(0, 0);
            this.greetPanel1.Name = "greetPanel1";
            this.greetPanel1.Size = new System.Drawing.Size(798, 51);
            this.greetPanel1.TabIndex = 22;
            // 
            // panel9
            // 
            this.panel9.Location = new System.Drawing.Point(0, 275);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(400, 295);
            this.panel9.TabIndex = 20;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(399, 149);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(399, 127);
            this.panel7.TabIndex = 18;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(0, 149);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(400, 127);
            this.panel6.TabIndex = 16;
            // 
            // profitGenpnl
            // 
            this.profitGenpnl.Location = new System.Drawing.Point(598, 50);
            this.profitGenpnl.Name = "profitGenpnl";
            this.profitGenpnl.Size = new System.Drawing.Size(200, 100);
            this.profitGenpnl.TabIndex = 21;
            // 
            // totalSales
            // 
            this.totalSales.Location = new System.Drawing.Point(399, 50);
            this.totalSales.Name = "totalSales";
            this.totalSales.Size = new System.Drawing.Size(200, 100);
            this.totalSales.TabIndex = 19;
            // 
            // totalCustpnl
            // 
            this.totalCustpnl.Location = new System.Drawing.Point(200, 50);
            this.totalCustpnl.Name = "totalCustpnl";
            this.totalCustpnl.Size = new System.Drawing.Size(200, 100);
            this.totalCustpnl.TabIndex = 17;
            // 
            // totalProdpnl
            // 
            this.totalProdpnl.Location = new System.Drawing.Point(0, 50);
            this.totalProdpnl.Name = "totalProdpnl";
            this.totalProdpnl.Size = new System.Drawing.Size(201, 100);
            this.totalProdpnl.TabIndex = 15;
            // 
            // DashboardPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 570);
            this.Controls.Add(this.greetPanel1);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.profitGenpnl);
            this.Controls.Add(this.totalSales);
            this.Controls.Add(this.totalCustpnl);
            this.Controls.Add(this.totalProdpnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardPanel";
            this.Text = "DashboardPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private GreetPanel greetPanel1;
        public System.Windows.Forms.Panel panel9;
        public System.Windows.Forms.Panel panel7;
        public System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Panel profitGenpnl;
        public System.Windows.Forms.Panel totalSales;
        public System.Windows.Forms.Panel totalCustpnl;
        public System.Windows.Forms.Panel totalProdpnl;
    }
}