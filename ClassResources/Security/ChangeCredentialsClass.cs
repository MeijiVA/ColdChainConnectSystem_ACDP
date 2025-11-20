using ColdChainConnectSystem_ACDP.Popup;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ColdChainConnectSystem_ACDP.ClassResources
{
    internal class ChangeCredentialsClass
    {
        static CustomMessageBox cmb;
        public static bool ChangeUsername(TextBox user, TextBox pass, TextBox rep)
        {
            if (!user.Text.Equals(ConnectionClass.username))
            {
                if (pass.Text.Equals(rep.Text))
                {
                    if (pass.Text.Equals(ConnectionClass.pass))
                    {
                        cmb = new CustomMessageBox("Change Username", "Username has been Changed.", MessageBoxButtons.OK);
                        cmb.ShowDialog();
                        ConnectionClass.username = user.Text;
                        return true;
                    }
                    else
                    {
                        cmb = new CustomMessageBox("Change Username", "Passwords do not match this User's Credentials.", MessageBoxButtons.OK);
                        cmb.ShowDialog();
                        return false;
                    }
                }
                else
                {
                    cmb = new CustomMessageBox("Change Username", "Your two Passwords do not match.", MessageBoxButtons.OK);
                    cmb.ShowDialog();
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
                        cmb = new CustomMessageBox("Change Password", "Password has been Changed.", MessageBoxButtons.OK);
                        cmb.ShowDialog();
                        ConnectionClass.pass = newp.Text;
                        return true;

                    }
                    else
                    {
                        cmb = new CustomMessageBox("Change Password", "Your Old Password must not match the new Password.", MessageBoxButtons.OK);
                        cmb.ShowDialog();
                        return false;
                    }
                }
                else
                {
                    cmb = new CustomMessageBox("Change Password", "Your two Passwords do not match.", MessageBoxButtons.OK);
                    cmb.ShowDialog();
                    return false;
                }
            }
            else
            {
                cmb = new CustomMessageBox("Change Password", "Your Old Password does not match this User's Credentials.", MessageBoxButtons.OK);
                cmb.ShowDialog();
                return false;
            }


        }//chng pass

        public static bool SameUsernameWith(TextBox user)
        {
            SqlConnection con = ConnectionClass.Connection();
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
                            cmb = new CustomMessageBox("Change Username", "Your New Username must not be the same as your Old Username.", MessageBoxButtons.OK);
                            cmb.ShowDialog();
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
