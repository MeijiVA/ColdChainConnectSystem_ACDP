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
        public static void LoadAllEmployees(int currentNum,Label lblemp, Label lbluser, Label lblname, Label lblpos, Label lblstatus)
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
    }
}

