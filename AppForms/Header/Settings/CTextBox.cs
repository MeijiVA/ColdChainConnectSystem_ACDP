using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColdChainConnectSystem_ACDP.AppForms.MainPanel.Settings
{
    public partial class CTextBox : UserControl
    {
        DisplayClass dc = new DisplayClass();
        public CTextBox()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void CTextBox_Load(object sender, EventArgs e)
        {
            dc.SetDisplayRectangle(txtBoxCust,20,20,20,20);
        }
    }
}
