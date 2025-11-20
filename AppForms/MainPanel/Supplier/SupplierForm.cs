using ColdChainConnectSystem_ACDP.ClassResources;
using ColdChainConnectSystem_ACDP.ClassResources.Connection;
using ColdChainConnectSystem_ACDP.ClassResources.Display;
using ColdChainConnectSystem_ACDP.ClassResources.Display.Tables;
using ColdChainConnectSystem_ACDP.Popup;
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
        public int totalPages = 0 ;
        public SupplierForm()
        {
            InitializeComponent();
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            currentPageIndex = 1;//!!!!!!!!!!!!!!!!!!!
            SelectedFilterClass.SelectedFilter = "";
            dgvTable.Rows.Clear();
            totalPages = SalesClass.loadInventoryData(dgvTable, lblMaxPage, lblPageNum, currentPageIndex);
        }
        private void searchUC1_Load(object sender, EventArgs e)
        {
            currentPageIndex = 1;//!!!!!!!!!!!!!!!!!!!
            totalPages = SalesClass.loadInventoryData(dgvTable, lblMaxPage, lblPageNum, currentPageIndex);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if ((SearchBar.txtSearch.Text.Equals("Search Term") || SearchBar.txtSearch.Text.Equals("")) && (currentPageIndex < totalPages) || (SelectedFilterClass.SelectedFilter.Equals("") && (currentPageIndex < totalPages)))
            {
                dgvTable.Rows.Clear();
                lblPageNum.Text = (currentPageIndex += 1).ToString();
                totalPages = SalesClass.loadInventoryData(dgvTable, lblMaxPage, lblPageNum, currentPageIndex);
            }//no search query
            else if ((currentPageIndex < Convert.ToInt32(totalPages)) && !(SelectedFilterClass.SelectedFilter.Equals("")))
            {
                dgvTable.Rows.Clear();
                lblPageNum.Text = (currentPageIndex += 1).ToString();
                string query = "WHERE " + SelectedFilterClass.SelectedFilter + " LIKE '%" + SearchBar.searchTXT + "%' ";
                totalPages = SalesClass.loadInventoryData(dgvTable, lblMaxPage, lblPageNum, currentPageIndex, query);
            }//has search query
            else if (currentPageIndex < totalPages)
            {
                dgvTable.Rows.Clear();
                lblPageNum.Text = (currentPageIndex += 1).ToString();
                string query = $"WHERE numid LIKE '%{(SearchBar.searchTXT)}%' OR skucode LIKE '%{(SearchBar.searchTXT)}%' OR quantity LIKE '%{(SearchBar.searchTXT)}%' OR expiry LIKE '%{(SearchBar.searchTXT)}%' OR descript LIKE '%{(SearchBar.searchTXT)}%' OR ";
                totalPages = SalesClass.loadInventoryData(dgvTable, lblMaxPage, lblPageNum, currentPageIndex, query);
            }// has search query ALL
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if ((SearchBar.txtSearch.Text.Equals("Search Term") || SearchBar.txtSearch.Text.Equals("")) && (currentPageIndex  > 1) || (SelectedFilterClass.SelectedFilter.Equals("") && (currentPageIndex > 1)))
            {
                dgvTable.Rows.Clear();
                lblPageNum.Text = (currentPageIndex -= 1).ToString();
                totalPages = SalesClass.loadInventoryData(dgvTable, lblMaxPage, lblPageNum, currentPageIndex);
            }//no search query
            else if ((currentPageIndex > 1) && !(SelectedFilterClass.SelectedFilter.Equals("")))
            {
                dgvTable.Rows.Clear();
                lblPageNum.Text = (currentPageIndex -= 1).ToString();
                string query = "WHERE " + SelectedFilterClass.SelectedFilter + " LIKE '%" + SearchBar.searchTXT + "%' ";
                totalPages = SalesClass.loadInventoryData(dgvTable, lblMaxPage, lblPageNum, currentPageIndex, query);
            }//has search query
            else if (currentPageIndex > 1)
            {
                dgvTable.Rows.Clear();
                lblPageNum.Text = (currentPageIndex -= 1).ToString();
                string query = $"WHERE numid LIKE '%{(SearchBar.searchTXT)}%' OR skucode LIKE '%{(SearchBar.searchTXT)}%' OR quantity LIKE '%{(SearchBar.searchTXT)}%' OR expiry LIKE '%{(SearchBar.searchTXT)}%' OR descript LIKE '%{(SearchBar.searchTXT)}%'";
                totalPages = SalesClass.loadInventoryData(dgvTable, lblMaxPage, lblPageNum, currentPageIndex, query);
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
                    totalPages = SalesClass.loadInventoryData(dgvTable, lblMaxPage, lblPageNum, currentPageIndex);

                }
                else if (SelectedFilterClass.SelectedFilter.Equals(""))
                {
                    lblPageNum.Text = "1";
                    currentPageIndex = 1;//!!!!!!!!!!!!!!!!!!!
                    dgvTable.Rows.Clear();
                    string query = $"WHERE numid LIKE '%{(SearchBar.searchTXT)}%' OR skucode LIKE '%{(SearchBar.searchTXT)}%' OR quantity LIKE '%{(SearchBar.searchTXT)}%' OR expiry LIKE '%{(SearchBar.searchTXT)}%' OR descript LIKE '%{(SearchBar.searchTXT)}%' ";
                    totalPages = SalesClass.loadInventoryData(dgvTable, lblMaxPage, lblPageNum, currentPageIndex, query);
                }
                else
                {
                    lblPageNum.Text = "1";
                    currentPageIndex = 1;//!!!!!!!!!!!!!!!!!!!
                    dgvTable.Rows.Clear();
                    string query = " WHERE " + SelectedFilterClass.SelectedFilter + " LIKE '%" + SearchBar.searchTXT + "%' ";
                    totalPages = SalesClass.loadInventoryData(dgvTable, lblMaxPage, lblPageNum, currentPageIndex, query);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTable.Columns[e.ColumnIndex].Name == "deleteCol")
            {
                if (new CustomMessageBox("Delete Row", "Are you sure you want to delete this item from the Database?",MessageBoxButtons.OKCancel).ShowDialog() == DialogResult.Yes)
                {
                    dgvTable.Rows.RemoveAt(e.RowIndex);
                }
            }
            if (dgvTable.Columns[e.ColumnIndex].Name == "editCol")
            {

            }
            if (dgvTable.Columns[e.ColumnIndex].Name == "viewCol")
            {

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
    }
}
