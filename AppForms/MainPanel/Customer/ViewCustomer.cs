using ColdChainConnectSystem_ACDP.ClassResources;
using ColdChainConnectSystem_ACDP.ClassResources.Instances;
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

namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Customer
{
    public partial class ViewCustomer : Form
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

                  
        public ViewCustomer()
        {
            InitializeComponent();  
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void ViewCustomer_Load(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM Customer WHERE [numid] = {ClassResources.Instances.VarView.id}";
            SqlConnection con = ConnectionClass.Connection();
            con.Open();
            using (SqlCommand cmd = new SqlCommand(query, con)) 
            {
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {//num  custid custname phonenum address payterm regdate status
                        lblID.Text = "  [" + reader[0].ToString() + "] ( Customer ID :" + reader[1].ToString() + ")";
                        lblCustomerName.Text = reader[2].ToString();
                        lblPhoneNumber.Text = reader[3].ToString();
                        String[] address = reader[4].ToString().Split(',');
                        lblHouseNumber.Text = address[0];
                        lblBarangay.Text = address[1];
                        lblCity.Text = address[2];
                        lblProvince.Text = address[3];
                        lblPostal.Text = address[4];
                        lblPaymentTerm.Text = reader[5].ToString();
                        dpRegistrationDate.Value = Convert.ToDateTime(reader[6]);
                        lblStatus.Text = reader[7].ToString();
                    }
                }
            }
        }

        private void btnExitView_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
