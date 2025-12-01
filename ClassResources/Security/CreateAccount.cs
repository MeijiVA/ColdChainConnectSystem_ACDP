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

        public void SetupNewAppUser(string username, string password)
        {
            string databaseName = "ColdChainConnectACDP_DB";
            string bracketedUsername = $"[{username}]";
            string sqlScript = $@"


        -- 1. Create the Server Login
        CREATE LOGIN {bracketedUsername}
            WITH PASSWORD = @Password,  -- *** USING PARAMETER HERE ***
            CHECK_POLICY = ON,
            CHECK_EXPIRATION = ON;
        GO 

        -- 2. Switch to the target database
        USE [{databaseName}];
        GO
        
        -- 3. Create a Database User for the Login
        CREATE USER {bracketedUsername} FOR LOGIN {bracketedUsername};
        GO
        
        -- 4. Add the User to the db_owner role
        ALTER ROLE db_owner ADD MEMBER {bracketedUsername};
        GO
        ";

            // Use a new connection object specifically for this operation
            using (SqlConnection con = ConnectionAdmin.Connection())
            {
                try
                {
                    con.Open();
                    // Split the script into individual commands using 'GO' as a separator
                    string[] commands = sqlScript.Split(new[] { "GO" }, StringSplitOptions.RemoveEmptyEntries)
                                                 .Where(c => !string.IsNullOrWhiteSpace(c))
                                                 .ToArray();
                    foreach (var commandText in commands)
                    {
                        using (SqlCommand command = new SqlCommand(commandText, con))
                        {
                            if (commandText.Trim().StartsWith("CREATE LOGIN", StringComparison.OrdinalIgnoreCase))
                            {
                                command.Parameters.AddWithValue("@Password", password);
                            }
                            command.ExecuteNonQuery();
                        }
                    }
                }
                catch (SqlException ex)
                {
                    new CustomMessageBox("Exception", ex.Message, System.Windows.Forms.MessageBoxButtons.OK);
                }
            }
        }




    }
}
