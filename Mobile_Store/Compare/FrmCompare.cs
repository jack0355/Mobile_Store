using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mobile_Store.Compare.CompareCtrl;
using Mobile_Store_Buisness;


namespace Mobile_Store.Compare
{
    public partial class FrmCompare : Form
    {
        public ClsProducts Phone;
        public ClsProductSpecs Specs;
        public int _SelectedProductID = -1;
        public FrmCompare(int ProductID)
        {

            InitializeComponent();
            _SelectedProductID = ProductID;
        }

        public FrmCompare()
        {

            InitializeComponent();
            
        }

        public void _LoadPhone()
        {
            
            DataTable dt = ClsProducts.GetAllPhones();

            
            int selected1 = cbFilterBy.SelectedValue != null ? (int)cbFilterBy.SelectedValue : -1;
            int selected2 = cbFilterBy2.SelectedValue != null ? (int)cbFilterBy2.SelectedValue : -1;

           
            cbFilterBy.DataSource = null;
            cbFilterBy.DataSource = dt;
            cbFilterBy.DisplayMember = "name";
            cbFilterBy.ValueMember = "product_id";

            cbFilterBy2.DataSource = null;
            cbFilterBy2.DataSource = dt.Copy();
            cbFilterBy2.DisplayMember = "name";
            cbFilterBy2.ValueMember = "product_id";

            // Restore previous selection
            if (_SelectedProductID != -1)
                cbFilterBy.SelectedValue = _SelectedProductID;
            else if (selected1 != -1)
                cbFilterBy.SelectedValue = selected1;

            if (selected2 != -1)
                cbFilterBy2.SelectedValue = selected2;
        }

        private void FrmCompare_Load(object sender, EventArgs e)
        {
            _LoadPhone();
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.SelectedValue == null) return;

            
            if (int.TryParse(cbFilterBy.SelectedValue.ToString(), out int ProductID))
            {
                ctrlPhoneComparing1._LoadPhoneCtrlCompare(ProductID);
            }
        }

        private void cbFilterBy2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy2.SelectedValue == null) return;

            
            if (int.TryParse(cbFilterBy2.SelectedValue.ToString(), out int ProductID))
            {
                ctrlPhoneComparing2._LoadPhoneCtrlCompare(ProductID);
            }
        }

        private void _LoadComparePhone()
        {
            int id1 = int.Parse(cbFilterBy.SelectedValue.ToString());
            int id2 = int.Parse(cbFilterBy2.SelectedValue.ToString());
            if (id1 == id2)
            {
                MessageBox.Show("Please select two different phones!", "Error",
        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            ClsProductSpecs specs1 = ctrlPhoneComparing1.Speces;
            ClsProductSpecs specs2 = ctrlPhoneComparing2.Speces;
            ClsProducts Phone1 = ctrlPhoneComparing1.Phone;
            ClsProducts Phone2 = ctrlPhoneComparing2.Phone;

            if(specs1 ==  null  || specs2 == null)
            {
                MessageBox.Show("Please Select Two Phones First !" , "Error" ,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //___________________________________________________________________
            //___________________________________________________________________
            int Ram1 = int.Parse(specs1.Ram.Replace("GB", "").Trim());
            int Ram2 = int.Parse(specs2.Ram.Replace("GB", "").Trim());
            if (Ram1 > Ram2)
            {
                pbRam1.Image = Properties.Resources.icons8_tick_32;
                pbRam2.Image = Properties.Resources.icons8_cross_48;
            }
            else if (Ram2 > Ram1)
            {
                pbRam1.Image = Properties.Resources.icons8_cross_48;
                pbRam2.Image = Properties.Resources.icons8_tick_32;
            }
            else
            {
                pbRam1.Image = Properties.Resources.icons8_equal_sign_48;
                pbRam2.Image = Properties.Resources.icons8_equal_sign_48;
            }
            lblRam.Text  =  specs1.Ram;
            lblRam2.Text = specs2.Ram;
            //_____________________________________________________________________
            //_____________________________________________________________________
            int Storage1 = int.Parse(specs1.Storage.Replace("GB", ""));
            int Storage2 = int.Parse(specs2.Storage.Replace("GB" ,""));
            if (Storage1 > Storage2)
            {
                pbStorage.Image = Properties.Resources.icons8_tick_32;
                pbStorage2.Image = Properties.Resources.icons8_cross_48;
            }
            else if (Storage2 > Storage1)
            {
                pbStorage.Image = Properties.Resources.icons8_cross_48;
                pbStorage2.Image = Properties.Resources.icons8_tick_32;
            }
            else
            {
                pbStorage.Image = Properties.Resources.icons8_equal_sign_48;
                pbStorage2.Image = Properties.Resources.icons8_equal_sign_48;
            }
            lblStorage1.Text = specs1.Storage;
            lblStorage2.Text = specs2.Storage;
        //____________________________________________________________________
        //____________________________________________________________________
            int Battery1 = int.Parse(specs1.Battery.Replace("mAh", ""));
            int Battery2 = int.Parse(specs2.Battery.Replace("mAh", ""));
            if (Battery1 > Battery2)
            {
                pbBattery.Image = Properties.Resources.icons8_tick_32;
                pbBattery2.Image = Properties.Resources.icons8_cross_48;
            }
            else if (Battery2 > Battery1)
            {
                pbBattery.Image = Properties.Resources.icons8_cross_48;
                pbBattery2.Image = Properties.Resources.icons8_tick_32;
            }
            else
            {
                pbBattery.Image = Properties.Resources.icons8_equal_sign_48;
                pbBattery2.Image = Properties.Resources.icons8_equal_sign_48;
            }
           lblBattery1.Text = specs1.Battery;
            lblBattery2.Text = specs2.Battery;
        //____________________________________________________________________
        //____________________________________________________________________

            decimal Price1 = Phone1.Price;
            decimal Price2 = Phone2.Price;
            if (Price1 > Price2)
            {
                pbPrice2.Image = Properties.Resources.icons8_tick_32;
                pbPrice1.Image = Properties.Resources.icons8_cross_48;
            }
            else if (Price2 > Price1)
            {
                pbPrice2.Image = Properties.Resources.icons8_cross_48;
                pbPrice1.Image = Properties.Resources.icons8_tick_32;
            }
            else
            {
                pbPrice1.Image = Properties.Resources.icons8_equal_sign_48;
                pbPrice2.Image = Properties.Resources.icons8_equal_sign_48;
            }

            lblPrice1.Text = Phone1.Price.ToString() + "$";
            lblPrice2.Text = Phone2.Price.ToString() + "$";

        }

    
        private void btnCompareClick_Click(object sender, EventArgs e)
        {
             _LoadComparePhone();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
