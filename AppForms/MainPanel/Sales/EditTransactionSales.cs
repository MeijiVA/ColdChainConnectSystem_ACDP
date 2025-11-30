using ColdChainConnectSystem_ACDP.ClassResources;
using ColdChainConnectSystem_ACDP.ClassResources.Instances;
using ColdChainConnectSystem_ACDP.ClassResources.Security;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Sales
{
    public partial class EditTransactionSales : Form
    {
        public EditTransactionSales()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Apply to the form
        }

        private void lblPaymentTerm_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (lblCustomerID.SelectedItem != null)
            {
                String custName = lblCustomerID.SelectedItem.ToString().Trim();
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

        private void customComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblPaymentTerm_Load(object sender, EventArgs e)
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
                        lblCustomerID.Items.Add(reader[0].ToString());
                    }
                }
            }
            con.Close();
        }
        int quantity;
        private void EditTransactionSales_Load(object sender, EventArgs e)
        {
            quantity = 0;
            string query = $"SELECT a.[numid], a.[salesid],a.[customerid], c.[customername],a.[salesdate],a.[productid], i.[skucode],a.[quantity],i.[unitprice],(a.[quantity] * i.[unitprice]) AS TOTAL,a.[status], a.[CreatedBy], i.[Quantity] FROM Sales as a JOIN Inventory AS i ON a.[productid] = i.[numid] JOIN Customer AS c ON c.[customerid] = a.[customerid] WHERE a.[numid] = {ClassResources.Instances.VarView.id}";
            SqlConnection con = ConnectionClass.Connection();
            con.Open();
            Console.WriteLine(query);
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {//num sales cust sales
                        lblID.Text = "  [" + reader[0].ToString() + "] ( Sale ID : " + reader[1].ToString() + ")";
                        lblCustomerID.Texts = reader[2].ToString();
                        lblCustomerName.Text = reader[3].ToString();
                        dpSalesDate.Value = Convert.ToDateTime(reader[4]);
                        lblProductID.Text = reader[5].ToString();
                        lblSku.Text = reader[6].ToString();

                        //gets product max quantity then adds current quantity
                        int max = Convert.ToInt32(reader[12].ToString()) + Convert.ToInt32(reader[7].ToString());
                        tbQuantity.Maximum = max;
                        //saves value of previous quantity
                        quantity = Convert.ToInt32(reader[7]);
                        //sets bar
                        tbQuantity.Value = Convert.ToInt32(reader[7]);
                        lblQuantity.Text = "" + tbQuantity.Value;
                        //puts value into label
                        lblPrice.Text = "" + (quantity * Convert.ToDecimal(reader[8].ToString()));


                        lblUnitPrice.Text = reader[8].ToString();
                        lblPrice.Text = reader[9].ToString();
                        lblStatus.Texts = reader[10].ToString();
                        lblCreatedBy.Text = reader[11].ToString();

                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbQuantity_Scroll(object sender, EventArgs e)
        {
            lblQuantity.Text = ""+tbQuantity.Value;
            lblPrice.Text =""+ (tbQuantity.Value*Convert.ToDecimal(lblUnitPrice.Text));
        }

        private void btnExitView_Click(object sender, EventArgs e)
        {
            if (quantity == tbQuantity.Value)
            {
                if (SalesClass.updateSalesData(VarView.id, lblCustomerID.Texts, dpSalesDate.Value.ToString("yyyy-MM-dd"), tbQuantity.Value.ToString(), lblStatus.Texts)) ;
            }
            else
            {
                String query = $"UPDATE Inventory SET [quantity] = ([quantity] + {quantity}) - {tbQuantity.Value} WHERE [numid] = {lblProductID.Text}";
                SqlConnection con = ConnectionClass.Connection();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    Console.WriteLine(query);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    AuditLog.AddAuditInfo("Edit", VarView.id, $"[{ConnectionClass.empid}] Edited [{quantity}] from [{lblProductID.Text}] in [invform] [{CurrentFormClass.form}]");
                }
                if (SalesClass.updateSalesData(VarView.id, lblCustomerID.Texts, dpSalesDate.Value.ToString("yyyy-MM-dd"), tbQuantity.Value.ToString(), lblStatus.Texts)) ;
            }
             


            this.Close();
            MainInstance.i.NavigateTo(SalesInstance.i);
            SalesInstance.i.UpdateTable();
        }
    }
}
