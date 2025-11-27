using ColdChainConnectSystem_ACDP.ClassResources.Security;
using ColdChainConnectSystem_ACDP.Popup;
using CustomControls.RJControls;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ColdChainConnectSystem_ACDP.ClassResources
{
    internal class ChangeCredentialsClass
    {
        static CustomMessageBox cmb;
        public static bool ChangeUsername(CustomTextBox user, CustomTextBox pass, CustomTextBox rep)
        {
            if (!user.Texts.Equals(ConnectionClass.username))
            {
                if (pass.Texts.Equals(rep.Texts))
                {
                    if (pass.Texts.Equals(ConnectionClass.pass))
                    {
                        cmb = new CustomMessageBox("Change Username", "Username has been Changed.", MessageBoxButtons.OK);
                        cmb.ShowDialog();
                        SqlConnection con = ConnectionAdmin.Connection();
                        con.Open();
                        String prevUser = ConnectionClass.username; 
                        ConnectionClass.username = user.Texts;
                        String query = $"UPDATE Employees SET [Username] = '{ConnectionClass.username}' WHERE [Username] = '{prevUser}';";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.ExecuteNonQuery();
                        }
                        query = $"ALTER LOGIN {prevUser} WITH NAME = {ConnectionClass.username};";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.ExecuteNonQuery();
                        }

                        con.Close();
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

        public static bool ChangePassword(CustomTextBox oldp, CustomTextBox newp, CustomTextBox rep)
        {

            if (oldp.Texts.Equals(ConnectionClass.pass))
            {
                if (newp.Texts.Equals(rep.Texts))
                {
                    if (!oldp.Texts.Equals(newp.Texts))
                    {
                        cmb = new CustomMessageBox("Change Password", "Password has been Changed.", MessageBoxButtons.OK);
                        cmb.ShowDialog();
                        SqlConnection con = ConnectionAdmin.Connection();
                        con.Open();
                        ConnectionClass.pass = newp.Texts;
                        String query = $"ALTER LOGIN {ConnectionClass.username} WITH PASSWORD = '{ConnectionClass.pass}';";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.ExecuteNonQuery();
                        }
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

        public static bool SameUsernameWith(CustomTextBox user)
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
                        if (user.Texts.Equals(ConnectionClass.username))
                        {
                            cmb = new CustomMessageBox("Change Username", "Your New Username must not be the same as your Old Username.", MessageBoxButtons.OK);
                            cmb.ShowDialog();
                            return false;
                        }
                        else if (user.Texts.Equals(reader[0].ToString()))
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
