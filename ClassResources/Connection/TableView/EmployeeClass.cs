using ColdChainConnectSystem_ACDP.Popup;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ColdChainConnectSystem_ACDP.ClassResources
{
    internal class EmployeeClass
    {
        /// <summary>
        /// Loads all employees from the database, removing duplicates
        /// Returns a list of employee data: [empid, username, firstname, middlename, lastname, position, status]
        /// </summary>
        public static List<string[]> LoadAllEmployees()
        {
            List<string[]> employees = new List<string[]>();
            HashSet<string> seenEmpIds = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            try
            {
                string query = @"SELECT [empid], [username], [firstname], [middlename], [lastname], [position], [status] FROM Employees ORDER BY [empid]";
                SqlConnection con = ConnectionClass.Connection();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string empid = reader[0].ToString().Trim();

                            // Skip if we've already seen this employee ID
                            if (seenEmpIds.Contains(empid))
                            {
                                continue;
                            }

                            seenEmpIds.Add(empid);

                            string[] employeeData = new string[]
                            {
                                empid, // empid
                                reader[1].ToString().Trim(), // username
                                reader[2].ToString().Trim(), // firstname
                                reader[3].ToString().Trim(), // middlename
                                reader[4].ToString().Trim(), // lastname
                                reader[5].ToString().Trim(), // position
                                reader[6].ToString().Trim() // status
                            };
                            employees.Add(employeeData);
                        }
                    }
                    con.Close();
                }

                // Check if current user is already in the list (by empid or username)
                bool currentUserFound = false;
                string currentEmpId = (ConnectionClass.empid ?? "").Trim();
                string currentUsername = (ConnectionClass.username ?? "").Trim();

                foreach (var emp in employees)
                {
                    // Check by empid or username (case-insensitive)
                    if ((!string.IsNullOrEmpty(currentEmpId) && emp[0].Trim().Equals(currentEmpId, StringComparison.OrdinalIgnoreCase)) ||
                        (!string.IsNullOrEmpty(currentUsername) && emp[1].Trim().Equals(currentUsername, StringComparison.OrdinalIgnoreCase)))
                    {
                        currentUserFound = true;
                        break;
                    }
                }

                // Only add current user if they're not already in the database
                if (!currentUserFound && !string.IsNullOrEmpty(currentEmpId))
                {
                    string[] currentUser = new string[]
                    {
                        currentEmpId,
                        currentUsername,
                        (ConnectionClass.fname ?? "").Trim(),
                        (ConnectionClass.mname ?? "").Trim(),
                        (ConnectionClass.lname ?? "").Trim(),
                        (ConnectionClass.position ?? "").Trim(),
                        (ConnectionClass.status ?? "").Trim()
                    };
                    employees.Add(currentUser);
                }
            }
            catch (Exception ex)
            {
                new CustomMessageBox("Error", "Failed to load employees: " + ex.Message, MessageBoxButtons.OK).ShowDialog();
            }

            return employees;
        }

        /// <summary>
        /// Gets employee data by employee ID (basic info)
        /// </summary>
        public static string[] GetEmployeeByID(string empID)
        {
            try
            {
                string query = @"SELECT [empid], [username], [firstname], [middlename], [lastname], [position], [status] FROM Employees WHERE [empid] = @empid";
                SqlConnection con = ConnectionClass.Connection();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@empid", empID);
                    con.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new string[]
                            {
                                reader[0].ToString(), // empid
                                reader[1].ToString(), // username
                                reader[2].ToString(), // firstname
                                reader[3].ToString(), // middlename
                                reader[4].ToString(), // lastname
                                reader[5].ToString(), // position
                                reader[6].ToString() // status
                            };
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                new CustomMessageBox("Error", "Failed to load employee: " + ex.Message, MessageBoxButtons.OK).ShowDialog();
            }

            return null;
        }

        /// <summary>
        /// Gets complete employee details by employee ID including all personal information
        /// Returns: [empid, username, firstname, middlename, lastname, contactnum, address, age, dateofbirth, position, status, sex, email]
        /// </summary>
        public static string[] GetEmployeeFullDetails(string empID)
        {
            try
            {
                string query = @"SELECT [empid], [username], [firstname], [middlename], [lastname], [contactnum], 
                                [address], [age], [dateofbirth], [position], [status], [sex], [email] 
                                FROM Employees WHERE [empid] = @empid";
                SqlConnection con = ConnectionClass.Connection();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@empid", empID);
                    con.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new string[]
                            {
                                reader[0].ToString().Trim(), // empid
                                reader[1].ToString().Trim(), // username
                                reader[2].ToString().Trim(), // firstname
                                reader[3].ToString().Trim(), // middlename
                                reader[4].ToString().Trim(), // lastname
                                reader[5].ToString().Trim(), // contactnum
                                reader[6].ToString().Trim(), // address
                                reader[7].ToString().Trim(), // age
                                reader[8].ToString().Trim(), // dateofbirth
                                reader[9].ToString().Trim(), // position
                                reader[10].ToString().Trim(), // status
                                reader[11].ToString().Trim(), // sex
                                reader[12].ToString().Trim() // email
                            };
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                new CustomMessageBox("Error", "Failed to load employee details: " + ex.Message, MessageBoxButtons.OK).ShowDialog();
            }

            return null;
        }
    }
}

