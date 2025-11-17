using ColdChainConnectSystem_ACDP.ClassResources.Display;
using ColdChainConnectSystem_ACDP.ClassResources.Instances;
using ColdChainConnectSystem_ACDP.Popup;
using ExcelDataReader;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Dapper.Plus;

namespace ColdChainConnectSystem_ACDP.ClassResources.Connection
{
    internal static class InvExcelClass
    {
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
                                    excelWorksheet.Cells[row, col].Value2 = reader[i];
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
