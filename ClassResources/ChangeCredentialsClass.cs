using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColdChainConnectSystem_ACDP.ClassResources
{
    internal class ChangeCredentialsClass
    {
        public static string ChangeUsername(TextBox user, TextBox pass, TextBox rep)
        {
            if (!user.Text.Equals(ConnectionClass.username))
            {
                if (pass.Text.Equals(rep.Text))
                {
                    if (pass.Text.Equals(ConnectionClass.pass))
                    {
                        MessageBox.Show("Username has been Changed.");
                        return ConnectionClass.username = user.Text;
                    }
                    else
                    {
                        MessageBox.Show("Passwords do not match this User's Credentials.");
                        return ConnectionClass.username;
                    }
                }
                else
                {
                    MessageBox.Show("Your two Passwords do not match.");
                    return ConnectionClass.username;
                }
            }
            else
            {
                MessageBox.Show("Your New Username must not be the same as your Old Username.");
                return ConnectionClass.username;
            }
        }//chng user

        public static string ChangePassword(TextBox oldp, TextBox newp, TextBox rep)
        {

            if (oldp.Text.Equals(ConnectionClass.pass))
            {
                if (newp.Text.Equals(rep.Text))
                {
                    if (!oldp.Text.Equals(newp.Text))
                    {
                            MessageBox.Show("Password has been Changed.");
                            return ConnectionClass.pass = newp.Text;
                    }
                    else
                    {
                        MessageBox.Show("Your Old Password must not match the new Password.");
                        return ConnectionClass.pass;
                    }
                }
                else
                {
                    MessageBox.Show("Your two Passwords do not match.");
                    return ConnectionClass.pass;
                }
            }
            else
            {
                MessageBox.Show("Your Old Password does not match this User's Credentials.");
                return ConnectionClass.pass;
            }


        }//chng pass
    }
}
