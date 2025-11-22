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
        }

        private void EmployeeProfile_Load(object sender, EventArgs e)
        {
            LoadEmployeeData();
        }

        private void LoadEmployeeData()
        {
         
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
