using Azure.Identity;
using ColdChainConnectSystem_ACDP.ClassResources;
using ColdChainConnectSystem_ACDP.ClassResources.Instances;
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
        public EmployeeProfile()
        {
            InitializeComponent();
        }

        public EmployeeProfile(string empID) : this()
        {
            employeeID = empID;
        }

        private void LoadEmployeeData()
        {
            Console.WriteLine(ProfileInstance.empid);
            String query = $"SELECT * FROM Employees WHERE EmpID = '{ProfileInstance.empid}'";
            SqlConnection con = ConnectionClass.Connection();
            con.Open();
            using (SqlCommand cmd = new SqlCommand(query, con))
            {//numid   | empid  | username  | first name  | middle name  | last name   | contact num  | address  | age  | date of birth  |  pos   |  status  | sex   | email
                using(var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ProfileInstance.id = reader[0].ToString();
                        this.lblEmpID.Text = "   " + reader[1].ToString();
                        this.PersonalContainer.First_NameInfo= reader[3].ToString();
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
                        this.PersonalContainer.DOBInfo = reader[9].ToString();
                        this.AccountContainer.PositionInfo = reader[10].ToString();
                        this.AccountContainer.StatusInfo = reader[11].ToString();
                        this.PersonalContainer.SexInfo = reader[12].ToString();
                        this.AccountContainer.EmailInfo = reader[13].ToString();
                        //Status Slider 
                        if (this.AccountContainer.StatusInfo.ToLower().Equals("Active"))
                        {
                            this.tscStatus.Checked = true;
                            this.tscStatus.ToggleBarText = "Active";
                            this.tscStatus.ToggleCircleColor = Color.Green;
                        }
                        else if (this.AccountContainer.StatusInfo.ToLower().Equals("inactive"))
                        {
                            this.tscStatus.Checked = false;
                            this.tscStatus.ToggleBarText = "Inactive";
                            this.tscStatus.ToggleCircleColor = Color.Red;
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
                EmployeeInstance.i.flpEmployee.Controls.Clear();
                int numEmp = EmployeeClass.GetTotalEmployees();
                for (int i = 1; i <= numEmp; i++)
                {
                    ShowEmployee showEmp = new ShowEmployee();
                    EmployeeClass.LoadAllEmployees(i, showEmp.lblEmpID, showEmp.lblUsername, showEmp.lblName, showEmp.lblPosition, showEmp.lblStatus);
                    EmployeeInstance.i.flpEmployee.Controls.Add(showEmp);
                }
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
    }
}
