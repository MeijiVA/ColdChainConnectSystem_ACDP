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

namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Sales
{
    public partial class ViewTransactionSales : Form
    {
        public ViewTransactionSales()
        {
            InitializeComponent();
        }

        private void ViewTransactionSales_Load(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM Sales WHERE [numid] = {ClassResources.Instances.VarView.id}";
            SqlConnection con = ConnectionClass.Connection();
            con.Open();
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {//num  custid custname phonenum address payterm regdate status
                        lblID.Text = "  [" + reader[0].ToString() + "] ( Sale ID : " + reader[1].ToString() + ")";
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void customLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
