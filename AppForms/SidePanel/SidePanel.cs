using ColdChainConnectSystem_ACDP.AppForms.Header.Settings.Employee;
using ColdChainConnectSystem_ACDP.AppForms.MainPanel.Customer;
using ColdChainConnectSystem_ACDP.AppForms.MainPanel.Dashboard;
using ColdChainConnectSystem_ACDP.AppForms.MainPanel.Inventory;
using ColdChainConnectSystem_ACDP.AppForms.MainPanel.Sales;
using ColdChainConnectSystem_ACDP.AppForms.MainPanel.Supplier;
using ColdChainConnectSystem_ACDP.ClassResources;
using ColdChainConnectSystem_ACDP.ClassResources.Instances;
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
        public SidePanel()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Apply to the form
        }
        String baseblue = "#070760";
        private void SelectedTab(Button b)
        {
            btnDashboard.BackColor = Color.White;
            btnInvMan.BackColor = Color.White; 
            btnSupMan.BackColor = Color.White;
            btnSalesMan.BackColor = Color.White;  
            btnCusMan.BackColor = Color.White; 
            btnEmpMan.BackColor = Color.White;

            btnDashboard.ForeColor = dc.SetCustomColor(baseblue);
            btnInvMan.ForeColor = dc.SetCustomColor(baseblue);
            btnSupMan.ForeColor = dc.SetCustomColor(baseblue);
            btnSalesMan.ForeColor = dc.SetCustomColor(baseblue);
            btnCusMan.ForeColor = dc.SetCustomColor(baseblue);
            btnEmpMan.ForeColor = dc.SetCustomColor(baseblue);

            b.BackColor = dc.SetCustomColor(baseblue);
            b.ForeColor = dc.SetCustomColor("#FFFFFF");
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            btnDashboard.Show();
            btnInvMan.Show();
            btnSupMan.Show();
            btnSalesMan.Show();
            btnCusMan.Show();
            btnEmpMan.Show();
            switch (LoginForm.verify)
            {
                
                case "admin":
                    break;
                case "assist":
                    break;
                case "sales":
                    btnSupMan.Hide();
                    btnCusMan.Hide();
                    btnEmpMan.Hide();
                    break;
                case "inv":
                    btnCusMan.Hide();
                    btnSalesMan.Hide();
                    btnEmpMan.Hide();
                    break;
            }
            //NOTE ADMIN = DASHBOARD, INV, SUPPLIER, SALES, CUST, EMP
            //NOTE ASSIST = DASHBOARD, INV, SUPPLIER, SALES, CUST
            //NOTE SALES = DASHBOARD, SALES, INV
            //NOTE INV = DASHBOARD,INV, SUPPLIER
            dc.SetDisplayRectangle(btnDashboard,0,50,0,0);
            dc.SetDisplayRectangle(btnInvMan, 0, 50, 0, 0);
            dc.SetDisplayRectangle(btnSupMan, 0, 50, 0, 0);
            dc.SetDisplayRectangle(btnSalesMan, 0, 50, 0, 0);
            dc.SetDisplayRectangle(btnCusMan, 0, 50, 0, 0);
            dc.SetDisplayRectangle(btnEmpMan, 0, 50, 0, 0);


        }



        private void dashboardbtn_Click(object sender, EventArgs e)
        {
            
            SelectedTab(btnDashboard);
            MainInstance.i.NavigateTo(new DashoardForm());
            CurrentFormClass.setPreviousFormTo("dbform");
        }

        private void invmanbtn_Click(object sender, EventArgs e)
        {
            CurrentFormClass.setPreviousFormTo("invform");
            SelectedTab(btnInvMan);
            MainInstance.i.NavigateTo(InventoryInstance.i = new InventoryForm());
        }

        private void supmanbbtn_Click(object sender, EventArgs e)
        {
            CurrentFormClass.setPreviousFormTo("supform");
            SelectedTab(btnSupMan);
            MainInstance.i.NavigateTo(SupplierInstance.i = new SupplierForm());
        }

        private void salesmanbbtn_Click(object sender, EventArgs e)
        {
            CurrentFormClass.setPreviousFormTo("salform");
            SelectedTab(btnSalesMan);
            MainInstance.i.NavigateTo(SalesInstance.i = new SalesForm());
        }

        private void custmanbtn_Click(object sender, EventArgs e)
        {
            CurrentFormClass.setPreviousFormTo("custform");
            SelectedTab(btnCusMan);
            MainInstance.i.NavigateTo(CustomerInstance.i = new CustomerForm());
        }

        private void empmanbtn_Click(object sender, EventArgs e)
        {
            CurrentFormClass.setPreviousFormTo("empform");
            SelectedTab(btnEmpMan);
            MainInstance.i.NavigateTo(EmployeeInstance.i = new EmployeeForm());
        }

 
    }
}
