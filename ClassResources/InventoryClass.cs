
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ColdChainConnectSystem_ACDP.ClassResources
{
    internal class InventoryClass
    {
        public static  void setInventoryData(DataGridView dgv)
        {
            Image testImage = Properties.Resources.CCC_GrayLogo;
            StreamReader sr = new StreamReader(ConnectionClass.filePath);
            string database = sr.ReadLine();
            database = database.Replace("username", ConnectionClass.username);
            database = database.Replace("password", ConnectionClass.pass);
            SqlConnection con = new SqlConnection(database);
            string query = "SELECT skucode, descript, image, unitprice, kg, quantity, expiry FROM Inventory";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        double amount = double.Parse(reader[3].ToString())  * double.Parse(reader[5].ToString());

                        //  0        0    1    2      3      blank    4      5         6          7              8
                        //checkbox, sku, desc,img,unitprice, amount, kg, quantity, buttonedit, button view, button delete
                        dgv.Rows.Add(new object[] { 0, reader[0].ToString(), reader[1].ToString(), testImage, reader[3].ToString(), amount ,reader[4].ToString(), reader[5].ToString()});
                    }
                }
                con.Close();
            }
        }
    }
}
