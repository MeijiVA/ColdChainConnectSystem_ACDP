using ColdChainConnectSystem_ACDP.ClassResources;
using ColdChainConnectSystem_ACDP.ClassResources.Connection;
using ColdChainConnectSystem_ACDP.ClassResources.Display;
using ColdChainConnectSystem_ACDP.ClassResources.Display.Tables;
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

namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Inventory
{
    public partial class InventoryForm : Form
    {
        int currentPageIndex = 0;
        public int totalPages = 0 ;
        public InventoryForm()
        {
            InitializeComponent();
        }
        private void InventoryForm_Load(object sender, EventArgs e)
        {
            SelectedFilterClass.SelectedFilter = "";
            dgvInventoryTable.table.Columns.Add(InventoryColumn.columnSkuCode());
            dgvInventoryTable.table.Columns.Add(InventoryColumn.columnDescription());
            dgvInventoryTable.table.Columns.Add(InventoryColumn.columnImage());
            dgvInventoryTable.table.Columns.Add(InventoryColumn.columnUnitPrice());
            dgvInventoryTable.table.Columns.Add(InventoryColumn.columnAmount());
            dgvInventoryTable.table.Columns.Add(InventoryColumn.columnKG());
            dgvInventoryTable.table.Columns.Add(InventoryColumn.columnQuantity());
            //
            dgvInventoryTable.table.Columns.Add(DataGridViewButtons.AddViewCol_dgvButton());
            dgvInventoryTable.table.Columns.Add(DataGridViewButtons.AddEditCol_dgvButton());
            dgvInventoryTable.table.Columns.Add(DataGridViewButtons.AddDelCol_dgvButton());


            dgvInventoryTable.table.Rows.Clear();
            totalPages = InventoryClass.loadInventoryData(dgvInventoryTable.table, lblMaxPage, lblPageNum, currentPageIndex);
        }
        private void searchUC1_Load(object sender, EventArgs e)
        {
            currentPageIndex = 1;//!!!!!!!!!!!!!!!!!!!
            totalPages = InventoryClass.loadInventoryData(dgvInventoryTable.table, lblMaxPage, lblPageNum, currentPageIndex);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if ((SearchBar.txtSearch.Text.Equals("Search Term") || SearchBar.txtSearch.Text.Equals("")) && (currentPageIndex < totalPages) || (SelectedFilterClass.SelectedFilter.Equals("") && (currentPageIndex < totalPages)))
            {
                dgvInventoryTable.table.Rows.Clear();
                lblPageNum.Text = (currentPageIndex += 1).ToString();
                totalPages = InventoryClass.loadInventoryData(dgvInventoryTable.table, lblMaxPage, lblPageNum, currentPageIndex);
            }//no search query
            else if ((currentPageIndex < Convert.ToInt32(totalPages)) && !(SelectedFilterClass.SelectedFilter.Equals("")))
            {
                dgvInventoryTable.table.Rows.Clear();
                lblPageNum.Text = (currentPageIndex += 1).ToString();
                string query = "WHERE " + SelectedFilterClass.SelectedFilter + " LIKE '%" + SearchBar.searchTXT + "%' ";
                totalPages = InventoryClass.loadInventoryData(dgvInventoryTable.table, lblMaxPage, lblPageNum, currentPageIndex, query);
            }//has search query
            else if (currentPageIndex < totalPages)
            {
                dgvInventoryTable.table.Rows.Clear();
                lblPageNum.Text = (currentPageIndex += 1).ToString();
                string query = $"WHERE numid LIKE '%{(SearchBar.searchTXT)}%' OR skucode LIKE '%{(SearchBar.searchTXT)}%' OR quantity LIKE '%{(SearchBar.searchTXT)}%' OR expiry LIKE '%{(SearchBar.searchTXT)}%' OR descript LIKE '%{(SearchBar.searchTXT)}%' OR ";
                totalPages = InventoryClass.loadInventoryData(dgvInventoryTable.table, lblMaxPage, lblPageNum, currentPageIndex, query);
            }// has search query ALL
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if ((SearchBar.txtSearch.Text.Equals("Search Term") || SearchBar.txtSearch.Text.Equals("")) && (currentPageIndex  > 1) || (SelectedFilterClass.SelectedFilter.Equals("") && (currentPageIndex > 1)))
            {
                dgvInventoryTable.table.Rows.Clear();
                lblPageNum.Text = (currentPageIndex -= 1).ToString();
                totalPages = InventoryClass.loadInventoryData(dgvInventoryTable.table, lblMaxPage, lblPageNum, currentPageIndex);
            }//no search query
            else if ((currentPageIndex > 1) && !(SelectedFilterClass.SelectedFilter.Equals("")))
            {
                dgvInventoryTable.table.Rows.Clear();
                lblPageNum.Text = (currentPageIndex -= 1).ToString();
                string query = "WHERE " + SelectedFilterClass.SelectedFilter + " LIKE '%" + SearchBar.searchTXT + "%' ";
                totalPages = InventoryClass.loadInventoryData(dgvInventoryTable.table, lblMaxPage, lblPageNum, currentPageIndex, query);
            }//has search query
            else if (currentPageIndex > 1)
            {
                dgvInventoryTable.table.Rows.Clear();
                lblPageNum.Text = (currentPageIndex -= 1).ToString();
                string query = $"WHERE numid LIKE '%{(SearchBar.searchTXT)}%' OR skucode LIKE '%{(SearchBar.searchTXT)}%' OR quantity LIKE '%{(SearchBar.searchTXT)}%' OR expiry LIKE '%{(SearchBar.searchTXT)}%' OR descript LIKE '%{(SearchBar.searchTXT)}%'";
                totalPages = InventoryClass.loadInventoryData(dgvInventoryTable.table, lblMaxPage, lblPageNum, currentPageIndex, query);
            }// has search query ALL
        }


        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                if ((SearchBar.txtSearch.Text.Equals("Search Term") || SearchBar.txtSearch.Text.Equals("")))
                {
                    lblPageNum.Text = "1";
                    currentPageIndex = 1;//!!!!!!!!!!!!!!!!!!!
                    dgvInventoryTable.table.Rows.Clear();
                    totalPages = InventoryClass.loadInventoryData(dgvInventoryTable.table, lblMaxPage, lblPageNum, currentPageIndex);

                }
                else if (SelectedFilterClass.SelectedFilter.Equals(""))
                {
                    lblPageNum.Text = "1";
                    currentPageIndex = 1;//!!!!!!!!!!!!!!!!!!!
                    dgvInventoryTable.table.Rows.Clear();
                    string query = $"WHERE numid LIKE '%{(SearchBar.searchTXT)}%' OR skucode LIKE '%{(SearchBar.searchTXT)}%' OR quantity LIKE '%{(SearchBar.searchTXT)}%' OR expiry LIKE '%{(SearchBar.searchTXT)}%' OR descript LIKE '%{(SearchBar.searchTXT)}%' ";
                    totalPages = InventoryClass.loadInventoryData(dgvInventoryTable.table, lblMaxPage, lblPageNum, currentPageIndex, query);
                }
                else
                {
                    lblPageNum.Text = "1";
                    currentPageIndex = 1;//!!!!!!!!!!!!!!!!!!!
                    dgvInventoryTable.table.Rows.Clear();
                    string query = " WHERE " + SelectedFilterClass.SelectedFilter + " LIKE '%" + SearchBar.searchTXT + "%' ";
                    totalPages = InventoryClass.loadInventoryData(dgvInventoryTable.table, lblMaxPage, lblPageNum, currentPageIndex, query);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
