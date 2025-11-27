using ColdChainConnectSystem_ACDP.ClassResources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Sales
{
    public partial class ViewTransactionSales : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
(
    int nLeftRect,     // x-coordinate of upper-left corner
    int nTopRect,      // y-coordinate of upper-left corner
    int nRightRect,    // x-coordinate of lower-right corner
    int nBottomRect,   // y-coordinate of lower-right corner
    int nWidthEllipse, // width of ellipse
    int nHeightEllipse // height of ellipse
);

        public ViewTransactionSales()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Apply to the form
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void ViewTransactionSales_Load(object sender, EventArgs e)
        {
            string query = $"SELECT a.[numid], a.[salesid],a.[customerid], c.[customername],a.[salesdate],a.[productid], i.[skucode],a.[quantity],i.[unitprice],(a.[quantity] * i.[unitprice]) AS TOTAL,a.[status] FROM Sales as a JOIN Inventory AS i ON a.[productid] = i.[numid] JOIN Customer AS c ON c.[customerid] = a.[customerid] WHERE a.[numid] = {ClassResources.Instances.VarView.id}";
            SqlConnection con = ConnectionClass.Connection();
            con.Open();
            Console.WriteLine(query);
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {//num sales cust sales
                        lblID.Text = "  [" + reader[0].ToString() + "] ( Sale ID : " + reader[1].ToString() + ")";
                        lblCustomerID.Text = reader[2].ToString();
                        lblCustomerName.Text = reader[3].ToString();
                        dpSalesDate.Value = Convert.ToDateTime(reader[4]);
                        lblProductID.Text = reader[5].ToString();
                        lblSku.Text = reader[6].ToString();
                        lblQuantity.Text = reader[7].ToString();
                        lblUnitPrice.Text = reader[8].ToString();
                        lblTotalPrice.Text = reader[9].ToString();
                        lblStatus.Text = reader[10].ToString();


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

        private void btnExitView_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
