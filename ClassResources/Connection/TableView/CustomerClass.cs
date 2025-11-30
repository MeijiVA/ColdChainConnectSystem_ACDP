
using ColdChainConnectSystem_ACDP.ClassResources.Security;
using ColdChainConnectSystem_ACDP.Popup;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IdentityModel.Tokens;
using System.IO;
using System.Windows.Forms;

namespace ColdChainConnectSystem_ACDP.ClassResources
{
    internal class CustomerClass
    {
        public static int loadCustomerData(DataGridView dgv, Label lblPage, Label lblPageNum, int currentPageIndex)
        {
            int totalRows = 0;
            int totalPages = 0;
            int PageSize = 10;
            String query;
            SqlConnection con = ConnectionClass.Connection();
            con.Open();
            query = "SELECT COUNT(*) FROM Customer";
            using (SqlCommand count = new SqlCommand(query, con))
            {
                totalRows = (int)count.ExecuteScalar();
                totalPages = (int)Math.Ceiling((double)totalRows / PageSize);
                lblPage.Text = totalPages.ToString();
                query = $"SELECT [numid],[customerid],[customername],[phonenumber],[address],[paymentterm],[registrationdate],[status] FROM Customer ORDER BY [numid] OFFSET {(currentPageIndex - 1) * PageSize} ROWS FETCH NEXT {PageSize} ROWS ONLY";
                using (SqlCommand data = new SqlCommand(query, con))
                {
                    using (var reader = data.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //[customerid],[customername],[phonenumber],[address],[paymentterm],[registrationdate],[status]
                            dgv.Rows.Add(new object[] { false, reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), Convert.ToDateTime(reader[6]).ToString("yyyy-MM-dd"), reader[7].ToString() });
                        }//while reader loop
                    }//reader
                    con.Close();
                }//sql command select query
            }//command count

            return totalPages;
        }//method


        public static int loadCustomerData(DataGridView dgv, Label lblPage, Label lblPageNum, int currentPageIndex, string searchQuery)
        {
            int totalRows = 0;
            int totalPages = 0;
            int PageSize = 10;
            String query;
            SqlConnection con = ConnectionClass.Connection();
            con.Open();
            if (searchQuery == "")
            {

            }



            query = $"SELECT COUNT(*) FROM Customer {searchQuery}";
            using (SqlCommand count = new SqlCommand(query, con))
            {
                totalRows = (int)count.ExecuteScalar();
                totalPages = (int)Math.Ceiling((double)totalRows / PageSize);
                lblPage.Text = totalPages.ToString();

                Console.WriteLine(totalRows + " TR " + totalPages + "TP");
                query = $"SELECT [numid],[customerid],[customername],[phonenumber],[address],[paymentterm],[registrationdate],[status] FROM Customer {searchQuery} ORDER BY [numid] OFFSET {(currentPageIndex - 1) * PageSize} ROWS FETCH NEXT {PageSize} ROWS ONLY";
                using (SqlCommand data = new SqlCommand(query, con))
                {
                    using (var reader = data.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //[numid],[customerid],[customername],[phonenumber],[address],[paymentterm],[registrationdate],[status]
                            dgv.Rows.Add(new object[] { 0, reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), Convert.ToDateTime(reader[6]).ToString("yyyy-MM-dd"), reader[7].ToString() });
                        }//while reader loop
                    }//reader
                    con.Close();
                }//sql command select query
            }//command count

            return totalPages;
        }//method



        public static bool writeCustomerData(string customername, string phonenumber, string registrationdate, string address, string paymentterm, string status)
        {
            if (!(customername.Equals("") || phonenumber.Equals("") || address.Equals("") || paymentterm.Equals("") || registrationdate.Equals("") || status.Equals("")))
            {
                try
                {
                    // Generate CustomerID
                    string query = $"INSERT INTO Customer([customername],[phonenumber],[address],[paymentterm],[registrationdate],[status]) VALUES( '{customername}', '{phonenumber}', '{address}','{paymentterm}','{registrationdate}', N'{status}')";

                    SqlConnection con = ConnectionClass.Connection();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        Console.WriteLine(query);
                        con.Open();
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        AuditLog.AddAuditInfo("Add", getCustomerNumID(), $"[{ConnectionClass.empid}] added [{customername}] to [{CurrentFormClass.form}]");
                        return true;

                    }
                }
                catch (Exception ex)
                {
                    new CustomMessageBox("Exception", ex.Message, MessageBoxButtons.OK).ShowDialog();
                    return false;
                }
            }
            else
            {
                new CustomMessageBox("Missing Element", "Fill in all required Fields.", MessageBoxButtons.OK).ShowDialog();
                return false;
            }
        }

        public static bool updateCustomerData(string numid, string customername, string phonenumber, string registrationdate, string address, string paymentterm, string status)
        {
            if (!(customername.Equals("") || phonenumber.Equals("") || address.Equals("") || paymentterm.Equals("") || registrationdate.Equals("") || status.Equals("")))
            {
                try
                {
                    string query = $"  UPDATE Customer\r\n" +
                            $"SET[customername] = '{customername}',\r\n    " +
                            $"[phonenumber] = '{phonenumber}',\r\n    " +
                            $"[address] = '{address}',\r\n    " +
                            $"[paymentterm] = '{paymentterm}',\r\n    " +
                            $"[registrationdate] = '{registrationdate}',\r\n    " +
                            $"[status] = N'{status}'\r\n" +
                            $"WHERE [numid] = {numid};";

                    SqlConnection con = ConnectionClass.Connection();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        Console.WriteLine(query);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        AuditLog.AddAuditInfo("Edit", getCustomerNumID(), $"[{ConnectionClass.empid}] Edited [{numid})] to [{CurrentFormClass.form}]");
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    new CustomMessageBox("Exception", ex.Message, MessageBoxButtons.OK).ShowDialog();
                    return false;
                }
            }
            else
            {
                new CustomMessageBox("Missing Element", "Fill in all required Fields.", MessageBoxButtons.OK).ShowDialog();
                return false;
            }
        }




        public static String getCustomerNumID()
        {
            int count = 0;
            try
            {
                SqlConnection con = ConnectionClass.Connection();
                string query = "SELECT COUNT(*) FROM Customer";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        count = (int)result;
                    }
                    con.Close();
                    return count + "";
                }
            }
            catch (Exception ex)
            {
                new CustomMessageBox("Exception", ex.Message, MessageBoxButtons.OK).ShowDialog();
            }
            return count + "";
        }






    }
}
