using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Net.Sockets;
using System.IO;

namespace ColdChainConnectSystem_ACDP.ClassResources
{
    class InactiveException : Exception
    {
        public InactiveException(string str) : base(str) { }
    }

    class UnknownPositionException : Exception
    {
        public UnknownPositionException(string str) : base(str) { }
    }






    internal class ConnectionClass
    {
        public static string empid { get; set; }
        public static string username { get; set; }
        public static string fname { get; set; }
        public static string mname { get; set; }
        public static string lname { get; set; }
        public static string address { get; set; }
        public static string contnum { get; set; }
        public static string age { get; set; }
        public static string dob { get; set; }
        public static string position { get; set; }
        public static string status { get; set; }
        public static string query { get; set; }
        public static string account { get; set; }
        public ConnectionClass()
        {
            empid = "";
            username = "";
            account = "";
            fname = "";
            mname = "";
            lname = "";
            address = "";
            contnum = "";
            age = "";
            dob = "";
            position = "";
            status = "";
        }
        public static string LoginAccount(string input)
        {
            //empid,username,fname,mname,lname,contnum,address,age,dob,position,status 
            try
            {
                string[] token = input.Split(',');
                string username = token[0];
                string password = token[1];

                string filePath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\conString.txt";
                StreamReader sr = new StreamReader(filePath);
                string database = sr.ReadLine();
                database = database.Replace("username",username);
                database = database.Replace("password", password);
                SqlConnection con = new SqlConnection(database);
                query = @"SELECT empid, username, fname, mname, lname, contnum,"
                        + "address, age, dob, position, status FROM Employees";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (username.Equals(reader[1].ToString()))
                            {
                                empid = reader[0].ToString();
                                username = reader[1].ToString();
                                fname = reader[2].ToString();
                                mname = reader[3].ToString().Substring(0, 1);
                                lname = reader[4].ToString();
                                contnum = reader[5].ToString();
                                address = reader[6].ToString();
                                age = reader[7].ToString();
                                dob = reader[8].ToString();
                                position = reader[9].ToString();
                                status = reader[10].ToString();

                                if (status.Equals("Inactive"))
                                {
                                    throw new InactiveException("Account's Status is INACTIVE, Please contact an Administrator.");
                                }

                                //NOTE not needed, bat ka pa gagawa ganto kung pwede mo naman return nalang ung position haha....
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
                                        throw new UnknownPositionException("Account has an undefined Position, Please contact an Administrator.");
                                }
                            }
                        }
                    }
                    con.Close();
                }

            }
            catch (System.Data.SqlClient.SqlException e)
            {
                MessageBox.Show("Invalid Credentials."+e.Message);
            }
            catch (InactiveException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (UnknownPositionException e)
            {
                MessageBox.Show(e.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return "default";
        }

    }//class
}//namespace





/*
string DB = "Data Source = MIAN\\SQLEXPRESS; Initial Catalog=SampleDB; Integrated Security=True;TrustServerCertificate=True";
//SQL CONNECTIONS
//NOTE TEMPORARY

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

            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return "default";*/