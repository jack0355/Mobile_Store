using Mobile_Store.Management;
using Mobile_Store.Orders.Create_And_Delete;
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
    public partial class FrmOrderManagement : Form
    {
        public FrmOrderManagement()
        {
            InitializeComponent();
        }

        private void FrmOrderManagement_Load(object sender, EventArgs e)
        {
            _RefreshGrid();



            if (dgvOrdersList.Rows.Count > 0)
            {
                dgvOrdersList.Rows[0].Selected = true;
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            FrmCreateOrder frm = new FrmCreateOrder();
            frm.ShowDialog();

            _RefreshGrid();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _RefreshGrid();
        }

        private void _RefreshGrid()
        {
            dgvOrdersList.DataSource = ClsOrders.GetAllOrders();
            if (dgvOrdersList.Columns["CustomerPhone"] != null)
                dgvOrdersList.Columns["CustomerPhone"].Visible = false;
        }

        private void txtSearchOrder_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)dgvOrdersList.DataSource;
            if (dt != null)
            {
                dt.DefaultView.RowFilter = string.Format("CustomerName LIKE '%{0}%' OR Convert(OrderID , 'System.String') LIKE '%{0}%'", txtSearchOrder.Text);

            }
        }

        private void dgvOrdersList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {

                    int OrderID = (int)dgvOrdersList.Rows[e.RowIndex].Cells["OrderID"].Value;

                   
                    ClsOrders SelectedOrder = ClsOrders.Find(OrderID);

                    if (SelectedOrder != null)
                    {
                        
                        ctrlOrderDetails1.LoadOrderData(SelectedOrder);
                    }
                    else
                    {
                        MessageBox.Show("Order Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                   
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmMangement frm = new FrmMangement();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int OrderID = (int)dgvOrdersList.CurrentRow.Cells["OrderID"].Value;

            DialogResult result = MessageBox.Show("Are you sure you wanna delete ? " + OrderID + "?");
            if (result == DialogResult.OK)
            {
                if (ClsOrders.DeleteOrders(OrderID))
                {
                    MessageBox.Show("Order Deleted Successfully !");
                    _RefreshGrid();
                }
            }
            else
            {
                MessageBox.Show("An error occurred: ", "Database Error",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
