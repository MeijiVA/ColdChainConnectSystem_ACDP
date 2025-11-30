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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle47 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle48 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLegends = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.lblOf = new System.Windows.Forms.Label();
            this.lblMaxPage = new System.Windows.Forms.Label();
            this.lblPageNum = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.lblPage = new System.Windows.Forms.Label();
            this.btnNext = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            this.btnPrev = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            this.actionlbl = new System.Windows.Forms.Label();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.rowCbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.statusExpiry = new System.Windows.Forms.DataGridViewImageColumn();
            this.numid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skucode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.img = new System.Windows.Forms.DataGridViewImageColumn();
            this.unitp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.editCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.deleteCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.uc = new ColdChainConnectSystem_ACDP.AppForms.MainPanel.Inventory.UsrCntrlLegend();
            this.SearchBar = new ColdChainConnectSystem_ACDP.AppForms.MainPanel.Inventory.SearchUC();
            this.customPanel1 = new ColdChainConnectSystem_ACDP.Materials.CustomPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblLegends);
            this.panel1.Controls.Add(this.lblOf);
            this.panel1.Controls.Add(this.lblMaxPage);
            this.panel1.Controls.Add(this.lblPageNum);
            this.panel1.Controls.Add(this.lblPage);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPrev);
            this.panel1.Location = new System.Drawing.Point(22, 520);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 35);
            this.panel1.TabIndex = 2;
            // 
            // lblLegends
            // 
            this.lblLegends.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblLegends.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblLegends.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.lblLegends.BorderRadius = 10;
            this.lblLegends.BorderSize = 0;
            this.lblLegends.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLegends.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLegends.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegends.ForeColor = System.Drawing.Color.White;
            this.lblLegends.Location = new System.Drawing.Point(3, 6);
            this.lblLegends.Name = "lblLegends";
            this.lblLegends.Size = new System.Drawing.Size(63, 25);
            this.lblLegends.TabIndex = 7;
            this.lblLegends.Text = "Legends";
            this.lblLegends.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLegends.TextColor = System.Drawing.Color.White;
            this.lblLegends.MouseLeave += new System.EventHandler(this.lblLegends_MouseLeave);
            this.lblLegends.MouseHover += new System.EventHandler(this.lblLegends_MouseHover);
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
            this.lblPageNum.BackColor = System.Drawing.Color.White;
            this.lblPageNum.BackgroundColor = System.Drawing.Color.White;
            this.lblPageNum.BorderColor = System.Drawing.Color.DimGray;
            this.lblPageNum.BorderRadius = 10;
            this.lblPageNum.BorderSize = 1;
            this.lblPageNum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPageNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPageNum.ForeColor = System.Drawing.Color.Gray;
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
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.btnNext.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.btnNext.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.btnNext.BorderRadius = 10;
            this.btnNext.BorderSize = 0;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.GradientColor1 = System.Drawing.Color.Transparent;
            this.btnNext.GradientColor2 = System.Drawing.Color.Transparent;
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
            this.btnPrev.BackColor = System.Drawing.Color.White;
            this.btnPrev.BackgroundColor = System.Drawing.Color.White;
            this.btnPrev.BorderColor = System.Drawing.Color.DimGray;
            this.btnPrev.BorderRadius = 10;
            this.btnPrev.BorderSize = 1;
            this.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.Color.Gray;
            this.btnPrev.GradientColor1 = System.Drawing.Color.Transparent;
            this.btnPrev.GradientColor2 = System.Drawing.Color.Transparent;
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
            // actionlbl
            // 
            this.actionlbl.AutoSize = true;
            this.actionlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(163)))));
            this.actionlbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionlbl.ForeColor = System.Drawing.Color.White;
            this.actionlbl.Location = new System.Drawing.Point(717, 74);
            this.actionlbl.Name = "actionlbl";
            this.actionlbl.Size = new System.Drawing.Size(41, 12);
            this.actionlbl.TabIndex = 5;
            this.actionlbl.Text = "Action";
            // 
            // dgvTable
            // 
            this.dgvTable.AllowUserToAddRows = false;
            this.dgvTable.AllowUserToDeleteRows = false;
            this.dgvTable.AllowUserToResizeColumns = false;
            this.dgvTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle33.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.dgvTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle33;
            this.dgvTable.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTable.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle34.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.dgvTable.ColumnHeadersHeight = 35;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowCbox,
            this.statusExpiry,
            this.numid,
            this.skucode,
            this.desc,
            this.img,
            this.unitp,
            this.supid,
            this.kg,
            this.quant,
            this.viewCol,
            this.editCol,
            this.deleteCol});
            dataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle46.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle46.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            dataGridViewCellStyle46.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle46.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle46.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle46.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle46.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTable.DefaultCellStyle = dataGridViewCellStyle46;
            this.dgvTable.EnableHeadersVisualStyles = false;
            this.dgvTable.GridColor = System.Drawing.Color.White;
            this.dgvTable.Location = new System.Drawing.Point(22, 63);
            this.dgvTable.MultiSelect = false;
            this.dgvTable.Name = "dgvTable";
            dataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle47.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle47.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle47.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle47.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle47.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle47.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle47;
            this.dgvTable.RowHeadersVisible = false;
            this.dgvTable.RowHeadersWidth = 15;
            this.dgvTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle48.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle48.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            dataGridViewCellStyle48.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle48.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle48.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle48.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.dgvTable.RowsDefaultCellStyle = dataGridViewCellStyle48;
            this.dgvTable.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.dgvTable.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTable.RowTemplate.Height = 40;
            this.dgvTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvTable.Size = new System.Drawing.Size(754, 442);
            this.dgvTable.TabIndex = 8;
            this.dgvTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTable_CellClick);
            this.dgvTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTable_CellContentClick_1);
            this.dgvTable.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTable_CellFormatting);
            this.dgvTable.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTable_CellMouseEnter);
            this.dgvTable.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTable_CellMouseLeave);
            this.dgvTable.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTable_CellValueChanged);
            this.dgvTable.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvTable_CurrentCellDirtyStateChanged);
            this.dgvTable.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvTable_RowPostPaint);
            // 
            // rowCbox
            // 
            this.rowCbox.HeaderText = "";
            this.rowCbox.Name = "rowCbox";
            this.rowCbox.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.rowCbox.Width = 20;
            // 
            // statusExpiry
            // 
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle35.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle35.NullValue")));
            dataGridViewCellStyle35.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.statusExpiry.DefaultCellStyle = dataGridViewCellStyle35;
            this.statusExpiry.HeaderText = "";
            this.statusExpiry.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.statusExpiry.Name = "statusExpiry";
            this.statusExpiry.ReadOnly = true;
            this.statusExpiry.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.statusExpiry.Width = 20;
            // 
            // numid
            // 
            this.numid.HeaderText = "";
            this.numid.MinimumWidth = 2;
            this.numid.Name = "numid";
            this.numid.ReadOnly = true;
            this.numid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.numid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.numid.Visible = false;
            this.numid.Width = 2;
            // 
            // skucode
            // 
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.skucode.DefaultCellStyle = dataGridViewCellStyle36;
            this.skucode.HeaderText = "SKU Code";
            this.skucode.Name = "skucode";
            this.skucode.ReadOnly = true;
            this.skucode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.skucode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.skucode.Width = 89;
            // 
            // desc
            // 
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.desc.DefaultCellStyle = dataGridViewCellStyle37;
            this.desc.HeaderText = "Description";
            this.desc.Name = "desc";
            this.desc.ReadOnly = true;
            this.desc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.desc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.desc.Width = 170;
            // 
            // img
            // 
            this.img.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle38.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle38.NullValue")));
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.img.DefaultCellStyle = dataGridViewCellStyle38;
            this.img.HeaderText = "Image";
            this.img.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.img.Name = "img";
            this.img.ReadOnly = true;
            this.img.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // unitp
            // 
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.unitp.DefaultCellStyle = dataGridViewCellStyle39;
            this.unitp.HeaderText = "Unit Price";
            this.unitp.Name = "unitp";
            this.unitp.ReadOnly = true;
            this.unitp.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.unitp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // supid
            // 
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.supid.DefaultCellStyle = dataGridViewCellStyle40;
            this.supid.HeaderText = "Supplier ID";
            this.supid.Name = "supid";
            this.supid.ReadOnly = true;
            this.supid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.supid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // kg
            // 
            dataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.kg.DefaultCellStyle = dataGridViewCellStyle41;
            this.kg.HeaderText = "KG";
            this.kg.Name = "kg";
            this.kg.ReadOnly = true;
            this.kg.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.kg.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.kg.Width = 40;
            // 
            // quant
            // 
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.quant.DefaultCellStyle = dataGridViewCellStyle42;
            this.quant.HeaderText = "Quantity";
            this.quant.Name = "quant";
            this.quant.ReadOnly = true;
            this.quant.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.quant.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.quant.Width = 70;
            // 
            // viewCol
            // 
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle43.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle43.NullValue")));
            dataGridViewCellStyle43.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.viewCol.DefaultCellStyle = dataGridViewCellStyle43;
            this.viewCol.HeaderText = "";
            this.viewCol.Image = global::ColdChainConnectSystem_ACDP.Properties.Resources.viewBtn;
            this.viewCol.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.viewCol.Name = "viewCol";
            this.viewCol.ReadOnly = true;
            this.viewCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.viewCol.ToolTipText = "Views further information about the row.";
            this.viewCol.Width = 25;
            // 
            // editCol
            // 
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle44.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle44.NullValue")));
            dataGridViewCellStyle44.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.editCol.DefaultCellStyle = dataGridViewCellStyle44;
            this.editCol.HeaderText = "";
            this.editCol.Image = global::ColdChainConnectSystem_ACDP.Properties.Resources.editBtn;
            this.editCol.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.editCol.Name = "editCol";
            this.editCol.ReadOnly = true;
            this.editCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.editCol.ToolTipText = "Edits the information of the selected row.";
            this.editCol.Width = 25;
            // 
            // deleteCol
            // 
            dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle45.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle45.NullValue")));
            dataGridViewCellStyle45.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.deleteCol.DefaultCellStyle = dataGridViewCellStyle45;
            this.deleteCol.HeaderText = "";
            this.deleteCol.Image = global::ColdChainConnectSystem_ACDP.Properties.Resources.delBtn;
            this.deleteCol.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.deleteCol.Name = "deleteCol";
            this.deleteCol.ReadOnly = true;
            this.deleteCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.deleteCol.ToolTipText = "Deletes the row.";
            this.deleteCol.Width = 25;
            // 
            // uc
            // 
            this.uc.BackColor = System.Drawing.SystemColors.Control;
            this.uc.Location = new System.Drawing.Point(22, 404);
            this.uc.Name = "uc";
            this.uc.Size = new System.Drawing.Size(137, 124);
            this.uc.TabIndex = 9;
            this.uc.Visible = false;
            // 
            // SearchBar
            // 
            this.SearchBar.BackColor = System.Drawing.Color.Transparent;
            this.SearchBar.Location = new System.Drawing.Point(22, 12);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.searchTXT = "Search Term";
            this.SearchBar.Size = new System.Drawing.Size(755, 87);
            this.SearchBar.TabIndex = 0;
            this.SearchBar.Load += new System.EventHandler(this.searchUC1_Load);
            // 
            // customPanel1
            // 
            this.customPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(163)))));
            this.customPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(163)))));
            this.customPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.customPanel1.BorderRadius = 10;
            this.customPanel1.BorderSize = 0;
            this.customPanel1.ForeColor = System.Drawing.Color.White;
            this.customPanel1.Location = new System.Drawing.Point(22, 490);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.Size = new System.Drawing.Size(753, 29);
            this.customPanel1.TabIndex = 10;
            this.customPanel1.TextColor = System.Drawing.Color.White;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(798, 570);
            this.Controls.Add(this.uc);
            this.Controls.Add(this.actionlbl);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.customPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventoryForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "InventoryForm";
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SearchUC SearchBar;
        private System.Windows.Forms.Panel panel1;
        private Materials.CustomButton btnPrev;
        private System.Windows.Forms.Label lblPage;
        private Materials.CustomButton btnNext;
        private Materials.CustomLabel lblPageNum;
        private System.Windows.Forms.Label lblOf;
        private System.Windows.Forms.Label lblMaxPage;
        private System.Windows.Forms.Label actionlbl;
        public System.Windows.Forms.DataGridView dgvTable;
        private Materials.CustomLabel lblLegends;
        private UsrCntrlLegend uc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rowCbox;
        private System.Windows.Forms.DataGridViewImageColumn statusExpiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn numid;
        private System.Windows.Forms.DataGridViewTextBoxColumn skucode;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
        private System.Windows.Forms.DataGridViewImageColumn img;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitp;
        private System.Windows.Forms.DataGridViewTextBoxColumn supid;
        private System.Windows.Forms.DataGridViewTextBoxColumn kg;
        private System.Windows.Forms.DataGridViewTextBoxColumn quant;
        private System.Windows.Forms.DataGridViewImageColumn viewCol;
        private System.Windows.Forms.DataGridViewImageColumn editCol;
        private System.Windows.Forms.DataGridViewImageColumn deleteCol;
        private Materials.CustomPanel customPanel1;
    }
}