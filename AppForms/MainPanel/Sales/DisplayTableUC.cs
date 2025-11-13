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
        public DisplayTableUC()
        {
            InitializeComponent();
        }

        private void DisplayTableUC_Load(object sender, EventArgs e)
        {
            Image testImage = Properties.Resources.CCC_GrayLogo;
        }

        private void invDisplaydgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (table.Columns[e.ColumnIndex].Name == "deleteCol")
            {
                if (MessageBox.Show("Are you sure you want to delete this item from the Database?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    table.Rows.RemoveAt(e.RowIndex);
                }
            }
            if (table.Columns[e.ColumnIndex].Name == "editCol")
            {

            }
            if (table.Columns[e.ColumnIndex].Name == "viewCol")
            {

            }
        }

        private void invDisplaydgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //usabble soon?
        }

        private void invDisplaydgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex % 2 == 0) // For even-indexed rows
            {
                using (Pen p = new Pen(Color.FromArgb(58, 58, 82), 2)) // Define pen for the line
                {
                    // Calculate the position for the line
                    int y = e.RowBounds.Bottom - 1;
                    e.Graphics.DrawLine(p, e.RowBounds.Left + 10, y, e.RowBounds.Right - 10, y);
                }
            }
        }
    }
}
