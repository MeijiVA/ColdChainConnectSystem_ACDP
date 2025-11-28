using ColdChainConnectSystem_ACDP.ClassResources;
using ColdChainConnectSystem_ACDP.ClassResources.Instances;
using ColdChainConnectSystem_ACDP.AppForms.MainPanel.Employee;
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
            flpEmployee.Controls.Clear();
            showEmployeeControls.Clear();
            int numEmp = EmployeeClass.GetTotalEmployees();
            for (int i = 1; i <= numEmp; i++)
            {
                ShowEmployee e = new ShowEmployee();
                EmployeeClass.LoadAllEmployees(i, e.lblEmpID, e.lblUsername, e.lblName, e.lblPosition, e.lblStatus);
                showEmployeeControls.Add(e);
                flpEmployee.Controls.Add(e);
            }
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            MainInstance.i.NavigateTo(new AddEmployeeForm());
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(searchTerm) || searchTerm == "search term")
            {
                LoadAllEmployees();
                return;
            }

            flpEmployee.Controls.Clear();
            foreach (ShowEmployee emp in showEmployeeControls)
            {
                bool matches =
                    emp.lblEmpID.Text.ToLower().Contains(searchTerm) ||
                    emp.lblName.Text.ToLower().Contains(searchTerm) ||
                    emp.lblUsername.Text.ToLower().Contains(searchTerm) ||
                    emp.lblPosition.Text.ToLower().Contains(searchTerm);

                if (matches)
                {
                    flpEmployee.Controls.Add(emp);
                }
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search Term")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.White;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search Term";
                txtSearch.ForeColor = Color.White;
            }
        }
    }
}
