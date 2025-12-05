using ColdChainConnectSystem_ACDP.ClassResources;
using ColdChainConnectSystem_ACDP.ClassResources.Instances;
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
            this.DoubleBuffered = true; // Apply to the form
        }

        double totalValuePrice;
        public String ChosenItem;
        public bool AlreadyChosen;

        private void ItemTab_Load(object sender, EventArgs e)
        {

        }
        public string WhereFilterQuery()
        {
             List<object> itemsToCheck = new List<object>
             {
            ItemTabInstance.it0.ChosenItem,
            ItemTabInstance.it1.ChosenItem,
            ItemTabInstance.it2.ChosenItem,
            ItemTabInstance.it3.ChosenItem,
            ItemTabInstance.it4.ChosenItem,
            ItemTabInstance.it5.ChosenItem,
            ItemTabInstance.it6.ChosenItem,
            ItemTabInstance.it7.ChosenItem,
            ItemTabInstance.it8.ChosenItem,
            ItemTabInstance.it9.ChosenItem
             };
            var chosenItems = itemsToCheck.Where(item => item != null).ToList();

            if (!chosenItems.Any())
            {
                return string.Empty; // Return empty string if no items are chosen.
            }
            string excludedIds = string.Join(", ", chosenItems);

            string whereFilter = $"AND [numid] NOT IN ({excludedIds})";

            // IMPORTANT SECURITY NOTE: This code is highly vulnerable to **SQL Injection**.
            // The preferred and secure approach is to use **Parameterized Queries** // (e.g., using a DbCommand object), NOT string concatenation.
            // If you MUST return a SQL string, this is the syntactically correct way, 
            // but it is UNSAFE in a real-world application.

            return whereFilter;
        }
        private void cbProductID_Load(object sender, EventArgs e)
        {
            String FilterQuery = WhereFilterQuery();

            string query = $"SELECT [NUMID] , [SKUCODE] FROM Inventory WHERE [quantity] > 0 {FilterQuery}";
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
                                ChosenItem = productID[0];
                                if (!AlreadyChosen)
                                {
                                    CurrentFormClass.addTransInstance.btnAddTab.Enabled = true;
                                    AlreadyChosen = true;
                                }
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

        public string getBatchID
        {
            get { return this.cbProductID.Texts; }
        }
        public string getQuantity
        {
            get { return this.lblQuantityValue.Text; }
        }
        private void cbStatus_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
