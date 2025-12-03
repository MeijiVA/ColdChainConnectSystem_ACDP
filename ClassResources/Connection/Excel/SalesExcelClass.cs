using ColdChainConnectSystem_ACDP.ClassResources.Display;
using ColdChainConnectSystem_ACDP.ClassResources.Security;
using ColdChainConnectSystem_ACDP.Popup;
using Microsoft.CSharp.RuntimeBinder;
using Microsoft.Office.Interop.Excel;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ColdChainConnectSystem_ACDP.ClassResources.Connection
{
    internal class SalesExcelClass
    {
        public static void Import(String ofd)
        {

            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook excelWorkbook = excelApp.Workbooks.Open(ofd);
            Worksheet excelWorksheet = (Worksheet)excelWorkbook.Sheets[1]; 
            Range excelRange = excelWorksheet.UsedRange;

            SqlConnection con = ConnectionClass.Connection();

            try
            {
                con.Open();
                String query = "INSERT INTO Sales ([SalesID],[CustomerID],[SalesDate],[ProductID],[Quantity],[Status],[CreatedBy]) VALUES";
                if ((excelRange.Cells[1, 1] as Range).Value == "Sales")
                {
                    for (int row = 3; row <= excelRange.Rows.Count; row++)
                    {
                        string sid = "" + (excelRange.Cells[row, 2] as Microsoft.Office.Interop.Excel.Range).Value;
                        String cid = "" + (excelRange.Cells[row, 3] as Microsoft.Office.Interop.Excel.Range).Value;
                        DateTime date = Convert.ToDateTime((excelRange.Cells[row, 4] as Range).Value);
                        String salesdate = date.ToString("MM/dd/yyyy");
                        String prodid = "" + (excelRange.Cells[row, 5] as Microsoft.Office.Interop.Excel.Range).Value;
                        String quant = "" + (excelRange.Cells[row, 6] as Microsoft.Office.Interop.Excel.Range).Value;
                        String stat = "" + (excelRange.Cells[row, 8] as Microsoft.Office.Interop.Excel.Range).Value;
                        String createdby = ConnectionClass.empid;


                        query = query + $"('{sid}','{cid}','{salesdate}',{prodid},{quant},'{stat}','{createdby}')";
                        if (row != excelRange.Rows.Count)
                        {
                            query = query + ",\n";
                        }
                        Console.WriteLine(query);
                    }
                    using (SqlCommand command = new SqlCommand(query, con))
                    {

                        command.ExecuteNonQuery();
                    }
                    new CustomMessageBox("Import", "Import has been completed.", MessageBoxButtons.OK).ShowDialog();
                    AuditLog.AddAuditInfo("Import", "1", ConnectionClass.empid + " Imported Multiple Values to " + CurrentFormClass.form);
                }
                else
                {
                    new CustomMessageBox("Import", "Invalid DataSet.", MessageBoxButtons.OK).ShowDialog();
                }
               
            }
            catch(RuntimeBinderException ex)
            {
                new CustomMessageBox("RunTimeBinder Exception",ex.Message,MessageBoxButtons.OK).ShowDialog();
            }
            catch(Exception ex)
            {
                new CustomMessageBox("Exception",ex.Message,MessageBoxButtons.OK).ShowDialog();
            }
            finally
            {
                con.Close();
                excelWorkbook.Close();
                excelApp.Quit();
                if (excelRange != null)
                {
                    Marshal.FinalReleaseComObject(excelRange);
                }
                if (excelWorksheet != null)
                {
                    Marshal.FinalReleaseComObject(excelWorksheet);
                }
                if (excelWorkbook != null)
                {
                    Marshal.FinalReleaseComObject(excelWorkbook);
                }
                if (excelApp != null)
                {
                    Marshal.FinalReleaseComObject(excelApp);
                }
            }
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
                    Filter = $"WHERE [numid] LIKE '%{(searchQuery)}%' OR [customerid] LIKE '%{(searchQuery)}%' OR [SalesDate] LIKE '%{(searchQuery)}%' OR [ProductID] LIKE '%{(searchQuery)}%' OR [Quantity] LIKE '%{(searchQuery)}%' OR [Status] LIKE '%{(searchQuery)}%'";
                }
                else
                {
                    Filter = " WHERE " + SelectedFilterClass.SelectedFilter + " LIKE '%" + searchQuery + "%' ";
                }
                query = $"SELECT s.[numID] AS \"ID\",s.[SalesID] AS \"SalesID\",s.[CustomerID] AS \"CustomerID\" , s.[SalesDate] AS \"Sales Date\",s.[ProductID] AS \"Product ID\",s.[Quantity] AS \"Quantity\",s.[Quantity] * i.[UnitPrice] AS \"Total\", s.[Status] AS \"Status\" FROM Sales AS s JOIN Inventory AS i ON  s.[productid] = i.[numid] {Filter} ORDER BY s.numid;";
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
            // Create a new Excel application and workbook
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook excelWorkbook = excelApp.Workbooks.Add();
            Worksheet excelWorksheet = excelWorkbook.Worksheets[1];
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
                            // Add the headers to the first row
                            excelWorksheet.Cells[1, 1].Value = "Sales";
                            int col = 1;
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                excelWorksheet.Cells[2, col].Value2 = reader.GetName(i);
                                col++;
                            }

                            // Iterate through the rows of data and insert them into the worksheet, starting from the second row
                            int row = 3;
                            while (reader.Read())
                            {
                                col = 1;
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    if (i == 3)
                                    {
                                        DateTime date = Convert.ToDateTime(reader[3].ToString());
                                        excelWorksheet.Cells[row, col].Value2 = date.ToString("MM/dd/yyyy");
                                    } else
                                    {
                                        excelWorksheet.Cells[row, col].Value2 = reader[i].ToString();
                                    }
     
                                    col++;
                                }
                                row++;
                            }
                            new CustomMessageBox("Export", "Export has been completed.", MessageBoxButtons.OK).ShowDialog();
                            AuditLog.AddAuditInfo("Import", "1", ConnectionClass.empid + " Exported from " + CurrentFormClass.form);
                        }
                    }
                }

            }

            catch (Exception ex)
            {
                new CustomMessageBox("Export Problem",ex.Message,MessageBoxButtons.OK).ShowDialog();
            }
            finally
            {
                // Save the workbook and close the Excel application
                excelWorkbook.SaveAs(ofd);
                excelWorkbook.Close();
                excelApp.Quit();
                if (excelWorksheet != null)
                {
                    Marshal.FinalReleaseComObject(excelWorksheet);
                }
                if (excelWorkbook != null)
                {
                    Marshal.FinalReleaseComObject(excelWorkbook);
                }
                if (excelApp != null)
                {
                    Marshal.FinalReleaseComObject(excelApp);
                }
            }

        }
    }
}
