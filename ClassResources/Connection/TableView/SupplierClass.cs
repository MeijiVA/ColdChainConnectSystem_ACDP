
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
    internal class SupplierClass

    {

        public static int loadSupplierData(DataGridView dgv, Label lblPage, Label lblPageNum, int currentPageIndex)
        {
            int totalRows = 0;
            int totalPages = 0;
            int PageSize = 10;
            String query;
            SqlConnection con = ConnectionClass.Connection();
            con.Open();
            query = "SELECT COUNT(*) FROM Supplier";
            using (SqlCommand count = new SqlCommand(query, con))
            {
                totalRows = (int)count.ExecuteScalar();
                totalPages = (int)Math.Ceiling((double)totalRows / PageSize);
                lblPage.Text = totalPages.ToString();
                query = $"SELECT [supplierid],[companyname],[contactperson],[contactnum],[address],[paymentterm] FROM Supplier ORDER BY [numid] OFFSET {(currentPageIndex - 1) * PageSize} ROWS FETCH NEXT {PageSize} ROWS ONLY";
                using (SqlCommand data = new SqlCommand(query, con))
                {
                    using (var reader = data.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //  0        0    1    2    3     4        blank   5      6         7            8              9
                            //checkbox,  id, sku, desc,img,unitprice, amount, kg, quantity, buttonedit, button view, button delete
                            dgv.Rows.Add(new object[] { 0, reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString() });
                        }//while reader loop
                    }//reader
                    con.Close();
                }//sql command select query
            }//command count

            return totalPages;
        }//method


        public static int loadSupplierData(DataGridView dgv, Label lblPage, Label lblPageNum, int currentPageIndex, string searchQuery)
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



            query = $"SELECT COUNT(*) FROM Supplier {searchQuery}";
            using (SqlCommand count = new SqlCommand(query, con))
            {
                totalRows = (int)count.ExecuteScalar();
                totalPages = (int)Math.Ceiling((double)totalRows / PageSize);
                lblPage.Text = totalPages.ToString();

                Console.WriteLine(totalRows + " TR " + totalPages + "TP");
                query = $"SELECT [supplierid],[companyname],[contactperson],[contactnum],[address],[paymentterm] FROM Supplier {searchQuery} ORDER BY [numid] OFFSET {(currentPageIndex - 1) * PageSize} ROWS FETCH NEXT {PageSize} ROWS ONLY";
                using (SqlCommand data = new SqlCommand(query, con))
                {
                    using (var reader = data.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            double amount = double.Parse(reader[4].ToString()) * double.Parse(reader[6].ToString());

                            //  0        0    1    2    3     4        blank   5      6         7            8              9
                            //checkbox,  id, sku, desc,img,unitprice, amount, kg, quantity, buttonedit, button view, button delete
                            dgv.Rows.Add(new object[] { 0, reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString() });
                        }//while reader loop
                    }//reader
                    con.Close();
                }//sql command select query
            }//command count

            return totalPages;
        }//method



        public static bool writeSupplierData(string supid, string compname, string contper, string contnum, string address, string payment)
        {
            if(!(supid.Equals("") || compname.Equals("") || contper.Equals("") || contnum.Equals("") || address.Equals("") || payment.Equals("")))
            {
                try
                {
                    string query = $"INSERT INTO Supplier([supplierid],[companyname],[contactperson],[contactnum],[address],[paymentterm]) VALUES('{supid}', '{compname}', '{contper}', '{contnum}', {address}, {payment})";

                    SqlConnection con = ConnectionClass.Connection();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        Console.WriteLine(query);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
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
                new CustomMessageBox("Missing Element","Fill in all required Fields.", MessageBoxButtons.OK).ShowDialog();
                return false;
            }
        }






    }
}
