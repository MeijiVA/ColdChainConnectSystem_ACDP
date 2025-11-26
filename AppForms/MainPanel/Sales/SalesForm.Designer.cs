using ColdChainConnectSystem_ACDP.AppForms.MainPanel.Inventory;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblOf = new System.Windows.Forms.Label();
            this.lblMaxPage = new System.Windows.Forms.Label();
            this.lblPageNum = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.lblPage = new System.Windows.Forms.Label();
            this.btnNext = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            this.btnPrev = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            this.actionlbl = new System.Windows.Forms.Label();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.rowCbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.numid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slsdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.editCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.deleteCol = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnCheck = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            this.SearchBar = new ColdChainConnectSystem_ACDP.AppForms.MainPanel.Inventory.SearchUC();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblOf);
            this.panel1.Controls.Add(this.lblMaxPage);
            this.panel1.Controls.Add(this.lblPageNum);
            this.panel1.Controls.Add(this.lblPage);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPrev);
            this.panel1.Location = new System.Drawing.Point(22, 528);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 35);
            this.panel1.TabIndex = 2;
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
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
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
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.Color.Gray;
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
            this.actionlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.actionlbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionlbl.ForeColor = System.Drawing.Color.White;
            this.actionlbl.Location = new System.Drawing.Point(715, 91);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.dgvTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTable.BackgroundColor = System.Drawing.Color.White;
            this.dgvTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTable.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTable.ColumnHeadersHeight = 35;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowCbox,
            this.numid,
            this.salesid,
            this.custid,
            this.slsdate,
            this.prodid,
            this.quant,
            this.unitp,
            this.amt,
            this.status,
            this.viewCol,
            this.editCol,
            this.deleteCol});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTable.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvTable.EnableHeadersVisualStyles = false;
            this.dgvTable.GridColor = System.Drawing.Color.White;
            this.dgvTable.Location = new System.Drawing.Point(22, 80);
            this.dgvTable.MultiSelect = false;
            this.dgvTable.Name = "dgvTable";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvTable.RowHeadersVisible = false;
            this.dgvTable.RowHeadersWidth = 15;
            this.dgvTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle15.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.dgvTable.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvTable.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.dgvTable.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTable.RowTemplate.Height = 40;
            this.dgvTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTable.Size = new System.Drawing.Size(755, 442);
            this.dgvTable.TabIndex = 7;
            this.dgvTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTable_CellContentClick_1);
            this.dgvTable.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTable_CellFormatting);
            this.dgvTable.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvTable_RowPostPaint_1);
            // 
            // rowCbox
            // 
            this.rowCbox.HeaderText = "";
            this.rowCbox.Name = "rowCbox";
            this.rowCbox.ReadOnly = true;
            this.rowCbox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.rowCbox.Width = 20;
            // 
            // numid
            // 
            this.numid.HeaderText = "";
            this.numid.Name = "numid";
            this.numid.Visible = false;
            // 
            // salesid
            // 
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.salesid.DefaultCellStyle = dataGridViewCellStyle3;
            this.salesid.HeaderText = "Sales ID";
            this.salesid.MinimumWidth = 2;
            this.salesid.Name = "salesid";
            this.salesid.ReadOnly = true;
            this.salesid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.salesid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // custid
            // 
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.custid.DefaultCellStyle = dataGridViewCellStyle4;
            this.custid.HeaderText = "Customer ID";
            this.custid.Name = "custid";
            this.custid.ReadOnly = true;
            this.custid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.custid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.custid.Width = 90;
            // 
            // slsdate
            // 
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.slsdate.DefaultCellStyle = dataGridViewCellStyle5;
            this.slsdate.HeaderText = "Sales Date";
            this.slsdate.Name = "slsdate";
            this.slsdate.ReadOnly = true;
            this.slsdate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.slsdate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.slsdate.Width = 80;
            // 
            // prodid
            // 
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.prodid.DefaultCellStyle = dataGridViewCellStyle6;
            this.prodid.HeaderText = "Product ID";
            this.prodid.Name = "prodid";
            this.prodid.ReadOnly = true;
            this.prodid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.prodid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.prodid.Width = 70;
            // 
            // quant
            // 
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.quant.DefaultCellStyle = dataGridViewCellStyle7;
            this.quant.HeaderText = "Quantity";
            this.quant.Name = "quant";
            this.quant.ReadOnly = true;
            this.quant.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.quant.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // unitp
            // 
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.unitp.DefaultCellStyle = dataGridViewCellStyle8;
            this.unitp.HeaderText = "Unit Price";
            this.unitp.Name = "unitp";
            this.unitp.ReadOnly = true;
            this.unitp.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.unitp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.unitp.Width = 65;
            // 
            // amt
            // 
            this.amt.HeaderText = "Total";
            this.amt.Name = "amt";
            this.amt.ReadOnly = true;
            this.amt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.amt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.amt.Width = 85;
            // 
            // status
            // 
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.status.DefaultCellStyle = dataGridViewCellStyle9;
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.status.Width = 70;
            // 
            // viewCol
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle10.NullValue")));
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.viewCol.DefaultCellStyle = dataGridViewCellStyle10;
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
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle11.NullValue")));
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.editCol.DefaultCellStyle = dataGridViewCellStyle11;
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
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle12.NullValue")));
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.deleteCol.DefaultCellStyle = dataGridViewCellStyle12;
            this.deleteCol.HeaderText = "";
            this.deleteCol.Image = global::ColdChainConnectSystem_ACDP.Properties.Resources.delBtn;
            this.deleteCol.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.deleteCol.Name = "deleteCol";
            this.deleteCol.ReadOnly = true;
            this.deleteCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.deleteCol.ToolTipText = "Deletes the row.";
            this.deleteCol.Width = 25;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.btnCheck.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.btnCheck.BackgroundImage = global::ColdChainConnectSystem_ACDP.Properties.Resources.Arrow_left_circle;
            this.btnCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheck.BorderColor = System.Drawing.Color.Empty;
            this.btnCheck.BorderRadius = 0;
            this.btnCheck.BorderSize = 0;
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.ForeColor = System.Drawing.Color.Transparent;
            this.btnCheck.Location = new System.Drawing.Point(286, 32);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(25, 25);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.TextColor = System.Drawing.Color.Transparent;
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // SearchBar
            // 
            this.SearchBar.BackColor = System.Drawing.Color.Transparent;
            this.SearchBar.Location = new System.Drawing.Point(22, 12);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.searchTXT = "Search Term";
            this.SearchBar.Size = new System.Drawing.Size(755, 65);
            this.SearchBar.TabIndex = 6;
            // 
            // SalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 570);
            this.Controls.Add(this.actionlbl);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.dgvTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "InventoryForm";
            this.Load += new System.EventHandler(this.SalesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Materials.CustomButton btnPrev;
        private System.Windows.Forms.Label lblPage;
        private Materials.CustomButton btnNext;
        private Materials.CustomLabel lblPageNum;
        private System.Windows.Forms.Label lblOf;
        private System.Windows.Forms.Label lblMaxPage;
        private Materials.CustomButton btnCheck;
        private System.Windows.Forms.Label actionlbl;
        private SearchUC SearchBar;
        public System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rowCbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn numid;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesid;
        private System.Windows.Forms.DataGridViewTextBoxColumn custid;
        private System.Windows.Forms.DataGridViewTextBoxColumn slsdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodid;
        private System.Windows.Forms.DataGridViewTextBoxColumn quant;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitp;
        private System.Windows.Forms.DataGridViewTextBoxColumn amt;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewImageColumn viewCol;
        private System.Windows.Forms.DataGridViewImageColumn editCol;
        private System.Windows.Forms.DataGridViewImageColumn deleteCol;
    }
}