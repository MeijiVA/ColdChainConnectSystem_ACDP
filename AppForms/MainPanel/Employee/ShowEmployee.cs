using ColdChainConnectSystem_ACDP.AppForms.MainPanel.Inventory;
using ColdChainConnectSystem_ACDP.AppForms.MainPanel.Sales;
using ColdChainConnectSystem_ACDP.ClassResources;
using ColdChainConnectSystem_ACDP.ClassResources.Instances;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColdChainConnectSystem_ACDP.AppForms.Header.Settings.Employee
{
    public partial class ShowEmployee : UserControl
    {
        public ShowEmployee()
        {
            InitializeComponent();





            DetermineStatusColor();
        }

        public void DetermineStatusColor()
        {

            if (lblStatus.Text.Equals("Active"))
            {
                lblStatus.BackColor = System.Drawing.Color.FromArgb(107, 188, 59);
            }
            else if (lblStatus.Text.Equals("Inactive"))
            {
                lblStatus.BackColor = System.Drawing.Color.FromArgb(115, 115, 115);
            }
        }



        private void lblStatus_TextChanged(object sender, EventArgs e)
        {
            DetermineStatusColor();
        }

        private void View_Click(object sender, EventArgs e)
        {

        }

        private void Edit_Click(object sender, EventArgs e)
        {
            MainInstance.i.NavigateTo(new EmployeeProfile());
            //EmpID References 
        }

        private void Delete_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public string Empid
        {
            get { return lblEmpID.Text; }
            set { lblEmpID.Text = value; }
        }
    }
}
