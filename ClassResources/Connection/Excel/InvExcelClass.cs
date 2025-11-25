using ColdChainConnectSystem_ACDP.ClassResources.Display;
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
    internal class InvExcelClass
    {
        public static void Import(String ofd)
        {

            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Workbook excelWorkbook = excelApp.Workbooks.Open(ofd);
            Worksheet excelWorksheet = (Worksheet)excelWorkbook.Sheets[1]; // Assuming data is in the first sheet
            Range excelRange = excelWorksheet.UsedRange;

            SqlConnection con = ConnectionClass.Connection();

            try
            {//skucode,unitprice,kg,quantity,expiry,image,descript
                con.Open();//[numid],[skucode],[description],[image],[unitprice],[kg],[quantity],[expiry]
                String query = "INSERT INTO Inventory ([skucode],[unitprice],[kg],[quantity],[expiry],[image],[description],[supplierid]) VALUES";
                if ((excelRange.Cells[1, 1] as Range).Value == "Inventory")
                {
                    
                }
                for (int row = 3; row <= excelRange.Rows.Count; row++)
                {
                    String skucode = "" + (excelRange.Cells[row, 2] as Range).Value;
                    String unitprice = "" + (excelRange.Cells[row, 4] as Range).Value;
                    String kg = "" + (excelRange.Cells[row, 6] as Range).Value;
                    String qty = "" + (excelRange.Cells[row, 7] as Range).Value;

                    DateTime date = Convert.ToDateTime((excelRange.Cells[row, 8] as Range).Value);
                    String expiry = date.ToString("MM/dd/yyyy");
                    // I have to switch these places because SQL only acccepts MM/dd/yyyy while excel autoconverts to MM/dd/yyyy
                    String supid = "" + (excelRange.Cells[row, 5] as Microsoft.Office.Interop.Excel.Range).Value;
                    String image = "Image.png";
                    String desc = "" + (excelRange.Cells[row, 3] as Microsoft.Office.Interop.Excel.Range).Value;
                    query = query + $"('{skucode}',{unitprice},{kg},{qty},'{expiry}','{image}','{desc}','{supid}')";
                    if (row != excelRange.Rows.Count)
                    {
                        query = query + ",\n";
                    }
                }
                Console.WriteLine(query);
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    //ID	SKU Code	Description	Unit Price	Amount	Weight(KG)	Quantity	Expiry Date
                    command.ExecuteNonQuery();
                }
                new CustomMessageBox("Import", "Import has been completed.", MessageBoxButtons.OK).ShowDialog();
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
                    Filter = $"WHERE numid LIKE '%{(searchQuery)}%' OR skucode LIKE '%{(searchQuery)}%' OR quantity LIKE '%{(searchQuery)}%' OR expiry LIKE '%{(searchQuery)}%' OR descript LIKE '%{(searchQuery)}%' OR quantity LIKE '%{(searchQuery)}%' OR expiry LIKE '%{(searchQuery)}%' OR [supplierid] LIKE '%{(searchQuery)}%'";
                }
                else
                {
                    Filter = " WHERE " + SelectedFilterClass.SelectedFilter + " LIKE '%" + searchQuery + "%' ";
                }
                query = $"SELECT [numid] AS \"ID\",[skucode] AS \"SKU Code\" , [description] AS \"Description\",[unitprice] AS \"Unit Price\", [SupplierID] AS \"Supplier\", [kg] AS \"Weight(KG)\", [quantity] AS \"Quantity\", [expiry] AS \"Expiry Date\" FROM Inventory {Filter} ORDER BY numid;";
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
                            excelWorksheet.Cells[1, 1].Value = "Inventory";
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
                                    if (i == 7)
                                    {
                                        DateTime date = Convert.ToDateTime(reader[7].ToString());
                                        excelWorksheet.Cells[row, col].Value2 = date.ToString("MM/dd/yyyy");
                                        Console.WriteLine(date.ToString("MM/dd/yyyy"));
                                    } else
                                    {
                                        excelWorksheet.Cells[row, col].Value2 = reader[i].ToString();
                                    }
     
                                    col++;
                                }
                                row++;
                            }
                            new CustomMessageBox("Export", "Export has been completed.", MessageBoxButtons.OK).ShowDialog();

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
