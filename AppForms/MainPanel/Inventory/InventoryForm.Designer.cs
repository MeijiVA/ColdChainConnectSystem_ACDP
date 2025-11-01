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
            this.searchUC1 = new ColdChainConnectSystem_ACDP.AppForms.MainPanel.Inventory.SearchUC();
            this.displayTableUC1 = new ColdChainConnectSystem_ACDP.AppForms.MainPanel.Inventory.DisplayTableUC();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblOf = new System.Windows.Forms.Label();
            this.lblMaxPage = new System.Windows.Forms.Label();
            this.lblPageNum = new ColdChainConnectSystem_ACDP.Materials.CustomLabel();
            this.lblPage = new System.Windows.Forms.Label();
            this.customButton2 = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            this.customButton1 = new ColdChainConnectSystem_ACDP.Materials.CustomButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchUC1
            // 
            this.searchUC1.BackColor = System.Drawing.Color.Transparent;
            this.searchUC1.Location = new System.Drawing.Point(22, 12);
            this.searchUC1.Name = "searchUC1";
            this.searchUC1.Size = new System.Drawing.Size(755, 65);
            this.searchUC1.TabIndex = 0;
            this.searchUC1.Load += new System.EventHandler(this.searchUC1_Load);
            // 
            // displayTableUC1
            // 
            this.displayTableUC1.BackColor = System.Drawing.Color.White;
            this.displayTableUC1.Location = new System.Drawing.Point(22, 81);
            this.displayTableUC1.Name = "displayTableUC1";
            this.displayTableUC1.Size = new System.Drawing.Size(755, 442);
            this.displayTableUC1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblOf);
            this.panel1.Controls.Add(this.lblMaxPage);
            this.panel1.Controls.Add(this.lblPageNum);
            this.panel1.Controls.Add(this.lblPage);
            this.panel1.Controls.Add(this.customButton2);
            this.panel1.Controls.Add(this.customButton1);
            this.panel1.Controls.Add(this.label1);
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
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(96)))));
            this.customButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.customButton2.BorderRadius = 10;
            this.customButton2.BorderSize = 0;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Location = new System.Drawing.Point(571, 2);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(46, 30);
            this.customButton2.TabIndex = 2;
            this.customButton2.Text = "Next";
            this.customButton2.TextColor = System.Drawing.Color.White;
            this.customButton2.UseVisualStyleBackColor = false;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.White;
            this.customButton1.BackgroundColor = System.Drawing.Color.White;
            this.customButton1.BorderColor = System.Drawing.Color.DimGray;
            this.customButton1.BorderRadius = 10;
            this.customButton1.BorderSize = 1;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton1.ForeColor = System.Drawing.Color.Gray;
            this.customButton1.Location = new System.Drawing.Point(519, 1);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(46, 30);
            this.customButton1.TabIndex = 1;
            this.customButton1.Text = "Prev";
            this.customButton1.TextColor = System.Drawing.Color.Gray;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F);
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "legends : ";
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.displayTableUC1);
            this.Controls.Add(this.searchUC1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventoryForm";
            this.Text = "InventoryForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private SearchUC searchUC1;
        private DisplayTableUC displayTableUC1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Materials.CustomButton customButton1;
        private System.Windows.Forms.Label lblPage;
        private Materials.CustomButton customButton2;
        private Materials.CustomLabel lblPageNum;
        private System.Windows.Forms.Label lblOf;
        private System.Windows.Forms.Label lblMaxPage;
    }
}