using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ColdChainConnectSystem_ACDP.ClassResources
{
    internal class ChangeCredentialsClass
    {
        public static bool ChangeUsername(TextBox user, TextBox pass, TextBox rep)
        {
            if (!user.Text.Equals(ConnectionClass.username))
            {
                if (pass.Text.Equals(rep.Text))
                {
                    if (pass.Text.Equals(ConnectionClass.pass))
                    {
                        MessageBox.Show("Username has been Changed.");
                        ConnectionClass.username = user.Text;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Passwords do not match this User's Credentials.");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Your two Passwords do not match.");
                    return false;
                }
            }
            return false;
        }//chng user

        public static bool ChangePassword(TextBox oldp, TextBox newp, TextBox rep)
        {

            if (oldp.Text.Equals(ConnectionClass.pass))
            {
                if (newp.Text.Equals(rep.Text))
                {
                    if (!oldp.Text.Equals(newp.Text))
                    {
                        MessageBox.Show("Password has been Changed.");
                        ConnectionClass.pass = newp.Text;
                        return true;
                          
                    }
                    else
                    {
                        MessageBox.Show("Your Old Password must not match the new Password.");
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Your two Passwords do not match.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Your Old Password does not match this User's Credentials.");
                return false;
            }


        }//chng pass

        public static bool SameUsernameWith(TextBox user)
        {
            string filePath = Directory.GetCurrentDirectory() + @"\conString.txt";
            StreamReader sr = new StreamReader(filePath);
            string database = sr.ReadLine();
            database = database.Replace("username", ConnectionClass.username);
            database = database.Replace("password", ConnectionClass.pass);
            SqlConnection con = new SqlConnection(database);
            string query = @"SELECT username FROM Employees";

            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (user.Text.Equals(ConnectionClass.username))
                        {
                            MessageBox.Show("Your New Username must not be the same as your Old Username.");
                            return false;
                        }
                        else if (user.Text.Equals(reader[0].ToString()))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;

        }

    }
}
