using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColdChainConnectSystem_ACDP.ClassResources.Connection.TableView
{
    internal class DeleteItem
    {
        public static void Delete(String item, String table)
        {
            String query = $"DELETE FROM {table} WHERE [numid] = {item}";
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
