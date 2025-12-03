using ColdChainConnectSystem_ACDP.ClassResources;
using ColdChainConnectSystem_ACDP.ClassResources.Instances;
using ColdChainConnectSystem_ACDP.ClassResources.Security;
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

            // Hide header controls - they're now in Account Information panel
            cbxPosition.Visible = false;
            tscStatus.Visible = false;
            lblPosition.Visible = false;

            // Initialize position combobox in Account Information panel

            // Initialize status toggle in Account Information panel
            if (editAccountInformation1.tscStatus != null)
            {
                editAccountInformation1.tscStatus.Checked = true;
                editAccountInformation1.tscStatus.ToggleBarText = "Active";
                editAccountInformation1.tscStatus.ToggleCircleColor = Color.Green;
                editAccountInformation1.StatusInfo = "Active";
            }
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
            // This is now handled in EditAccountInformation
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate required fields
            string position = "";
            if (editAccountInformation1.PositionInfo != null)
            {
                position = editAccountInformation1.PositionInfo;
            }
            if (string.IsNullOrWhiteSpace(position))
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
            if (editAccountInformation1.PositionInfo != null)
            {
                position = editAccountInformation1.PositionInfo.Trim();
            }
            string firstName = editPersonalInformation1.First_NAMEInfo;
            string middleName = editPersonalInformation1.Middle_NAMEInfo;
            string lastName = editPersonalInformation1.Last_NAMEInfo;
            string contactNum = editAccountInformation1.ContactInfo;
            string email = editAccountInformation1.EmailInfo;
            string username = editAccountInformation1.UsernameInfo;
            string password = editAccountInformation1.PasswordInfo;

            // Get status from toggle in Account Information panel
            string status = "Active";
            if (editAccountInformation1.tscStatus != null)
            {
                status = editAccountInformation1.tscStatus.Checked ? "Active" : "Inactive";
            }
            else
            {
                status = editAccountInformation1.StatusInfo;
            }
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

            // Validate username and password (user-defined)
            if (string.IsNullOrWhiteSpace(username))
            {
                new CustomMessageBox("Validation Error", "Please enter a username for the employee.", MessageBoxButtons.OK).ShowDialog();
                return;
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                new CustomMessageBox("Validation Error", "Please enter a password for the employee.", MessageBoxButtons.OK).ShowDialog();
                return;
            }

            if (EmployeeClass.CheckIfDuplicateAccount(username))
            {
                // Save to database
                bool success = EmployeeClass.SaveEmployee(
                    empID, username, firstName, middleName, lastName,
                    contactNum, address, age, dob, position, status, sex, email
                );

                if (success)
                {
                    // Create SQL login/user for this new employee
                    try
                    {
                        CreateAccount.SetupNewAppUser(username, password);


                        new CustomMessageBox("Success", "Employee saved successfully!", MessageBoxButtons.OK).ShowDialog();
                        // Navigate back to EmployeeForm and refresh
                        EmployeeInstance.i.LoadAllEmployees();
                        MainInstance.i.NavigateTo(EmployeeInstance.i);
                    }
                    catch (Exception ex)
                    {
                        new CustomMessageBox("Account Creation", "Employee saved, but failed to create login: " + ex.Message, MessageBoxButtons.OK).ShowDialog();
                    }
                }
            }
            else
            {
                new CustomMessageBox("Account Creation", "Username already exists.", MessageBoxButtons.OK).ShowDialog();
            }
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            editAccountInformation1.lblPos.Hide();
            editAccountInformation1.cbxPosition.Show();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            CreateAccount.SetupNewAppUser("test","passwordhere");
        }
    }
}
