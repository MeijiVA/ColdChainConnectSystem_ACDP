
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
    internal class InventoryClass
    {
        static CustomMessageBox cmb;
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
                query = $"SELECT numid, skucode, descript, image, unitprice, kg, quantity, expiry FROM Inventory ORDER BY numid OFFSET {(currentPageIndex - 1) * PageSize} ROWS FETCH NEXT {PageSize} ROWS ONLY";
                using (SqlCommand data = new SqlCommand(query, con))
                {
                    using (var reader = data.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            double amount = double.Parse(reader[4].ToString()) * double.Parse(reader[6].ToString());

                            //  0        0    1    2    3     4        blank   5      6         7            8              9
                            //checkbox,  id, sku, desc,img,unitprice, amount, kg, quantity, buttonedit, button view, button delete
                            dgv.Rows.Add(new object[] { 0, reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), getImage(reader[3].ToString()), reader[4].ToString(), amount, reader[5].ToString(), reader[6].ToString() });
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
                query = $"SELECT numid,skucode, descript, image, unitprice, kg, quantity, expiry FROM Inventory {searchQuery} ORDER BY numid OFFSET {(currentPageIndex - 1) * PageSize} ROWS FETCH NEXT {PageSize} ROWS ONLY";
                using (SqlCommand data = new SqlCommand(query, con))
                {
                    using (var reader = data.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            double amount = double.Parse(reader[4].ToString()) * double.Parse(reader[6].ToString());

                            //  0        0    1    2    3     4        blank   5      6         7            8              9
                            //checkbox,  id, sku, desc,img,unitprice, amount, kg, quantity, buttonedit, button view, button delete
                            dgv.Rows.Add(new object[] { 0, reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), getImage(reader[3].ToString()), reader[4].ToString(), amount, reader[5].ToString(), reader[6].ToString() });
                        }//while reader loop
                    }//reader
                    con.Close();
                }//sql command select query
            }//command count

            return totalPages;
        }//method



        public static bool writeInventoryData(string sku, string desc, string unitp, string img, string kg, string quantity, string expiry)
        {
            if(!(sku.Equals("") || sku.Equals("") || desc.Equals("") || unitp.Equals("") || kg.Equals("") || quantity.Equals("") || expiry.Equals("")))
            {
                try
                {
                    if (img == "")
                    {
                        img = "NoImage.png";
                    }
                    string query = $"INSERT INTO Inventory(skucode, descript, image, unitprice, kg, quantity, expiry) VALUES('{sku}', '{desc}', '{img}', CAST({unitp} AS Decimal(18, 2)), {kg}, {quantity}, '{expiry}')";

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
                    cmb = new CustomMessageBox("Exception", ex.Message, MessageBoxButtons.OK);
                    cmb.ShowDialog();
                    return false;
                }
            }
            else
            {
                cmb = new CustomMessageBox("Missing Element","Fill in all required Fields.", MessageBoxButtons.OK);
                cmb.ShowDialog();
                return false;
            }
        }






    }
}
