using System;
using System.Drawing;
using System.Windows.Forms;


namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Inventory
{
    public partial class CopyableTable : UserControl
    {
        DisplayClass dc = new DisplayClass();
        public CopyableTable()
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

            using (Pen p = new Pen(Color.FromArgb(07, 07, 96), 2)) // Define pen for the line
            {
                // Calculate the position for the line
                int y = e.RowBounds.Bottom - 1;
                e.Graphics.DrawLine(p, e.RowBounds.Left + 10, y, e.RowBounds.Right - 10, y);
            }
        }
    }
}
