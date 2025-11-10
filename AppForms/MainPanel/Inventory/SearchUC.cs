using ColdChainConnectSystem_ACDP.ClassResources;
using ColdChainConnectSystem_ACDP.ClassResources.Display;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Inventory
{
    public partial class SearchUC : UserControl
    {
        DisplayClass dc = new DisplayClass();
        public SearchUC()
        {
            InitializeComponent();

        }

        public string searchTXT
        {
            get { return txtSearchBar.Texts;  }
            set { txtSearchBar.Texts = value; }
        }

        private void customTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchBar_Enter(object sender, EventArgs e)
        {
            if (txtSearchBar.Texts.Equals("Search Term"))
            {
                txtSearchBar.Texts = "";
            }

        }

        private void txtSearchBar_Leave(object sender, EventArgs e)
        {
            if (txtSearchBar.Texts.Equals(""))
            {
                txtSearchBar.Texts = "Search Term";
            }
        }

        private void cbxFilter_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxFilter.Texts)
            {
                case "All":
                SelectedFilterClass.SelectedFilter = "";
                    break;
                case "ID":
                    SelectedFilterClass.SelectedFilter = "numid";
                    break;
                case "SKU":
                    SelectedFilterClass.SelectedFilter = "skucode";
                    break;
                case "Desc":
                    SelectedFilterClass.SelectedFilter = "descript";
                    break;
                case "Qty":
                    SelectedFilterClass.SelectedFilter = "quantity";
                    break;
                case "Expry":
                    SelectedFilterClass.SelectedFilter = "expiry";
                    break;
                //FOR INVENTORY


            }

        }

        private void cbxFilter_Load(object sender, EventArgs e)
        {
            Console.WriteLine("HERE at " + CurrentFormClass.form);

            switch (CurrentFormClass.form)
            {
                case "invform":
                    cbxFilter.Items.Add("All");
                    cbxFilter.Items.Add("ID");
                    cbxFilter.Items.Add("SKU");
                    cbxFilter.Items.Add("Desc");
                    cbxFilter.Items.Add("Qty");
                    cbxFilter.Items.Add("Expry");
                    break;
                case "supform":
                    cbxFilter.Items.Add("Supplier Name");
                    break;

                case "salform":
                    cbxFilter.Items.Add("Customer Name");
                    break;

                case "custform":
                    cbxFilter.Items.Add("Customer Name");
                    break;

            }
        }
    }
}
