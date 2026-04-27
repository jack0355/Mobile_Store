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
using System.IO;

namespace Mobile_Store.Admin.Add_Edit
{
    public partial class FrmEditPhones : Form
    {
        private int _ProductID;
        private ClsProducts _Phone;
        private ClsProductSpecs _Specs;

        public FrmEditPhones(int ProductID)
        {
            InitializeComponent();
            _ProductID = ProductID;
        }

        private void FrmEditPhones_Load(object sender, EventArgs e)
        {
            _LoadData();
            _LoadBrands();
            _LoadCategories();
        }

        private void _LoadBrands()
        {
            cbBrands.DataSource = null;
            cbBrands.DataSource = Clsbrands.GetAllBrands();
            cbBrands.DisplayMember = "name";
            cbBrands.ValueMember = "brand_id";

            // Only set SelectedValue if _Phone is loaded
            if (_Phone != null)
                cbBrands.SelectedValue = _Phone.BrandID;
        }

        private void _LoadCategories()
        {
            cmbCategory.DataSource = null;
            cmbCategory.DataSource = ClsCategory.GetAllCategories();
            cmbCategory.DisplayMember = "name";
            cmbCategory.ValueMember = "category_id";

            if (_Phone != null)
                cmbCategory.SelectedValue = _Phone.CategoryID;
        }

        private void _LoadData()
        {
            _Phone = ClsProducts.GetPhoneByID(_ProductID);
            if (_Phone == null)
            {
                MessageBox.Show("No phone selected to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            txtName.Text = _Phone.ProductName;
            cbBrands.SelectedValue = _Phone.BrandID;
            cmbCategory.SelectedValue = _Phone.CategoryID;
            txtPrice.Text = _Phone.Price.ToString();
            txtDesc.Text = _Phone.Description;
            cbIsAvailable.Checked = _Phone.IsAvailable;

            if (!string.IsNullOrEmpty(_Phone.ImageURL) && File.Exists(_Phone.ImageURL))
                pbPhoneImage.ImageLocation = _Phone.ImageURL;
            else
                pbPhoneImage.Image = Properties.Resources.icons8_apple_phone_1001;

            // Fill specs
            _Specs = ClsProductSpecs.GetSpecsByProductID(_ProductID);
            if (_Specs != null)
            {
                txtStorage.Text = _Specs.Storage;
                txtRam.Text = _Specs.Ram;
                txtScreen.Text = _Specs.ScreenSize;
                txtBattery.Text = _Specs.Battery;
                txtColor.Text = _Specs.Color;
                txtOS.Text = _Specs.OS;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                MessageBox.Show("Phone Name is required!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }

            if (!decimal.TryParse(txtPrice.Text.Trim(), out decimal price))
            {
                MessageBox.Show("Price must be a valid number!", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                return;
            }

    
            _Phone.ProductName = txtName.Text.Trim();
            _Phone.BrandID = (int)cbBrands.SelectedValue;
            _Phone.CategoryID = (int)cmbCategory.SelectedValue;
            _Phone.Price = price;
            _Phone.Description = txtDesc.Text.Trim();
            _Phone.IsAvailable = cbIsAvailable.Checked;
            _Phone.ImageURL = pbPhoneImage.ImageLocation ?? "";

            if (_Phone.Save())
            {
           
                if (_Specs != null)
                {
                    _Specs.Storage = txtStorage.Text.Trim();
                    _Specs.Ram = txtRam.Text.Trim();
                    _Specs.ScreenSize = txtScreen.Text.Trim();
                    _Specs.Battery = txtBattery.Text.Trim();
                    _Specs.Color = txtColor.Text.Trim();
                    _Specs.OS = txtOS.Text.Trim();
                    _Specs.Save();
                }

                

                MessageBox.Show("Phone Updated Successfully!", "Saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to update phone!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            pbPhoneImage.ImageLocation = null;
            pbPhoneImage.Image = Properties.Resources.icons8_apple_phone_1001;
            btnRemoveImage.Visible = false;
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.jfif;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbPhoneImage.ImageLocation = openFileDialog1.FileName;
                btnRemoveImage.Visible = true;
            }
        }
    }
}