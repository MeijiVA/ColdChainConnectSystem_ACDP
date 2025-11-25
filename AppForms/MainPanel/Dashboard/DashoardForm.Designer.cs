namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Dashboard
{
    partial class DashoardForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            this.customPanel1 = new ColdChainConnectSystem_ACDP.Materials.CustomPanel();
            this.customPanel2 = new ColdChainConnectSystem_ACDP.Materials.CustomPanel();
            this.customPanel3 = new ColdChainConnectSystem_ACDP.Materials.CustomPanel();
            this.customPanel4 = new ColdChainConnectSystem_ACDP.Materials.CustomPanel();
            this.customPanel5 = new ColdChainConnectSystem_ACDP.Materials.CustomPanel();
            this.customLabel1 = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.customLabel2 = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.clblProducts = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.customLabel4 = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.customLabel5 = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.customLabel6 = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.customLabel7 = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.customLabel8 = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.customLabel3 = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.customLabel9 = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.customLabel10 = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.dataGridViewlatestransaction = new System.Windows.Forms.DataGridView();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.totalCustpnl.SuspendLayout();
            this.totalProdpnl.SuspendLayout();
            this.customPanel1.SuspendLayout();
            this.customPanel2.SuspendLayout();
            this.customPanel3.SuspendLayout();
            this.customPanel4.SuspendLayout();
            this.customPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewlatestransaction)).BeginInit();
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
            this.panel9.Controls.Add(this.dataGridViewlatestransaction);
            this.panel9.Controls.Add(this.customLabel10);
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
            this.panel6.Controls.Add(this.customPanel5);
            this.panel6.Controls.Add(this.customPanel4);
            this.panel6.Controls.Add(this.customPanel3);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(0, 149);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(20);
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
            this.totalCustpnl.Controls.Add(this.customPanel2);
            this.totalCustpnl.Location = new System.Drawing.Point(200, 50);
            this.totalCustpnl.Name = "totalCustpnl";
            this.totalCustpnl.Padding = new System.Windows.Forms.Padding(10);
            this.totalCustpnl.Size = new System.Drawing.Size(200, 100);
            this.totalCustpnl.TabIndex = 17;
            // 
            // totalProdpnl
            // 
            this.totalProdpnl.Controls.Add(this.customPanel1);
            this.totalProdpnl.Location = new System.Drawing.Point(0, 50);
            this.totalProdpnl.Name = "totalProdpnl";
            this.totalProdpnl.Padding = new System.Windows.Forms.Padding(10);
            this.totalProdpnl.Size = new System.Drawing.Size(201, 100);
            this.totalProdpnl.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.label5.Location = new System.Drawing.Point(7, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Schedule";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.Transparent;
            this.customPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.customPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customPanel1.BorderRadius = 15;
            this.customPanel1.BorderSize = 1;
            this.customPanel1.Controls.Add(this.customLabel4);
            this.customPanel1.Controls.Add(this.clblProducts);
            this.customPanel1.Controls.Add(this.customLabel2);
            this.customPanel1.Controls.Add(this.customLabel1);
            this.customPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customPanel1.ForeColor = System.Drawing.Color.White;
            this.customPanel1.Location = new System.Drawing.Point(10, 10);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(181, 80);
            this.customPanel1.TabIndex = 1;
            this.customPanel1.TextColor = System.Drawing.Color.White;
            // 
            // customPanel2
            // 
            this.customPanel2.BackColor = System.Drawing.Color.Transparent;
            this.customPanel2.BackgroundColor = System.Drawing.Color.Transparent;
            this.customPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customPanel2.BorderRadius = 15;
            this.customPanel2.BorderSize = 1;
            this.customPanel2.Controls.Add(this.customLabel7);
            this.customPanel2.Controls.Add(this.customLabel6);
            this.customPanel2.Controls.Add(this.customLabel5);
            this.customPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customPanel2.ForeColor = System.Drawing.Color.White;
            this.customPanel2.Location = new System.Drawing.Point(10, 10);
            this.customPanel2.Name = "customPanel2";
            this.customPanel2.Size = new System.Drawing.Size(180, 80);
            this.customPanel2.TabIndex = 0;
            this.customPanel2.TextColor = System.Drawing.Color.White;
            // 
            // customPanel3
            // 
            this.customPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customPanel3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customPanel3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customPanel3.BorderRadius = 15;
            this.customPanel3.BorderSize = 0;
            this.customPanel3.Controls.Add(this.customLabel8);
            this.customPanel3.ForeColor = System.Drawing.Color.White;
            this.customPanel3.Location = new System.Drawing.Point(10, 38);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.Size = new System.Drawing.Size(98, 66);
            this.customPanel3.TabIndex = 5;
            this.customPanel3.TextColor = System.Drawing.Color.White;
            // 
            // customPanel4
            // 
            this.customPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customPanel4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customPanel4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customPanel4.BorderRadius = 15;
            this.customPanel4.BorderSize = 0;
            this.customPanel4.Controls.Add(this.customLabel3);
            this.customPanel4.ForeColor = System.Drawing.Color.White;
            this.customPanel4.Location = new System.Drawing.Point(153, 38);
            this.customPanel4.Name = "customPanel4";
            this.customPanel4.Size = new System.Drawing.Size(98, 66);
            this.customPanel4.TabIndex = 6;
            this.customPanel4.TextColor = System.Drawing.Color.White;
            // 
            // customPanel5
            // 
            this.customPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customPanel5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customPanel5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customPanel5.BorderRadius = 15;
            this.customPanel5.BorderSize = 0;
            this.customPanel5.Controls.Add(this.customLabel9);
            this.customPanel5.ForeColor = System.Drawing.Color.White;
            this.customPanel5.Location = new System.Drawing.Point(292, 38);
            this.customPanel5.Name = "customPanel5";
            this.customPanel5.Size = new System.Drawing.Size(98, 66);
            this.customPanel5.TabIndex = 6;
            this.customPanel5.TextColor = System.Drawing.Color.White;
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.customLabel1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customLabel1.BorderRadius = 0;
            this.customLabel1.BorderSize = 0;
            this.customLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customLabel1.ForeColor = System.Drawing.Color.White;
            this.customLabel1.Location = new System.Drawing.Point(12, 11);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(73, 13);
            this.customLabel1.TabIndex = 0;
            this.customLabel1.Text = "customLabel1";
            this.customLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.customLabel1.TextColor = System.Drawing.Color.White;
            // 
            // customLabel2
            // 
            this.customLabel2.AutoSize = true;
            this.customLabel2.BackColor = System.Drawing.Color.Transparent;
            this.customLabel2.BackgroundColor = System.Drawing.Color.Transparent;
            this.customLabel2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customLabel2.BorderRadius = 0;
            this.customLabel2.BorderSize = 0;
            this.customLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customLabel2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customLabel2.Location = new System.Drawing.Point(12, 10);
            this.customLabel2.Name = "customLabel2";
            this.customLabel2.Size = new System.Drawing.Size(102, 15);
            this.customLabel2.TabIndex = 1;
            this.customLabel2.Text = "Total Products";
            this.customLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.customLabel2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            // 
            // clblProducts
            // 
            this.clblProducts.AutoSize = true;
            this.clblProducts.BackColor = System.Drawing.Color.Transparent;
            this.clblProducts.BackgroundColor = System.Drawing.Color.Transparent;
            this.clblProducts.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.clblProducts.BorderRadius = 0;
            this.clblProducts.BorderSize = 0;
            this.clblProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clblProducts.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clblProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.clblProducts.Location = new System.Drawing.Point(12, 28);
            this.clblProducts.Name = "clblProducts";
            this.clblProducts.Size = new System.Drawing.Size(38, 18);
            this.clblProducts.TabIndex = 2;
            this.clblProducts.Text = "265";
            this.clblProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clblProducts.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            // 
            // customLabel4
            // 
            this.customLabel4.AutoSize = true;
            this.customLabel4.BackColor = System.Drawing.Color.Transparent;
            this.customLabel4.BackgroundColor = System.Drawing.Color.Transparent;
            this.customLabel4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customLabel4.BorderRadius = 0;
            this.customLabel4.BorderSize = 0;
            this.customLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customLabel4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customLabel4.Location = new System.Drawing.Point(70, 57);
            this.customLabel4.Name = "customLabel4";
            this.customLabel4.Size = new System.Drawing.Size(108, 12);
            this.customLabel4.TabIndex = 3;
            this.customLabel4.Text = "Up from Yesterday";
            this.customLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.customLabel4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            // 
            // customLabel5
            // 
            this.customLabel5.AutoSize = true;
            this.customLabel5.BackColor = System.Drawing.Color.Transparent;
            this.customLabel5.BackgroundColor = System.Drawing.Color.Transparent;
            this.customLabel5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customLabel5.BorderRadius = 0;
            this.customLabel5.BorderSize = 0;
            this.customLabel5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customLabel5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customLabel5.Location = new System.Drawing.Point(12, 10);
            this.customLabel5.Name = "customLabel5";
            this.customLabel5.Size = new System.Drawing.Size(114, 15);
            this.customLabel5.TabIndex = 4;
            this.customLabel5.Text = "Total Customers";
            this.customLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.customLabel5.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            // 
            // customLabel6
            // 
            this.customLabel6.AutoSize = true;
            this.customLabel6.BackColor = System.Drawing.Color.Transparent;
            this.customLabel6.BackgroundColor = System.Drawing.Color.Transparent;
            this.customLabel6.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customLabel6.BorderRadius = 0;
            this.customLabel6.BorderSize = 0;
            this.customLabel6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customLabel6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customLabel6.Location = new System.Drawing.Point(12, 28);
            this.customLabel6.Name = "customLabel6";
            this.customLabel6.Size = new System.Drawing.Size(28, 18);
            this.customLabel6.TabIndex = 4;
            this.customLabel6.Text = "55";
            this.customLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.customLabel6.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            // 
            // customLabel7
            // 
            this.customLabel7.AutoSize = true;
            this.customLabel7.BackColor = System.Drawing.Color.Transparent;
            this.customLabel7.BackgroundColor = System.Drawing.Color.Transparent;
            this.customLabel7.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customLabel7.BorderRadius = 0;
            this.customLabel7.BorderSize = 0;
            this.customLabel7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customLabel7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customLabel7.Location = new System.Drawing.Point(69, 57);
            this.customLabel7.Name = "customLabel7";
            this.customLabel7.Size = new System.Drawing.Size(108, 12);
            this.customLabel7.TabIndex = 4;
            this.customLabel7.Text = "Up from Yesterday";
            this.customLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.customLabel7.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            // 
            // customLabel8
            // 
            this.customLabel8.AutoSize = true;
            this.customLabel8.BackColor = System.Drawing.Color.Transparent;
            this.customLabel8.BackgroundColor = System.Drawing.Color.Transparent;
            this.customLabel8.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customLabel8.BorderRadius = 0;
            this.customLabel8.BorderSize = 0;
            this.customLabel8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customLabel8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel8.ForeColor = System.Drawing.Color.White;
            this.customLabel8.Location = new System.Drawing.Point(7, 12);
            this.customLabel8.Name = "customLabel8";
            this.customLabel8.Size = new System.Drawing.Size(53, 18);
            this.customLabel8.TabIndex = 0;
            this.customLabel8.Text = "08:00";
            this.customLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.customLabel8.TextColor = System.Drawing.Color.White;
            // 
            // customLabel3
            // 
            this.customLabel3.AutoSize = true;
            this.customLabel3.BackColor = System.Drawing.Color.Transparent;
            this.customLabel3.BackgroundColor = System.Drawing.Color.Transparent;
            this.customLabel3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customLabel3.BorderRadius = 0;
            this.customLabel3.BorderSize = 0;
            this.customLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customLabel3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel3.ForeColor = System.Drawing.Color.White;
            this.customLabel3.Location = new System.Drawing.Point(7, 12);
            this.customLabel3.Name = "customLabel3";
            this.customLabel3.Size = new System.Drawing.Size(53, 18);
            this.customLabel3.TabIndex = 1;
            this.customLabel3.Text = "12:00";
            this.customLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.customLabel3.TextColor = System.Drawing.Color.White;
            // 
            // customLabel9
            // 
            this.customLabel9.AutoSize = true;
            this.customLabel9.BackColor = System.Drawing.Color.Transparent;
            this.customLabel9.BackgroundColor = System.Drawing.Color.Transparent;
            this.customLabel9.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customLabel9.BorderRadius = 0;
            this.customLabel9.BorderSize = 0;
            this.customLabel9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customLabel9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel9.ForeColor = System.Drawing.Color.White;
            this.customLabel9.Location = new System.Drawing.Point(7, 12);
            this.customLabel9.Name = "customLabel9";
            this.customLabel9.Size = new System.Drawing.Size(53, 18);
            this.customLabel9.TabIndex = 2;
            this.customLabel9.Text = "12:00";
            this.customLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.customLabel9.TextColor = System.Drawing.Color.White;
            // 
            // customLabel10
            // 
            this.customLabel10.AutoSize = true;
            this.customLabel10.BackColor = System.Drawing.Color.Transparent;
            this.customLabel10.BackgroundColor = System.Drawing.Color.Transparent;
            this.customLabel10.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customLabel10.BorderRadius = 0;
            this.customLabel10.BorderSize = 0;
            this.customLabel10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customLabel10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customLabel10.Location = new System.Drawing.Point(12, 14);
            this.customLabel10.Name = "customLabel10";
            this.customLabel10.Size = new System.Drawing.Size(159, 18);
            this.customLabel10.TabIndex = 0;
            this.customLabel10.Text = "Latest Transaction";
            this.customLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.customLabel10.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            // 
            // dataGridViewlatestransaction
            // 
            this.dataGridViewlatestransaction.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewlatestransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewlatestransaction.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.dataGridViewlatestransaction.Location = new System.Drawing.Point(11, 35);
            this.dataGridViewlatestransaction.Name = "dataGridViewlatestransaction";
            this.dataGridViewlatestransaction.Size = new System.Drawing.Size(376, 248);
            this.dataGridViewlatestransaction.TabIndex = 1;
            // 
            // DashoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 570);
            this.Controls.Add(this.greetPanel1);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.profitGenpnl);
            this.Controls.Add(this.totalSales);
            this.Controls.Add(this.totalCustpnl);
            this.Controls.Add(this.totalProdpnl);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashoardForm";
            this.Text = "DashboardPanel";
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.totalCustpnl.ResumeLayout(false);
            this.totalProdpnl.ResumeLayout(false);
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            this.customPanel2.ResumeLayout(false);
            this.customPanel2.PerformLayout();
            this.customPanel3.ResumeLayout(false);
            this.customPanel3.PerformLayout();
            this.customPanel4.ResumeLayout(false);
            this.customPanel4.PerformLayout();
            this.customPanel5.ResumeLayout(false);
            this.customPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewlatestransaction)).EndInit();
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
        private System.Windows.Forms.Label label5;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
        private Materials.CustomPanel customPanel1;
        private Materials.CustomPanel customPanel2;
        private Materials.CustomPanel customPanel3;
        private Materials.CustomPanel customPanel5;
        private Materials.CustomPanel customPanel4;
        private Materials.CustomLabel customLabel4;
        private Materials.CustomLabel clblProducts;
        private Materials.CustomLabel customLabel2;
        private Materials.CustomLabel customLabel1;
        private Materials.CustomLabel customLabel7;
        private Materials.CustomLabel customLabel6;
        private Materials.CustomLabel customLabel5;
        private Materials.CustomLabel customLabel8;
        private Materials.CustomLabel customLabel9;
        private Materials.CustomLabel customLabel3;
        private Materials.CustomLabel customLabel10;
        private System.Windows.Forms.DataGridView dataGridViewlatestransaction;
    }
}