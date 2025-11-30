
using ColdChainConnectSystem_ACDP.ClassResources.Security;
using ColdChainConnectSystem_ACDP.Popup;
using System;
using System.Collections;
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
                query = $"SELECT a.[numid], a.[salesid],a.[customerid],a.[salesdate],a.[productid],a.[quantity],i.[unitprice],(a.[quantity] * i.[unitprice])AS TOTAL,a.[status] FROM Sales as a JOIN Inventory AS i ON   a.[productid] = i.[numid] ORDER BY a.[numid] OFFSET {(currentPageIndex - 1) * PageSize} ROWS FETCH NEXT {PageSize} ROWS ONLY";
                using (SqlCommand data = new SqlCommand(query, con))
                {
                    using (var reader = data.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //[salesid],[customerid],[salesdate],[productid],[quantity],[unitprice],[status]
                            dgv.Rows.Add(new object[] { false, reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), Convert.ToDateTime(reader[3]).ToString("yyyy-MM-dd"), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString() });
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

            query = $"SELECT COUNT(*) FROM Sales AS A JOIN Inventory AS i ON  a.[productid] = i.[numid]  {searchQuery}";
            using (SqlCommand count = new SqlCommand(query, con))
            {
                totalRows = (int)count.ExecuteScalar();
                totalPages = (int)Math.Ceiling((double)totalRows / PageSize);
                lblPage.Text = totalPages.ToString();

                query = $"SELECT a.[numid], a.[salesid],a.[customerid],a.[salesdate],a.[productid],a.[quantity],i.[unitprice],(a.[quantity] * i.[unitprice]) AS TOTAL,a.[status] FROM Sales as a JOIN Inventory AS i ON   a.[productid] = i.[numid] {searchQuery} ORDER BY a.[numid] OFFSET {(currentPageIndex - 1) * PageSize} ROWS FETCH NEXT {PageSize} ROWS ONLY";
                using (SqlCommand data = new SqlCommand(query, con))
                {
                    using (var reader = data.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //[salesid],[customerid],[salesdate],[productid],[quantity],[unitprice],[status]
                            dgv.Rows.Add(new object[] { false, reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), Convert.ToDateTime(reader[3]).ToString("yyyy-MM-dd"), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), reader[8].ToString() });
                        }//while reader loop
                    }//reader
                    con.Close();
                }//sql command select query
            }//command count

            return totalPages;
        }//method


        //[salesid],[customerid],[salesdate],[productid],[quantity],[unitprice],[status]
        public static bool writeSalesData(string salesid, string custid, string sdate, string prodid, string quantity, string status, string createdby)
        {
            if (!(salesid.Equals("") || custid.Equals("") || sdate.Equals("") || prodid.Equals("") || quantity.Equals("") || status.Equals("") || createdby.Equals("")))
            {
                try
                {
                    string query = $"INSERT INTO Sales([salesid],[customerid],[salesdate],[productid],[quantity],[status],[createdby]) VALUES('{salesid}', '{custid}', '{sdate}',{prodid}, {quantity}, N'{status}',N'{createdby}')";
                    SqlConnection con = ConnectionClass.Connection();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        AuditLog.AddAuditInfo("Add", GetSalesNumID(), $"[{ConnectionClass.empid}] Added [{salesid}] to [{CurrentFormClass.form}]");

                    }
                    query = $"UPDATE Inventory SET [quantity] = [quantity] - {quantity} WHERE [numid] = {prodid}";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        AuditLog.AddAuditInfo("Deducted", GetSalesNumID(), $"[{ConnectionClass.empid}] Deducted [{quantity}] from [{prodid}] in [invform] via [{CurrentFormClass.form}]");
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


        public static string getNewSalesID()
        {
            String var = "";
            String query = "SELECT TOP 1[SalesID] FROM Sales ORDER BY [numid] DESC";
            SqlConnection con = ConnectionClass.Connection();
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var = reader[0].ToString();
                        var = var.Replace("SLS-00", "");
                        int i = Convert.ToInt32(var) + 1;
                        var = "SLS-00" + i;
                    }
                    else return "";
                }
                con.Close();
            }
            return var;
        }




        public static bool updateSalesData(string numid, string custid, string sdate, string quantity, string status)
        {
            if (!(custid.Equals("") || sdate.Equals("") || numid.Equals("") || quantity.Equals("") || status.Equals("")))
            {
                try
                {
                    string query = $"  UPDATE Sales SET\r\n" +
                            $"[customerid] = '{custid}',\r\n    " +
                            $"[salesdate] = '{sdate}',\r\n    " +
                            $"[quantity] = '{quantity}',\r\n    " +
                            $"[status] = '{status}'\r\n    " +
                            $"WHERE [numid] = {numid};";

                    SqlConnection con = ConnectionClass.Connection();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        AuditLog.AddAuditInfo("Edit", numid, $"[{ConnectionClass.empid}] Edited [{numid}] to [{CurrentFormClass.form}]");
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


        public static String GetSalesNumID()
        {
            int count = 0;
            try
            {
                SqlConnection con = ConnectionClass.Connection();
                string query = "SELECT COUNT(*) FROM Sales";

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
