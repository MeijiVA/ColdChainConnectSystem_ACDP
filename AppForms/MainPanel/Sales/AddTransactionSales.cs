using ColdChainConnectSystem_ACDP.AppForms.MainPanel.Inventory;
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
    public partial class AddTransactionSales : Form
    {
        CustomMessageBox cmb;
        public AddTransactionSales()
        {
            InitializeComponent();
            string downloadsPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
        }
        int numpages;
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            MainInstance.i.NavigateTo(new SalesForm());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                cmb = new CustomMessageBox("Add Supplier", "Confirm?", MessageBoxButtons.OKCancel);
                if (cmb.ShowDialog() == DialogResult.OK)
                {
                    String[,] table = new string[10,3];
                    for (int num = 0; num < numpages; num++)
                    {
                    Console.WriteLine(num + " num");
                    Console.WriteLine(numpages + "numpages");
                    String[] productID = GetTab(num).getBatchID.Trim().Split('|'); //removes SKUCODE
                    table[num, 0] = productID[0];
                    table[num, 1] = GetTab(num).getQuantity;
                    table[num, 2] = GetTab(num).getStatus;
                    Console.WriteLine(table[num, 0] +" " + table[num,1] + " " + table[num, 2]);
                        //cbCustomerID.Texts, dpSalesDate.Value.ToString("yyyy-MM-dd"), table[num,0] , table[num,1], table[num,2]
                        if (SalesClass.writeSalesData(lblSalesID.Text, cbCustomerID.Texts, dpSalesDate.Value.ToString("yyyy-MM-dd"), table[num, 0], table[num, 1], table[num, 2]));
                    }
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



        private void AddItemInventoryForm_Load(object sender, EventArgs e)
        {
            AddItemInstance();
            numpages = 1;
            TabPage tab = new TabPage("Item " + 1);
            ItemTab it = GetTab(0);

            tab.Controls.Add(it);
            tcSales.TabPages.Add(tab);
            // Set default date to today
            lblSalesID.Text = SalesClass.getNewSalesID();
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
            if (numpages < 10)
            {
                numpages++;
                Console.WriteLine(numpages);
                TabPage tab = new TabPage("Item " + numpages);
                ItemTab it = GetTab(numpages-1);
                
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
                    return ItemTabInstance.it0;
                case 1:
                    return ItemTabInstance.it1;
                case 2:
                    return ItemTabInstance.it2;
                case 3:
                    return ItemTabInstance.it3;
                case 4:
                    return ItemTabInstance.it4;
                case 5:
                    return ItemTabInstance.it5;
                case 6:
                    return ItemTabInstance.it6;
                case 7:
                    return ItemTabInstance.it7;
                case 8:
                    return ItemTabInstance.it8;
                case 9:
                    return ItemTabInstance.it9;
            }
            return new ItemTab();
        } 

        private void AddItemInstance()
        {
            ItemTabInstance.it0 = new ItemTab();
            ItemTabInstance.it1 = new ItemTab();
            ItemTabInstance.it2 = new ItemTab();
            ItemTabInstance.it3 = new ItemTab();
            ItemTabInstance.it4 = new ItemTab();
            ItemTabInstance.it5 = new ItemTab();
            ItemTabInstance.it6 = new ItemTab();
            ItemTabInstance.it7 = new ItemTab();
            ItemTabInstance.it8 = new ItemTab();
            ItemTabInstance.it9 = new ItemTab();
        }

        private void btnRemoveTab_Click(object sender, EventArgs e)
        {
            // Check if there are any tab pages to remove
            if (tcSales.TabPages.Count > 1)
            {
                numpages--;
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
