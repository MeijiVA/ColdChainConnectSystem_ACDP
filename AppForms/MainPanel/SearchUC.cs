using ColdChainConnectSystem_ACDP.AppForms.MainPanel.Customer;
using ColdChainConnectSystem_ACDP.AppForms.MainPanel.Sales;
using ColdChainConnectSystem_ACDP.AppForms.MainPanel.Supplier;
using ColdChainConnectSystem_ACDP.ClassResources;
using ColdChainConnectSystem_ACDP.ClassResources.Connection;
using ColdChainConnectSystem_ACDP.ClassResources.Display;
using ColdChainConnectSystem_ACDP.ClassResources.Instances;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Inventory
{
    public partial class SearchUC : UserControl
    {

        public SearchUC()
        {
            InitializeComponent();
            ofdExport.Filter = "Excel Worksheets|*.xls;*.xlsx;*.xlsm";
            ofdImport.Filter = "Excel Worksheets|*.xls;*.xlsx;*.xlsm";
        }

        public string searchTXT
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }

        private void customTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxFilter_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxFilter.Texts)
            {
                case "Filter":
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
                default:
                    break;
            }
        }


        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Keys.Enter))
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals("Search Term"))
            {
                txtSearch.Text = "";
            }

        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals(""))
            {
                txtSearch.Text = "Search Term";
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("HERE at " + CurrentFormClass.form);
            switch (CurrentFormClass.form)
            {
                case "invform":
                    AddItemInventoryForm addItem = new AddItemInventoryForm();
                    MainInstance.i.NavigateTo(addItem);
                    break;
                case "supform":
                    AddSupplierForm addTransaction = new AddSupplierForm();
                    MainInstance.i.NavigateTo(addTransaction);
                    break;
                case "salform":
                    AddTransactionSalesForm addTrans = new AddTransactionSalesForm();
                    MainInstance.i.NavigateTo(addTrans);
                    break;
                case "custform":
                    AddCustomerForm addCust = new AddCustomerForm();
                    MainInstance.i.NavigateTo(addCust);
                    break;
                default:
                    break;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            switch (CurrentFormClass.form)
            {
                case "invform":
                    if (ofdImport.ShowDialog() == DialogResult.OK)
                    {

                        InvExcelClass.Import(ofdImport.FileName);
                        InventoryInstance.i.UpdateTable();
                    }
                    break;
                case "supform":
                    break;
                case "salform":
                    break;
                case "custform":
                    break;
                default:
                    break;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Console.WriteLine("HERE at " + CurrentFormClass.form);

            switch (CurrentFormClass.form)
            {
                case "invform":
                    Console.WriteLine(txtSearch.Text + " | " + cbxFilter.Texts + " | " + ofdExport.FileName + " | " + SelectedFilterClass.SelectedFilter);
                    if (ofdExport.ShowDialog() == DialogResult.OK)
                    {

                        InvExcelClass.Export(txtSearch.Text, ofdExport.FileName);
                        InventoryInstance.i.UpdateTable();
                    }
                    break;
                case "supform":
                    break;
                case "salform":
                    break;
                case "custform":
                    break;
                default:
                    break;
            }
        }


    }
}
