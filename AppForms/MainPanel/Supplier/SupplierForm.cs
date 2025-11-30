using ColdChainConnectSystem_ACDP.AppForms.MainPanel.Inventory;
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

namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Supplier
{
    public partial class SupplierForm : Form
    {
        int currentPageIndex = 0;
        public int totalPages = 0;
        public SupplierForm()
        {
            InitializeComponent();
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            currentPageIndex = 1;//!!!!!!!!!!!!!!!!!!!
            SelectedFilterClass.SelectedFilter = "";
            dgvTable.Rows.Clear();
            totalPages = SupplierClass.loadSupplierData(dgvTable, lblMaxPage, lblPageNum, currentPageIndex);
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
            totalPages = SupplierClass.loadSupplierData(dgvTable, lblMaxPage, lblPageNum, currentPageIndex);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if ((SearchBar.txtSearch.Text.Equals("Search Term") || SearchBar.txtSearch.Text.Equals("")) && (currentPageIndex < totalPages) || (SelectedFilterClass.SelectedFilter.Equals("") && (currentPageIndex < totalPages)))
            {
                dgvTable.Rows.Clear();
                lblPageNum.Text = (currentPageIndex += 1).ToString();
                totalPages = SupplierClass.loadSupplierData(dgvTable, lblMaxPage, lblPageNum, currentPageIndex);
            }//no search query
            else if ((currentPageIndex < Convert.ToInt32(totalPages)) && !(SelectedFilterClass.SelectedFilter.Equals("")))
            {
                dgvTable.Rows.Clear();
                lblPageNum.Text = (currentPageIndex += 1).ToString();
                // Sanitize search input to prevent SQL injection
                string sanitizedSearch = SanitizeLikeInput(SearchBar.searchTXT);
                string query = "WHERE " + SelectedFilterClass.SelectedFilter + " LIKE '%" + sanitizedSearch + "%' ";
                totalPages = SupplierClass.loadSupplierData(dgvTable, lblMaxPage, lblPageNum, currentPageIndex, query);
            }//has search query
            else if (currentPageIndex < totalPages)
            {
                //[supplierid],[companyname],[contactperson],[contactnum],[address],[paymentterm]
                dgvTable.Rows.Clear();
                lblPageNum.Text = (currentPageIndex += 1).ToString();
                // Sanitize search input to prevent SQL injection
                string sanitizedSearch = SanitizeLikeInput(SearchBar.searchTXT);
                string query = $"WHERE supplierid LIKE '%{sanitizedSearch}%' OR companyname LIKE '%{sanitizedSearch}%' OR contactperson LIKE '%{sanitizedSearch}%' OR contactnum LIKE '%{sanitizedSearch}%' OR address LIKE '%{sanitizedSearch}%' OR paymentterm  LIKE '%{sanitizedSearch}%'";
                totalPages = SupplierClass.loadSupplierData(dgvTable, lblMaxPage, lblPageNum, currentPageIndex, query);
            }// has search query ALL
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if ((SearchBar.txtSearch.Text.Equals("Search Term") || SearchBar.txtSearch.Text.Equals("")) && (currentPageIndex > 1) || (SelectedFilterClass.SelectedFilter.Equals("") && (currentPageIndex > 1)))
            {
                dgvTable.Rows.Clear();
                lblPageNum.Text = (currentPageIndex -= 1).ToString();
                totalPages = SupplierClass.loadSupplierData(dgvTable, lblMaxPage, lblPageNum, currentPageIndex);
            }//no search query
            else if ((currentPageIndex > 1) && !(SelectedFilterClass.SelectedFilter.Equals("")))
            {
                dgvTable.Rows.Clear();
                lblPageNum.Text = (currentPageIndex -= 1).ToString();
                // Sanitize search input to prevent SQL injection
                string sanitizedSearch = SanitizeLikeInput(SearchBar.searchTXT);
                string query = "WHERE " + SelectedFilterClass.SelectedFilter + " LIKE '%" + sanitizedSearch + "%' ";
                totalPages = SupplierClass.loadSupplierData(dgvTable, lblMaxPage, lblPageNum, currentPageIndex, query);
            }//has search query
            else if (currentPageIndex > 1)
            {
                dgvTable.Rows.Clear();
                lblPageNum.Text = (currentPageIndex -= 1).ToString();
                // Sanitize search input to prevent SQL injection
                string sanitizedSearch = SanitizeLikeInput(SearchBar.searchTXT);
                string query = $"WHERE supplierid LIKE '%{sanitizedSearch}%' OR companyname LIKE '%{sanitizedSearch}%' OR contactperson LIKE '%{sanitizedSearch}%' OR contactnum LIKE '%{sanitizedSearch}%' OR address LIKE '%{sanitizedSearch}%' OR paymentterm  LIKE '%{sanitizedSearch}%'";
                totalPages = SupplierClass.loadSupplierData(dgvTable, lblMaxPage, lblPageNum, currentPageIndex, query);
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
                    totalPages = SupplierClass.loadSupplierData(dgvTable, lblMaxPage, lblPageNum, currentPageIndex);

                }
                else if (SelectedFilterClass.SelectedFilter.Equals(""))
                {
                    lblPageNum.Text = "1";
                    currentPageIndex = 1;//!!!!!!!!!!!!!!!!!!!
                    dgvTable.Rows.Clear();
                    // Sanitize search input to prevent SQL injection
                    string sanitizedSearch = SanitizeLikeInput(SearchBar.searchTXT);
                    string query = $"WHERE supplierid LIKE '%{sanitizedSearch}%' OR companyname LIKE '%{sanitizedSearch}%' OR contactperson LIKE '%{sanitizedSearch}%' OR contactnum LIKE '%{sanitizedSearch}%' OR address LIKE '%{sanitizedSearch}%' OR paymentterm  LIKE '%{sanitizedSearch}%'";
                    totalPages = SupplierClass.loadSupplierData(dgvTable, lblMaxPage, lblPageNum, currentPageIndex, query);
                }
                else
                {
                    lblPageNum.Text = "1";
                    currentPageIndex = 1;//!!!!!!!!!!!!!!!!!!!
                    dgvTable.Rows.Clear();
                    string query = " WHERE " + SelectedFilterClass.SelectedFilter + " LIKE '%" + SearchBar.searchTXT + "%' ";
                    totalPages = SupplierClass.loadSupplierData(dgvTable, lblMaxPage, lblPageNum, currentPageIndex, query);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dgvTable_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (Pen p = new Pen(Color.FromArgb(07, 07, 96), 2)) // Define pen for the line
            {
                // Calculate the position for the line
                int y = e.RowBounds.Bottom - 1;
                e.Graphics.DrawLine(p, e.RowBounds.Left + 10, y, e.RowBounds.Right - 10, y);
            }
        }

        private void dgvTable_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            String cellValue = Convert.ToString(dgvTable.Rows[e.RowIndex].Cells["numid"].FormattedValue);
            if (dgvTable.Columns[e.ColumnIndex].Name == "deleteCol")
            {
                if (new CustomMessageBox("Delete Row", "Are you sure you want to delete this item from the Database?", MessageBoxButtons.OKCancel).ShowDialog() == DialogResult.OK)
                {
                    DeleteItem.Delete(cellValue, "Supplier");
                    UpdateTable();

                }
            }
            if (dgvTable.Columns[e.ColumnIndex].Name == "editCol")
            {
                VarView.id = cellValue;
                EditSupplier es = new EditSupplier();
                es.Show(this);
            }
            if (dgvTable.Columns[e.ColumnIndex].Name == "viewCol")
            {
                VarView.id = cellValue;
                ViewSupplier vs = new ViewSupplier();
                vs.Show(this);
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

        private void actionlbl_Click(object sender, EventArgs e)
        {

        }
    }
}
