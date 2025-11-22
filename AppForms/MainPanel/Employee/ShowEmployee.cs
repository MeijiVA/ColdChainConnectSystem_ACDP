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
        [Category("Data")]
        public string EmpID
        {
            get { return lblEmpID.Text; }
            set { lblEmpID.Text = value; }
        }
        [Category("Data")]
        public string EmployeeName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }

        [Category("Data")]
        public string Position
        {
            get { return lblPosition.Text; }
            set { lblPosition.Text = value; }
        }

        [Category("Data")]
        public string Status
        {
            get { return lblStatus.Text; }
            set { lblStatus.Text = value; }
        }

        public void DetermineStatusColor()
        {

            if (lblStatus.Text.Equals("Active"))
            {
                lblStatus.ForeColor = System.Drawing.Color.FromArgb(107, 188, 59);
            }
            else if (lblStatus.Text.Equals("Inactive"))
            {
                lblStatus.ForeColor = System.Drawing.Color.FromArgb(115, 115, 115);
            }
        }



        private void lblStatus_TextChanged(object sender, EventArgs e)
        {
            if (lblStatus.Text.Equals("Active"))
            {
                lblStatus.ForeColor = System.Drawing.Color.FromArgb(107, 188, 59);
            }
            else if (lblStatus.Text.Equals("Inactive"))
            {
                lblStatus.ForeColor = System.Drawing.Color.FromArgb(115, 115, 115);
            }
        }

        private void View_Click(object sender, EventArgs e)
        {

        }

        private void Edit_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {

        }
    }
}
