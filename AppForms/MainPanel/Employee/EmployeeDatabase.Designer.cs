using ColdChainConnectSystem_ACDP.AppForms.MainPanel.Inventory;

namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Employee
{
    partial class EmployeeDatabase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblOf = new System.Windows.Forms.Label();
            this.lblMaxPage = new System.Windows.Forms.Label();
            this.lblPageNum = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.lblPage = new System.Windows.Forms.Label();
            this.btnNext = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            this.btnPrev = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.SearchBar = new ColdChainConnectSystem_ACDP.AppForms.MainPanel.Inventory.SearchUC();
            this.footerPanel = new ColdChainConnectSystem_ACDP.Materials.CustomPanel();
            this.rowCbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.numid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUnarchive = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.AllowUserToResizeColumns = false;
            this.dgvEmployee.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.dgvEmployee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployee.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmployee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvEmployee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployee.ColumnHeadersHeight = 35;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowCbox,
            this.numid,
            this.empid,
            this.username,
            this.fullname,
            this.position,
            this.status,
            this.btnUnarchive});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployee.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEmployee.EnableHeadersVisualStyles = false;
            this.dgvEmployee.GridColor = System.Drawing.Color.White;
            this.dgvEmployee.Location = new System.Drawing.Point(22, 63);
            this.dgvEmployee.MultiSelect = false;
            this.dgvEmployee.Name = "dgvEmployee";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployee.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEmployee.RowHeadersVisible = false;
            this.dgvEmployee.RowHeadersWidth = 15;
            this.dgvEmployee.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.dgvEmployee.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEmployee.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.dgvEmployee.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployee.RowTemplate.Height = 40;
            this.dgvEmployee.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployee.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvEmployee.Size = new System.Drawing.Size(754, 442);
            this.dgvEmployee.TabIndex = 1;
            this.dgvEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellClick);
            this.dgvEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellContentClick);
            this.dgvEmployee.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvEmployee_CellFormatting);
            this.dgvEmployee.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvEmployee_DataError);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblOf);
            this.panel1.Controls.Add(this.lblMaxPage);
            this.panel1.Controls.Add(this.lblPageNum);
            this.panel1.Controls.Add(this.lblPage);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPrev);
            this.panel1.Location = new System.Drawing.Point(22, 520);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 35);
            this.panel1.TabIndex = 3;
            // 
            // lblOf
            // 
            this.lblOf.AutoSize = true;
            this.lblOf.Font = new System.Drawing.Font("Arial", 8.25F);
            this.lblOf.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblOf.Location = new System.Drawing.Point(714, 10);
            this.lblOf.Name = "lblOf";
            this.lblOf.Size = new System.Drawing.Size(17, 14);
            this.lblOf.TabIndex = 6;
            this.lblOf.Text = "of";
            // 
            // lblMaxPage
            // 
            this.lblMaxPage.AutoSize = true;
            this.lblMaxPage.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblMaxPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblMaxPage.Location = new System.Drawing.Point(731, 10);
            this.lblMaxPage.Name = "lblMaxPage";
            this.lblMaxPage.Size = new System.Drawing.Size(19, 14);
            this.lblMaxPage.TabIndex = 5;
            this.lblMaxPage.Text = "25";
            // 
            // lblPageNum
            // 
            this.lblPageNum.Angle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.lblPageNum.BackColor = System.Drawing.Color.White;
            this.lblPageNum.BackgroundColor = System.Drawing.Color.White;
            this.lblPageNum.BorderColor = System.Drawing.Color.DimGray;
            this.lblPageNum.BorderRadius = 10;
            this.lblPageNum.BorderSize = 1;
            this.lblPageNum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPageNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPageNum.ForeColor = System.Drawing.Color.Gray;
            this.lblPageNum.GradientColor1 = System.Drawing.Color.Transparent;
            this.lblPageNum.GradientColor2 = System.Drawing.Color.Transparent;
            this.lblPageNum.GradientTextColor = System.Drawing.Color.Transparent;
            this.lblPageNum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPageNum.Location = new System.Drawing.Point(661, 2);
            this.lblPageNum.Name = "lblPageNum";
            this.lblPageNum.Size = new System.Drawing.Size(48, 30);
            this.lblPageNum.TabIndex = 4;
            this.lblPageNum.Text = " 1";
            this.lblPageNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPageNum.TextColor = System.Drawing.Color.Gray;
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("Arial", 8.25F);
            this.lblPage.ForeColor = System.Drawing.Color.DimGray;
            this.lblPage.Location = new System.Drawing.Point(623, 10);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(34, 14);
            this.lblPage.TabIndex = 3;
            this.lblPage.Text = "Page:";
            // 
            // btnNext
            // 
            this.btnNext.Angle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.btnNext.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.btnNext.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.btnNext.BorderRadius = 10;
            this.btnNext.BorderSize = 0;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.GradientColor1 = System.Drawing.Color.Empty;
            this.btnNext.GradientColor2 = System.Drawing.Color.Empty;
            this.btnNext.GradientTextColor = System.Drawing.Color.Transparent;
            this.btnNext.Location = new System.Drawing.Point(571, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(46, 30);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.TextColor = System.Drawing.Color.White;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Angle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.btnPrev.BackColor = System.Drawing.Color.White;
            this.btnPrev.BackgroundColor = System.Drawing.Color.White;
            this.btnPrev.BorderColor = System.Drawing.Color.DimGray;
            this.btnPrev.BorderRadius = 10;
            this.btnPrev.BorderSize = 1;
            this.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.btnPrev.ForeColor = System.Drawing.Color.Gray;
            this.btnPrev.GradientColor1 = System.Drawing.Color.Empty;
            this.btnPrev.GradientColor2 = System.Drawing.Color.Empty;
            this.btnPrev.GradientTextColor = System.Drawing.Color.Transparent;
            this.btnPrev.Location = new System.Drawing.Point(519, 1);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(46, 30);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "Prev";
            this.btnPrev.TextColor = System.Drawing.Color.Gray;
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn2.HeaderText = "Emp ID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Username";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 90;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "Full Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Position";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Status";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 70;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::ColdChainConnectSystem_ACDP.Properties.Resources.delBtn;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // SearchBar
            // 
            this.SearchBar.BackColor = System.Drawing.Color.Transparent;
            this.SearchBar.Location = new System.Drawing.Point(22, 12);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.searchTXT = "Search Term";
            this.SearchBar.Size = new System.Drawing.Size(755, 84);
            this.SearchBar.TabIndex = 0;
            // 
            // footerPanel
            // 
            this.footerPanel.Angle = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.footerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(163)))));
            this.footerPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(163)))));
            this.footerPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.footerPanel.BorderRadius = 10;
            this.footerPanel.BorderSize = 0;
            this.footerPanel.ForeColor = System.Drawing.Color.White;
            this.footerPanel.GradientColor1 = System.Drawing.Color.Transparent;
            this.footerPanel.GradientColor2 = System.Drawing.Color.Transparent;
            this.footerPanel.GradientTextColor = System.Drawing.Color.Transparent;
            this.footerPanel.Location = new System.Drawing.Point(22, 490);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(753, 29);
            this.footerPanel.TabIndex = 4;
            this.footerPanel.TextColor = System.Drawing.Color.White;
            // 
            // rowCbox
            // 
            this.rowCbox.HeaderText = "";
            this.rowCbox.Name = "rowCbox";
            this.rowCbox.Width = 20;
            // 
            // numid
            // 
            this.numid.HeaderText = "";
            this.numid.Name = "numid";
            this.numid.Visible = false;
            // 
            // empid
            // 
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.empid.DefaultCellStyle = dataGridViewCellStyle3;
            this.empid.HeaderText = "Emp ID";
            this.empid.Name = "empid";
            this.empid.Width = 80;
            // 
            // username
            // 
            this.username.HeaderText = "Username";
            this.username.Name = "username";
            this.username.Width = 90;
            // 
            // fullname
            // 
            this.fullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fullname.HeaderText = "Full Name";
            this.fullname.Name = "fullname";
            // 
            // position
            // 
            this.position.HeaderText = "Position";
            this.position.Name = "position";
            this.position.Width = 80;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.Width = 70;
            // 
            // btnUnarchive
            // 
            this.btnUnarchive.HeaderText = "Unarchive";
            this.btnUnarchive.Image = global::ColdChainConnectSystem_ACDP.Properties.Resources.btnArchive;
            this.btnUnarchive.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.btnUnarchive.Name = "btnUnarchive";
            // 
            // EmployeeDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(798, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.footerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeDatabase";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "EmployeeDatabase";
            this.Load += new System.EventHandler(this.EmployeeDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Panel panel1;
        private Materials.CustomButton btnPrev;
        private System.Windows.Forms.Label lblPage;
        private Materials.CustomButton btnNext;
        private Materials.CustomLabel lblPageNum;
        private System.Windows.Forms.Label lblOf;
        private System.Windows.Forms.Label lblMaxPage;
        private Materials.CustomPanel footerPanel;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        public SearchUC SearchBar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rowCbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn numid;
        private System.Windows.Forms.DataGridViewTextBoxColumn empid;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewImageColumn btnUnarchive;
    }
}


