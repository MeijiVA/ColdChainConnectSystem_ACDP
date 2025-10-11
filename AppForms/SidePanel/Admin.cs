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

namespace ColdChainConnectSystem_ACDP.AppForms.SidePanel
{
    public partial class Admin : UserControl
    {
        DisplayClass dc = new DisplayClass();
        String baseblue = "#070760";
        public Admin()
        {
            InitializeComponent();
        }

        private void SelectedTab(Button b)
        {
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

        private void dashboardbtn_Click(object sender, EventArgs e)
        {
            SelectedTab(dashboardbtn);
        }

        private void invmanbtn_Click(object sender, EventArgs e)
        {
            SelectedTab(invmanbtn);
        }

        private void supmanbbtn_Click(object sender, EventArgs e)
        {
            SelectedTab(supmanbbtn);
        }

        private void salesmanbbtn_Click(object sender, EventArgs e)
        {
            SelectedTab(salesmanbbtn);
        }

        private void custmanbtn_Click(object sender, EventArgs e)
        {
            SelectedTab(custmanbtn);
        }

        private void empmanbtn_Click(object sender, EventArgs e)
        {
            SelectedTab(empmanbtn);
        }
    }
}
