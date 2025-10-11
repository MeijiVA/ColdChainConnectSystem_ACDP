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
        public static string fname { get; set; }
        public static string mname { get; set; }
        public static string lname { get; set; }

        public ConnectionClass()
        {
            account = "";
            fname = "";
            mname = "";
            lname = "";
            position = "";
        }
        public string account = "";
        public string position = "";
        public string LoginAccount(string input)
        {
            
            string DB = "Data Source = MIAN\\SQLEXPRESS; Initial Catalog=SampleDB; Integrated Security=True;TrustServerCertificate=True";
            //SQL CONNECTIONS
            SqlConnection con = new SqlConnection(DB);
            //NOTE TEMPORARY

            string query = @"SELECT USERNAME, PASSWORD, POSITION, FNAME, MNAME, LNAME FROM Accounts";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    //NOTE: Add If active or not !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! (too lazy)

                    //EMPID USERNAME PASSWORD FNAME MNAME LNAME CONTNUM AGE DOB POSITION(ACCESS)   
                    while (reader.Read())
                    {
                        account = reader[0].ToString() + "," + reader[1].ToString();

                        if (input.Equals(account))
                        {
                            fname = reader[3].ToString();
                            mname = reader[4].ToString().Substring(0, 1);
                            lname = reader[5].ToString(); 
                            position = reader[2].ToString();
                            switch (position)
                            {
                                case "Administrator":
                                    return "admin";
                                case "Sales":
                                    return "sales";
                                case "Assistant":
                                    return "assist";
                                case "Inventory":
                                    return "inv"; 
                                default:
                                    MessageBox.Show("Unknown Position, Please Contact the Adminstrator.");
                                    return "default"; 
                            }
                        }
                    }
                }
                con.Close();
                return "default";

            }

        }

    }
}
