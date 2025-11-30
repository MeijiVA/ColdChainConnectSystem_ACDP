using ColdChainConnectSystem_ACDP.ClassResources;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Dashboard
{
    public partial class DashoardForm : Form
    {
        public DashoardForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Apply to the form
        }
        private void DashoardForm_Load(object sender, EventArgs e)
        {
            try
            {
                //TOP PART COUNTER
                SqlConnection con = ConnectionClass.Connection();
                String query = "SELECT COUNT(*) FROM Customer";
                con.Open();
                using (SqlCommand countC = new SqlCommand(query, con))
                {
                    clblCustomer.Text = countC.ExecuteScalar().ToString();
                }
                query = "SELECT COUNT(*) FROM Inventory";
                using (SqlCommand countI = new SqlCommand(query, con))
                {
                    clblProducts.Text = countI.ExecuteScalar().ToString();
                }
                query = "SELECT COUNT(*) FROM Sales";
                using (SqlCommand countS = new SqlCommand(query, con))
                {
                    clblSales.Text = countS.ExecuteScalar().ToString();
                }
                query = "SELECT SUM(Price) FROM(SELECT(s.[quantity] * i.[unitprice]) AS Price FROM Sales AS s JOIN Inventory AS i ON s.[productID] = i.[numid]) AS SOURCETABLE";
                using (SqlCommand profit = new SqlCommand(query, con))
                {
                    decimal num = Convert.ToDecimal(profit.ExecuteScalar());
                    clblProfit.Text = "₱" + num.ToString("#,##0.#0");
                }
                con.Close();

                //LOAD LATEST SALES
                con.Open();
                query = "\r\nWITH ParsedSales AS (\r\n    SELECT\r\n        [SalesID],\r\n        [ProductID],\r\n        [Quantity],\r\n        [Status],\r\n        TRY_CAST(SUBSTRING(SalesID, 7, 10) AS INT) AS NumericSalesID\r\n    FROM\r\n        Sales\r\n),\r\nRankedSales AS (\r\n    SELECT \r\n        [SalesID],\r\n        [ProductID],\r\n        [Quantity],\r\n        [NumericSalesID],\r\n        [STATUS],\r\n        DENSE_RANK() OVER (ORDER BY NumericSalesID DESC) as [SalesRank]\r\n    FROM\r\n        [ParsedSales]\r\n    WHERE\r\n        [NumericSalesID] IS NOT NULL\r\n)\r\nSELECT \r\n    R.SalesID,\r\n    COUNT(R.ProductID) AS ItemCount,\r\n    SUM(R.Quantity * I.UnitPrice) AS TotalAmount,\r\n    R.Status\r\nFROM\r\n    RankedSales R\r\nJOIN\r\n    Inventory I ON R.ProductID = I.NumID\r\nWHERE\r\n    R.SalesRank <= 5 \r\nGROUP BY\r\n    R.SalesID, R.SalesRank, R.Status\r\nORDER BY\r\n    R.SalesRank ASC;\r\n";
                using (SqlCommand data = new SqlCommand(query, con))
                {
                    using (var reader = data.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            //[salesid],[customerid],[salesdate],[productid],[quantity],[unitprice],[status]
                            tableTransaction.Rows.Add(new object[] { reader[0].ToString(), reader[2].ToString(), reader[1].ToString(), getImage(reader[3].ToString()) });
                        }//while reader loop
                    }//reader
                    con.Close();
                }//sql command select query

                tableTransaction.ClearSelection();


                //LOAD EXPIRING ITEMS
                con.Open();
                query =
                   "SELECT TOP 5 [SkuCode],[Quantity], [Expiry], [Image]" +
                   "FROM [Inventory] " +
                   "WHERE [Expiry] >= GETDATE() AND [Expiry] <= DATEADD(month, 1, GETDATE()) AND [Quantity] > 0 " +
                   "ORDER BY [Expiry] ASC;";
                using (SqlCommand data = new SqlCommand(query, con))
                {
                    using (var reader = data.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            tableExpiry.Rows.Add(new object[] { reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), getImage(reader[3].ToString()) });
                        }//while reader loop
                    }//reader
                    con.Close();
                }//sql command select query
                tableExpiry.ClearSelection();
            }
            catch (Exception ex)
            {

            }
        }


        public static Image getImage(string imgStr)
        {
            Image i;
            if (imgStr.Equals("paid"))
            {
                i = Properties.Resources.Paid;
                return i;
            }
            else if (imgStr.Equals("unpaid"))
            {
                i = Properties.Resources.Unpaid;
                return i;
            }
            else
            {
                i = Properties.Resources.CCC_GrayLogo;
                return i;
            }
        }

        private void tableExpiry_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
