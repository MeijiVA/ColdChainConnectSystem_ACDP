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
        }
        [Category("Data")]
        public string EMPID { get; set; }

        [Category("Data")]
        public string EmployeeName { get; set; }

        [Category("Data")]
        public string Position { get; set; }

        [Category("Data")]
        public string Status { get; set; }

        public void UpdateDisplay()
        {
            if (!string.IsNullOrEmpty(EMPID))
            {
                // Display employee name or ID
                if (!string.IsNullOrEmpty(EmployeeName))
                {
                    lblEMP.Text = EmployeeName;
                }
                else
                {
                    lblEMP.Text = "ID: " + EMPID;
                }
            }
            else
            {
                lblEMP.Text = "No Employee";
            }
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            EmployeeProfile empProfile = new EmployeeProfile(this.EMPID);
            MainInstance.i.NavigateTo(empProfile);
        }

        private void customButton2_Click(object sender, EventArgs e)
        {

        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            AddTransactionSalesForm add = new AddTransactionSalesForm();
            SettingsInstance.i.pnlDisplaySettings.Controls.Add(add);
        }
    }
}
