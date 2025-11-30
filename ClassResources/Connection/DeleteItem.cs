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
                Console.WriteLine(query);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}
