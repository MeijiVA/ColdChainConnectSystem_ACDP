using ColdChainConnectSystem_ACDP.Popup;
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Dapper.Plus;

namespace ColdChainConnectSystem_ACDP.ClassResources.Connection
{
    internal class ImportClass
    {

        static DataTableCollection tableCollection;
        public static void InsertDataToSQL(string fileName)
        {
            using(var stream = File.Open(fileName,FileMode.Open, FileAccess.Read))
            {
                using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                {
                    DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                    });
                    tableCollection = result.Tables;
                    foreach (DataTable table in tableCollection)
                    {

                    }
                }
            }

            try
            {
                string connectionString = "Data Source=localhost\\SQLExpress01;Initial Catalog=ColdChainConnectACDP_DB;Integrated Security=True;TrustServerCertificate=True";
                DapperPlusManager.Entity<Customers>().Table("Customers");
            }
            catch (Exception e)
            {
                CustomMessageBox cmb = new CustomMessageBox("Import Error","",MessageBoxButtons.OK);
                cmb.ShowDialog();
            }
        }
    }
}
