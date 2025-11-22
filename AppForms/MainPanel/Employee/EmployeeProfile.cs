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
            this.Load += EmployeeProfile_Load;
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
            if (string.IsNullOrEmpty(employeeID))
            {
                lblEmpID.Text = "Employee ID: Not Specified";
                return;
            }

            // Load full employee details from database
            string[] employeeData = EmployeeClass.GetEmployeeFullDetails(employeeID);

            if (employeeData == null || employeeData.Length < 13)
            {
                lblEmpID.Text = "Employee ID: " + employeeID + " (Not Found)";
                return;
            }

            // Set Employee ID label
            lblEmpID.Text = "Employee ID: " + employeeData[0];

            // Populate Personal Information
            PersonalUserControl.First_NameInfo = employeeData[2]; // firstname
            PersonalUserControl.Middle_NameInfo = employeeData[3]; // middlename
            PersonalUserControl.Last_NameInfo = employeeData[4]; // lastname
            PersonalUserControl.AgeInfo = employeeData[7]; // age
            PersonalUserControl.DOBInfo = employeeData[8]; // dateofbirth
            PersonalUserControl.SexInfo = employeeData[11]; // sex

            // Populate Contact/Account Information
            ContactUserControl.PositionInfo = employeeData[9]; // position
            ContactUserControl.StatusInfo = employeeData[10]; // status
            ContactUserControl.ConNum = employeeData[5]; // contactnum
            ContactUserControl.EmailInfo = employeeData[12]; // email

            // Populate Address Information
            // Address is stored as comma-separated: HouseNum,Barangay,City,Province,Postal
            string address = employeeData[6]; // address
            if (!string.IsNullOrEmpty(address))
            {
                string[] addressParts = address.Split(',');
                if (addressParts.Length >= 5)
                {
                    AddressUserControl.HouseNum = addressParts[0].Trim();
                    AddressUserControl.Barangay = addressParts[1].Trim();
                    AddressUserControl.City = addressParts[2].Trim();
                    AddressUserControl.Province = addressParts[3].Trim();
                    AddressUserControl.Postal = addressParts[4].Trim();
                }
                else if (addressParts.Length > 0)
                {
                    // If address format is different, try to parse it
                    AddressUserControl.HouseNum = addressParts.Length > 0 ? addressParts[0].Trim() : "";
                    AddressUserControl.Barangay = addressParts.Length > 1 ? addressParts[1].Trim() : "";
                    AddressUserControl.City = addressParts.Length > 2 ? addressParts[2].Trim() : "";
                    AddressUserControl.Province = addressParts.Length > 3 ? addressParts[3].Trim() : "";
                    AddressUserControl.Postal = addressParts.Length > 4 ? addressParts[4].Trim() : "";
                }
                else
                {
                    // If address is not in expected format, show the whole address
                    AddressUserControl.HouseNum = address;
                }
            }
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
