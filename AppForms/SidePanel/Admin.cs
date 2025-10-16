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
using ColdChainConnectSystem_ACDP.AppForms.MainPanel.Dashboard;
using ColdChainConnectSystem_ACDP.AppForms.MainPanel.Inventory;
using ColdChainConnectSystem_ACDP.ClassResources;

namespace ColdChainConnectSystem_ACDP.AppForms.SidePanel
{
    public partial class Admin : UserControl
    {
        DisplayClass dc = new DisplayClass();
        public Admin()
        {
            InitializeComponent();
        }

        private void SelectedTab(Button b)
        {
            String baseblue = "#070760";
            dashboardbtn.BackColor = Color.White;
            invmanbtn.BackColor = Color.White; 
            supmanbbtn.BackColor = Color.White;
            salesmanbbtn.BackColor = Color.White;  
            custmanbtn.BackColor = Color.White; 
            empmanbtn.BackColor = Color.White;

            dashboardbtn.ForeColor = dc.SetCustomColor(baseblue);
            invmanbtn.ForeColor = dc.SetCustomColor(baseblue);
            supmanbbtn.ForeColor = dc.SetCustomColor(baseblue);
            salesmanbbtn.ForeColor = dc.SetCustomColor(baseblue);
            custmanbtn.ForeColor = dc.SetCustomColor(baseblue);
            empmanbtn.ForeColor = dc.SetCustomColor(baseblue);

            b.BackColor = dc.SetCustomColor(baseblue);
            b.ForeColor = Color.White;
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            dc.SetDisplayRectangle(dashboardbtn,0,50,0,0);
            dc.SetDisplayRectangle(invmanbtn, 0, 50, 0, 0);
            dc.SetDisplayRectangle(supmanbbtn, 0, 50, 0, 0);
            dc.SetDisplayRectangle(salesmanbbtn, 0, 50, 0, 0);
            dc.SetDisplayRectangle(custmanbtn, 0, 50, 0, 0);
            dc.SetDisplayRectangle(empmanbtn, 0, 50, 0, 0);
        }

        public void GetCurrentPanel()
        {
            //to be used:::
        }
        private void dashboardbtn_Click(object sender, EventArgs e)
        {
            SelectedTab(dashboardbtn);
            LoginForm.mf.NavigateTo(new DashoardForm());
            CurrentFormClass.form = "dbform";
            MainForm.settingFlag = 1;
        }

        private void invmanbtn_Click(object sender, EventArgs e)
        {
            SelectedTab(invmanbtn);
            LoginForm.mf.NavigateTo(new InventoryForm());
            CurrentFormClass.form = "invform";
            MainForm.settingFlag = 1;
        }

        private void supmanbbtn_Click(object sender, EventArgs e)
        {
            SelectedTab(supmanbbtn);
            CurrentFormClass.form = "supform";
            MainForm.settingFlag = 1;
        }

        private void salesmanbbtn_Click(object sender, EventArgs e)
        {
            SelectedTab(salesmanbbtn);
            CurrentFormClass.form = "salform";
            MainForm.settingFlag = 1;
        }

        private void custmanbtn_Click(object sender, EventArgs e)
        {
            SelectedTab(custmanbtn);
            CurrentFormClass.form = "custform";
            MainForm.settingFlag = 1;
        }

        private void empmanbtn_Click(object sender, EventArgs e)
        {
            SelectedTab(empmanbtn);
            CurrentFormClass.form = "empform";
            MainForm.settingFlag = 1;
        }
    }
}
