﻿using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace ColdChainConnectSystem_ACDP.AppForms.SidePanel
{
    public partial class SidePanel : UserControl
    {
        DisplayClass dc = new DisplayClass();
        public SidePanel()
        {
            InitializeComponent();
        }

        private void SelectedTab(Button b)
        {
            String baseblue = "#070760";
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
            b.ForeColor = Color.White;
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            btnDashboard.Show();
            btnInvMan.Show();
            btnSupMan.Show();
            btnSalesMan.Show();
            btnCusMan.Show();
            btnEmpMan.Hide();//unused
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

        public void setPreviousFormTo(string name)
        {
            CurrentFormClass.form = name;
            MainForm.settingFlag = 1;
        }

        private void dashboardbtn_Click(object sender, EventArgs e)
        {
            
            SelectedTab(btnDashboard);
            LoginForm.mf.NavigateTo(new DashoardForm());
            setPreviousFormTo("dbform");
        }

        private void invmanbtn_Click(object sender, EventArgs e)
        {
            SelectedTab(btnInvMan);
            LoginForm.mf.NavigateTo(new InventoryForm());
            setPreviousFormTo("invform");
        }

        private void supmanbbtn_Click(object sender, EventArgs e)
        {
            SelectedTab(btnSupMan);
            setPreviousFormTo("supform");
        }

        private void salesmanbbtn_Click(object sender, EventArgs e)
        {
            SelectedTab(btnSalesMan);
            setPreviousFormTo("salform");
        }

        private void custmanbtn_Click(object sender, EventArgs e)
        {
            SelectedTab(btnCusMan);
            setPreviousFormTo("custform");
        }

        private void empmanbtn_Click(object sender, EventArgs e)
        {
            SelectedTab(btnEmpMan);
            setPreviousFormTo("empform");
        }
    }
}
