using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using ColdChainConnectSystem_ACDP.Popup;
using System.Drawing;

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
        public static string email { get; set; }
        public static string pass { get; set; }


        public static string query { get; set; }
        public static string account { get; set; }
        public static string filePath { get; set; }
        public static string db { get; set; }
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
            filePath = "";
        }

        public static SqlConnection Connection()
        {
            StreamReader sr = new StreamReader(filePath);
            db = sr.ReadLine();
            sr.Close();
            string database = "Data Source = database; Initial Catalog = ColdChainConnectACDP_DB; User ID = username; Password = password; TrustServerCertificate = True";
            //Data Source = ANNEX - PC00; Initial Catalog = ColdChainConnectACDP_DB; User ID = bautista.369742; Password = ***********; Trust Server Certificate = True
            database = database.Replace("database", db);
            database = database.Replace("username", username);
            database = database.Replace("password", pass);
            Console.WriteLine(database);
            return new SqlConnection(database);
        }
        public static string LoginAccount(string input)
        {
            LoginPopupForm lpf = new LoginPopupForm();
            filePath = Directory.GetCurrentDirectory() + @"\conString.txt";
            if (!File.Exists(filePath))
            {
                if (lpf.ShowDialog() == DialogResult.Cancel)
                {
                    return "default";
                }
            }
            //empid,username,fname,mname,lname,contnum,address,age,dob,position,status 
                try
                {
                    string[] token = input.Split(',');
                    username = token[0];
                    pass = token[1];
                    query = @"SELECT empid, username, fname, mname, lname, contnum,"
                            + "address, age, dob, position, status, sex, email FROM Employees";
                    SqlConnection con = Connection();
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
                catch (FileNotFoundException)
                {
                    FileNotFound();
                }
                catch (System.Data.SqlClient.SqlException e)
                {
                //if not found
                if (e.Message.Contains("Server"))
                {
                    new CustomMessageBox("Server", "Invalid Server.").ShowDialog();
                    File.Delete(filePath);
                }
                // if credentials bad
                else if (e.Message.Contains("Login"))
                {
                   new CustomMessageBox("Credentials", "Invalid Credentials.").ShowDialog();
                }
                else
                {
                    new CustomMessageBox("File Not Found", e.Message).ShowDialog();
                }


                }
                catch (InactiveException e)
                {
                new CustomMessageBox("Inactive", e.Message).ShowDialog();
                }
                catch (UnknownPositionException e)
                {
                new CustomMessageBox("Position Problem", e.Message).ShowDialog();
                }
                catch (Exception e)
                {
                new CustomMessageBox("Exception", e.Message).ShowDialog();
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
                new CustomMessageBox("File Not Found", e.Message, MessageBoxButtons.OK).ShowDialog();
            }
        }


    }//class
}//namespace


