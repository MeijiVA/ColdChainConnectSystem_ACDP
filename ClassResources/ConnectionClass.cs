using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColdChainConnectSystem_ACDP.ClassResources
{
    internal class ConnectionClass
    {
        public void LoginAccount(string input)
        {
            
            string DB = "Data Source = MIAN\\SQLEXPRESS; Initial Catalog=SampleDB; Integrated Security=True;TrustServerCertificate=True";
            //SQL CONNECTIONS
            SqlConnection con = new SqlConnection(DB);
            //NOTE TEMPORARY

            string Account = "";
            string query = @"SELECT USERNAME, PASSWORD, POSITION FROM Accounts";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    //NOTE: Add If active or not !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! (too lazy)

                    //EMPID USERNAME PASSWORD FNAME MNAME LNAME CONTNUM AGE DOB POSITION(ACCESS)   
                    while (reader.Read())
                    {
                        Account = reader[0].ToString() + "," + reader[1].ToString();

                        if (input.Equals(Account))
                        {
                            switch (reader[2].ToString())
                            {
                                case "Administrator":
                                    break;
                                case "Sales":
                                    break;
                                case "Assistant":
                                    break;
                                case "Inventory":
                                    break;
                                default:
                                    MessageBox.Show("Unknown Position, Please");
                                    break;
                            }
                            break;
                        }
                    }

                }
                con.Close();

            }

        }
    }
}
