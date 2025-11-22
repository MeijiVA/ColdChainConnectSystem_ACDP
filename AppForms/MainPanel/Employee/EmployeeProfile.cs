using ColdChainConnectSystem_ACDP.AppForms.MainPanel.Inventory;
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
    public partial class EmployeeProfile : Form
    {
        private string employeeID;

        public EmployeeProfile()
        {
            InitializeComponent();
        }
        public EmployeeProfile(string empID) : this()
        {
            employeeID = empID;
            lblEmpID.Text = "Employee ID: " + empID;
            // TODO: Load employee data from database using empID
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            // Navigate back to EmployeeForm
            if (EmployeeInstance.i != null)
            {
                MainInstance.i.NavigateTo(EmployeeInstance.i);
            }
            else
            {
                MainInstance.i.NavigateTo(new EmployeeForm());
            }
        }
    }
}