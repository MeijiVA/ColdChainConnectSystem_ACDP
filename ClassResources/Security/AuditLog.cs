using ColdChainConnectSystem_ACDP.Popup;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColdChainConnectSystem_ACDP.ClassResources.Security
{
    internal class AuditLog
    {

        public static void AddAuditInfo( String action, string refid, string desc)
        {
            Console.Write("Here in add");
            String user = ConnectionClass.empid;
            string reference = CurrentFormClass.form;
            switch (reference)
            {
                case "dbform":
                    reference = "Dashboard";
                    break;
                case "invform":
                    reference = "Inventory";
                    break;
                case "supform":
                    reference = "Supplier";
                    break;
                case "salform":
                    reference = "Sales";
                    break;
                case "custform":
                    reference = "Customer";
                    break;
                case "empform":
                    reference = "Employee";
                    break;
                default:
                    reference = "Dashboard";
                    break;
            }

            string sqlQuery = @"
            INSERT INTO Audit ([User], Action, Reference, ReferenceID, Description, ActionDate, Notified)
            VALUES (@User, @Action, @Reference, @ReferenceID, @Description, GETDATE(), @Notified);";

            using (SqlConnection connection = ConnectionClass.Connection())
            using (SqlCommand command = new SqlCommand(sqlQuery, connection))
            {
                try
                {
                    command.Parameters.AddWithValue("@User", user);
                    command.Parameters.AddWithValue("@Action", action);
                    command.Parameters.AddWithValue("@Reference", reference);
                    command.Parameters.Add("@ReferenceID", SqlDbType.VarChar).Value = refid;
                    command.Parameters.AddWithValue("@Description", desc);
                    command.Parameters.Add("@Notified", SqlDbType.Bit).Value = 0;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (SqlException ex)
                {
                    new CustomMessageBox("Database Error", ex.Message, MessageBoxButtons.OK).ShowDialog();
                }
                catch (Exception ex)
                {
                    new CustomMessageBox("Exception Error", ex.Message, MessageBoxButtons.OK).ShowDialog();
                }
            }

 
        }
    }
}
