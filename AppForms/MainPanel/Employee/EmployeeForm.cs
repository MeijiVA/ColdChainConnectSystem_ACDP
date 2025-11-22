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
            this.Load += EmployeeForm_Load;
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            // Clear existing controls
            flowLayoutPanel1.Controls.Clear();
            showEmployeeControls.Clear();

            // Load all employees from database
            List<string[]> employees = EmployeeClass.LoadAllEmployees();

            // Create ShowEmployee controls for each employee (up to 6)
            int maxEmployees = Math.Min(employees.Count, 6);

            for (int i = 0; i < maxEmployees; i++)
            {
                ShowEmployee showEmp = new ShowEmployee();
                showEmp.EmployeeName = employees[i][2] + " " + employees[i][4]; // firstname + lastname
                showEmp.Position = employees[i][5]; // position
                showEmp.Status = employees[i][6]; // status
                showEmp.BorderStyle = BorderStyle.FixedSingle;
                showEmp.Padding = new Padding(5);
                showEmp.Size = new Size(241, 180);
                showEmp.Margin = new Padding(3, 3, 3, 3);

                showEmployeeControls.Add(showEmp);
                flowLayoutPanel1.Controls.Add(showEmp);
            }

            // If there are fewer than 6 employees, create empty placeholder boxes
            for (int i = employees.Count; i < 6; i++)
            {
                ShowEmployee showEmp = new ShowEmployee();
                showEmp.BorderStyle = BorderStyle.FixedSingle;
                showEmp.Padding = new Padding(5);
                showEmp.Size = new Size(241, 180);
                showEmp.Margin = new Padding(3, 3, 3, 3);
                showEmp.Enabled = false; // Disable empty boxes

                showEmployeeControls.Add(showEmp);
                flowLayoutPanel1.Controls.Add(showEmp);
            }
        }

        public void RefreshEmployees()
        {
            LoadEmployees();
        }
    }
}
