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



        int tabNum;
        private void AddItemInventoryForm_Load(object sender, EventArgs e)
        {
            tabNum = 1;
            tcSales.TabPages.Add("Item " + tabNum);

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
            if (tabNum <= 10)
            {
                tabNum++;
                tcSales.TabPages.Add("Item " + tabNum);
            }
            else
            {
                new CustomMessageBox("Tabs", "You can only have 10 Concurrent Tabs.", MessageBoxButtons.OK).ShowDialog();
            }

        }

        private void btnRemoveTab_Click(object sender, EventArgs e)
        {
            if (tabNum > 0)
            {
                tabNum--;
                TabPage tab = new TabPage("Item " + tabNum);
                ItemTab it = new ItemTab();
                it.Dock = DockStyle.Fill;
                tab.Controls.Add(it);
                tcSales.TabPages.Add(tab);
            }
            else
            {
                new CustomMessageBox("Tabs", "You must atleast have 1 Tab Open.", MessageBoxButtons.OK).ShowDialog();
            }
        }
    }
}
