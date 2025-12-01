using ColdChainConnectSystem_ACDP.Popup;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ColdChainConnectSystem_ACDP.ClassResources.Security
{
    internal class CreateAccount
    {

        public static void SetupNewAppUser(string username, string password)
        {
            string databaseName = "ColdChainConnectACDP_DB";
            string bracketedUsername = $"[{username}]";
            string sqlScript = $@"
        CREATE LOGIN {bracketedUsername}
            WITH PASSWORD = '@Password',
            CHECK_POLICY = ON,
            CHECK_EXPIRATION = ON;
        GO 
        CREATE USER {bracketedUsername} FOR LOGIN {bracketedUsername};
        GO
        ALTER ROLE db_owner ADD MEMBER {bracketedUsername};
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
                            if (commandText.Trim().StartsWith("CREATE LOGIN", StringComparison.OrdinalIgnoreCase))
                            {
                                command.Parameters.Add("@Password", password);
                            }
                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (SqlException ex)
                {
                    new CustomMessageBox("Exception", ex.Message, System.Windows.Forms.MessageBoxButtons.OK).ShowDialog();
                }
            }
        }




    }
}
