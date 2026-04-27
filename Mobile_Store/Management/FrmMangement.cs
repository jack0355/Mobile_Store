using Mobile_Store.Admin;
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

namespace Mobile_Store.Management
{
    public partial class FrmMangement : Form
    {
        public FrmMangement()
        {
            InitializeComponent();
        }

        private void btnProdcuts_Click(object sender, EventArgs e)
        {
            FrmAdmin frm = new FrmAdmin();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmOrderManagement frm = new FrmOrderManagement();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           
            FrmMainMenu frm = new FrmMainMenu();
            this.Hide();
            frm.ShowDialog();
            this.Close();
           
        }
    }
}
