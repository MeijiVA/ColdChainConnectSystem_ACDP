using System;
using System.Drawing;
using System.Windows.Forms;

namespace ColdChainConnectSystem_ACDP.ClassResources.CustomControls
{
    public class CheckBoxHeaderCell : DataGridViewColumnHeaderCell
    {
        private bool isChecked = false;
        private Point checkBoxLocation;
        private Size checkBoxSize;
        private Rectangle checkBoxBounds;

        public CheckBoxHeaderCell()
        {
            checkBoxSize = new Size(15, 15);
        }

        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates dataGridViewElementState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, dataGridViewElementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);

            // Calculate checkbox location (centered)
            checkBoxLocation = new Point(
                cellBounds.X + (cellBounds.Width / 2) - (checkBoxSize.Width / 2),
                cellBounds.Y + (cellBounds.Height / 2) - (checkBoxSize.Height / 2)
            );

            checkBoxBounds = new Rectangle(checkBoxLocation, checkBoxSize);

            // Draw checkbox
            ControlPaint.DrawCheckBox(graphics, checkBoxBounds, isChecked ? ButtonState.Checked : ButtonState.Normal);
        }

        protected override void OnMouseClick(DataGridViewCellMouseEventArgs e)
        {
            if (checkBoxBounds.Contains(e.Location))
            {
                isChecked = !isChecked;
                this.DataGridView.InvalidateCell(this);

                // Trigger select all functionality
                DataGridView dgv = this.DataGridView;
                if (dgv != null)
                {
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (row.Cells[0] is DataGridViewCheckBoxCell checkBoxCell)
                        {
                            checkBoxCell.Value = isChecked;
                        }
                    }
                    dgv.RefreshEdit();
                }
            }
            base.OnMouseClick(e);
        }

        public void UpdateCheckState(bool allChecked)
        {
            if (isChecked != allChecked)
            {
                isChecked = allChecked;
                if (this.DataGridView != null)
                {
                    this.DataGridView.InvalidateCell(this);
                }
            }
        }
    }
}

