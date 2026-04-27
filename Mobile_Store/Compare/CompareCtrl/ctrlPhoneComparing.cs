using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mobile_Store_Buisness;

namespace Mobile_Store.Compare.CompareCtrl
{
    public partial class ctrlPhoneComparing : UserControl
    {
        public ClsProductSpecs Speces;
        public ClsProducts Phone;
        public ctrlPhoneComparing()
        {
            InitializeComponent();
            
        }

        public   void _LoadPhoneCtrlCompare(int ProductID)
        {
            Phone = ClsProducts.GetPhoneByID(ProductID);
            if (Phone != null)
            {
                lblPhoneName.Text = Phone.ProductName;
                lblPrice.Text = "$" + Phone.Price.ToString();
                if(!string.IsNullOrEmpty(Phone.ImageURL)&& System.IO.File.Exists(Phone.ImageURL)) 
                    pbPhoneImage.ImageLocation = Phone.ImageURL;
                else
                    pbPhoneImage.Image = Properties.Resources.icons8_apple_phone_1001;
            }

            Speces = ClsProductSpecs.GetSpecsByProductID(ProductID);
            if (Speces != null)
            {
                lblStorage.Text = Speces.Storage;
                lblRam.Text = Speces.Ram;
                lblScreem.Text = Speces.ScreenSize;
                lblBattery.Text = Speces.Battery;
               
            }


        }
    }
}
