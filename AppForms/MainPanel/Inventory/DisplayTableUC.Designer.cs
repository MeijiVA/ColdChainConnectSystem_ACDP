namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Inventory
{
    partial class DisplayTableUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.invDisplaydgv = new System.Windows.Forms.DataGridView();
            this.rowCbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.skucode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.img = new System.Windows.Forms.DataGridViewImageColumn();
            this.unitp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.editCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.actionlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.invDisplaydgv)).BeginInit();
            this.SuspendLayout();
            // 
            // invDisplaydgv
            // 
            this.invDisplaydgv.AllowUserToAddRows = false;
            this.invDisplaydgv.AllowUserToDeleteRows = false;
            this.invDisplaydgv.AllowUserToResizeColumns = false;
            this.invDisplaydgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.invDisplaydgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.invDisplaydgv.BackgroundColor = System.Drawing.Color.White;
            this.invDisplaydgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.invDisplaydgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.invDisplaydgv.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.invDisplaydgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.invDisplaydgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.invDisplaydgv.ColumnHeadersHeight = 35;
            this.invDisplaydgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.invDisplaydgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rowCbox,
            this.skucode,
            this.desc,
            this.img,
            this.unitp,
            this.amt,
            this.kg,
            this.quant,
            this.viewCol,
            this.editCol,
            this.deleteCol});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.invDisplaydgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.invDisplaydgv.EnableHeadersVisualStyles = false;
            this.invDisplaydgv.GridColor = System.Drawing.Color.White;
            this.invDisplaydgv.Location = new System.Drawing.Point(20, 15);
            this.invDisplaydgv.MultiSelect = false;
            this.invDisplaydgv.Name = "invDisplaydgv";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.invDisplaydgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.invDisplaydgv.RowHeadersVisible = false;
            this.invDisplaydgv.RowHeadersWidth = 15;
            this.invDisplaydgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.invDisplaydgv.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.invDisplaydgv.RowTemplate.Height = 32;
            this.invDisplaydgv.ShowEditingIcon = false;
            this.invDisplaydgv.Size = new System.Drawing.Size(755, 442);
            this.invDisplaydgv.TabIndex = 0;
            this.invDisplaydgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.invDisplaydgv_CellContentClick);
            this.invDisplaydgv.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.invDisplaydgv_CellMouseUp);
            this.invDisplaydgv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.invDisplaydgv_CellValueChanged);
            this.invDisplaydgv.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.invDisplaydgv_RowsAdded);
            // 
            // rowCbox
            // 
            this.rowCbox.HeaderText = "";
            this.rowCbox.Name = "rowCbox";
            this.rowCbox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.rowCbox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.rowCbox.Width = 20;
            // 
            // skucode
            // 
            this.skucode.HeaderText = "SKU Code";
            this.skucode.Name = "skucode";
            this.skucode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.skucode.Width = 90;
            // 
            // desc
            // 
            this.desc.HeaderText = "Description";
            this.desc.Name = "desc";
            this.desc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.desc.Width = 170;
            // 
            // img
            // 
            this.img.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.img.HeaderText = "Image";
            this.img.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.img.Name = "img";
            this.img.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.img.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // unitp
            // 
            this.unitp.HeaderText = "Unit Price";
            this.unitp.Name = "unitp";
            this.unitp.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // amt
            // 
            this.amt.HeaderText = "Amount";
            this.amt.Name = "amt";
            this.amt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // kg
            // 
            this.kg.HeaderText = "KG";
            this.kg.Name = "kg";
            this.kg.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.kg.Width = 40;
            // 
            // quant
            // 
            this.quant.HeaderText = "Quantity";
            this.quant.Name = "quant";
            this.quant.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.quant.Width = 70;
            // 
            // viewCol
            // 
            this.viewCol.HeaderText = "";
            this.viewCol.Name = "viewCol";
            this.viewCol.ToolTipText = "Views further information about the row.";
            this.viewCol.Width = 25;
            // 
            // editCol
            // 
            this.editCol.HeaderText = "";
            this.editCol.Name = "editCol";
            this.editCol.ToolTipText = "Edits the information of the selected row.";
            this.editCol.Width = 25;
            // 
            // deleteCol
            // 
            this.deleteCol.HeaderText = "";
            this.deleteCol.Name = "deleteCol";
            this.deleteCol.ToolTipText = "Deletes the row.";
            this.deleteCol.Width = 25;
            // 
            // actionlbl
            // 
            this.actionlbl.AutoSize = true;
            this.actionlbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.actionlbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionlbl.ForeColor = System.Drawing.Color.White;
            this.actionlbl.Location = new System.Drawing.Point(717, 25);
            this.actionlbl.Name = "actionlbl";
            this.actionlbl.Size = new System.Drawing.Size(41, 12);
            this.actionlbl.TabIndex = 1;
            this.actionlbl.Text = "Action";
            // 
            // DisplayTableUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.actionlbl);
            this.Controls.Add(this.invDisplaydgv);
            this.Name = "DisplayTableUC";
            this.Size = new System.Drawing.Size(798, 470);
            this.Load += new System.EventHandler(this.DisplayTableUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invDisplaydgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label actionlbl;
        public System.Windows.Forms.DataGridView invDisplaydgv;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rowCbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn skucode;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
        private System.Windows.Forms.DataGridViewImageColumn img;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitp;
        private System.Windows.Forms.DataGridViewTextBoxColumn amt;
        private System.Windows.Forms.DataGridViewTextBoxColumn kg;
        private System.Windows.Forms.DataGridViewTextBoxColumn quant;
        private System.Windows.Forms.DataGridViewButtonColumn viewCol;
        private System.Windows.Forms.DataGridViewButtonColumn editCol;
        private System.Windows.Forms.DataGridViewButtonColumn deleteCol;
    }
}
