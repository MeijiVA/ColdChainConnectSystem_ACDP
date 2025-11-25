using ColdChainConnectSystem_ACDP.ClassResources;
using ColdChainConnectSystem_ACDP.Popup;
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
    public partial class ItemTab : UserControl
    {
        public ItemTab()
        {
            InitializeComponent();
        }

        double totalValuePrice;


        private void ItemTab_Load(object sender, EventArgs e)
        {
            // Add status values
            cbStatus.Items.Clear();
            cbStatus.Items.Add("paid");
            cbStatus.Items.Add("unpaid");
        }

        private void cbProductID_Load(object sender, EventArgs e)
        {
            string query = $"SELECT [NUMID] , [SKUCODE] FROM Inventory";
            SqlConnection con = ConnectionClass.Connection();
            con.Open();
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cbProductID.Items.Add(reader[0].ToString() + " | " + reader[1].ToString());
                    }
                }
            }
            con.Close();
        }

        private void cbProductID_OnSelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbProductID.SelectedItem != null)
            {
                string[] productID = cbProductID.SelectedItem.ToString().Trim().Split('|');
                try
                {
                    string query = $"SELECT [quantity], [unitprice] FROM Inventory WHERE [numid] = {productID[0]} ";
                    SqlConnection con = ConnectionClass.Connection();
                    con.Open();
                    Console.WriteLine(query);
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                tbQuantity.Maximum = Convert.ToInt32(reader[0].ToString());
                                lblUnitPrice.Text = reader[1].ToString();
                                lblPrice.Text = "" + Math.Round(1 * Convert.ToDouble(reader[1].ToString()), 2);
                                tbQuantity.Value = 1;
                                lblQuantityValue.Text = "" + tbQuantity.Value;
                            }
                        }
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    new CustomMessageBox("Exception", ex.Message, MessageBoxButtons.OK).ShowDialog();
                }
            }
        }

        private void tbQuantity_Scroll_1(object sender, EventArgs e)
        {
            lblQuantityValue.Text = "" + tbQuantity.Value;
            totalValuePrice = Convert.ToDouble(lblUnitPrice.Text) * tbQuantity.Value;
            lblPrice.Text = "" + totalValuePrice;
        }

        private void tbQuantity_MouseMove(object sender, MouseEventArgs e)
        {
            totalValuePrice = Convert.ToDouble(lblUnitPrice.Text) * tbQuantity.Value;
        }

        public string BatchID
        {
            get { return cbProductID.Texts; }
        }
        public string UnitPrice
        {
            get { return lblUnitPrice.Text; }
        }
        public string Quantity
        {
            get { return lblQuantityValue.Text; }
        }
        public string Status
        {
            get { return cbStatus.Text; }
        }










    }
}
