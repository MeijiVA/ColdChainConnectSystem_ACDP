using ColdChainConnectSystem_ACDP.ClassResources.Security;
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
        /// <summary>
        /// Gets the total number of employees that are NOT archived.
        /// </summary>
        public static int GetTotalEmployees()
        {
            int i;
            SqlConnection con = ConnectionClass.Connection();
            con.Open();
            // Only count employees that are not archived so they appear in EmployeeForm
            String query = "SELECT COUNT(*) FROM Employees WHERE [Status] <> 'Archived'";
            using (SqlCommand count = new SqlCommand(query, con))
            {
                i = (int)count.ExecuteScalar();
            }
            con.Close();
            return i;
        }

        /// <summary>
        /// Loads a single (non-archived) employee into the small employee cards shown in EmployeeForm.
        /// </summary>
        public static void LoadAllEmployees(int currentNum, Label lblemp, Label lbluser, Label lblname, Label lblpos, Label lblstatus)
        {
            try
            {
                SqlConnection con = ConnectionClass.Connection();

                // Skip archived employees from the main EmployeeForm listing
                String query = $@"SELECT [empid], [username], [firstname], [lastname], [position], [status] 
                                  FROM Employees 
                                  WHERE [numID] = {currentNum} AND [Status] <> 'Archived'";
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

        public static void LoadAllEmployeesByRowNumber(int rowNumber, Label lblemp, Label lbluser, Label lblname, Label lblpos, Label lblstatus)
        {
            try
            {
                SqlConnection con = ConnectionClass.Connection();

                // Use ROW_NUMBER() to get employees in order, handling gaps in numID
                String query = $@"SELECT [empid], [username], [firstname], [lastname], [position], [status] 
                    FROM (
                        SELECT [empid], [username], [firstname], [lastname], [position], [status],
                               ROW_NUMBER() OVER (ORDER BY [numID]) as RowNum
                        FROM Employees
                    ) AS RankedEmployees
                    WHERE RowNum = {rowNumber}";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
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
                    AuditLog.AddAuditInfo("Add", empID, $"[{ConnectionClass.empid}] Added Employee [{empID}] from [{CurrentFormClass.form}]");
                    return true;
                }
            }
            catch (Exception ex)
            {
                new CustomMessageBox("Error", "Failed to save employee: " + ex.Message, MessageBoxButtons.OK).ShowDialog();
                return false;
            }
        }

        /// <summary>
        /// Archives an employee by setting their Status to 'Archived' instead of deleting the record.
        /// Existing code may still call this as DeleteEmployee, but behaviour is now archive-only.
        /// </summary>
        public static bool DeleteEmployee(string empID)
        {
            return ArchiveEmployee(empID);
        }

        /// <summary>
        /// Explicit archive helper so other screens (like EmployeeDatabase) can re-use it.
        /// </summary>
        public static bool ArchiveEmployee(string empID)
        {
            try
            {
                SqlConnection con = ConnectionClass.Connection();
                string query = "UPDATE Employees SET [Status] = 'Archived' WHERE [empid] = @EmpID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@EmpID", empID);
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();
                    AuditLog.AddAuditInfo("Edit", empID, $"[{ConnectionClass.empid}] Archived Employee [{empID}] from [{CurrentFormClass.form}]");
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                new CustomMessageBox("Error", "Failed to archive employee: " + ex.Message, MessageBoxButtons.OK).ShowDialog();
                return false;
            }
        }

        /// <summary>
        /// Un-archives an employee by switching Status back to 'Active'.
        /// </summary>
        public static bool UnarchiveEmployee(string empID)
        {
            try
            {
                SqlConnection con = ConnectionClass.Connection();
                string query = "UPDATE Employees SET [Status] = 'Active' WHERE [empid] = @EmpID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@EmpID", empID);
                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();
                    AuditLog.AddAuditInfo("Edit", empID, $"[{ConnectionClass.empid}] Unarchived Employee [{empID}] from [{CurrentFormClass.form}]");
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                new CustomMessageBox("Error", "Failed to unarchive employee: " + ex.Message, MessageBoxButtons.OK).ShowDialog();
                return false;
            }
        }

        /// <summary>
        /// Loads paged employee data (including archived) into a DataGridView for EmployeeDatabase.
        /// </summary>
        public static int LoadEmployeeDatabase(DataGridView dgv, Label lblPage, Label lblPageNum, int currentPageIndex, string searchQuery = "")
        {
            int totalRows = 0;
            int totalPages = 0;
            int pageSize = 10;
            string query;
            SqlConnection con = ConnectionClass.Connection();
            con.Open();

            // Base query for count and data
            string whereClause = "";
            if (!string.IsNullOrWhiteSpace(searchQuery))
            {
                whereClause = searchQuery;
            }

            query = $"SELECT COUNT(*) FROM Employees {whereClause}";
            using (SqlCommand count = new SqlCommand(query, con))
            {
                totalRows = (int)count.ExecuteScalar();
                totalPages = (int)Math.Ceiling((double)totalRows / pageSize);
                lblPage.Text = totalPages.ToString();

                query = $@"SELECT [numid],[empid],[username],[firstname],[middlename],[lastname],
                                  [position],[status]
                           FROM Employees {whereClause}
                           ORDER BY [numid]
                           OFFSET {(currentPageIndex - 1) * pageSize} ROWS
                           FETCH NEXT {pageSize} ROWS ONLY";

                using (SqlCommand data = new SqlCommand(query, con))
                {
                    using (var reader = data.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string fullName = $"{reader[5].ToString().Trim()}, {reader[3].ToString().Trim()} {reader[4].ToString().Trim()}".Trim();
                            dgv.Rows.Add(new object[]
                            {
                                false,                     // checkbox
                                reader[0].ToString().Trim(), // numid (hidden)
                                reader[1].ToString().Trim(), // empid
                                reader[2].ToString().Trim(), // username
                                fullName,                    // full name
                                reader[6].ToString().Trim(), // position
                                reader[7].ToString().Trim()  // status
                            });
                        }
                    }
                    con.Close();
                }
            }

            return totalPages;
        }

        public static string GenerateEmployeeID(string position)
        {
            try
            {
                SqlConnection con = ConnectionClass.Connection();
                string prefix = "";

                // Map position to prefix
                switch (position.ToLower())
                {
                    case "administrator":
                        prefix = "ADM";
                        break;
                    case "assistant":
                        prefix = "AST";
                        break;
                    case "inventory":
                        prefix = "INV";
                        break;
                    case "sales":
                        prefix = "SLS";
                        break;
                    default:
                        prefix = "EMP";
                        break;
                }

                // Count employees with this position
                string query = "SELECT COUNT(*) FROM Employees WHERE [position] = @Position";
                int count = 0;

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Position", position);
                    con.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        count = (int)result;
                    }
                    con.Close();
                }

                // Generate new EmpID (count + 1, formatted as 0001, 0002, etc.)
                int nextNumber = count + 1;
                string empID = $"{prefix}-{nextNumber:D4}";

                return empID;
            }
            catch (Exception ex)
            {
                new CustomMessageBox("Error", "Failed to generate Employee ID: " + ex.Message, MessageBoxButtons.OK).ShowDialog();
                return "EMP-0001";
            }
        }




    }
}

