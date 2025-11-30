using ColdChainConnectSystem_ACDP.AppForms.MainPanel.Customer;
using ColdChainConnectSystem_ACDP.ClassResources;
using ColdChainConnectSystem_ACDP.ClassResources.Connection;
using ColdChainConnectSystem_ACDP.ClassResources.Connection.TableView;
using ColdChainConnectSystem_ACDP.ClassResources.Display;
using ColdChainConnectSystem_ACDP.ClassResources.Instances;
using ColdChainConnectSystem_ACDP.Popup;
using static ColdChainConnectSystem_ACDP.ClassResources.Connection.SqlInjectionPrevention;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.BulkOperations.Internal.InformationSchema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Inventory
{
    public partial class InventoryForm : Form
    {
        int currentPageIndex = 0;
        public int totalPages = 0;
        public InventoryForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Apply to the form
        }
        private void InventoryForm_Load(object sender, EventArgs e)
        {
            currentPageIndex = 1;//!!!!!!!!!!!!!!!!!!!
            SelectedFilterClass.SelectedFilter = "";
            dgvTable.Rows.Clear();
            totalPages = InventoryClass.loadInventoryData(dgvTable, lblMaxPage, lblPageNum, currentPageIndex);
            // Subscribe to real-time search event
            SearchBar.SearchTextChanged += SearchBar_SearchTextChanged;
        }

        private void SearchBar_SearchTextChanged(object sender, EventArgs e)
        {
            // Real-time search - update table as user types
            UpdateTable();
        }
        private void searchUC1_Load(object sender, EventArgs e)
        {
            currentPageIndex = 1;//!!!!!!!!!!!!!!!!!!!
            totalPages = InventoryClass.loadInventoryData(dgvTable, lblMaxPage, lblPageNum, currentPageIndex);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if ((SearchBar.txtSearch.Text.Equals("Search Term") || SearchBar.txtSearch.Text.Equals("")) && (currentPageIndex < totalPages) || (SelectedFilterClass.SelectedFilter.Equals("") && (currentPageIndex < totalPages)))
            {
                dgvTable.Rows.Clear();
                lblPageNum.Text = (currentPageIndex += 1).ToString();
                totalPages = InventoryClass.loadInventoryData(dgvTable, lblMaxPage, lblPageNum, currentPageIndex);
            }//no search query
            else if ((currentPageIndex < Convert.ToInt32(totalPages)) && !(SelectedFilterClass.SelectedFilter.Equals("")))
            {
                dgvTable.Rows.Clear();
                lblPageNum.Text = (currentPageIndex += 1).ToString();
                // Sanitize search input to prevent SQL injection
                string sanitizedSearch = SanitizeLikeInput(SearchBar.searchTXT);
                string query = "WHERE " + SelectedFilterClass.SelectedFilter + " LIKE '%" + sanitizedSearch + "%' ";
                totalPages = InventoryClass.loadInventoryData(dgvTable, lblMaxPage, lblPageNum, currentPageIndex, query);
            }//has search query
            else if (currentPageIndex < totalPages)
            {
                dgvTable.Rows.Clear();
                lblPageNum.Text = (currentPageIndex += 1).ToString();
                // Sanitize search input to prevent SQL injection
                string sanitizedSearch = SanitizeLikeInput(SearchBar.searchTXT);
                string query = $"WHERE [numid] LIKE '%{sanitizedSearch}%' OR [skucode] LIKE '%{sanitizedSearch}%' OR [quantity] LIKE '%{sanitizedSearch}%' OR [expiry] LIKE '%{sanitizedSearch}%' OR [description] LIKE '%{sanitizedSearch}%' OR [SupplierID] LIKE '%{sanitizedSearch}%' ";
                totalPages = InventoryClass.loadInventoryData(dgvTable, lblMaxPage, lblPageNum, currentPageIndex, query);
            }// has search query ALL
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if ((SearchBar.txtSearch.Text.Equals("Search Term") || SearchBar.txtSearch.Text.Equals("")) && (currentPageIndex > 1) || (SelectedFilterClass.SelectedFilter.Equals("") && (currentPageIndex > 1)))
            {
                dgvTable.Rows.Clear();
                lblPageNum.Text = (currentPageIndex -= 1).ToString();
                totalPages = InventoryClass.loadInventoryData(dgvTable, lblMaxPage, lblPageNum, currentPageIndex);
            }//no search query
            else if ((currentPageIndex > 1) && !(SelectedFilterClass.SelectedFilter.Equals("")))
            {
                dgvTable.Rows.Clear();
                lblPageNum.Text = (currentPageIndex -= 1).ToString();
                // Sanitize search input to prevent SQL injection
                string sanitizedSearch = SanitizeLikeInput(SearchBar.searchTXT);
                string query = "WHERE " + SelectedFilterClass.SelectedFilter + " LIKE '%" + sanitizedSearch + "%' ";
                totalPages = InventoryClass.loadInventoryData(dgvTable, lblMaxPage, lblPageNum, currentPageIndex, query);
            }//has search query
            else if (currentPageIndex > 1)
            {
                dgvTable.Rows.Clear();
                lblPageNum.Text = (currentPageIndex -= 1).ToString();
                // Sanitize search input to prevent SQL injection
                string sanitizedSearch = SanitizeLikeInput(SearchBar.searchTXT);
                string query = $"WHERE [numid] LIKE '% {sanitizedSearch} %' OR [skucode] LIKE '% {sanitizedSearch} %' OR [quantity] LIKE '% {sanitizedSearch} %' OR [expiry] LIKE '% {sanitizedSearch} %' OR [description] LIKE '% {sanitizedSearch} %' OR [SupplierID] LIKE '%{sanitizedSearch}%' ";
                totalPages = InventoryClass.loadInventoryData(dgvTable, lblMaxPage, lblPageNum, currentPageIndex, query);
            }// has search query ALL
        }


        private void btnCheck_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }

        public void UpdateTable()
        {
            try
            {
                if ((SearchBar.txtSearch.Text.Equals("Search Term") || SearchBar.txtSearch.Text.Equals("")))
                {
                    lblPageNum.Text = "1";
                    currentPageIndex = 1;//!!!!!!!!!!!!!!!!!!!
                    dgvTable.Rows.Clear();
                    totalPages = InventoryClass.loadInventoryData(dgvTable, lblMaxPage, lblPageNum, currentPageIndex);

                }
                else if (SelectedFilterClass.SelectedFilter.Equals(""))
                {
                    lblPageNum.Text = "1";
                    currentPageIndex = 1;//!!!!!!!!!!!!!!!!!!!
                    dgvTable.Rows.Clear();
                    // Sanitize search input to prevent SQL injection
                    string sanitizedSearch = SanitizeLikeInput(SearchBar.searchTXT);
                    string query = $"WHERE [numid] LIKE '%{sanitizedSearch}%' OR [skucode] LIKE '%{sanitizedSearch}%' OR [quantity] LIKE '%{sanitizedSearch}%' OR [expiry] LIKE '%{sanitizedSearch}%' OR [description] LIKE '%{sanitizedSearch}%' OR [SupplierID] LIKE '%{sanitizedSearch}%' ";
                    totalPages = InventoryClass.loadInventoryData(dgvTable, lblMaxPage, lblPageNum, currentPageIndex, query);
                }
                else
                {
                    lblPageNum.Text = "1";
                    currentPageIndex = 1;//!!!!!!!!!!!!!!!!!!!
                    dgvTable.Rows.Clear();
                    // Sanitize search input to prevent SQL injection
                    string sanitizedSearch = SanitizeLikeInput(SearchBar.searchTXT);
                    string query = " WHERE " + SelectedFilterClass.SelectedFilter + " LIKE '%" + sanitizedSearch + "%' ";
                    totalPages = InventoryClass.loadInventoryData(dgvTable, lblMaxPage, lblPageNum, currentPageIndex, query);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvTable_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (Pen p = new Pen(Color.FromArgb(07, 07, 96), 2)) // Define pen for the line
            {
                // Calculate the position for the line
                int y = e.RowBounds.Bottom - 1;
                e.Graphics.DrawLine(p, e.RowBounds.Left + 10, y, e.RowBounds.Right - 10, y);
            }
        }

        private void dgvTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Add light indicator for quantity column
            if (dgvTable.Columns[e.ColumnIndex].Name == "quant" && e.RowIndex >= 0)
            {
                if (dgvTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    string quantityStr = dgvTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    if (int.TryParse(quantityStr, out int quantity))
                    {
                        if (quantity <= 50)
                        {
                            // Red for low stock
                            e.CellStyle.BackColor = Color.FromArgb(255, 200, 200);
                            e.CellStyle.ForeColor = Color.FromArgb(255, 27, 20);
                        }
                        else if (quantity >= 51 && quantity <= 100)
                        {
                            // Yellow for medium stock
                            e.CellStyle.BackColor = Color.FromArgb(255, 255, 200);
                            e.CellStyle.ForeColor = Color.FromArgb(230, 230, 10);
                        }
                        else if (quantity >= 101)
                        {
                            // Green for sufficient stock
                            e.CellStyle.BackColor = Color.FromArgb(200, 255, 200);
                            e.CellStyle.ForeColor = Color.FromArgb(107, 188, 59);
                        }
                    }
                }
            }
        }

        private void dgvTable_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            String cellValue = Convert.ToString(dgvTable.Rows[e.RowIndex].Cells["numid"].FormattedValue);
            if (dgvTable.Columns[e.ColumnIndex].Name == "deleteCol")
            {
                if (new CustomMessageBox("Delete Row", "Are you sure you want to delete this item from the Database?", MessageBoxButtons.OKCancel).ShowDialog() == DialogResult.OK)
                {
                    DeleteItem.Delete(cellValue, "Inventory");
                    UpdateTable();

                }
            }
            if (dgvTable.Columns[e.ColumnIndex].Name == "editCol")
            {
                VarView.id = cellValue;
                EditItemInventory ei = new EditItemInventory();
                ei.Show(this);
            }
            if (dgvTable.Columns[e.ColumnIndex].Name == "viewCol")
            {
                VarView.id = cellValue;
                ViewItemInventory vi = new ViewItemInventory();
                vi.Show(this);
            }
            if (dgvTable.Columns[e.ColumnIndex].Name == "img")
            {
                // Show image viewer
                if (dgvTable.Rows[e.RowIndex].Cells["img"].Value != null)
                {
                    ImageViewerForm imageViewer = new ImageViewerForm();
                    imageViewer.SetImage((Image)dgvTable.Rows[e.RowIndex].Cells["img"].Value);
                    imageViewer.ShowDialog();
                }
            }
        }

        private void lblLegends_MouseHover(object sender, EventArgs e)
        {
            uc.Visible = true;
        }


        private void lblLegends_MouseLeave(object sender, EventArgs e)
        {
            uc.Visible = false;
        }

        private void dgvTable_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = dgvTable.Columns[e.ColumnIndex].Name;
                if (columnName == "deleteCol" || columnName == "editCol" || columnName == "viewCol")
                {
                    dgvTable.Cursor = Cursors.Hand;
                }
                else
                {
                    dgvTable.Cursor = Cursors.Default;
                }
            }
        }

        private void dgvTable_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dgvTable.Cursor = Cursors.Default;
        }
    }
}
