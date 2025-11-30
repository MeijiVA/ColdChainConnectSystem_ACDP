using Azure.Core.GeoJson;
using Azure.Identity;
using ColdChainConnectSystem_ACDP.AppForms.Header.Settings.PersonalDetails;
using ColdChainConnectSystem_ACDP.ClassResources;
using ColdChainConnectSystem_ACDP.ClassResources.Instances;
using ColdChainConnectSystem_ACDP.Popup;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private bool editFlag;
        AccountInformation AccountContainer;
        Personal_Information PersonalContainer;
        AddressInformation AddressContainer;
        EditAccountInformation EditAccountContainer;
        EditPersonalInformation EditPersonalContainer;
        EditAddressInformation EditAddressContainer;
        public EmployeeProfile()
        {
            InitializeComponent();
            editFlag = false;
            this.DoubleBuffered = true; // Apply to the form

        }

        public EmployeeProfile(string empID) : this()
        {
            employeeID = empID;
        }
        private void ClearControls()
        {
            pnlAccount.Controls.Clear();
            pnlPersonal.Controls.Clear();
            pnlAddress.Controls.Clear();
        }
        private void EditInstances()
        {
            if (EditAccountContainer == null)
            {
                EditAccountContainer = new EditAccountInformation();
            }
            if (EditPersonalContainer == null)
            {
                EditPersonalContainer = new EditPersonalInformation();
            }
            if (EditAddressContainer == null)
            {
                EditAddressContainer = new EditAddressInformation();
            }
            EditAccountContainer.ForeColor = Color.Black;
            EditPersonalContainer.ForeColor = Color.Black;
            EditAddressContainer.ForeColor = Color.Black;
        }

        private void ViewInstances()
        {
            if (AccountContainer == null)
            {
                AccountContainer = new AccountInformation();
            }
            if (PersonalContainer == null)
            {
                PersonalContainer = new Personal_Information();
            }
            if (AddressContainer == null)
            {
                AddressContainer = new AddressInformation();
            }
            AccountContainer.ForeColor = Color.Black;
            PersonalContainer.ForeColor = Color.Black;
            AddressContainer.ForeColor = Color.Black;
        }
        private void LoadEmployeeData()
        {
            ClearControls();
            ViewInstances();
            pnlAccount.Controls.Add(AccountContainer);
            pnlPersonal.Controls.Add(PersonalContainer);
            pnlAddress.Controls.Add(AddressContainer);

            // Hide toggle when viewing
            this.tscStatus.Visible = false;

            Console.WriteLine(ProfileInstance.empid);
            String query = $"SELECT * FROM Employees WHERE EmpID = '{ProfileInstance.empid}'";
            SqlConnection con = ConnectionClass.Connection();
            con.Open();
            using (SqlCommand cmd = new SqlCommand(query, con))
            {//numid   | empid  | username  | first name  | middle name  | last name   | contact num  | address  | age  | date of birth  |  pos   |  status  | sex   | email
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ProfileInstance.id = reader[0].ToString();
                        this.lblEmpID.Text = "   " + reader[1].ToString();
                        this.PersonalContainer.First_NameInfo = reader[3].ToString();
                        this.PersonalContainer.Middle_NameInfo = reader[4].ToString();
                        this.PersonalContainer.Last_NameInfo = reader[5].ToString();
                        this.AccountContainer.ConNum = reader[6].ToString();
                        //Address Splitter
                        string[] address = reader[7].ToString().Split(',');
                        this.AddressContainer.HouseNum = address[0];
                        this.AddressContainer.Barangay = address[1];
                        this.AddressContainer.City = address[2];
                        this.AddressContainer.Province = address[3];
                        this.AddressContainer.Postal = address[4];
                        this.PersonalContainer.AgeInfo = reader[8].ToString();
                        this.PersonalContainer.DOBInfo = Convert.ToDateTime(reader[9]).ToString("yyyy-MM-dd");
                        this.AccountContainer.PositionInfo = reader[10].ToString();
                        this.AccountContainer.StatusInfo = reader[11].ToString();
                        this.PersonalContainer.SexInfo = reader[12].ToString();
                        this.AccountContainer.EmailInfo = reader[13].ToString();
                    }
                }
                con.Close();
            }
        }

        private void EditEmployeeData()
        {
            ClearControls();
            EditInstances();
            pnlAccount.Controls.Add(EditAccountContainer);
            pnlPersonal.Controls.Add(EditPersonalContainer);
            pnlAddress.Controls.Add(EditAddressContainer);

            // Hide toggle beside empID, it will be in Account Information panel
            this.tscStatus.Visible = false;

            Console.WriteLine(ProfileInstance.empid);
            String query = $"SELECT * FROM Employees WHERE EmpID = '{ProfileInstance.empid}'";
            SqlConnection con = ConnectionClass.Connection();
            con.Open();
            using (SqlCommand cmd = new SqlCommand(query, con))
            {//numid   | empid  | username  | first name  | middle name  | last name   | contact num  | address  | age  | date of birth  |  pos   |  status  | sex   | email
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ProfileInstance.id = reader[0].ToString();
                        this.lblEmpID.Text = "   " + reader[1].ToString();
                        this.EditPersonalContainer.First_NAMEInfo = reader[3].ToString();
                        this.EditPersonalContainer.Middle_NAMEInfo = reader[4].ToString();
                        this.EditPersonalContainer.Last_NAMEInfo = reader[5].ToString();
                        this.EditAccountContainer.ContactInfo = reader[6].ToString();
                        //Address Splitter
                        string[] address = reader[7].ToString().Split(',');
                        this.EditAddressContainer.HouseNum = address[0];
                        this.EditAddressContainer.Barangay = address[1];
                        this.EditAddressContainer.Municipality = address[2];
                        this.EditAddressContainer.Province = address[3];
                        this.EditAddressContainer.Postal = address[4];
                        this.EditPersonalContainer.AgeInfo = reader[8].ToString();
                        this.EditPersonalContainer.DOBInfo = Convert.ToDateTime(reader[9]);
                        this.EditAccountContainer.PositionInfo = reader[10].ToString();
                        this.EditAccountContainer.StatusInfo = reader[11].ToString();
                        this.EditPersonalContainer.SexInfo = reader[12].ToString();
                        this.EditAccountContainer.EmailInfo = reader[13].ToString();

                        // Update position combobox in Account Information panel
                        if (EditAccountContainer.cbxPosition != null)
                        {
                            EditAccountContainer.cbxPosition.Texts = reader[10].ToString();
                        }

                        // Update status toggle in Account Information panel
                        if (EditAccountContainer.tscStatus != null)
                        {
                            if (reader[11].ToString().ToLower().Equals("active"))
                            {
                                EditAccountContainer.tscStatus.Checked = true;
                                EditAccountContainer.tscStatus.ToggleBarText = "Active";
                                EditAccountContainer.tscStatus.ToggleCircleColor = Color.Green;
                            }
                            else
                            {
                                EditAccountContainer.tscStatus.Checked = false;
                                EditAccountContainer.tscStatus.ToggleBarText = "Inactive";
                                EditAccountContainer.tscStatus.ToggleCircleColor = Color.Red;
                            }
                        }
                    }
                }
                con.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            // Navigate back to EmployeeForm
            if (EmployeeInstance.i != null)
            {
                MainInstance.i.NavigateTo(EmployeeInstance.i);
                EmployeeInstance.i.LoadAllEmployees();
            }
            else
            {
                MainInstance.i.NavigateTo(new EmployeeForm());
            }
        }

        private void EmployeeProfile_Load(object sender, EventArgs e)
        {
            LoadEmployeeData();
        }

        private void tscStatus_CheckChanged(object sender, EventArgs e)
        {
            if (!this.AccountContainer.PositionInfo.Equals("Administrator"))
            {
                SqlConnection con = ConnectionClass.Connection();
                con.Open();
                if (this.tscStatus.Checked == true)
                {
                    this.tscStatus.ToggleBarText = "Active";
                    this.AccountContainer.StatusInfo = this.tscStatus.ToggleBarText;
                    this.tscStatus.ToggleCircleColor = Color.Green;
                    String query = $"UPDATE Employees SET [Status] = 'Active' WHERE EmpID = '{ProfileInstance.empid}'";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
                else if (this.tscStatus.Checked == false)
                {
                    this.tscStatus.ToggleBarText = "Inactive";
                    this.AccountContainer.StatusInfo = this.tscStatus.ToggleBarText;
                    this.tscStatus.ToggleCircleColor = Color.Red;
                    String query = $"UPDATE Employees SET [Status] = 'Inactive' WHERE EmpID = '{ProfileInstance.empid}'";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            else
            {
                new CustomMessageBox("Status Change", "You are not allow to Set an Administrator's Status to Inactive", MessageBoxButtons.OK).ShowDialog();
                tscStatus.Checked = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!editFlag)
            {
                this.SuspendLayout();
                EditEmployeeData();
                btnSave.Visible = true;
                editFlag = true;
                this.ResumeLayout();
            }
            else if (editFlag)
            {
                this.SuspendLayout();
                LoadEmployeeData();
                btnSave.Visible = false;
                editFlag = false;
                this.ResumeLayout();
            }

        }

        private void UpdateData()
        {
            string sqlQuery = @"
            UPDATE Employees
            SET
                FirstName = @FirstName,
                MiddleName = @MiddleName,
                LastName = @LastName,
                ContactNum = @ContactNum,
                Address = @Address,
                Age = @Age,
                DateOfBirth = @DateOfBirth,
                Position = @Position,
                Status = @Status,
                Sex = @Sex,
                Email = @Email
            WHERE
                NumID = @NumID;";

            int rowsAffected = 0;

            try
            {
                // 1. Establish the connection
                using (SqlConnection con = ConnectionClass.Connection())
                {
                    // 2. Create the command object
                    using (SqlCommand command = new SqlCommand(sqlQuery, con))
                    {
                        string address = this.EditAddressContainer.HouseNum + "," + this.EditAddressContainer.Barangay + "," + this.EditAddressContainer.Municipality + "," + this.EditAddressContainer.Province + "," + this.EditAddressContainer.Postal;


                        command.Parameters.Add("@NumID", SqlDbType.Int).Value = ProfileInstance.id;
                        command.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = this.EditPersonalContainer.First_NAMEInfo;
                        command.Parameters.Add("@MiddleName", SqlDbType.NVarChar).Value = this.EditPersonalContainer.Middle_NAMEInfo;
                        command.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = this.EditPersonalContainer.Last_NAMEInfo;
                        command.Parameters.Add("@ContactNum", SqlDbType.NVarChar).Value = this.EditAccountContainer.ContactInfo; ;
                        command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = address;
                        command.Parameters.Add("@Age", SqlDbType.Int).Value = this.EditPersonalContainer.AgeInfo; ;
                        command.Parameters.Add("@DateOfBirth", SqlDbType.Date).Value = this.EditPersonalContainer.DOBInfo;
                        // Get position from combobox if available, otherwise from PositionInfo
                        string position = this.EditAccountContainer.PositionInfo;
                        if (this.EditAccountContainer.cbxPosition != null && !string.IsNullOrEmpty(this.EditAccountContainer.cbxPosition.Texts))
                        {
                            position = this.EditAccountContainer.cbxPosition.Texts;
                        }

                        // Get status from toggle if available, otherwise from StatusInfo
                        string status = this.EditAccountContainer.StatusInfo;
                        if (this.EditAccountContainer.tscStatus != null)
                        {
                            status = this.EditAccountContainer.tscStatus.Checked ? "Active" : "Inactive";
                        }

                        command.Parameters.Add("@Position", SqlDbType.NVarChar).Value = position;
                        command.Parameters.Add("@Status", SqlDbType.NVarChar).Value = status;
                        command.Parameters.Add("@Sex", SqlDbType.NVarChar).Value = this.EditPersonalContainer.SexInfo;
                        command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = this.EditAccountContainer.EmailInfo;

                        con.Open();
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                new CustomMessageBox("Acquiring Data", ex.Message, MessageBoxButtons.OK).ShowDialog();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            UpdateData();
            new CustomMessageBox("Save", "Updated Information", MessageBoxButtons.OK).ShowDialog();
            LoadEmployeeData();
            btnSave.Visible = false;
            editFlag = false;
            MainInstance.i.uacUserProfile.AccountName = this.PersonalContainer.First_NameInfo + " " + this.PersonalContainer.Middle_NameInfo.Substring(0, 1) + ". " + this.PersonalContainer.Last_NameInfo;
        }

        private void tscStatus_Load(object sender, EventArgs e)
        {

        }

    }
}
