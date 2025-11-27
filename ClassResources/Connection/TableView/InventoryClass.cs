
using ColdChainConnectSystem_ACDP.Materials;
using ColdChainConnectSystem_ACDP.Popup;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IdentityModel.Tokens;
using System.IO;
using System.Security.Policy;
using System.Windows.Forms;

namespace ColdChainConnectSystem_ACDP.ClassResources
{
    internal class InventoryClass
    {
        public static void SetSuppliers(CustomComboBox cbx)
        {
            try
            {
                String query = $"SELECT [SupplierID], [CompanyName] FROM Supplier ";
                SqlConnection con = ConnectionClass.Connection();
                con.Open();
                Console.WriteLine(query);
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cbx.Items.Add(reader[0].ToString() + " | " + reader[1].ToString());
                        }
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                new CustomMessageBox("Exception", ex.Message, MessageBoxButtons.OK).ShowDialog();
            }
        }
        public static Image CheckDate(DateTime expiryDate)
        {
            Image i;
            var bestByDate = DateTime.Today.AddMonths(2);
            //3 to 4 months best to sell frozen goods
            if (expiryDate >= bestByDate)
            {
                i = Properties.Resources.Expiry_Green_;
                return i;//color green = good;
            }
            else if (expiryDate <= bestByDate && expiryDate >= DateTime.Today)
            {
                i = Properties.Resources.Expiry_Yellow_;
                return i;//color yellow = still ok;
            }
            else 
            {
                i = Properties.Resources.Expiry_Red_;
                return i;//color red = bad;
            }

        }
        public static Image getImage(string imgStr)
        {
            Image i;
            if (File.Exists(Directory.GetCurrentDirectory() + "\\InventoryImage\\" + imgStr))
            {
                i = Image.FromFile(Directory.GetCurrentDirectory() + "\\InventoryImage\\" + imgStr);
                return i;
            }
            else
            {
                i = Properties.Resources.CCC_GrayLogo;
                return i;
            }
        }
        public static int loadInventoryData(DataGridView dgv, Label lblPage, Label lblPageNum, int currentPageIndex)
        {
            int totalRows = 0;
            int totalPages = 0;
            int PageSize = 10;
            String query;
            SqlConnection con = ConnectionClass.Connection();
            con.Open();
            query = "SELECT COUNT(*) FROM Inventory";
            using (SqlCommand count = new SqlCommand(query, con))
            {
                totalRows = (int)count.ExecuteScalar();
                totalPages = (int)Math.Ceiling((double)totalRows / PageSize);
                lblPage.Text = totalPages.ToString();
                query = $"SELECT [numid],[skucode],[description],[image],[unitprice],[SupplierID],[kg],[quantity],[expiry] FROM Inventory ORDER BY [numid] OFFSET {(currentPageIndex - 1) * PageSize} ROWS FETCH NEXT {PageSize} ROWS ONLY";
                using (SqlCommand data = new SqlCommand(query, con))
                {
                    using (var reader = data.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            //  0        0    1    2    3     4         5      6      7       8              9          10
                            //checkbox,  id, sku, desc,img,unitprice, suppid, kg, quantity, buttonedit, button view, button delete
                            dgv.Rows.Add(new object[] { CheckDate(Convert.ToDateTime(reader[8])), reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), getImage(reader[3].ToString()), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString() });
                        }//while reader loop
                    }//reader
                    con.Close();
                }//sql command select query
            }//command count

            return totalPages;
        }//method


        public static int loadInventoryData(DataGridView dgv, Label lblPage, Label lblPageNum, int currentPageIndex, string searchQuery)
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



            query = $"SELECT COUNT(*) FROM Inventory {searchQuery}";
            using (SqlCommand count = new SqlCommand(query, con))
            {
                totalRows = (int)count.ExecuteScalar();
                totalPages = (int)Math.Ceiling((double)totalRows / PageSize);
                lblPage.Text = totalPages.ToString();

                Console.WriteLine(totalRows + " TR " + totalPages + "TP");
                query = $"SELECT [numid],[skucode],[description],[image],[unitprice],[SupplierID],[kg],[quantity],[expiry] FROM Inventory {searchQuery} ORDER BY [numid] OFFSET {(currentPageIndex - 1) * PageSize} ROWS FETCH NEXT {PageSize} ROWS ONLY";
                using (SqlCommand data = new SqlCommand(query, con))
                {
                    using (var reader = data.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            double amount = double.Parse(reader[4].ToString()) * double.Parse(reader[6].ToString());
                            //  0        0    1    2    3     4         5      6      7       8              9          10
                            //checkbox,  id, sku, desc,img,unitprice, suppid, kg, quantity, buttonedit, button view, button delete
                            dgv.Rows.Add(new object[] { 0, reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), getImage(reader[3].ToString()), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), reader[7].ToString() });
                        }//while reader loop
                    }//reader
                    con.Close();
                }//sql command select query
            }//command count

            return totalPages;
        }//method



        public static bool writeInventoryData(string sku, string desc, string unitp, string img, string kg, string quantity, string expiry, string supid)
        {
            if (!(sku.Equals("") || sku.Equals("") || desc.Equals("") || unitp.Equals("") || kg.Equals("") || quantity.Equals("") || expiry.Equals("") || supid.Equals("")))
            {
                try
                {
                    if (img == "")
                    {
                        img = "NoImage.png";
                    }
                    string query = $"INSERT INTO Inventory([skucode],[description],[image],[unitprice],[supplierid],[kg],[quantity],[expiry]) VALUES('{sku}', '{desc}', '{img}', CAST({unitp} AS Decimal(18, 2)), '{supid}',{kg}, {quantity}, N'{expiry}')";

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
                new CustomMessageBox("Missing Element", "Fill in all required Fields.", MessageBoxButtons.OK).ShowDialog();
                return false;
            }
        }

        public static bool updateInventoryData(string numid,string sku, string desc, string unitp, string img, string kg, string quantity, string expiry, string supid)
        {
            if (!(sku.Equals("") || sku.Equals("") || desc.Equals("") || unitp.Equals("") || kg.Equals("") || quantity.Equals("") || expiry.Equals("") || supid.Equals("")))
            {
                try
                {
                    if (img == "")
                    {
                        img = "NoImage.png";
                    }
                    string query = $"UPDATE Inventory SET [skucode] = '{sku}'," +
                        $"[description] = '{desc}'," +
                        $"[image] = '{img}'," +
                        $"[unitprice] = CAST({unitp} AS Decimal(18, 2))," +
                        $"[supplierid] =  '{supid}'" +
                        $",[kg] = {kg}," +
                        $"[quantity] = {quantity}," +
                        $"[expiry] = N'{expiry}'" +
                        $"WHERE [numid] = '{numid}'";

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
                new CustomMessageBox("Missing Element", "Fill in all required Fields.", MessageBoxButtons.OK).ShowDialog();
                return false;
            }
        }


    }
}
