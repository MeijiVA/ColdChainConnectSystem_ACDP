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
           /* cmb = new CustomMessageBox("Add Supplier", "Confirm?", MessageBoxButtons.OKCancel);
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

            }*/
        }



        private void AddItemInventoryForm_Load(object sender, EventArgs e)
        {
            TabPage tab = new TabPage("Item " + 1);
            ItemTab it = new ItemTab();

            tab.Controls.Add(it);
            tcSales.TabPages.Add(tab);
            // Set default date to today
            dpSalesDate.Value = DateTime.Now;
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

        private void btnAddTab_Click(object sender, EventArgs e)
        {
            // Get the index of the last tab page
            int NextTabIndex = tcSales.TabPages.Count + 1;
            if (NextTabIndex <= 10)
            {
                TabPage tab = new TabPage("Item " + NextTabIndex);
                ItemTab it = new ItemTab();
                
                tab.Controls.Add(it);
                tcSales.TabPages.Add(tab);
            }
            else
            {
                new CustomMessageBox("Tabs", "You can only have 10 Concurrent Tabs.", MessageBoxButtons.OK).ShowDialog();
            }

        }

        private void btnRemoveTab_Click(object sender, EventArgs e)
        {
            // Check if there are any tab pages to remove
            if (tcSales.TabPages.Count > 1)
            {
                // Get the index of the last tab page
                int lastTabIndex = tcSales.TabPages.Count - 1;

                // Remove the tab page at the last index
                tcSales.TabPages.RemoveAt(lastTabIndex);
            }
            else
            {
                // Optionally, inform the user that there are no tabs to remove
                new CustomMessageBox("Tabs", "You must have atleast 1 Item", MessageBoxButtons.OK).ShowDialog();
            }
        }
    }
}
