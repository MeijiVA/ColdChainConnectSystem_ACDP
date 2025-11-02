using ColdChainConnectSystem_ACDP.ClassResources;
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
        int totalPages = 0;
        public InventoryForm()
        {
            InitializeComponent();
        }

        private void searchUC1_Load(object sender, EventArgs e)
        {
            currentPageIndex = 1;
            totalPages = InventoryClass.loadInventoryData(displayTableUC.invDisplaydgv, lblMaxPage, lblPageNum, currentPageIndex);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if((searchUC1.txtSearchBar.Texts.Equals("Search Term") || searchUC1.txtSearchBar.Texts.Equals("")) && (currentPageIndex < totalPages))
            {
                displayTableUC.invDisplaydgv.Rows.Clear();
                lblPageNum.Text = (currentPageIndex += 1).ToString();
                totalPages = InventoryClass.loadInventoryData(displayTableUC.invDisplaydgv, lblMaxPage, lblPageNum, currentPageIndex);
            }//no search query
            else
            {

            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if ((searchUC1.txtSearchBar.Texts.Equals("Search Term") || searchUC1.txtSearchBar.Texts.Equals("")) && (currentPageIndex  > 1))
            {
                displayTableUC.invDisplaydgv.Rows.Clear();
                lblPageNum.Text = (currentPageIndex -= 1).ToString();
                totalPages = InventoryClass.loadInventoryData(displayTableUC.invDisplaydgv, lblMaxPage, lblPageNum, currentPageIndex);
            }//no search query
            else
            {

            }//has search query
        }
    }
}
