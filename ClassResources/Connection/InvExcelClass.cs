using ColdChainConnectSystem_ACDP.ClassResources.Display;
using ColdChainConnectSystem_ACDP.ClassResources.Instances;
using ColdChainConnectSystem_ACDP.Popup;
using ExcelDataReader;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColdChainConnectSystem_ACDP.ClassResources.Connection
{
    internal class InvExcelClass
    {
        public static void Import(String ofd, DataGridView dataGridView)
        {
  
            Microsoft.Office.Interop.Excel.Application  excelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(ofd);
            Microsoft.Office.Interop.Excel.Worksheet excelWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)excelWorkbook.Sheets[1]; // Assuming data is in the first sheet
            Microsoft.Office.Interop.Excel.Range excelRange = excelWorksheet.UsedRange;

            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("skucode",typeof(string));
            dt.Columns.Add("unitprice", typeof(double));
            dt.Columns.Add("kg", typeof(int));
            dt.Columns.Add("quantity", typeof(int));
            dt.Columns.Add("expiry");
            dt.Columns.Add("image",typeof(string));
            dt.Columns.Add("descript", typeof(string));
            // Populate the DataTable with data from Excel, starting from the second row (after headers)
            for (int row = 2; row <= excelRange.Rows.Count; row++)
            {
                System.Data.DataRow dr = dt.NewRow();
                for (int col = 1; col <= excelRange.Columns.Count; col++)
                {
                    //ID	SKU Code	Description	Unit Price	Amount	Weight(KG)	Quantity	Expiry Date
                    dr[0] = (excelRange.Cells[row, 2] as Microsoft.Office.Interop.Excel.Range).Value;//sku
                    dr[1] = (excelRange.Cells[row, 4] as Microsoft.Office.Interop.Excel.Range).Value;//unit
                    dr[2] = (excelRange.Cells[row, 6] as Microsoft.Office.Interop.Excel.Range).Value;//kg
                    dr[3] = (excelRange.Cells[row, 7] as Microsoft.Office.Interop.Excel.Range).Value;//qty
                    string excelDate = ""+ (excelRange.Cells[row, 8] as Microsoft.Office.Interop.Excel.Range).Value;
                    dr[4] = excelDate.Substring(0,8);//expiry
                    dr[5] = "Image.png";//image
                    dr[6] = (excelRange.Cells[row, 3] as Microsoft.Office.Interop.Excel.Range).Value;//descript


                }
                dt.Rows.Add(dr);
            }
            dataGridView.DataSource = dt;

            SqlConnection con = ConnectionClass.Connection();
            con.Open();
            using (SqlBulkCopy bulkCopy = new SqlBulkCopy(con))
            {
                bulkCopy.DestinationTableName = "Inventory"; // Name of the target table in the database

                // Map columns from DataTable to database table (if names differ)
                // bulkCopy.ColumnMappings.Add("DataTableColumnName", "DatabaseColumnName");

                bulkCopy.WriteToServer(dt);
            }
            con.Close();
            excelWorkbook.Close();
            excelApp.Quit();
        }







        public static void Export(String searchQuery, String ofd)
        {
            string Filter = "";
            String query = "";
            try
            {
                if ((searchQuery.Equals("Search Term") || searchQuery.Equals("")))
                {
                    Filter = "";
                }
                else if (SelectedFilterClass.SelectedFilter.Equals(""))
                {
                    Filter = $"WHERE numid LIKE '%{(searchQuery)}%' OR skucode LIKE '%{(searchQuery)}%' OR quantity LIKE '%{(searchQuery)}%' OR expiry LIKE '%{(searchQuery)}%' OR descript LIKE '%{(searchQuery)}%' ";
                }
                else
                {
                    Filter = " WHERE " + SelectedFilterClass.SelectedFilter + " LIKE '%" + searchQuery + "%' ";
                }
                query = $"SELECT numid AS \"ID\",skucode AS \"SKU Code\" , descript AS \"Description\",unitprice AS \"Unit Price\", unitprice * quantity AS \"Amount\", kg AS \"Weight(KG)\", quantity AS \"Quantity\", expiry AS \"Expiry Date\"FROM Inventory {Filter} ORDER BY numid;";
                Console.WriteLine(query);
                ExportDataFromTable(query, ofd);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //not mine, don't edit xd
        public static void ExportDataFromTable(string query, String ofd)
        {
            try
            {
                if (File.Exists(ofd))
                    File.Delete(ofd);

                // Connect to the SQL Server database and retrieve the data you want to export
                using (SqlConnection connection = ConnectionClass.Connection())
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Create a new Excel application and workbook
                            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                            Workbook excelWorkbook = excelApp.Workbooks.Add();
                            Worksheet excelWorksheet = excelWorkbook.Worksheets[1];

                            // Add the headers to the first row
                            int col = 1;
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                excelWorksheet.Cells[1, col].Value2 = reader.GetName(i);
                                col++;
                            }

                            // Iterate through the rows of data and insert them into the worksheet, starting from the second row
                            int row = 2;
                            while (reader.Read())
                            {
                                col = 1;
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    if (i == 7)
                                    {
                                        excelWorksheet.Cells[row, col].Value2 = reader[7].ToString().Substring(0,8);
                                    } else
                                    {
                                        excelWorksheet.Cells[row, col].Value2 = reader[i].ToString();
                                    }
     
                                    col++;
                                }
                                row++;
                            }

                            // Save the workbook and close the Excel application
                            excelWorkbook.SaveAs(ofd);
                            excelWorkbook.Close();
                            excelApp.Quit();
                        }
                    }
                }

            }

            catch (Exception ex)
            {
                new CustomMessageBox("Export Problem",ex.Message,MessageBoxButtons.OK).ShowDialog();
            }


        }
    }
}
