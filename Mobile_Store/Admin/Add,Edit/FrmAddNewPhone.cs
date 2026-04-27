using Mobile_Store.Properties;
using Mobile_Store_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Mobile_Store.Admin.Add_Edit
{
    public partial class FrmAddNewPhone : Form
    {
       
 
        private ClsProducts _Phone;

        public FrmAddNewPhone()
        {
            InitializeComponent();
            
        }

        private void _LoadBrands()
        {
            cbBrands.DataSource = null; // reset first!
            DataTable dtBrands = Clsbrands.GetAllBrands();
            cbBrands.DataSource = dtBrands;
            cbBrands.DisplayMember = "name";
            cbBrands.ValueMember = "brand_id";
        }

        private void _LoadCategories()
        {
            cmbCategory.DataSource = null; // reset first!
            DataTable dtCategories = ClsCategory.GetAllCategories();
            cmbCategory.DataSource = dtCategories;
            cmbCategory.DisplayMember = "name";
            cmbCategory.ValueMember = "category_id";
        }
        

        private void FrmAddNewPhone_Load(object sender, EventArgs e)
        {
            _LoadBrands();
            _LoadCategories();
            _Phone = new ClsProducts();
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

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            pbPhoneImage.ImageLocation = null;
            pbPhoneImage.Image = Properties.Resources.icons8_apple_phone_1001; 
            btnRemoveImage.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                MessageBox.Show("Phone Name is required!", "Validation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtPrice.Text.Trim()))
            {
                MessageBox.Show("Price is required!", "Validation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                return;
            }

            _Phone.ProductName = txtName.Text.Trim();
            _Phone.Description = txtDesc.Text.Trim();
            if (!decimal.TryParse(txtPrice.Text.Trim(), out decimal price))
            {
                MessageBox.Show("Price must be a valid number!", "Validation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                return;
            }
            _Phone.Price = price;
            _Phone.CategoryID = (int)cmbCategory.SelectedValue;
            _Phone.BrandID = (int)cbBrands.SelectedValue;
            _Phone.ImageURL = pbPhoneImage.ImageLocation ?? "";
            _Phone.IsAvailable = cbIsAvailable.Checked;




            if (_Phone.Save())
            {
                // Save specs too!
                ClsProductSpecs Specs = new ClsProductSpecs();
                Specs.ProductID = _Phone.ProductID;

                Specs.Storage = txtStorage.Text.Trim().EndsWith("GB") ?
                    txtStorage.Text.Trim() : txtStorage.Text.Trim() + "GB";

                Specs.Ram = txtRam.Text.Trim().EndsWith("GB") ?
                    txtRam.Text.Trim() : txtRam.Text.Trim() + "GB";

                Specs.Battery = txtBattery.Text.Trim().EndsWith("mAh") ?
                    txtBattery.Text.Trim() : txtBattery.Text.Trim() + "mAh";

                Specs.ScreenSize = txtScreen.Text.Trim();
                Specs.Color = txtColor.Text.Trim();
                Specs.OS = txtOS.Text.Trim();
                Specs.Save();

                MessageBox.Show("Phone Added Successfully!", "Saved",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to save phone!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
