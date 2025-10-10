using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColdChainConnectSystem_ACDP.ClassResources
{
    internal class ConnectionClass
    {
        public static void LoginAccount(string input)
        {
            
            string DB = "Data Source = MIAN\\SQLEXPRESS; Initial Catalog=SampleDB; Integrated Security=True;TrustServerCertificate=True";
            //SQL CONNECTIONS
            SqlConnection con = new SqlConnection(DB);
            //NOTE TEMPORARY

            string Account = "";
            string query = @"SELECT Username, Password FROM Accounts";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    //NOTE : EMPID USERNAME PASSWORD FNAME MNAME LNAME CONTNUM AGE DOB POSITION(ACCESS)
                    while (reader.Read())
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            if (i == 1)
                            {
                                Account = reader[i].ToString();
                            }
                            else
                            {
                                Account = Account + "," + reader[i].ToString();
                            }
                        }

                        if (input.Equals(Account))
                        {
                            Console.WriteLine("Account Accepted");
                            break;
                        }
                    }

                }
                con.Close();

            }

        }
    }
}
