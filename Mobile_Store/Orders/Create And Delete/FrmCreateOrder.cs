using Mobile_Store_Buisness;
using System;
using System.Data;
using System.Windows.Forms;

namespace Mobile_Store.Orders.Create_And_Delete
{
    public partial class FrmCreateOrder : Form
    {
        private decimal _total = 0;

        public FrmCreateOrder()
        {
            InitializeComponent();
        }
        private void _LoadProducts()
        {
            DataTable dt = ClsProducts.GetAllPhones();
            cbProducts.DisplayMember = "name";
            cbProducts.ValueMember = "product_id";
            cbProducts.DataSource = dt;
            cbProducts.SelectedIndex = -1;
        }

        private void FrmCreateOrder_Load_1(object sender, EventArgs e)
        {
            _LoadProducts();
            _SetupGrid();
            
        }

        private void cbProducts_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           if (cbProducts.SelectedIndex == -1) return;

            DataRowView row = (DataRowView)cbProducts.SelectedItem;
            decimal price = Convert.ToDecimal(row["price"]);
            lblUnitPrice.Text = "Price : $" + price.ToString("0.00");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbProducts.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            DataRowView row = (DataRowView)cbProducts.SelectedItem;
            int productID = Convert.ToInt32(row["product_id"]);
            string name = row["name"].ToString();
            decimal unitPrice = Convert.ToDecimal(row["price"]);
            decimal totalPrice = unitPrice * qty;

            dgvItems.Rows.Add(productID, name, qty, unitPrice, totalPrice);

            _total += totalPrice;
            lblTotal.Text = "Total : $" + _total.ToString("0.00");

            cbProducts.SelectedIndex = -1;
            txtQuantity.Text = "1";
            lblUnitPrice.Text = "Price : 0.00";
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCustomerName.Text) ||
                string.IsNullOrWhiteSpace(txtCustomerAddress.Text) )
               
            {
                MessageBox.Show("Please fill all customer fields.");
                return;
            }

            if (dgvItems.Rows.Count == 0)
            {
                MessageBox.Show("Please add at least one item to the order.");
                return;
            }

            ClsOrders order = new ClsOrders();
            if (dgvItems.Rows.Count > 0)
            {
                order.CustomerPhone = dgvItems.Rows[0].Cells["colProductName"].Value.ToString();
            }
            else
            {
                order.CustomerPhone = "No Product";
            }

            order.CustomerAddress = txtCustomerAddress.Text.Trim();
            order.CustomerName = txtCustomerName.Text.Trim();
            order.OrderDate = DateTime.Now;
            order.TotalAmount = _total;
            order.Status = 0;
            if (!order.Save())
            {
                MessageBox.Show("Failed to save order.");
                return;
            }

            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                ClsOrderItem item = new ClsOrderItem();
                item.OrderID = order.OrderID;
                item.ProductID = Convert.ToInt32(row.Cells[0].Value);
                item.ProductName = row.Cells[1].Value.ToString();
                item.Quantity = Convert.ToInt32(row.Cells[2].Value);
                item.UnitPrice = Convert.ToDecimal(row.Cells[3].Value);
                item.TotalPrice = Convert.ToDecimal(row.Cells[4].Value);
                item.Save();
            }

            MessageBox.Show("Order saved successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
        private void _SetupGrid()
        {
     
            dgvItems.Columns.Clear();
            dgvItems.AutoGenerateColumns = false;
            dgvItems.AllowUserToAddRows = false;

           
            dgvItems.Columns.Add("colID", "ID");
            dgvItems.Columns["colID"].Visible = false;

          
            dgvItems.Columns.Add("colProductName", "Product Name");
            dgvItems.Columns["colProductName"].Width = 300;
            dgvItems.Columns["colProductName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; 

            
            dgvItems.Columns.Add("colQty", "Qty");
            dgvItems.Columns["colQty"].Width = 80;

          
            dgvItems.Columns.Add("colUnitPrice", "Unit Price");
            dgvItems.Columns["colUnitPrice"].Width = 130;

            dgvItems.Columns.Add("colTotalPrice", "Total Price");
            dgvItems.Columns["colTotalPrice"].Width = 130;

       
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddQty_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtQuantity.Text, out int quantity))
            {
                txtQuantity.Text = (quantity + 1).ToString();
            }
            else
            {
                txtQuantity.Text = "1";
            }

        }

       
    }
}