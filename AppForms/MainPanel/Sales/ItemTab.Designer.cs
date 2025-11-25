namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Sales
{
    partial class ItemTab
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
            this.tabPanel = new ColdChainConnectSystem_ACDP.Materials.CustomPanel();
            this.lblPHP = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPriceTitle = new System.Windows.Forms.Label();
            this.lblQuantityValue = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.lblUnitPrice = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.cbProductID = new ColdChainConnectSystem_ACDP.Materials.CustomComboBox();
            this.lblProductID = new System.Windows.Forms.Label();
            this.cbStatus = new ColdChainConnectSystem_ACDP.Materials.CustomComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TrackBar();
            this.tabPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPanel
            // 
            this.tabPanel.BackColor = System.Drawing.Color.White;
            this.tabPanel.BackgroundColor = System.Drawing.Color.White;
            this.tabPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.tabPanel.BorderRadius = 15;
            this.tabPanel.BorderSize = 2;
            this.tabPanel.Controls.Add(this.lblPHP);
            this.tabPanel.Controls.Add(this.lblPrice);
            this.tabPanel.Controls.Add(this.lblPriceTitle);
            this.tabPanel.Controls.Add(this.lblQuantityValue);
            this.tabPanel.Controls.Add(this.lblUnitPrice);
            this.tabPanel.Controls.Add(this.cbProductID);
            this.tabPanel.Controls.Add(this.lblProductID);
            this.tabPanel.Controls.Add(this.cbStatus);
            this.tabPanel.Controls.Add(this.lblQuantity);
            this.tabPanel.Controls.Add(this.lblStatus);
            this.tabPanel.Controls.Add(this.tbQuantity);
            this.tabPanel.ForeColor = System.Drawing.Color.White;
            this.tabPanel.Location = new System.Drawing.Point(0, 0);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.Size = new System.Drawing.Size(746, 311);
            this.tabPanel.TabIndex = 0;
            this.tabPanel.TextColor = System.Drawing.Color.White;
            // 
            // lblPHP
            // 
            this.lblPHP.AutoSize = true;
            this.lblPHP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblPHP.ForeColor = System.Drawing.Color.Green;
            this.lblPHP.Location = new System.Drawing.Point(683, 34);
            this.lblPHP.Name = "lblPHP";
            this.lblPHP.Size = new System.Drawing.Size(36, 16);
            this.lblPHP.TabIndex = 57;
            this.lblPHP.Text = "PHP";
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblPrice.ForeColor = System.Drawing.Color.Green;
            this.lblPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPrice.Location = new System.Drawing.Point(568, 34);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(117, 16);
            this.lblPrice.TabIndex = 56;
            this.lblPrice.Text = "0.00";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPriceTitle
            // 
            this.lblPriceTitle.AutoSize = true;
            this.lblPriceTitle.BackColor = System.Drawing.Color.White;
            this.lblPriceTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblPriceTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblPriceTitle.Location = new System.Drawing.Point(639, 14);
            this.lblPriceTitle.Name = "lblPriceTitle";
            this.lblPriceTitle.Size = new System.Drawing.Size(80, 16);
            this.lblPriceTitle.TabIndex = 55;
            this.lblPriceTitle.Text = "Total Price";
            // 
            // lblQuantityValue
            // 
            this.lblQuantityValue.AutoSize = true;
            this.lblQuantityValue.BackColor = System.Drawing.Color.White;
            this.lblQuantityValue.BackgroundColor = System.Drawing.Color.White;
            this.lblQuantityValue.BorderColor = System.Drawing.Color.Transparent;
            this.lblQuantityValue.BorderRadius = 0;
            this.lblQuantityValue.BorderSize = 0;
            this.lblQuantityValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblQuantityValue.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblQuantityValue.ForeColor = System.Drawing.Color.Black;
            this.lblQuantityValue.Location = new System.Drawing.Point(227, 112);
            this.lblQuantityValue.Name = "lblQuantityValue";
            this.lblQuantityValue.Size = new System.Drawing.Size(15, 16);
            this.lblQuantityValue.TabIndex = 54;
            this.lblQuantityValue.Text = "0";
            this.lblQuantityValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQuantityValue.TextColor = System.Drawing.Color.Black;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.BackColor = System.Drawing.Color.White;
            this.lblUnitPrice.BackgroundColor = System.Drawing.Color.White;
            this.lblUnitPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblUnitPrice.BorderRadius = 15;
            this.lblUnitPrice.BorderSize = 2;
            this.lblUnitPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUnitPrice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.lblUnitPrice.ForeColor = System.Drawing.Color.Black;
            this.lblUnitPrice.Location = new System.Drawing.Point(235, 45);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(111, 37);
            this.lblUnitPrice.TabIndex = 53;
            this.lblUnitPrice.Text = "0.00";
            this.lblUnitPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUnitPrice.TextColor = System.Drawing.Color.Black;
            // 
            // cbProductID
            // 
            this.cbProductID.BackColor = System.Drawing.Color.White;
            this.cbProductID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.cbProductID.BorderRadius = 0;
            this.cbProductID.BorderSize = 1;
            this.cbProductID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbProductID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.cbProductID.ForeColor = System.Drawing.Color.DimGray;
            this.cbProductID.IconColor = System.Drawing.Color.Navy;
            this.cbProductID.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbProductID.ListTextColor = System.Drawing.Color.DimGray;
            this.cbProductID.Location = new System.Drawing.Point(29, 45);
            this.cbProductID.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbProductID.Name = "cbProductID";
            this.cbProductID.Padding = new System.Windows.Forms.Padding(1);
            this.cbProductID.Size = new System.Drawing.Size(200, 37);
            this.cbProductID.TabIndex = 51;
            this.cbProductID.Texts = "";
            this.cbProductID.OnSelectedIndexChanged += new System.EventHandler(this.cbProductID_OnSelectedIndexChanged_1);
            this.cbProductID.Load += new System.EventHandler(this.cbProductID_Load);
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblProductID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblProductID.Location = new System.Drawing.Point(26, 24);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(97, 16);
            this.lblProductID.TabIndex = 50;
            this.lblProductID.Text = "Item Batch ID";
            // 
            // cbStatus
            // 
            this.cbStatus.BackColor = System.Drawing.Color.White;
            this.cbStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.cbStatus.BorderRadius = 0;
            this.cbStatus.BorderSize = 1;
            this.cbStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F);
            this.cbStatus.ForeColor = System.Drawing.Color.DimGray;
            this.cbStatus.IconColor = System.Drawing.Color.Navy;
            this.cbStatus.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cbStatus.ListTextColor = System.Drawing.Color.DimGray;
            this.cbStatus.Location = new System.Drawing.Point(29, 161);
            this.cbStatus.MinimumSize = new System.Drawing.Size(200, 30);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Padding = new System.Windows.Forms.Padding(1);
            this.cbStatus.Size = new System.Drawing.Size(250, 37);
            this.cbStatus.TabIndex = 49;
            this.cbStatus.Texts = "";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblQuantity.Location = new System.Drawing.Point(26, 85);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(64, 16);
            this.lblQuantity.TabIndex = 48;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.lblStatus.Location = new System.Drawing.Point(26, 142);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 16);
            this.lblStatus.TabIndex = 47;
            this.lblStatus.Text = "Status";
            // 
            // tbQuantity
            // 
            this.tbQuantity.BackColor = System.Drawing.Color.White;
            this.tbQuantity.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.tbQuantity.Location = new System.Drawing.Point(29, 110);
            this.tbQuantity.Maximum = 60;
            this.tbQuantity.Minimum = 1;
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(200, 45);
            this.tbQuantity.TabIndex = 52;
            this.tbQuantity.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbQuantity.Value = 1;
            this.tbQuantity.Scroll += new System.EventHandler(this.tbQuantity_Scroll_1);
            this.tbQuantity.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tbQuantity_MouseMove);
            // 
            // ItemTab
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabPanel);
            this.Name = "ItemTab";
            this.Size = new System.Drawing.Size(746, 311);
            this.Load += new System.EventHandler(this.ItemTab_Load);
            this.tabPanel.ResumeLayout(false);
            this.tabPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Materials.CustomPanel tabPanel;
        private System.Windows.Forms.Label lblPHP;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPriceTitle;
        private Materials.CustomLabel lblQuantityValue;
        private Materials.CustomLabel lblUnitPrice;
        private Materials.CustomComboBox cbProductID;
        private System.Windows.Forms.Label lblProductID;
        private Materials.CustomComboBox cbStatus;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TrackBar tbQuantity;
    }
}
