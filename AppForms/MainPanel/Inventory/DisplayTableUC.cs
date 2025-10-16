using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ColdChainConnectSystem_ACDP.ClassResources;


namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Inventory
{
    public partial class DisplayTableUC : UserControl
    {
        DisplayClass dc = new DisplayClass();
        string baseBlue = "#070760";
        string baseWhite = "#FFFFFF";
        public DisplayTableUC()
        {
            InitializeComponent();
        }

        private void DisplayTableUC_Load(object sender, EventArgs e)
        {
            Image testImage = Properties.Resources.CCC_GrayLogo;
            invDisplaydgv.Rows.Add(new object[] {0, 7700165, "FF Bossing Hotdog Kingsized 1kg", testImage, 148.57f, 8914.20f, 60, 60});
            invDisplaydgv.Rows.Add(new object[] {0, 1, 1, testImage, 1, 1, 1, 1});
            invDisplaydgv.Rows.Add(new object[] {0, 1, 1, testImage, 1, 1, 1, 1});
            invDisplaydgv.Rows.Add(new object[] {0, 1, 1, testImage, 1, 1, 1, 1});
            invDisplaydgv.Rows.Add(new object[] {0, 1, 1, testImage, 1, 1, 1, 1});
            invDisplaydgv.Rows.Add(new object[] {0, 1, 1, testImage, 1, 1, 1, 1});
            invDisplaydgv.Rows.Add(new object[] {0, 1, 1, testImage, 1, 1, 1, 1});
            invDisplaydgv.Rows.Add(new object[] {0, 1, 1, testImage, 1, 1, 1, 1});
            invDisplaydgv.Rows.Add(new object[] {0, 1, 1, testImage, 1, 1, 1, 1});
        }

        private void invDisplaydgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (invDisplaydgv.Columns[e.ColumnIndex].Name == "deleteCol")
            {
                if (MessageBox.Show("Are you sure you want to delete this item from the Database?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    invDisplaydgv.Rows.RemoveAt(e.RowIndex);
                }
            }
            if (invDisplaydgv.Columns[e.ColumnIndex].Name == "editCol")
            {

            }
            if (invDisplaydgv.Columns[e.ColumnIndex].Name == "viewCol")
            {

            }
        }

        private void invDisplaydgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //usabble soon?
        }

        private void invDisplaydgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void invDisplaydgv_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            foreach (DataGridViewRow r in invDisplaydgv.Rows)
            {
                if (Convert.ToBoolean(r.Cells[0].Value) == true)
                {
                    r.DefaultCellStyle.BackColor = dc.SetCustomColor(baseBlue);
                    r.DefaultCellStyle.ForeColor = dc.SetCustomColor(baseWhite);
                }
                else if (Convert.ToBoolean(r.Cells[0].Value) == false)
                {
                    r.DefaultCellStyle.BackColor = dc.SetCustomColor(baseWhite);
                    r.DefaultCellStyle.ForeColor = dc.SetCustomColor(baseBlue);
                }
            }
        }
    }
}
