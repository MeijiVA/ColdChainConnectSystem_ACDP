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
                String[][] table = new string[10][3];
                for(int num = 0; num < tcSales.TabPages.Count ;num++)
                {
                   String[] productID = GetTab(num).getBatchID.Trim().Split('|'); //removes SKUCODE
                    table[num][0] = productID[0];
                    table[num][0] = GetTab(num).getQuantity;
                    table[num][0] = GetTab(num).getStatus;
                }
                try
                    {
                        String[] ProdID = ItemTabInstance.it0.getBatchID.Trim().Split('|');
                        if (SalesClass.writeSalesData(cbCustomerID.Texts, dpSalesDate.Value.ToString("yyyy-MM-dd"), ProdID[0], tbQuantity.Value.ToString(), cbStatus.Texts))
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



        private void AddItemInventoryForm_Load(object sender, EventArgs e)
        {
            TabPage tab = new TabPage("Item " + 1);
            ItemTab it = GetTab(0);

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
            int NextTabIndex = tcSales.TabPages.Count;
            if (NextTabIndex < 10)
            {
                TabPage tab = new TabPage("Item " + NextTabIndex+1);
                ItemTab it = GetTab(NextTabIndex);
                
                tab.Controls.Add(it);
                tcSales.TabPages.Add(tab);
               
            }
            else
            {
                new CustomMessageBox("Tabs", "You can only have 10 Concurrent Tabs.", MessageBoxButtons.OK).ShowDialog();
            }

        }
        private ItemTab GetTab(int i)
        {
            switch (i)
            {
                case 0:
                    ItemTabInstance.it0 = new ItemTab();
                    return ItemTabInstance.it0;
                case 1:
                    ItemTabInstance.it1 = new ItemTab();
                    return ItemTabInstance.it1;
                case 2:
                    ItemTabInstance.it2 = new ItemTab();
                    return ItemTabInstance.it2;
                case 3:
                    ItemTabInstance.it3 = new ItemTab();
                    return ItemTabInstance.it3;
                case 4:
                    ItemTabInstance.it4 = new ItemTab();
                    return ItemTabInstance.it4;
                case 5:
                    ItemTabInstance.it5 = new ItemTab();
                    return ItemTabInstance.it5;
                case 6:
                    ItemTabInstance.it6 = new ItemTab();
                    return ItemTabInstance.it6;
                case 7:
                    ItemTabInstance.it7 = new ItemTab();
                    return ItemTabInstance.it7;
                case 8:
                    ItemTabInstance.it8 = new ItemTab();
                    return ItemTabInstance.it8;
                case 9:
                    ItemTabInstance.it9 = new ItemTab();
                    return ItemTabInstance.it9;
            }
            return new ItemTab();
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
