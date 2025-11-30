using ColdChainConnectSystem_ACDP.Popup;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColdChainConnectSystem_ACDP.ClassResources.Display
{
    internal class NotificationClass
    {
        public static int GetTotalNotifs()
        {
            int i;
            SqlConnection con = ConnectionClass.Connection();
            con.Open();
            String query = "SELECT COUNT(*) FROM Audit WHERE [Notified] = 0";
            using (SqlCommand count = new SqlCommand(query, con))
            {
                i = (int)count.ExecuteScalar();
            }
            con.Close();
            return i;
        }
        public static String LoadNotifs(int currentNum, Label user, Label desc)
        {
            String num = "";
            try
            {
                SqlConnection con = ConnectionClass.Connection();

                String query = $"SELECT [numid], [user], [action], [reference], [referenceid] FROM Audit WHERE [numID] = {currentNum} AND [Notified] = 0";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            num  = reader[0].ToString().Trim(); // numid
                            user.Text = reader[1].ToString().Trim(); // user
                            desc.Text = reader[2].ToString().Trim() + " " + reader[3].ToString().Trim() + " in " + reader[4].ToString(); 
                        }
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                new CustomMessageBox("Error", "Failed to load employees: " + ex.Message, MessageBoxButtons.OK).ShowDialog();
            }
                return num;
        }

    }
}
