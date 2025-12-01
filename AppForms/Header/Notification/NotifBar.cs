using ColdChainConnectSystem_ACDP.ClassResources;
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

namespace ColdChainConnectSystem_ACDP.AppForms.Header.Notification
{
    public partial class NotifBar : UserControl
    {
        public NotifBar()
        {
            InitializeComponent();
        }
        string numID;
        public string notifID
        {
            get { return numID; }
            set { numID = value; }
        }


        private void NotifBar_Load(object sender, EventArgs e)
        {

        }

        private void NotifBar_Click(object sender, EventArgs e)
        {
            //do action when click, close THIS
            String query = $"UPDATE [Audit] SET Notified = 1 WHERE numid = {notifID}";//act -> ref -> refid
            try
            {
                using (SqlConnection con = ConnectionClass.Connection())
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                new CustomMessageBox("Exception", ex.Message, MessageBoxButtons.OK).ShowDialog();
            }

            Dispose();
        }
    }
}
