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
        public static string empid { get; set; }
        public static string password { get; set; }
        public static string username { get; set; }
        public static string position { get; set; }
        public static string fname { get; set; }
        public static string mname { get; set; }
        public static string lname { get; set; }
        public static string status { get; set; }
        public static string contnum { get; set; }
        public static string age { get; set; }
        public static string dob { get; set; }

        public ConnectionClass()
        {
            empid = "";
            password = "";
            username = "";
            account = "";
            fname = "";
            mname = "";
            lname = "";
            position = "";
            status = "";
            contnum = "";
            age = "";
            dob = "";
        }
        public string account = "";
        public string LoginAccount(string input)
        {
            try
            {
                string DB = "Data Source = MIAN\\SQLEXPRESS; Initial Catalog=SampleDB; Integrated Security=True;TrustServerCertificate=True";
                //SQL CONNECTIONS
                SqlConnection con = new SqlConnection(DB);
                //NOTE TEMPORARY

                string query = @"SELECT EMPID, USERNAME, PASSWORD, FNAME, MNAME, LNAME, AGE, DOB, POSITION, STATUS FROM Accounts";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    using (var reader = cmd.ExecuteReader())
                    {

                        //EMPID USERNAME PASSWORD FNAME MNAME LNAME CONTNUM AGE DOB POSITION(ACCESS) STATUS  
                        while (reader.Read())
                        {
                            account = reader[1].ToString() + "," + reader[2].ToString();

                            if (account.Equals(input))
                            {
                                empid = reader[0].ToString();  
                                username = reader[1].ToString();
                                password = reader[2].ToString();
                                fname = reader[3].ToString();
                                mname = reader[4].ToString().Substring(0, 1);
                                lname = reader[5].ToString();
                                age = reader[6].ToString();
                                dob = reader[7].ToString();
                                position = reader[8].ToString();
                                status = reader[9].ToString();
                                if (status.Equals("INACTIVE"))
                                {
                                    MessageBox.Show("Account is Inactive, Please Contact the Administrator.");
                                    return "default";
                                }
    

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
                    MessageBox.Show("Incorrect Credentials.");
                    con.Close();
                }
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return "default";
        }

    }//class
}//namespace
