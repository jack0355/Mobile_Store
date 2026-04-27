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

namespace Mobile_Store.Orders.Ctrl
{
    public partial class ctrlOrderDetails : UserControl
    {
        
        public ctrlOrderDetails()
        {
            InitializeComponent();
        }

        public void LoadOrderData(ClsOrders Order)
        {
            lblOrderID.Text = Order.OrderID.ToString();
            lblCustomerName.Text = Order.CustomerName;
            lblDate.Text = Order.OrderDate.ToShortDateString();
            lblTotalPrice.Text = Order.TotalAmount.ToString("0.00")+"$";
            dgvOrders.DataSource = ClsOrderItem.GetItemsByOrderID(Order.OrderID);

            switch (Order.Status)
            {
                case ClsOrders.enOrderStatus.Pending:
                    lblStatus.Text = "In Progress";
                    pbStatus.Image = Properties.Resources.icons8_in_progress_48;
                    break;

                case ClsOrders.enOrderStatus.Shipped:
                    lblStatus.Text = "Shipped";
                    pbStatus.Image = Properties.Resources.icons8_shipped_48;
                    break;

                case ClsOrders.enOrderStatus.Cancelled:
                    lblStatus.Text = "Cancelled";
                    pbStatus.Image = Properties.Resources.icons8_cross_48;
                    break;
            }
        }
    }
}
