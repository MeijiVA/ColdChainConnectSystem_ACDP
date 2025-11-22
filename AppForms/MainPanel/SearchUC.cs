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
using System.Diagnostics.Eventing.Reader;
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
        private bool IfIsInventoryFilter()
        {
            if (CurrentFormClass.form.Equals("invform"))
            {
                return true;
            }
            return false;
        }
        private bool IfIsSupplierFilter()
        {
            if (CurrentFormClass.form.Equals("supform"))
            {
                return true;
            }
            return false;
        }
        private bool IfIsSalesFilter()
        {
            if (CurrentFormClass.form.Equals("salform"))
            {
                return true;
            }
            return false;
        }
        private bool IfIsCustomerFilter()
        {
            if (CurrentFormClass.form.Equals("custform"))
            {
                return true;
            }
            return false;
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

        private void cbxFilter_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (IfIsInventoryFilter())
            {
                switch (cbxFilter.Texts)
                {
                    case "Filter":
                    case "All":
                        SelectedFilterClass.SelectedFilter = "";
                        break;
                    case "ID":
                        SelectedFilterClass.SelectedFilter = "[numid]";
                        break;
                    case "SKU":
                        SelectedFilterClass.SelectedFilter = "[skucode]";
                        break;
                    case "Desc":
                        SelectedFilterClass.SelectedFilter = "[Description]";
                        break;
                    case "Qty":
                        SelectedFilterClass.SelectedFilter = "[quantity]";
                        break;
                    case "Expry":
                        SelectedFilterClass.SelectedFilter = "[expiry]";
                        break;
                        //FOR INVENTORY
                }
            }
            else if (IfIsSupplierFilter())
            {
                switch (cbxFilter.Texts)
                {
                    case "Filter":
                    case "All":
                        SelectedFilterClass.SelectedFilter = "";
                        break;
                    case "ID":
                        SelectedFilterClass.SelectedFilter = "[NumID]";
                        break;
                    case "SupID":
                        SelectedFilterClass.SelectedFilter = "[SupplierID]";
                        break;
                    case "C.Name":
                        SelectedFilterClass.SelectedFilter = "[CompanyName]";
                        break;
                    case "C.Person":
                        SelectedFilterClass.SelectedFilter = "[ContactPerson]";
                        break;
                    case "C.Num":
                        SelectedFilterClass.SelectedFilter = "[ContactNumber]";
                        break;
                    case "Adrs.":
                        SelectedFilterClass.SelectedFilter = "[Address]";
                        break;
                    case "PayTerm":
                        SelectedFilterClass.SelectedFilter = "[PaymentTerm]";
                        break;
                        //FOR SUPPLIER
                }
            }
            else if (IfIsSalesFilter())
            {
                switch (cbxFilter.Texts)
                {
                    case "Filter":
                    case "All":
                        SelectedFilterClass.SelectedFilter = "";
                        break;
                    case "ID":
                        SelectedFilterClass.SelectedFilter = "a.[numid]";
                        break;
                    case "Sal.ID":
                        SelectedFilterClass.SelectedFilter = "a.[SalesID]";
                        break;
                    case "C.ID":
                        SelectedFilterClass.SelectedFilter = "a.[CustomerID]";
                        break;
                    case "S.Date":
                        SelectedFilterClass.SelectedFilter = "a.[SalesDate]";
                        break;
                    case "Qty":
                        SelectedFilterClass.SelectedFilter = "a.[Quantity]";
                        break;
                    case "Price":
                        SelectedFilterClass.SelectedFilter = "i.[UnitPrice]";
                        break;
                    case "Status":
                        SelectedFilterClass.SelectedFilter = "a.[Status]";
                        break;
                        //FOR Sales
                }
            }
            else if (IfIsCustomerFilter())
            {
                switch (cbxFilter.Texts)
                {
                    case "Filter":
                    case "All":
                        SelectedFilterClass.SelectedFilter = "";
                        break;
                    case "ID":
                        SelectedFilterClass.SelectedFilter = "[numid]";
                        break;
                    case "C.ID":
                        SelectedFilterClass.SelectedFilter = "[CustomerID]";
                        break;
                    case "C.Name":
                        SelectedFilterClass.SelectedFilter = "[CustomerName]";
                        break;
                    case "Phone#":
                        SelectedFilterClass.SelectedFilter = "[PhoneNumber]";
                        break;
                    case "Adrs.":
                        SelectedFilterClass.SelectedFilter = "[Address]";
                        break;
                    case "PayTerm":
                        SelectedFilterClass.SelectedFilter = "[PaymentTerm]";
                        break;
                    case "R.Date":
                        SelectedFilterClass.SelectedFilter = "[RegistrationDate]";
                        break;
                    case "Status":
                        SelectedFilterClass.SelectedFilter = "[Status]";
                        break;
                        //FOR SUPPLIER
                }
            }
        }

        private void cbxFilter_Load(object sender, EventArgs e)
        {
            Console.WriteLine("HERE at " + CurrentFormClass.form);
            cbxFilter.Items.Add("All");
            cbxFilter.Items.Add("ID");
            switch (CurrentFormClass.form)
            {
                case "invform":
                    cbxFilter.Items.Add("SKU");
                    cbxFilter.Items.Add("Desc");
                    cbxFilter.Items.Add("Qty");
                    cbxFilter.Items.Add("Expry");
                    break;
                case "supform":
                    cbxFilter.Items.Add("SupID");
                    cbxFilter.Items.Add("C.Name");
                    cbxFilter.Items.Add("C.Person");
                    cbxFilter.Items.Add("C.Num");
                    cbxFilter.Items.Add("Adrs.");
                    cbxFilter.Items.Add("PayTerm");
                    break;

                case "salform":
                    cbxFilter.Items.Add("Sal.ID");
                    cbxFilter.Items.Add("C.ID");
                    cbxFilter.Items.Add("S.Date");
                    cbxFilter.Items.Add("Qty");
                    cbxFilter.Items.Add("Price");
                    cbxFilter.Items.Add("Status");
                    break;

                case "custform":
                    cbxFilter.Items.Add("C.Name");
                    cbxFilter.Items.Add("Phone#");
                    cbxFilter.Items.Add("Adrs.");
                    cbxFilter.Items.Add("PayTerm");
                    cbxFilter.Items.Add("R.Date");
                    cbxFilter.Items.Add("Status");
                    break;
                default:
                    break;
            }
        }
    }
}
