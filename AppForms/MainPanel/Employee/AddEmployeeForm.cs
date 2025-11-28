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

namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Employee
{
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
            editAccountInformation1.PositionInfo = "";
            editAccountInformation1.StatusInfo = "";
            tscStatus.Checked = true;
            UpdateStatusDisplay();

            // Populate position combo box
            cbxPosition.Items.Clear();
            cbxPosition.Items.Add("Administrator");
            cbxPosition.Items.Add("Assistant");
            cbxPosition.Items.Add("Inventory");
            cbxPosition.Items.Add("Sales");
        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MainInstance.i.NavigateTo(EmployeeInstance.i);
        }

        private void cbxPosition_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            string position = cbxPosition.Texts;
            editAccountInformation1.PositionInfo = position;
        }

        private void tscStatus_CheckChanged(object sender, EventArgs e)
        {
            UpdateStatusDisplay();
        }

        private void UpdateStatusDisplay()
        {
            if (tscStatus.Checked)
            {
                editAccountInformation1.StatusInfo = "Active";
                tscStatus.ToggleBarText = "Active";
            }
            else
            {
                editAccountInformation1.StatusInfo = "Inactive";
                tscStatus.ToggleBarText = "Inactive";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate required fields
            if (string.IsNullOrWhiteSpace(cbxPosition.Texts))
            {
                new CustomMessageBox("Validation Error", "Please select Position.", MessageBoxButtons.OK).ShowDialog();
                return;
            }

            if (string.IsNullOrWhiteSpace(editPersonalInformation1.First_NAMEInfo) ||
                string.IsNullOrWhiteSpace(editPersonalInformation1.Last_NAMEInfo))
            {
                new CustomMessageBox("Validation Error", "Please enter First Name and Last Name.", MessageBoxButtons.OK).ShowDialog();
                return;
            }

            // Get all the data
            string position = cbxPosition.Texts.Trim();
            string firstName = editPersonalInformation1.First_NAMEInfo;
            string middleName = editPersonalInformation1.Middle_NAMEInfo;
            string lastName = editPersonalInformation1.Last_NAMEInfo;
            string contactNum = editAccountInformation1.ContactInfo;
            string email = editAccountInformation1.EmailInfo;
            string status = editAccountInformation1.StatusInfo;
            string age = editPersonalInformation1.AgeInfo;
            DateTime dob = editPersonalInformation1.DOBInfo;
            string sex = editPersonalInformation1.SexInfo;

            // Build address
            string address = editAddressInformation1.HouseNum + "," +
                           editAddressInformation1.Barangay + "," +
                           editAddressInformation1.Municipality + "," +
                           editAddressInformation1.Province + "," +
                           editAddressInformation1.Postal;

            // Generate EmpID based on position count
            string empID = EmployeeClass.GenerateEmployeeID(position);

            // Generate username (can be improved)
            string username = "";
            if (!string.IsNullOrWhiteSpace(firstName) && !string.IsNullOrWhiteSpace(lastName))
            {
                username = (firstName.Substring(0, 1) + lastName).ToLower();
            }
            else
            {
                username = empID.ToLower();
            }

            // Save to database
            bool success = EmployeeClass.SaveEmployee(
                empID, username, firstName, middleName, lastName,
                contactNum, address, age, dob, position, status, sex, email
            );

            if (success)
            {
                new CustomMessageBox("Success", "Employee saved successfully!", MessageBoxButtons.OK).ShowDialog();
                // Navigate back to EmployeeForm and refresh
                EmployeeInstance.i.LoadAllEmployees();
                MainInstance.i.NavigateTo(EmployeeInstance.i);
            }
        }
    }
}
