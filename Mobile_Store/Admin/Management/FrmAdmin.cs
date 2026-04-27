using Mobile_Store.Admin.Add_Edit;
using Mobile_Store.Management;
using Mobile_Store_Buisness;
using System;
using System.Data;
using System.Windows.Forms;

namespace Mobile_Store.Admin
{
    public partial class FrmAdmin : Form
    {
        public DataTable _dtAllPhones;
        private int ProductID;

        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            _LoadPhones();
            cbFilterBy.SelectedIndex = 0;
        }

        private void _LoadPhones()
        {
            _dtAllPhones = ClsProducts.GetAllPhones();
            dgvPhones.DataSource = _dtAllPhones;
            lblRecordCount.Text = dgvPhones.Rows.Count.ToString();

            if (dgvPhones.Rows.Count > 0)
            {
                dgvPhones.Columns[0].HeaderText = "Product ID";
                dgvPhones.Columns[0].Width = 80;
                dgvPhones.Columns[1].HeaderText = "Brand";
                dgvPhones.Columns[1].Width = 100;
                dgvPhones.Columns[2].HeaderText = "Category";
                dgvPhones.Columns[2].Width = 100;
                dgvPhones.Columns[3].HeaderText = "Phone Name";
                dgvPhones.Columns[3].Width = 250;
                dgvPhones.Columns[4].HeaderText = "Price $";
                dgvPhones.Columns[4].Width = 100;
                dgvPhones.Columns[5].HeaderText = "Available";
                dgvPhones.Columns[5].Width = 80;
            }
        }

        private void txtFilterSearch_TextChanged(object sender, EventArgs e)
        {
            _ApplyFilter();
        }

        private void _ApplyFilter()
        {
            string FilterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "Phone Name":
                    FilterColumn = "name";
                    break;
                case "Brand":
                    FilterColumn = "Brand";
                    break;
                case "Category":
                    FilterColumn = "Category";
                    break;
                default:
                    FilterColumn = "None";
                    break;
            }

            if (txtFilterSearch.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtAllPhones.DefaultView.RowFilter = "";
                lblRecordCount.Text = dgvPhones.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "name")
                _dtAllPhones.DefaultView.RowFilter = string.Format(
                    "[{0}] LIKE '{1}%'", FilterColumn, txtFilterSearch.Text.Trim());
            else
                _dtAllPhones.DefaultView.RowFilter = string.Format(
                    "[{0}] = {1}", FilterColumn, txtFilterSearch.Text.Trim());

            lblRecordCount.Text = dgvPhones.Rows.Count.ToString();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFilterSearch.Visible = (cbFilterBy.Text != "None");

            if (cbFilterBy.Text == "None")
                txtFilterSearch.Enabled = false;
            else
            {
                txtFilterSearch.Enabled = true;
                txtFilterSearch.Text = "";
                txtFilterSearch.Focus();
            }
        }

        private void dgvPhones_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int ProductID = (int)dgvPhones.Rows[e.RowIndex].Cells[0].Value;
                ctrlPhoneInfoAdmin1.LoadPhoneDetails(ProductID);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            cbFilterBy.SelectedIndex = 0;
            cbFilterBy.Text = "None";
            txtFilterSearch.Enabled = false;
            txtFilterSearch.Text = "";

            ctrlPhoneInfoAdmin1.ClearInfo();

            _LoadPhones();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Are you sure you want to delete Person [" + dgvPhones.CurrentRow.Cells[0].Value + "]",
                "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (ClsProducts.DeletePhone((int)dgvPhones.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Phone Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _LoadPhones();
                    ctrlPhoneInfoAdmin1.ClearInfo();
                }
                else
                    MessageBox.Show("Phone was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            FrmAddNewPhone frm = new FrmAddNewPhone();
            frm.ShowDialog();

            // Refresh after adding new phone
            _LoadPhones();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPhones.CurrentRow == null) return;

            int ProductID = (int)dgvPhones.CurrentRow.Cells[0].Value;
            FrmEditPhones frm = new FrmEditPhones(ProductID);
            frm.ShowDialog();

            // Fix: refresh phone list after editing to prevent duplicates
            _LoadPhones();
            ctrlPhoneInfoAdmin1.ClearInfo();
        }

        private void btnCheckClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Do you want to go back to Management Menu ?\n\nYes = Management Menu\nNo = Main Menu ",
                "Exit Admin",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                FrmMangement frm = new FrmMangement();
                this.Hide();
                frm.ShowDialog();
                this.Close();

            }
            else if (result == DialogResult.No)
                this.Hide();
                FrmMainMenu frm2 = new FrmMainMenu();
                frm2.ShowDialog();
                this.Close();
        }
    }
}