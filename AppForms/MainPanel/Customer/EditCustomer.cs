using ColdChainConnectSystem_ACDP.AppForms.MainPanel.Inventory;
using ColdChainConnectSystem_ACDP.ClassResources;
using ColdChainConnectSystem_ACDP.ClassResources.Instances;
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

namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Customer
{
    public partial class EditCustomer : Form
    {
        public EditCustomer()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Apply to the form
        }

        private void EditCustomer_Load(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM Customer WHERE [numid] = {ClassResources.Instances.VarView.id}";
            SqlConnection con = ConnectionClass.Connection();
            con.Open();
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {//num  custid custname phonenum address payterm regdate status
                        lblID.Text = "  [" + reader[0].ToString() + "] ( Customer ID :" + reader[1].ToString() + ")";
                        lblCustomerName.Texts = reader[2].ToString();
                        lblPhoneNumber.Texts = reader[3].ToString();
                        String[] address = reader[4].ToString().Split(',');
                        lblHouseNumber.Texts = address[0];
                        lblBarangay.Texts = address[1];
                        lblCity.Texts = address[2];
                        lblProvince.Texts = address[3];
                        lblPostal.Texts = address[4];
                        lblPaymentTerm.Texts = reader[5].ToString();
                        dpRegistrationDate.Value = Convert.ToDateTime(reader[6]);
                        lblStatus.Texts = reader[7].ToString();
                    }
                }
            }
        }

        private void customComboBox2_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            lblCity.Items.Clear();
            lblCity.Texts = "";
            foreach (string i in MunicipalityListClass.municipality)
            {
                string[] current = i.Split(',');
                string selected = " " + lblProvince.Texts;
                if (current[1].Equals(selected))
                {
                    lblCity.Items.Add(current[0]);
                }
            }
        }

        private void customPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String address = lblHouseNumber.Texts + "," + lblBarangay.Texts + "," + lblCity.Texts + "," + lblProvince.Texts + "," + lblPostal.Texts;
            if (CustomerClass.updateCustomerData(VarView.id, lblCustomerName.Texts, lblPhoneNumber.Texts, dpRegistrationDate.Value.ToString("yyyy-MM-dd"), address, lblPaymentTerm.Texts, lblStatus.Texts)) ;
            this.Close();
            MainInstance.i.NavigateTo(CustomerInstance.i);
            CustomerInstance.i.UpdateTable();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblCity_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblProvince_Leave(object sender, EventArgs e)
        {
            lblCity.Items.Clear();
            lblCity.Texts = "";
            foreach (string i in MunicipalityListClass.municipality)
            {
                string[] current = i.Split(',');
                string selected = " " + lblProvince.Texts;
                if (current[1].Equals(selected))
                {
                    lblCity.Items.Add(current[0]);
                }
            }
        }
    }
}
