using System;
using System.Data.SqlClient;
using System.Windows.Forms;
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
        public static string sex { get; set; }
        public static string query { get; set; }
        public static string account { get; set; }
        public static string email { get; set; }
        public static string filePath { get; set; }
        public static string pass { get; set; }
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
            sex = "";
            pass = "";
        }
        public static string LoginAccount(string input)
        {
            //empid,username,fname,mname,lname,contnum,address,age,dob,position,status 
            try
            {
                string[] token = input.Split(',');
                username = token[0];
                pass = token[1];

                filePath = Directory.GetCurrentDirectory() + @"\conString.txt";
                StreamReader sr = new StreamReader(filePath);
                string database = sr.ReadLine();
                database = database.Replace("username", username);
                database = database.Replace("password", pass);
                SqlConnection con = new SqlConnection(database);
                query = @"SELECT empid, username, fname, mname, lname, contnum,"
                        + "address, age, dob, position, status, sex, email FROM Employees";
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
                                mname = reader[3].ToString();
                                lname = reader[4].ToString();
                                contnum = reader[5].ToString();
                                address = reader[6].ToString();
                                age = reader[7].ToString();
                                dob = reader[8].ToString();
                                position = reader[9].ToString();
                                status = reader[10].ToString();
                                sex = reader[11].ToString();
                                email = reader[12].ToString();

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
            catch (FileNotFoundException )
            {
                FileNotFound();
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                MessageBox.Show("Invalid Credentials." + e.Message);
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

        public static void FileNotFound()
        {
            try
            {
                OpenFileDialog ofdNoFileFound = new OpenFileDialog();
                ofdNoFileFound.InitialDirectory = Directory.GetCurrentDirectory();
                ofdNoFileFound.Title = "Select Connection String Text File";
                ofdNoFileFound.DefaultExt = "txt";
                ofdNoFileFound.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                ofdNoFileFound.ShowDialog();
                string getPath = ofdNoFileFound.FileName;
                string newPath = Directory.GetCurrentDirectory() + @"\conString.txt";
                using (StreamReader sr = File.OpenText(getPath))
                {
                    string _getText = "";
                    using (StreamWriter sw = File.CreateText(newPath))
                    {
                        while ((_getText = sr.ReadLine()) != null)
                        {
                            sw.WriteLine(_getText);
                            Console.WriteLine(_getText);
                        }
                        sw.Close();
                    }
                }

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
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