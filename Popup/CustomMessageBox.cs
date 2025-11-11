using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColdChainConnectSystem_ACDP.Popup
{
    public partial class CustomMessageBox : Form
    {
        public CustomMessageBox(String lbl, String desc)
        {
            InitializeComponent();
            btnOK.Visible = true;
            lblTitle.Text = lbl;
            lblDescription.Text = desc;
        }
        public CustomMessageBox(String lbl, String desc, MessageBoxButtons messageBoxButtons)
        {
            if (messageBoxButtons == MessageBoxButtons.OKCancel)
            {
                InitializeComponent();
                btnOK.Visible = true;
                btnCancel.Visible = true;
                lblTitle.Text = lbl;
                lblDescription.Text = desc;
            }
            else if (messageBoxButtons == MessageBoxButtons.OK)
            {
                InitializeComponent();
                btnOK.Visible = true;
                btnCancel.Visible = false;
                lblTitle.Text = lbl;
                lblDescription.Text = desc;
            }
            else
            {
                InitializeComponent();
                btnOK.Visible = false;
                btnCancel.Visible = false;
                lblTitle.Text = lbl;
                lblDescription.Text = desc;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}