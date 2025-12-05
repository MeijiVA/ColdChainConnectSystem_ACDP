using ColdChainConnectSystem_ACDP.AppForms.MainPanel.Inventory;
using ColdChainConnectSystem_ACDP.ClassResources;
using ColdChainConnectSystem_ACDP.ClassResources.Connection;
using ColdChainConnectSystem_ACDP.ClassResources.Connection.TableView;
using ColdChainConnectSystem_ACDP.ClassResources.CustomControls;
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

namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Customer
{
    public partial class CustomerForm : Form
    {
        int currentPageIndex = 0;
        public int totalPages = 0;
        public CustomerForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Apply to the form
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            if (ConnectionClass.position != "Administrator")
            {
                dgvTable.Columns.Remove("deleteCol");
                dgvTable.Columns["editCol"].DefaultCellStyle.Padding = new Padding(12, 0, 13, 0);
                dgvTable.Columns["editCol"].Width = 37;
                dgvTable.Columns["viewCol"].DefaultCellStyle.Padding = new Padding(12, 0, 13, 0);
                dgvTable.Columns["viewCol"].Width = 38;
            }
            currentPageIndex = 1;//!!!!!!!!!!!!!!!!!!!
            SelectedFilterClass.SelectedFilter = "";
            dgvTable.Rows.Clear();
            totalPages = CustomerClass.loadCustomerData(dgvTable, lblMaxPage, lblPageNum, currentPageIndex);
            // Subscribe to real-time search event
            SearchBar.SearchTextChanged += SearchBar_SearchTextChanged;
            // Set custom header cell for checkbox column
            if (dgvTable.Columns["rowCbox"] != null)
            {
                dgvTable.Columns["rowCbox"].HeaderCell = new CheckBoxHeaderCell();
            }
        }

        private void SearchBar_SearchTextChanged(object sender, EventArgs e)
        {
            // Real-time search - update table as user types
            UpdateTable();
        }
        private void searchUC1_Load(object sender, EventArgs e)
        {
            currentPageIndex = 1;//!!!!!!!!!!!!!!!!!!!
            totalPages = CustomerClass.loadCustomerData(dgvTable, lblMaxPage, lblPageNum, currentPageIndex);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if ((SearchBar.txtSearch.Text.Equals("Search Term") || SearchBar.txtSearch.Text.Equals("")) && (currentPageIndex < totalPages) || (SelectedFilterClass.SelectedFilter.Equals("") && (currentPageIndex < totalPages)))
            {
                dgvTable.Rows.Clear();
                lblPageNum.Text = (currentPageIndex += 1).ToString();
                totalPages = CustomerClass.loadCustomerData(dgvTable, lblMaxPage, lblPageNum, currentPageIndex);
            }//no search query
            else if ((currentPageIndex < Convert.ToInt32(totalPages)) && !(SelectedFilterClass.SelectedFilter.Equals("")))
            {
                dgvTable.Rows.Clear();
                lblPageNum.Text = (currentPageIndex += 1).ToString();
                // Sanitize search input to prevent SQL injection
                string sanitizedSearch = SanitizeLikeInput(SearchBar.searchTXT);
                string query = "WHERE " + SelectedFilterClass.SelectedFilter + " LIKE '%" + sanitizedSearch + "%' ";
                totalPages = CustomerClass.loadCustomerData(dgvTable, lblMaxPage, lblPageNum, currentPageIndex, query);
            }//has search query
            else if (currentPageIndex < totalPages)
            {
                dgvTable.Rows.Clear();
                lblPageNum.Text = (currentPageIndex += 1).ToString();
                // Sanitize search input to prevent SQL injection
                string sanitizedSearch = SanitizeLikeInput(SearchBar.searchTXT);
                string query = $"WHERE [numid] LIKE '%{sanitizedSearch}%' OR [CustomerID] LIKE '%{sanitizedSearch}%' OR [CustomerName] LIKE '%{sanitizedSearch}%' OR [PhoneNumber] LIKE '%{sanitizedSearch}%' OR [Address] LIKE '%{sanitizedSearch}%' OR [PaymentTerm] LIKE '%{sanitizedSearch}%' OR [RegistrationDate] LIKE '%{sanitizedSearch}%' OR [Status] LIKE '%{sanitizedSearch}%'   ";
                totalPages = CustomerClass.loadCustomerData(dgvTable, lblMaxPage, lblPageNum, currentPageIndex, query);
            }// has search query ALL
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if ((SearchBar.txtSearch.Text.Equals("Search Term") || SearchBar.txtSearch.Text.Equals("")) && (currentPageIndex > 1) || (SelectedFilterClass.SelectedFilter.Equals("") && (currentPageIndex > 1)))
            {
                dgvTable.Rows.Clear();
                lblPageNum.Text = (currentPageIndex -= 1).ToString();
                totalPages = CustomerClass.loadCustomerData(dgvTable, lblMaxPage, lblPageNum, currentPageIndex);
            }//no search query
            else if ((currentPageIndex > 1) && !(SelectedFilterClass.SelectedFilter.Equals("")))
            {
                dgvTable.Rows.Clear();
                lblPageNum.Text = (currentPageIndex -= 1).ToString();
                // Sanitize search input to prevent SQL injection
                string sanitizedSearch = SanitizeLikeInput(SearchBar.searchTXT);
                string query = "WHERE " + SelectedFilterClass.SelectedFilter + " LIKE '%" + sanitizedSearch + "%' ";
                totalPages = CustomerClass.loadCustomerData(dgvTable, lblMaxPage, lblPageNum, currentPageIndex, query);
            }//has search query
            else if (currentPageIndex > 1)
            {
                dgvTable.Rows.Clear();
                lblPageNum.Text = (currentPageIndex -= 1).ToString();
                // Sanitize search input to prevent SQL injection
                string sanitizedSearch = SanitizeLikeInput(SearchBar.searchTXT);
                string query = $"WHERE [numid] LIKE '%{sanitizedSearch}%' OR [CustomerID] LIKE '%{sanitizedSearch}%' OR [CustomerName] LIKE '%{sanitizedSearch}%' OR [PhoneNumber] LIKE '%{sanitizedSearch}%' OR [Address] LIKE '%{sanitizedSearch}%' OR [PaymentTerm] LIKE '%{sanitizedSearch}%' OR [RegistrationDate] LIKE '%{sanitizedSearch}%' OR [Status] LIKE '%{sanitizedSearch}%'  ";
                totalPages = CustomerClass.loadCustomerData(dgvTable, lblMaxPage, lblPageNum, currentPageIndex, query);
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
                    totalPages = CustomerClass.loadCustomerData(dgvTable, lblMaxPage, lblPageNum, currentPageIndex);

                }
                else if (SelectedFilterClass.SelectedFilter.Equals(""))
                {
                    lblPageNum.Text = "1";
                    currentPageIndex = 1;//!!!!!!!!!!!!!!!!!!!
                    dgvTable.Rows.Clear();
                    // Sanitize search input to prevent SQL injection
                    string sanitizedSearch = SanitizeLikeInput(SearchBar.searchTXT);
                    string query = $"WHERE [numid] LIKE '%{sanitizedSearch}%' OR [CustomerID] LIKE '%{sanitizedSearch}%' OR [CustomerName] LIKE '%{sanitizedSearch}%' OR [PhoneNumber] LIKE '%{sanitizedSearch}%' OR [Address] LIKE '%{sanitizedSearch}%' OR [PaymentTerm] LIKE '%{sanitizedSearch}%' OR [RegistrationDate] LIKE '%{sanitizedSearch}%' OR [Status] LIKE '%{sanitizedSearch}%'";
                    totalPages = CustomerClass.loadCustomerData(dgvTable, lblMaxPage, lblPageNum, currentPageIndex, query);
                }
                else
                {
                    lblPageNum.Text = "1";
                    currentPageIndex = 1;//!!!!!!!!!!!!!!!!!!!
                    dgvTable.Rows.Clear();
                    string query = " WHERE " + SelectedFilterClass.SelectedFilter + " LIKE '%" + SearchBar.searchTXT + "%' ";
                    totalPages = CustomerClass.loadCustomerData(dgvTable, lblMaxPage, lblPageNum, currentPageIndex, query);
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
            // Add status indicator for customer status column
            if (dgvTable.Columns[e.ColumnIndex].Name == "status" && e.RowIndex >= 0)
            {
                if (dgvTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    string status = dgvTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().ToLower();
                    if (status == "active")
                    {
                        // green
                        e.CellStyle.BackColor = Color.FromArgb(200, 255, 200);
                        e.CellStyle.ForeColor = Color.FromArgb(107, 188, 59);
                    }
                    else if (status == "inactive")
                    {
                        // red
                        e.CellStyle.BackColor = Color.FromArgb(255, 200, 200);
                        e.CellStyle.ForeColor = Color.FromArgb(255, 27, 20);
                    }
                }
            }


            if (dgvTable.Columns[e.ColumnIndex].Name == "editCol" && e.RowIndex >= 0)
            {
                if (dgvTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    e.CellStyle.BackColor = Color.FromArgb(215, 215, 230);
                }
            }

            if (dgvTable.Columns[e.ColumnIndex].Name == "viewCol" && e.RowIndex >= 0)
            {
                if (dgvTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    e.CellStyle.BackColor = Color.FromArgb(215, 215, 230);
                }
            }

            if (dgvTable.Columns[e.ColumnIndex].Name == "deleteCol" && e.RowIndex >= 0)
            {
                if (dgvTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    e.CellStyle.BackColor = Color.FromArgb(215, 215, 230);
                }
            }
        }

        private void dgvTable_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            String cellValue = Convert.ToString(dgvTable.Rows[e.RowIndex].Cells["numid"].FormattedValue);

            if (dgvTable.Columns[e.ColumnIndex].Name == "deleteCol")
            {
                // Check if any rows are selected via checkboxes
                List<string> selectedIds = new List<string>();
                foreach (DataGridViewRow row in dgvTable.Rows)
                {
                    if (row.Cells["rowCbox"].Value != null && (bool)row.Cells["rowCbox"].Value)
                    {
                        string id = row.Cells["numid"].Value?.ToString();
                        if (!string.IsNullOrEmpty(id))
                        {
                            selectedIds.Add(id);
                        }
                    }
                }

                if (selectedIds.Count > 0)
                {
                    // Delete all selected rows
                    if (new CustomMessageBox("Delete Rows", $"Are you sure you want to delete {selectedIds.Count} item(s) from the Database?", MessageBoxButtons.OKCancel).ShowDialog() == DialogResult.OK)
                    {
                        foreach (string id in selectedIds)
                        {
                            DeleteItem.Delete(id, "Customer");
                        }
                        UpdateTable();
                    }
                }
                else
                {
                    // Delete single row
                    if (new CustomMessageBox("Delete Row", "Are you sure you want to delete this item from the Database?", MessageBoxButtons.OKCancel).ShowDialog() == DialogResult.OK)
                    {
                        DeleteItem.Delete(cellValue, "Customer");
                        UpdateTable();
                    }
                }
            }
            if (dgvTable.Columns[e.ColumnIndex].Name == "editCol")
            {
                VarView.id = cellValue;
                EditCustomer ec = new EditCustomer();
                ec.Show(this);
            }
            if (dgvTable.Columns[e.ColumnIndex].Name == "viewCol")
            {
                VarView.id = cellValue;
                ViewCustomer vc = new ViewCustomer();
                vc.Show();
            }
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

        private void dgvTable_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvTable.IsCurrentCellDirty)
            {
                dgvTable.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0) // rowCbox column
            {
                UpdateHeaderCheckbox();
            }
        }

        private void dgvTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle header checkbox click for select all
            if (e.RowIndex == -1 && e.ColumnIndex == 0)
            {
                bool allChecked = true;
                foreach (DataGridViewRow row in dgvTable.Rows)
                {
                    if (row.Cells[0].Value == null || !(bool)row.Cells[0].Value)
                    {
                        allChecked = false;
                        break;
                    }
                }

                foreach (DataGridViewRow row in dgvTable.Rows)
                {
                    row.Cells[0].Value = !allChecked;
                }
                dgvTable.RefreshEdit();
            }
        }

        private void UpdateHeaderCheckbox()
        {
            if (dgvTable.Rows.Count == 0) return;

            bool allChecked = true;
            foreach (DataGridViewRow row in dgvTable.Rows)
            {
                if (row.Cells[0].Value == null || !(bool)row.Cells[0].Value)
                {
                    allChecked = false;
                    break;
                }
            }

            // Update custom header cell checkbox state
            if (dgvTable.Columns["rowCbox"]?.HeaderCell is CheckBoxHeaderCell headerCell)
            {
                headerCell.UpdateCheckState(allChecked);
            }
        }

        private void actionlbl_Click(object sender, EventArgs e)
        {

        }
    }
}
