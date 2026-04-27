using Mobile_Store.Admin;
using Mobile_Store.Browser;
using Mobile_Store.Compare;
using Mobile_Store.Orders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_Store
{
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
          
            FrmOrderscs Frm = new FrmOrderscs();
            Frm.ShowDialog();

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogin login = new FrmLogin();
            login.ShowDialog();
            this.Show();

        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            FrmCompare frm = new FrmCompare();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmBrowse frmBrowse = new FrmBrowse();
            frmBrowse.ShowDialog();
        }
    }
}
