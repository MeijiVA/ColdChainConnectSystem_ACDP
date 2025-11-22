
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
    internal class SalesClass
    {
        public static int loadSalesData(DataGridView dgv, Label lblPage, Label lblPageNum, int currentPageIndex)
        {
            int totalRows = 0;
            int totalPages = 0;
            int PageSize = 10;
            String query;
            SqlConnection con = ConnectionClass.Connection();
            con.Open();
            query = "SELECT COUNT(*) FROM Sales AS A JOIN Inventory AS i ON  a.[productid] = i.[numid] ";
            using (SqlCommand count = new SqlCommand(query, con))
            {
                totalRows = (int)count.ExecuteScalar();
                totalPages = (int)Math.Ceiling((double)totalRows / PageSize);
                lblPage.Text = totalPages.ToString();
                Console.WriteLine(query);
                query = $"SELECT a.[salesid],a.[customerid],a.[salesdate],a.[productid],a.[quantity],i.[unitprice],a.[status] FROM Sales as a JOIN Inventory AS i ON   a.[productid] = i.[numid] ORDER BY a.[numid] OFFSET {(currentPageIndex - 1) * PageSize} ROWS FETCH NEXT {PageSize} ROWS ONLY";
                Console.WriteLine(query);
                using (SqlCommand data = new SqlCommand(query, con))
                {
                    using (var reader = data.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //[salesid],[customerid],[salesdate],[productid],[quantity],[unitprice],[status]
                            dgv.Rows.Add(new object[] { 0, reader[0].ToString(), reader[1].ToString(), Convert.ToDateTime(reader[2]).ToString("yyyy-MM-dd"), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString() });
                        }//while reader loop
                    }//reader
                    con.Close();
                }//sql command select query
            }//command count

            return totalPages;
        }//method


        public static int loadSalesData(DataGridView dgv, Label lblPage, Label lblPageNum, int currentPageIndex, string searchQuery)
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



            query = $"SELECT COUNT(*) FROM Sales AS A JOIN Inventory AS i ON  a.[productid] = i.[numid]  {searchQuery}";
            using (SqlCommand count = new SqlCommand(query, con))
            {
                totalRows = (int)count.ExecuteScalar();
                totalPages = (int)Math.Ceiling((double)totalRows / PageSize);
                lblPage.Text = totalPages.ToString();

                Console.WriteLine(totalRows + " TR " + totalPages + "TP");
                Console.WriteLine(query);
                query = $"SELECT a.[salesid],a.[customerid],a.[salesdate],a.[productid],a.[quantity],i.[unitprice],a.[status] FROM Sales as a JOIN Inventory AS i ON   a.[productid] = i.[numid] {searchQuery} ORDER BY a.[numid] OFFSET {(currentPageIndex - 1) * PageSize} ROWS FETCH NEXT {PageSize} ROWS ONLY";
                Console.WriteLine(query);
                using (SqlCommand data = new SqlCommand(query, con))
                {
                    using (var reader = data.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //[salesid],[customerid],[salesdate],[productid],[quantity],[unitprice],[status]
                            dgv.Rows.Add(new object[] { 0, reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString() });
                        }//while reader loop
                    }//reader
                    con.Close();
                }//sql command select query
            }//command count

            return totalPages;
        }//method


        //[salesid],[customerid],[salesdate],[productid],[quantity],[unitprice],[status]
        public static bool writeSalesData(string sid, string custid, string sdate, string prodid, string quantity, string status)
        {
            if(!(sid.Equals("") || custid.Equals("") || sdate.Equals("") || prodid.Equals("") || quantity.Equals("") || status.Equals("")))
            {
                try
                {
                    string query = $"INSERT INTO Sales([salesid],[customerid],[salesdate],[productid],[quantity],[status]) VALUES('{sid}', '{custid}', '{sdate}', '{prodid}', {quantity}, N'{status}')";

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
