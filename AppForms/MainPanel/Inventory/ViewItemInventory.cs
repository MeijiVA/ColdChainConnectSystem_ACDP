using ColdChainConnectSystem_ACDP.ClassResources;
using ColdChainConnectSystem_ACDP.ClassResources.Display;
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

namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Inventory
{
    public partial class ViewItemInventory : Form
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

        public ViewItemInventory()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Apply to the form
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void ViewEditInventory_Load(object sender, EventArgs e)
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
                        lblID.Text = "  [" + reader[0].ToString() + "] ( SKU CODE : " + reader[1].ToString() + ")";
                        lblUnitPrice.Text = reader[2].ToString();
                        lblWeight.Text = reader[3].ToString();
                        lblQuantity.Text = reader[4].ToString();
                        dpExpiry.Value = Convert.ToDateTime(reader[5]);
                        //pboxExpiry reader[6]
                        lblDescription.Text = reader[7].ToString();
                        lblSupplierID.Text = reader[8].ToString();
                        pboxExpiry.BackgroundImage = InventoryClass.CheckDate(dpExpiry.Value);
                        //QR CODE
                        string dataToEncode = $"NUMID:{reader[0].ToString()},"
                                             + $"SKUCODE:{reader[1].ToString()},"
                                             + $"DESC:{reader[7].ToString()},"
                                             + $"PRICE:{reader[2].ToString()},"
                                             + $"WEIGHT(KG):{reader[3].ToString()},"
                                             + $"QTY:{reader[4].ToString()},"
                                             + $"EXPRY:{Convert.ToDateTime(reader[5]).ToString("yyyy-MM-dd")},"
                                             + $"SUPID:{reader[8].ToString()}";
                        Bitmap qrCodeBitmap = QREncoder.GenerateQRCode(dataToEncode, 100); // Adjust pixel size as needed
                        pboxQR.BackgroundImage = qrCodeBitmap;



                    }
                }
            }
            con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnExitView_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
