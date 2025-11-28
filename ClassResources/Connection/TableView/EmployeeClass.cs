using ColdChainConnectSystem_ACDP.Popup;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ColdChainConnectSystem_ACDP.ClassResources
{
    internal class EmployeeClass
    {
        public static int GetTotalEmployees()
        {
            int i;
            SqlConnection con = ConnectionClass.Connection();
            con.Open();
            String query = "SELECT COUNT(*) FROM Employees";
            using (SqlCommand count = new SqlCommand(query, con))
            {
                i = (int)count.ExecuteScalar();
            }
            con.Close();
            return i;
        }
        public static void LoadAllEmployees(int currentNum, Label lblemp, Label lbluser, Label lblname, Label lblpos, Label lblstatus)
        {
            try
            {
                SqlConnection con = ConnectionClass.Connection();

                String query = $"SELECT [empid], [username], [firstname], [lastname], [position], [status] FROM Employees WHERE [numID] = {currentNum}";
                Console.WriteLine(query);
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lblemp.Text = reader[0].ToString().Trim(); // empid
                            lbluser.Text = reader[1].ToString().Trim(); // username
                            lblname.Text = reader[3].ToString().Trim() + ", " + reader[2].ToString().Trim(); // lastname
                            lblpos.Text = reader[4].ToString().Trim(); // pos
                            lblstatus.Text = reader[5].ToString().Trim(); // status
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                new CustomMessageBox("Error", "Failed to load employees: " + ex.Message, MessageBoxButtons.OK).ShowDialog();
            }
        }

        public static bool SaveEmployee(string empID, string username, string firstName, string middleName,
            string lastName, string contactNum, string address, string age, DateTime dob,
            string position, string status, string sex, string email)
        {
            try
            {
                SqlConnection con = ConnectionClass.Connection();
                string query = @"INSERT INTO Employees ([empid], [username], [firstname], [middlename], [lastname], 
                    [contactnum], [address], [age], [dateofbirth], [position], [status], [sex], [email]) 
                    VALUES (@EmpID, @Username, @FirstName, @MiddleName, @LastName, @ContactNum, @Address, 
                    @Age, @DateOfBirth, @Position, @Status, @Sex, @Email)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@EmpID", empID);
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@FirstName", firstName);
                    cmd.Parameters.AddWithValue("@MiddleName", string.IsNullOrWhiteSpace(middleName) ? (object)DBNull.Value : middleName);
                    cmd.Parameters.AddWithValue("@LastName", lastName);
                    cmd.Parameters.AddWithValue("@ContactNum", string.IsNullOrWhiteSpace(contactNum) ? (object)DBNull.Value : contactNum);
                    cmd.Parameters.AddWithValue("@Address", string.IsNullOrWhiteSpace(address) ? (object)DBNull.Value : address);
                    if (string.IsNullOrWhiteSpace(age) || !int.TryParse(age, out int ageValue))
                    {
                        cmd.Parameters.AddWithValue("@Age", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Age", ageValue);
                    }
                    cmd.Parameters.AddWithValue("@DateOfBirth", dob);
                    cmd.Parameters.AddWithValue("@Position", position);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@Sex", string.IsNullOrWhiteSpace(sex) ? (object)DBNull.Value : sex);
                    cmd.Parameters.AddWithValue("@Email", string.IsNullOrWhiteSpace(email) ? (object)DBNull.Value : email);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                new CustomMessageBox("Error", "Failed to save employee: " + ex.Message, MessageBoxButtons.OK).ShowDialog();
                return false;
            }
        }

        public static bool DeleteEmployee(string empID)
        {
            try
            {
                SqlConnection con = ConnectionClass.Connection();
                string query = "DELETE FROM Employees WHERE [empid] = @EmpID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@EmpID", empID);
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                new CustomMessageBox("Error", "Failed to delete employee: " + ex.Message, MessageBoxButtons.OK).ShowDialog();
                return false;
            }
        }
    }
}

