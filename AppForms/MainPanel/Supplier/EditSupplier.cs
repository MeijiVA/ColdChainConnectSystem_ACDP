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

namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Supplier
{
    public partial class EditSupplier : Form
    {
        public EditSupplier()
        {
            InitializeComponent();
        }

        private void EditSupplier_Load(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM Supplier WHERE [numid] = {ClassResources.Instances.VarView.id}";
            SqlConnection con = ConnectionClass.Connection();
            con.Open();
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {//num  custid custname phonenum address payterm regdate status
                        lblID.Text = "  [" + reader[0].ToString() + "] ( Supplier ID : " + reader[1].ToString() + ")";
                        lblCompanyName.Texts = reader[2].ToString();
                        lblContactPerson.Texts = reader[3].ToString();
                        lblContactNum.Texts = reader[4].ToString();
                        String[] address = reader[5].ToString().Split(',');
                        lblHouseNumber.Texts = address[0];
                        lblBarangay.Texts = address[1];
                        lblCity.Texts = address[2];
                        lblProvince.Texts = address[3];
                        lblPostal.Text = address[4];
                        lblPaymentTerm.Texts = reader[6].ToString();
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String address = lblHouseNumber.Texts + "," + lblBarangay.Texts + "," + lblCity.Texts + "," + lblProvince.Texts + "," + lblPostal.Texts;
            if (SupplierClass.updateSupplierData(VarView.id, lblCompanyName.Texts, lblContactPerson.Texts, lblContactNum.Texts, address, lblPaymentTerm.Texts)) ;
            this.Close();
            MainInstance.i.NavigateTo(SupplierInstance.i);
            SupplierInstance.i.UpdateTable();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
