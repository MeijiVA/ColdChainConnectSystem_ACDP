using ColdChainConnectSystem_ACDP.Popup;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ColdChainConnectSystem_ACDP.ClassResources.Security
{
    internal class UpdateAccount
    {
        public static string GetAccount(string empid)
        {
            empid = empid.Trim();
            string sqlQuery = $"SELECT [Username] FROM Employees WHERE [empid] = '{empid}'";
            using (SqlConnection con = ConnectionAdmin.Connection())
            {
                string username = "";
                Console.WriteLine(sqlQuery);
                try
                {
                    using (SqlCommand command = new SqlCommand(sqlQuery, con))
                    {
                        con.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                username = reader[0].ToString();
                                return username;
                            }
                        }
                        con.Close();
                    }
                }
                catch (Exception ex) 
                {
                    new CustomMessageBox("No Account",ex.Message,System.Windows.Forms.MessageBoxButtons.OK);
                }
                return username;
            }
        }
                    public static void DatabaseAccountChangeTo(string oldUser, string newUser, string newPass)
                    {
                        string databaseName = "ColdChainConnectACDP_DB";
                        string bOldUser = $"[{oldUser}]";
                        string bNewUser = $"[{newUser}]";
                        string sqlScript = $@"
        ALTER LOGIN {bOldUser} WITH PASSWORD = '{newPass}';
        GO
        ALTER LOGIN {bOldUser} WITH NAME = {bNewUser};
        GO
        ";
                        // Use a new connection object specifically for this operation
                        using (SqlConnection con = ConnectionAdmin.Connection())
                        {
                            try
                            {
                                con.Open();
                                string[] commands = sqlScript.Split(new[] { "GO" }, StringSplitOptions.RemoveEmptyEntries)
                                                             .Where(c => !string.IsNullOrWhiteSpace(c))
                                                             .ToArray();
                                foreach (var commandText in commands)
                                {
                                    Console.WriteLine(commands[0]);
                                    using (SqlCommand command = new SqlCommand(commandText, con))
                                    {
                                        
                                        command.ExecuteNonQuery();
                        }
                    }
                    if (oldUser == ConnectionClass.username)
                    {
                        ConnectionClass.username = newUser;
                        ConnectionClass.pass = newPass;
                    }
                    String query = $"UPDATE [Employees] SET username = '{newUser}' WHERE username = '{oldUser}'";
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.ExecuteNonQuery();
                    }
                    con.Close();
                    
                            }
                            catch (SqlException ex)
                            {
                                new CustomMessageBox("Exception", ex.Message, System.Windows.Forms.MessageBoxButtons.OK).ShowDialog();
                            }
                        }
                    }
    }
}
