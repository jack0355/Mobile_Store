using Mobile_Store;
using Mobile_Store.Browser.Browsing_Cards;
using Mobile_Store.Compare;
using Mobile_Store.Details;
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

namespace Mobile_Store.Browser
{
    public partial class FrmBrowse : Form
    {
        private DataTable _dtAllPhones;
        private DataTable _dtFiltered;
        private int _currentIndex = 0;
        private int _batchSize = 20;


        private void _LoadNextBatch()
        {
            int count = 0;

            while (_currentIndex < _dtFiltered.Rows.Count && count < _batchSize)
            {
                DataRow row = _dtFiltered.Rows[_currentIndex];

                ctrlPhoneDetailBrowsing card = new ctrlPhoneDetailBrowsing();
                card._LoadPhone(row);

                flpPhones.Controls.Add(card);

                _currentIndex++;
                count++;
            }

            lblRecordCount.Text = $"Loaded {_currentIndex} / {_dtFiltered.Rows.Count}";
        
        }

        public FrmBrowse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private async void FrmBrowse_Load(object sender, EventArgs e)
        {
            lblRecordCount.Text = "⏳ Loading phones...";
            flpPhones.Controls.Clear();

            _ShowLoadingCards();
            _LoadFilterPhones();


            // HERE i let the flow panel wait a little bit to download the data and the other stuff 
            await Task.Run(() =>
            {
                _dtAllPhones = ClsProducts.GetAllPhones();
            });
            _dtFiltered = _dtAllPhones.Copy();
            flpPhones.Controls.Clear();
            _currentIndex = 0;
            _LoadNextBatch();

        }

        private void _LoadFilterPhones()
        {
            DataTable dtBrand = Clsbrands.GetAllBrands();
            DataRow AllBrands = dtBrand.NewRow();
            AllBrands["brand_id"] = -1;
            AllBrands["name"] = "All Brands";
            dtBrand.Rows.InsertAt(AllBrands, 0);

            cbBrands.DataSource = dtBrand;
            cbBrands.DisplayMember = "name";
            cbBrands.ValueMember = "brand_id";


            DataTable dtCategory = ClsCategory.GetAllCategories();
            DataRow AllCategories = dtCategory.NewRow();
            AllCategories["category_id"] = -1;
            AllCategories["name"] = "All Categories";
            dtCategory.Rows.InsertAt(AllCategories, 0);

            cbFilterCategory.DataSource = dtCategory;
            cbFilterCategory.DisplayMember = "name";
            cbFilterCategory.ValueMember = "category_id";



        }


        private void _ApplyFilter()
        {
            if (_dtAllPhones == null) return;

            List<string> filters = new List<string>();

            if (!string.IsNullOrWhiteSpace(txtSearchPhone.Text))
                filters.Add($"name LIKE '%{txtSearchPhone.Text.Trim()}%'");

            if (cbBrands.SelectedIndex > 0)
                filters.Add($"Brand LIKE '{cbBrands.Text}'");

            if (cbFilterCategory.SelectedIndex > 0)
                filters.Add($"Category LIKE '{cbFilterCategory.Text}'");

            decimal min = 0;
            decimal max = decimal.MaxValue;

            if (!string.IsNullOrWhiteSpace(txtMin.Text))
                decimal.TryParse(txtMin.Text, out min);

            if (!string.IsNullOrWhiteSpace(txtMax.Text))
                decimal.TryParse(txtMax.Text, out max);

            if (min >=  max)
            {
                if (!string.IsNullOrWhiteSpace(txtMin.Text) || !string.IsNullOrWhiteSpace(txtMax.Text))
                {

                }
                filters.Add($"price >= {min} AND price <= {max}");
                MessageBox.Show("min cannoot be grater than max" ,"Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            string filterString = string.Join(" AND ", filters);
            _dtAllPhones.DefaultView.RowFilter = filterString;
            _dtFiltered = _dtAllPhones.DefaultView.ToTable();

            flpPhones.Controls.Clear();
            _currentIndex = 0;
            _LoadNextBatch();
        }

        private void _ShowLoadingCards()
        {
            for (int i = 0; i <= 10; i++)
            {
                Panel skeleton = new Panel();
                skeleton.Width = 200;
                skeleton.Height = 250;
                skeleton.BackColor = Color.LightGray;

                flpPhones.Controls.Add(skeleton);
            }
        }

        private void flpPhones_Scroll(object sender, ScrollEventArgs e)
        {

            if (flpPhones.VerticalScroll.Value + flpPhones.ClientSize.Height >= flpPhones.VerticalScroll.Maximum - 10)
            {
                _LoadNextBatch();
            }

        }

        private void cbBrands_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ApplyFilter();
        }

        private void cbFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ApplyFilter();
        }

        private void txtSearchPhone_TextChanged(object sender, EventArgs e)
        {
            _ApplyFilter();
        }

        private void txtMin_TextChanged(object sender, EventArgs e)
        {
            _ApplyFilter();
        }

        private void txtMax_TextChanged(object sender, EventArgs e)
        {
            _ApplyFilter();
        }
    }
}
