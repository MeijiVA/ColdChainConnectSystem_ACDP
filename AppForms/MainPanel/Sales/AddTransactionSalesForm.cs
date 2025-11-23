using ColdChainConnectSystem_ACDP.ClassResources;
using ColdChainConnectSystem_ACDP.ClassResources.Instances;
using ColdChainConnectSystem_ACDP.Popup;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Sales
{
    public partial class AddTransactionSalesForm : Form
    {
        CustomMessageBox cmb;
        public AddTransactionSalesForm()
        {
            InitializeComponent();
            string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            MainInstance.i.NavigateTo(new SalesForm());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cmb = new CustomMessageBox("Add Item", "Confirm?", MessageBoxButtons.OKCancel);
            if (cmb.ShowDialog() == DialogResult.OK)
            {
                if (SalesClass.writeSalesData(txtSales.Texts, txtCustomerID.Texts, dpSalesDate.Value.ToString("yyyy-MM-dd"), cbProductID.Texts, txtQuantity.Texts, cbStatus.Texts))
                {
                    try
                    {
                        this.Close();
                        MainInstance.i.NavigateTo(new SalesForm());
                    }
                    catch (Exception ex)
                    {
                        cmb = new CustomMessageBox("Missing Element", ex.Message, MessageBoxButtons.OK);
                        cmb.Show();
                    }
                }
            }
        }

        private void customTextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void AddItemInventoryForm_Load(object sender, EventArgs e)
        {
            // Add status values
            cbStatus.Items.Clear();
            cbStatus.Items.Add("paid");
            cbStatus.Items.Add("unpaid");

            // Set default date to today
            dpSalesDate.Value = DateTime.Now;
        }

        private void cbProductID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProductID.SelectedItem != null)
            {
                string productID = cbProductID.SelectedItem.ToString();

                // Get the most recent sale for this product to populate fields as reference
                try
                {
                    string query = $"SELECT TOP 1 [customerid], [status], [quantity], [salesdate] FROM Sales WHERE [productid] = '{productID}' ORDER BY [salesdate] DESC";
                    SqlConnection con = ConnectionClass.Connection();
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Populate fields with the most recent sale data (except salesID which should be unique)
                                txtCustomerID.Texts = reader[0].ToString();
                                cbStatus.Texts = reader[1].ToString();
                                txtQuantity.Texts = reader[2].ToString();
                                if (reader[3] != DBNull.Value)
                                {
                                    dpSalesDate.Value = Convert.ToDateTime(reader[3]);
                                }
                            }
                        }
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    // If no previous sales exist, just populate productID
                    // User can fill in other fields manually
                }
            }
        }

        private void lblExpiry_Click(object sender, EventArgs e)
        {

        }
    }
}
