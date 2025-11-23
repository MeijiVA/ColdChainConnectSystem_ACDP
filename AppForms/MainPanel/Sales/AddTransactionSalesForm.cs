using ColdChainConnectSystem_ACDP.ClassResources;
using ColdChainConnectSystem_ACDP.ClassResources.Instances;
using ColdChainConnectSystem_ACDP.Popup;
using Microsoft.Office.Interop.Excel;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Net.NetworkInformation;
using System.Windows.Forms;

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
            cmb = new CustomMessageBox("Add Supplier", "Confirm?", MessageBoxButtons.OKCancel);
            if (cmb.ShowDialog() == DialogResult.OK)
            {
                {
                    try
                    {
                        String[] ProdID = cbProductID.Texts.ToString().Trim().Split('|');
                        if (SalesClass.writeSalesData(cbCustomerID.Texts, dpSalesDate.Value.ToString("yyyy-MM-dd"), ProdID[0], tbQuantity.Value.ToString(),cbStatus.Texts))
                        {//custName phonenum regdate address payterm status
                            this.Close();
                            MainInstance.i.NavigateTo(SalesInstance.i);
                            SalesInstance.i.UpdateTable();
                        }
                    }
                    catch (Exception ex)
                    {
                        new CustomMessageBox("Missing Element", ex.Message, MessageBoxButtons.OK).ShowDialog();
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

        private void cbProductID_Load(object sender, EventArgs e)
        {
            string query = $"SELECT [numid], [skucode] FROM Inventory";
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


        double totalValuePrice;
        private void tbQuantity_MouseMove(object sender, MouseEventArgs e)
        {
            totalValuePrice = Convert.ToDouble(lblUnitPrice.Text) * tbQuantity.Value;
        }
        private void tbQuantity_Scroll(object sender, EventArgs e)
        {
            lblQuantityValue.Text =""+ tbQuantity.Value;
            totalValuePrice = Convert.ToDouble(lblUnitPrice.Text) * tbQuantity.Value;
            lblPrice.Text = "" + totalValuePrice;
        }




        private void cbProductID_OnSelectedIndexChanged(object sender, EventArgs e)
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
                                lblUnitPrice.Text  = reader[1].ToString();
                                lblPrice.Text =""+ Math.Round(1 * Convert.ToDouble(reader[1].ToString()),2);
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

        private void customComboBox1_Load(object sender, EventArgs e)
        {
            string query = $"SELECT [CustomerID] FROM Customer";
            SqlConnection con = ConnectionClass.Connection();
            con.Open();
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cbCustomerID.Items.Add(reader[0].ToString());
                    }
                }
            }
            con.Close();
        }

        private void cbCustomerID_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbCustomerID.SelectedItem != null)
            {
                String custName = cbCustomerID.SelectedItem.ToString().Trim();
                Console.WriteLine(custName);
                try
                {
                    String query = $"SELECT [CustomerName] FROM Customer WHERE [CustomerID] = '{custName}'";
                    SqlConnection con = ConnectionClass.Connection();
                    con.Open();
                    Console.WriteLine(query);
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                lblCustomerName.Text = (reader[0].ToString());
                                Console.WriteLine(reader[0].ToString() + "hererr");
                            }
                        }
                    }
                    con.Close();
                }
                catch (Exception)
                {

                }
                
            }
            
        }
    }
}
