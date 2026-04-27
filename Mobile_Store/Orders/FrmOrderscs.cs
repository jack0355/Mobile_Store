using Mobile_Store.Orders.Create_And_Delete;
using Mobile_Store.Orders.Order_Ctrl;
using Mobile_Store_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_Store.Orders
{
    public partial class FrmOrderscs : Form
    {
        public FrmOrderscs()
        {
            InitializeComponent();
        }

        private void FrmOrderscs_Load(object sender, EventArgs e)
        {
           _LoadOrders();
        }
        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            FrmCreateOrder frm = new FrmCreateOrder();
            frm.ShowDialog();
            _LoadOrders();

        }
        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow == null) return;

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this order?",
                "Delete Order",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                int OrderID = Convert.ToInt32(dgvOrders.CurrentRow.Cells[0].Value);
                ClsOrders.DeleteOrders(OrderID);
                _LoadOrders();
            }
        }
        private void _LoadOrders()
        {
            dgvOrders.AutoGenerateColumns = true;
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.DataSource = ClsOrders.GetCustomerOrders();
            lblOrdersCount.Text = dgvOrders.Rows.Count.ToString();

            if (dgvOrders.Columns["CustomerPhone"] != null)
                dgvOrders.Columns["CustomerPhone"].Visible = false;

            if (dgvOrders.Columns["TotalAmount"] != null)
                dgvOrders.Columns["TotalAmount"].Visible = false;

            if (dgvOrders.Rows.Count > 0)
            {
                dgvOrders.Columns[0].HeaderText = "Order ID";
                dgvOrders.Columns[0].Width = 80;

                dgvOrders.Columns[1].HeaderText = "Customer Name";
                dgvOrders.Columns[1].Width = 180;

                dgvOrders.Columns[2].HeaderText = "Address";
                dgvOrders.Columns[2].Width = 200;

                dgvOrders.Columns[3].HeaderText = "Order Date";
                dgvOrders.Columns[3].Width = 150;

                dgvOrders.Columns[4].HeaderText = "Total $";
                dgvOrders.Columns[4].Width = 100;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow == null) return;

            int OrderID = (int)dgvOrders.CurrentRow.Cells["OrderID"].Value;

            
            FrmCtrlDetails frm = new FrmCtrlDetails();
            frm.LoadOrderData(OrderID);
            frm.ShowDialog();
   
            
            _LoadOrders();

        }
    }
}
