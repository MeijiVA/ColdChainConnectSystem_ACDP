using ColdChainConnectSystem_ACDP.ClassResources;
using ColdChainConnectSystem_ACDP.ClassResources.Display;
using ColdChainConnectSystem_ACDP.ClassResources.Display.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Inventory
{
    public partial class InventoryForm : Form
    {
        int currentPageIndex = 0;
        public int totalPages = 0;
        public InventoryForm()
        {
            InitializeComponent();
        }
        private void InventoryForm_Load(object sender, EventArgs e)
        {
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
            string query = "WHERE " + "CHANGE THIS TO THE COMBO BOX THANK YOU " + " = " + SearchBar.searchTXT;
            totalPages = InventoryClass.loadInventoryData(dgvInventoryTable.table, lblMaxPage, lblPageNum, currentPageIndex);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if((SearchBar.txtSearchBar.Texts.Equals("Search Term") || SearchBar.txtSearchBar.Texts.Equals("")) && (currentPageIndex < totalPages))
            {
                dgvInventoryTable.table.Rows.Clear();
                lblPageNum.Text = (currentPageIndex += 1).ToString();
                totalPages = InventoryClass.loadInventoryData(dgvInventoryTable.table, lblMaxPage, lblPageNum, currentPageIndex);
            }//no search query
            else
            {

            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if ((SearchBar.txtSearchBar.Texts.Equals("Search Term") || SearchBar.txtSearchBar.Texts.Equals("")) && (currentPageIndex  > 1))
            {
                dgvInventoryTable.table.Rows.Clear();
                lblPageNum.Text = (currentPageIndex -= 1).ToString();
                totalPages = InventoryClass.loadInventoryData(dgvInventoryTable.table, lblMaxPage, lblPageNum, currentPageIndex);
            }//no search query
            else
            {

            }//has search query
        }
    }
}
