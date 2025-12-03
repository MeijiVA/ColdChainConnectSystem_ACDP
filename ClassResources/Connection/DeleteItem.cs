using ColdChainConnectSystem_ACDP.ClassResources.Security;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ColdChainConnectSystem_ACDP.ClassResources.Connection.SqlInjectionPrevention;

namespace ColdChainConnectSystem_ACDP.ClassResources.Connection.TableView
{
    internal class DeleteItem
    {
        public static void Delete(String item, String table)
        {
            // Sanitize inputs to prevent SQL injection
            string sanitizedItem = SanitizeInput(item);
            string sanitizedTable = SanitizeInput(table);
            String query = $"DELETE FROM {sanitizedTable} WHERE [numid] = {sanitizedItem}";
            SqlConnection con = ConnectionClass.Connection();
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                AuditLog.AddAuditInfo("Delete",item, ConnectionClass.empid + $" Deleted Item [{item}] in " + CurrentFormClass.form);
            }
        }
    }
}
