using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA6
{
    public partial class FrmCWID : Form
    {
        public FrmCWID()
        {
            InitializeComponent();
        }

        private void btnCLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain myForm = new frmMain(txtCWID.Text);
            if (myForm.ShowDialog() == DialogResult.OK)
            {
            }
            else
            {
                this.Close();
            }
        }
    }
}
