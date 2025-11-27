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
    public partial class EmployeeForm : Form
    {
        private List<ShowEmployee> showEmployeeControls = new List<ShowEmployee>();

        public EmployeeForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Apply to the form
        }

        private void EmployeeForm_Load(object sender, EventArgs ea)
        {
            LoadAllEmployees();
        }

        public void LoadAllEmployees()
        {
            EmployeeInstance.i.flpEmployee.Controls.Clear();
            int numEmp = EmployeeClass.GetTotalEmployees();
            for (int i = 1; i <= numEmp; i++)
            {
                ShowEmployee e = new ShowEmployee();
                EmployeeClass.LoadAllEmployees(i, e.lblEmpID, e.lblUsername, e.lblName, e.lblPosition, e.lblStatus);
                EmployeeInstance.i.flpEmployee.Controls.Add(e);
            }
        }
    }
}
