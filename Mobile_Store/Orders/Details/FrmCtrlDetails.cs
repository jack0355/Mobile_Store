using Mobile_Store_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_Store.Orders.Order_Ctrl
{
    public partial class FrmCtrlDetails : Form
    {
        public FrmCtrlDetails()
        {
            InitializeComponent();
        }

        public void LoadOrderData(int OrderID)
        {
            ClsOrders Order = ClsOrders.Find(OrderID);
            if (Order != null)

            {
                lblOrderID.Text = "#"+Order.OrderID.ToString();
                lblCustomerName.Text = Order.CustomerName;
                lblDate.Text = Order.OrderDate.ToShortDateString();
                lblTotalPrice.Text = "$" + Order.TotalAmount.ToString("0.00");

                DataTable dtItems =ClsOrderItem.GetItemsByOrderID(OrderID);
                dgvOrdersItems.DataSource = dtItems;

                FormatItemsGrid();

            }
            else
            {
                MessageBox.Show("Could not find order with ID " + OrderID, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                Reset();
            }
        }

        private void FormatItemsGrid()
        {
            if (dgvOrdersItems.Columns.Count > 0)
            {
                dgvOrdersItems.Columns["ProductName"].HeaderText = "Product Name";
                dgvOrdersItems.Columns["Quantity"].HeaderText = "Qty";
                dgvOrdersItems.Columns["UnitPrice"].HeaderText = "Price";
                dgvOrdersItems.Columns["TotalPrice"].HeaderText = "Subtotal";

                dgvOrdersItems.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
        
        


        public void Reset()
        {
            lblOrderID.Text = "????";
            lblCustomerName.Text = "????";
            lblDate.Text = "????";
            lblTotalPrice.Text = "$0.00";
            dgvOrdersItems.DataSource = null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
