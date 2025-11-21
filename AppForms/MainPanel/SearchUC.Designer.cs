namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Inventory
{
    partial class SearchUC
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
            this.ofdImport = new System.Windows.Forms.OpenFileDialog();
            this.ofdExport = new System.Windows.Forms.SaveFileDialog();
            this.customPanel1 = new ColdChainConnectSystem_ACDP.Materials.CustomPanel();
            this.cbxFilter = new ColdChainConnectSystem_ACDP.Materials.CustomComboBox();
            this.pnlSearch = new ColdChainConnectSystem_ACDP.Materials.CustomPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddItem = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            this.btnImport = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            this.btnExport = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            this.customPanel1.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ofdImport
            // 
            this.ofdImport.InitialDirectory = "Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), \"D" +
    "ownloads\")";
            // 
            // ofdExport
            // 
            this.ofdExport.InitialDirectory = "Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), \"D" +
    "ownloads\")";
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.customPanel1.BorderRadius = 10;
            this.customPanel1.BorderSize = 0;
            this.customPanel1.Controls.Add(this.cbxFilter);
            this.customPanel1.Controls.Add(this.pnlSearch);
            this.customPanel1.Controls.Add(this.btnAddItem);
            this.customPanel1.Controls.Add(this.btnImport);
            this.customPanel1.Controls.Add(this.btnExport);
            this.customPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customPanel1.ForeColor = System.Drawing.Color.White;
            this.customPanel1.Location = new System.Drawing.Point(0, 0);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Padding = new System.Windows.Forms.Padding(15);
            this.customPanel1.Size = new System.Drawing.Size(755, 65);
            this.customPanel1.TabIndex = 3;
            this.customPanel1.TextColor = System.Drawing.Color.White;
            // 
            // cbxFilter
            // 
            this.cbxFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(60)))));
            this.cbxFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(60)))));
            this.cbxFilter.BorderRadius = 10;
            this.cbxFilter.BorderSize = 1;
            this.cbxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbxFilter.ForeColor = System.Drawing.Color.White;
            this.cbxFilter.IconColor = System.Drawing.Color.White;
            this.cbxFilter.Items.AddRange(new object[] {
            "Filter"});
            this.cbxFilter.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbxFilter.ListTextColor = System.Drawing.Color.DimGray;
            this.cbxFilter.Location = new System.Drawing.Point(302, 15);
            this.cbxFilter.MinimumSize = new System.Drawing.Size(40, 30);
            this.cbxFilter.Name = "cbxFilter";
            this.cbxFilter.Padding = new System.Windows.Forms.Padding(1);
            this.cbxFilter.Size = new System.Drawing.Size(100, 35);
            this.cbxFilter.TabIndex = 5;
            this.cbxFilter.Texts = "Filter";
            this.cbxFilter.OnSelectedIndexChanged += new System.EventHandler(this.cbxFilter_OnSelectedIndexChanged);
            this.cbxFilter.Load += new System.EventHandler(this.cbxFilter_Load);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.pnlSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.pnlSearch.BorderColor = System.Drawing.Color.White;
            this.pnlSearch.BorderRadius = 10;
            this.pnlSearch.BorderSize = 1;
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.pictureBox1);
            this.pnlSearch.ForeColor = System.Drawing.Color.White;
            this.pnlSearch.Location = new System.Drawing.Point(18, 15);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(40, 10, 2, 2);
            this.pnlSearch.Size = new System.Drawing.Size(278, 35);
            this.pnlSearch.TabIndex = 4;
            this.pnlSearch.TextColor = System.Drawing.Color.White;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(40, 10);
            this.txtSearch.MaximumSize = new System.Drawing.Size(200, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 14);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.Text = "Search Term";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ColdChainConnectSystem_ACDP.Properties.Resources.searchIcon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(10, 7);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(24, 24);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(24, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.Transparent;
            this.btnAddItem.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAddItem.BackgroundImage = global::ColdChainConnectSystem_ACDP.Properties.Resources.add;
            this.btnAddItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddItem.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAddItem.BorderRadius = 10;
            this.btnAddItem.BorderSize = 0;
            this.btnAddItem.FlatAppearance.BorderSize = 0;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(405, 15);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(132, 35);
            this.btnAddItem.TabIndex = 0;
            this.btnAddItem.TextColor = System.Drawing.Color.White;
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.Transparent;
            this.btnImport.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnImport.BackgroundImage = global::ColdChainConnectSystem_ACDP.Properties.Resources.import;
            this.btnImport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImport.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnImport.BorderRadius = 10;
            this.btnImport.BorderSize = 0;
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.Location = new System.Drawing.Point(543, 16);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(94, 35);
            this.btnImport.TabIndex = 2;
            this.btnImport.TextColor = System.Drawing.Color.White;
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Transparent;
            this.btnExport.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnExport.BackgroundImage = global::ColdChainConnectSystem_ACDP.Properties.Resources.export;
            this.btnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExport.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnExport.BorderRadius = 10;
            this.btnExport.BorderSize = 0;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(643, 15);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(94, 35);
            this.btnExport.TabIndex = 1;
            this.btnExport.TextColor = System.Drawing.Color.White;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // SearchUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.customPanel1);
            this.Name = "SearchUC";
            this.Size = new System.Drawing.Size(755, 65);
            this.customPanel1.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Materials.CustomButton btnAddItem;
        private Materials.CustomButton btnExport;
        private Materials.CustomButton btnImport;
        private Materials.CustomPanel customPanel1;
        private Materials.CustomPanel pnlSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Materials.CustomComboBox cbxFilter;
        public System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.OpenFileDialog ofdImport;
        private System.Windows.Forms.SaveFileDialog ofdExport;
    }
}
