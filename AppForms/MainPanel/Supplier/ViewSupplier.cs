using ColdChainConnectSystem_ACDP.ClassResources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Supplier
{
    public partial class ViewSupplier : Form
    {
        public ViewSupplier()
        {
            InitializeComponent();
        }

        private void ViewSupplier_Load(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM Inventory WHERE [numid] = {ClassResources.Instances.VarView.id}";
            SqlConnection con = ConnectionClass.Connection();
            con.Open();
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {//num  custid custname phonenum address payterm regdate status
                        lblID.Text = "  [" + reader[0].ToString() + "] ( Supplier ID : " + reader[1].ToString() + ")";
                    }
                }
            }
        }
    }
}
