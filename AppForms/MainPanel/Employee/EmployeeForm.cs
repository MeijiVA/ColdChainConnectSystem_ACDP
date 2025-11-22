using ColdChainConnectSystem_ACDP.ClassResources;
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
        }

        private void EmployeeForm_Load(object sender, EventArgs ea)
        {
            flpEmployee.Controls.Clear();
            int numEmp = EmployeeClass.GetTotalEmployees();
            for (int i = 1;i <= numEmp;i++)
            {
                ShowEmployee e = new ShowEmployee();
                EmployeeClass.LoadAllEmployees(i, e.lblEmpID, e.lblUsername, e.lblName, e.lblPosition, e.lblStatus);
                flpEmployee.Controls.Add(e);
            }
        }
    }
}
