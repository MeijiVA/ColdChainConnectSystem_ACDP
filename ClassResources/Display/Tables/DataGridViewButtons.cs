using System.Windows.Forms;


namespace ColdChainConnectSystem_ACDP.ClassResources.Display.Tables
{
    internal class DataGridViewButtons
    {
        public static DataGridViewCellStyle buttonStyle()
        {
            DataGridViewCellStyle dgvCs = new DataGridViewCellStyle();
            dgvCs.NullValue = null;
            dgvCs.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvCs.Padding = new Padding(0, 10, 0, 10);

            return dgvCs;
        }

        public static DataGridViewImageColumn AddViewCol_dgvButton()
        {
            DataGridViewImageColumn viewCol = new DataGridViewImageColumn();
            viewCol.Name = "viewCol";
            viewCol.HeaderText = "";
            viewCol.Image = Properties.Resources.viewBtn;
            viewCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            viewCol.Width = 25;
            viewCol.Resizable = DataGridViewTriState.False;
            viewCol.DefaultCellStyle = buttonStyle();
            return viewCol;
        }
        public static DataGridViewImageColumn AddEditCol_dgvButton()
        {
            DataGridViewImageColumn editCol = new DataGridViewImageColumn();
            editCol.Name = "editCol";
            editCol.HeaderText = "";
            editCol.Image = Properties.Resources.editBtn;
            editCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            editCol.Width = 25;
            editCol.Resizable = DataGridViewTriState.False;
            editCol.DefaultCellStyle = buttonStyle();
            return editCol;

        }
        public static DataGridViewImageColumn AddDelCol_dgvButton()
        {
            DataGridViewImageColumn deleteCol = new DataGridViewImageColumn();
            deleteCol.Name = "deleteCol";
            deleteCol.HeaderText = "";
            deleteCol.Image = Properties.Resources.delBtn;
            deleteCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            deleteCol.Width = 25;
            deleteCol.Resizable = DataGridViewTriState.False;
            deleteCol.DefaultCellStyle = buttonStyle();
            return deleteCol;
        }
    }
}
