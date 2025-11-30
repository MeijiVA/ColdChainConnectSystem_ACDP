using ColdChainConnectSystem_ACDP.AppForms.Header.Settings.Employee;
using ColdChainConnectSystem_ACDP.AppForms.MainPanel.Customer;
using ColdChainConnectSystem_ACDP.AppForms.MainPanel.Dashboard;
using ColdChainConnectSystem_ACDP.AppForms.MainPanel.Inventory;
using ColdChainConnectSystem_ACDP.AppForms.MainPanel.Sales;
using ColdChainConnectSystem_ACDP.AppForms.MainPanel.Supplier;
using ColdChainConnectSystem_ACDP.ClassResources;
using ColdChainConnectSystem_ACDP.ClassResources.Instances;
using ColdChainConnectSystem_ACDP.Materials;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace ColdChainConnectSystem_ACDP.AppForms.SidePanel
{
    public partial class SidePanel : UserControl
    {
        DisplayClass dc = new DisplayClass();
        CustomButton cbCurrent;
        public SidePanel()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Apply to the form
            cbCurrent = cbtnDashboard;
        }
        public void SelectedTab(CustomButton b)
        {
            cbCurrent.GradientColor1 = ColorTranslator.FromHtml("#070760");
            cbCurrent.GradientColor2 = ColorTranslator.FromHtml("#2B2BA3");
            cbCurrent.Refresh();

            b.GradientColor1 = ColorTranslator.FromHtml("#0347D9");
            b.GradientColor2 = ColorTranslator.FromHtml("#2B2BA3");
            cbCurrent = b;
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            cbtnDashboard.Show();
            cbtnInventory.Show();
            cbtnSupplier.Show();
            cbtnSales.Show();
            cbtnCustomer.Show();
            cbtnEmployee.Show();
            switch (LoginForm.verify)
            {
                
                case "admin":
                    break;
                case "assist":
                    break;
                case "sales":
                    cbtnSupplier.Hide();
                    cbtnCustomer.Hide();
                    cbtnEmployee.Hide();
                    break;
                case "inv":
                    cbtnCustomer.Hide();
                    cbtnSales.Hide();
                    cbtnEmployee.Hide();
                    break;
            }
            //NOTE ADMIN = DASHBOARD, INV, SUPPLIER, SALES, CUST, EMP
            //NOTE ASSIST = DASHBOARD, INV, SUPPLIER, SALES, CUST
            //NOTE SALES = DASHBOARD, SALES, INV
            //NOTE INV = DASHBOARD,INV, SUPPLIER
        }

        private void cbtnDashboard_Click(object sender, EventArgs e)
        {

            SelectedTab(cbtnDashboard);
            MainInstance.i.NavigateTo(new DashoardForm());
            CurrentFormClass.setPreviousFormTo("dbform");
        }

        private void cbtnInventory_Click(object sender, EventArgs e)
        {
            CurrentFormClass.setPreviousFormTo("invform");
            SelectedTab(cbtnInventory);
            MainInstance.i.NavigateTo(InventoryInstance.i = new InventoryForm());
        }

        private void cbtnSupplier_Click(object sender, EventArgs e)
        {
            CurrentFormClass.setPreviousFormTo("supform");
            SelectedTab(cbtnSupplier);
            MainInstance.i.NavigateTo(SupplierInstance.i = new SupplierForm());

        }

        private void cbtnSales_Click(object sender, EventArgs e)
        {
            CurrentFormClass.setPreviousFormTo("salform");
            SelectedTab(cbtnSales);
            MainInstance.i.NavigateTo(SalesInstance.i = new SalesForm());
        }

        private void cbtnCustomer_Click(object sender, EventArgs e)
        {
            CurrentFormClass.setPreviousFormTo("custform");
            SelectedTab(cbtnCustomer);
            MainInstance.i.NavigateTo(CustomerInstance.i = new CustomerForm());
        }

        private void cbtnEmployee_Click(object sender, EventArgs e)
        {
            CurrentFormClass.setPreviousFormTo("empform");
            SelectedTab(cbtnEmployee);
            MainInstance.i.NavigateTo(EmployeeInstance.i = new EmployeeForm());
        }
    }
}
