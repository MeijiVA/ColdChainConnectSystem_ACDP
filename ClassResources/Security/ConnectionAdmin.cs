using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ColdChainConnectSystem_ACDP.ClassResources.Security
{
    internal class ConnectionAdmin
    {
        public static SqlConnection Connection()
        {
            StreamReader sr = new StreamReader(ConnectionClass.filePath);
            ConnectionClass.db = sr.ReadLine();
            sr.Close();
            string database = "Data Source= @database ;Initial Catalog=ColdChainConnectACDP_DB;Integrated Security=True;TrustServerCertificate=True";
            database = database.Replace("@database", ConnectionClass.db);
            Console.WriteLine(database);
            return new SqlConnection(database);
        }
    }
}
