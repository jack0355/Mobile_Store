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



namespace Mobile_Store.Details
{
    public partial class ctrlPhonesDetailscs : UserControl
    {
        public ctrlPhonesDetailscs()
        {
            InitializeComponent();
        }


        public  void LoadPhoneDetails(int ProdcutID)
        {
            ClsProducts Phone = ClsProducts.GetPhoneByID(ProdcutID);

            if(Phone != null)
            {
                lblPhoneName.Text = Phone.ProductName;
                Clsbrands Brand = Clsbrands.GetbrandById(Phone.BrandID);
                lblBrand.Text = Brand != null ? Brand.BrandName : "Unknown";

                ClsCategory category = ClsCategory.GetCategoryByID(Phone.CategoryID);
                lblCategory.Text = category != null ? category._CategoryName : "Unknown";
               

                lblPrice.Text ="$"+ Phone.Price.ToString();
                lblDescription.Text =   Phone.Description;
            }

            else
            {
                MessageBox.Show("The Phone Is not existed , Please Try Again ! ", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);  
            }
            ClsProductSpecs Specs = ClsProductSpecs.GetSpecsByProductID(ProdcutID);

            if (Specs != null)
            {
                lblStorage.Text = Specs.Storage;
                lblRam.Text = Specs.Ram;
                lblScreem.Text = Specs.ScreenSize;
                lblBattery.Text = Specs.Battery;
                lblColor.Text = Specs.Color;
                lblOS.Text = Specs.OS;
            }
            else
            {
                MessageBox.Show("Phone Specs Information Failed to Load " ,"Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
            }

            lblpbPhoneName.Text = lblPhoneName.Text;
            if (!string.IsNullOrEmpty(Phone.ImageURL) && File.Exists(Phone.ImageURL))
                pbPhoneImage.Image = Image.FromFile(Phone.ImageURL);
            else
                pbPhoneImage.Image = null; // no image, just empty picturebox
   
        }
    }
}
