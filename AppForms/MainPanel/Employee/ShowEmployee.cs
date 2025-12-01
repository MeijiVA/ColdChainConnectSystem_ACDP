using ColdChainConnectSystem_ACDP.AppForms.MainPanel.Inventory;
using ColdChainConnectSystem_ACDP.AppForms.MainPanel.Sales;
using ColdChainConnectSystem_ACDP.ClassResources;
using ColdChainConnectSystem_ACDP.ClassResources.Instances;
using ColdChainConnectSystem_ACDP.Popup;
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

            this.DoubleBuffered = true; // Apply to the form



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
            ProfileInstance.empid = this.lblEmpID.Text;
            MainInstance.i.NavigateTo(ProfileInstance.i = new EmployeeProfile());
        }

        private void Archive_Click(object sender, EventArgs e)
        {
            if (new CustomMessageBox(
                    "Archive Employee",
                    $"Are you sure you want to archive employee {lblEmpID.Text}?",
                    MessageBoxButtons.OKCancel).ShowDialog() == DialogResult.OK)
            {
                bool success = EmployeeClass.ArchiveEmployee(lblEmpID.Text);
                if (success)
                {
                    new CustomMessageBox("Success", "Employee archived successfully!", MessageBoxButtons.OK).ShowDialog();
                    // Remove this control from parent and refresh the list
                    if (this.Parent != null)
                    {
                        this.Parent.Controls.Remove(this);
                    }
                    // Refresh the employee list
                    if (EmployeeInstance.i != null)
                    {
                        EmployeeInstance.i.LoadAllEmployees();
                    }
                }
            }
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
