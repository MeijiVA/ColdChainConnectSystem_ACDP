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
            this.customPanel1 = new ColdChainConnectSystem_ACDP.Materials.CustomPanel();
            this.cbxFilter = new ColdChainConnectSystem_ACDP.Materials.CustomComboBox();
            this.pnlSearch = new ColdChainConnectSystem_ACDP.Materials.CustomPanel();
            this.txtSearchBar = new CustomControls.RJControls.CustomTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customButton1 = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            this.customButton3 = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            this.customButton2 = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            this.customPanel1.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.customPanel1.Controls.Add(this.customButton1);
            this.customPanel1.Controls.Add(this.customButton3);
            this.customPanel1.Controls.Add(this.customButton2);
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
            this.cbxFilter.BackgroundImage = global::ColdChainConnectSystem_ACDP.Properties.Resources.Filter;
            this.cbxFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(6)))), ((int)(((byte)(60)))));
            this.cbxFilter.BorderRadius = 10;
            this.cbxFilter.BorderSize = 1;
            this.cbxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbxFilter.ForeColor = System.Drawing.Color.White;
            this.cbxFilter.IconColor = System.Drawing.Color.White;
            this.cbxFilter.Items.AddRange(new object[] {
            "test"});
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
            this.pnlSearch.Controls.Add(this.txtSearchBar);
            this.pnlSearch.Controls.Add(this.pictureBox1);
            this.pnlSearch.ForeColor = System.Drawing.Color.White;
            this.pnlSearch.Location = new System.Drawing.Point(18, 15);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(10, 7, 2, 2);
            this.pnlSearch.Size = new System.Drawing.Size(278, 35);
            this.pnlSearch.TabIndex = 4;
            this.pnlSearch.TextColor = System.Drawing.Color.White;
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.txtSearchBar.BorderColor = System.Drawing.Color.Transparent;
            this.txtSearchBar.BorderFocusColor = System.Drawing.Color.Transparent;
            this.txtSearchBar.BorderRadius = 0;
            this.txtSearchBar.BorderSize = 1;
            this.txtSearchBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtSearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtSearchBar.ForeColor = System.Drawing.Color.White;
            this.txtSearchBar.Location = new System.Drawing.Point(34, 3);
            this.txtSearchBar.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchBar.MaximumSize = new System.Drawing.Size(230, 30);
            this.txtSearchBar.MinimumSize = new System.Drawing.Size(230, 30);
            this.txtSearchBar.Multiline = false;
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSearchBar.PasswordChar = false;
            this.txtSearchBar.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearchBar.PlaceholderText = "";
            this.txtSearchBar.Size = new System.Drawing.Size(230, 30);
            this.txtSearchBar.TabIndex = 3;
            this.txtSearchBar.Texts = "Search Term";
            this.txtSearchBar.UnderlinedStyle = false;
            this.txtSearchBar._TextChanged += new System.EventHandler(this.customTextBox1__TextChanged);
            this.txtSearchBar.Enter += new System.EventHandler(this.txtSearchBar_Enter);
            this.txtSearchBar.Leave += new System.EventHandler(this.txtSearchBar_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ColdChainConnectSystem_ACDP.Properties.Resources.searchIcon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(10, 7);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(24, 24);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(24, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.Transparent;
            this.customButton1.BackgroundColor = System.Drawing.Color.Transparent;
            this.customButton1.BackgroundImage = global::ColdChainConnectSystem_ACDP.Properties.Resources.add;
            this.customButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton1.BorderRadius = 10;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(405, 15);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(132, 35);
            this.customButton1.TabIndex = 0;
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // customButton3
            // 
            this.customButton3.BackColor = System.Drawing.Color.Transparent;
            this.customButton3.BackgroundColor = System.Drawing.Color.Transparent;
            this.customButton3.BackgroundImage = global::ColdChainConnectSystem_ACDP.Properties.Resources.import;
            this.customButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton3.BorderRadius = 10;
            this.customButton3.BorderSize = 0;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.ForeColor = System.Drawing.Color.White;
            this.customButton3.Location = new System.Drawing.Point(543, 16);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(94, 35);
            this.customButton3.TabIndex = 2;
            this.customButton3.TextColor = System.Drawing.Color.White;
            this.customButton3.UseVisualStyleBackColor = false;
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.Transparent;
            this.customButton2.BackgroundColor = System.Drawing.Color.Transparent;
            this.customButton2.BackgroundImage = global::ColdChainConnectSystem_ACDP.Properties.Resources.export;
            this.customButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.customButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton2.BorderRadius = 10;
            this.customButton2.BorderSize = 0;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Location = new System.Drawing.Point(643, 15);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(94, 35);
            this.customButton2.TabIndex = 1;
            this.customButton2.TextColor = System.Drawing.Color.White;
            this.customButton2.UseVisualStyleBackColor = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Materials.CustomButton customButton1;
        private Materials.CustomButton customButton2;
        private Materials.CustomButton customButton3;
        private Materials.CustomPanel customPanel1;
        private Materials.CustomPanel pnlSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        public CustomControls.RJControls.CustomTextBox txtSearchBar;
        private Materials.CustomComboBox cbxFilter;
    }
}
