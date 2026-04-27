using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mobile_Store.Details;
using Mobile_Store_Buisness;


namespace Mobile_Store.Browser.Browsing_Cards
{
    public partial class ctrlPhoneDetailBrowsing : UserControl
    {
        private int _ProductID;
        public ctrlPhoneDetailBrowsing()
        {
            InitializeComponent();

            this.MouseEnter += ctrlPhoneDetailBrowsing_MouseEnter;
            this.MouseLeave += ctrlPhoneDetailBrowsing_MouseLeave;

            foreach (Control ctrl in this.Controls)
            {
                ctrl.MouseEnter += ctrlPhoneDetailBrowsing_MouseEnter;
                ctrl.MouseLeave += ctrlPhoneDetailBrowsing_MouseLeave;
            }
        }

        public void _LoadPhone(DataRow row)
        {
            _ProductID = (int)row["product_id"];

            lblPhoneName.Text = row["name"].ToString();
            lblBrandName.Text = row["Brand"].ToString();
            lblPhonePrice.Text = "$" + row["price"].ToString();

            string imageURL = row["image_url"] != DBNull.Value ?
                              row["image_url"].ToString() : "";

            if (!string.IsNullOrEmpty(imageURL) && System.IO.File.Exists(imageURL))
                pbPhonePicture.ImageLocation = imageURL;
            else
                pbPhonePicture.Image = Properties.Resources.icons8_apple_phone_1001;
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            FrmDetails frm = new FrmDetails(_ProductID);
            frm.ShowDialog();

        }

        private void ctrlPhoneDetailBrowsing_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(45, 45, 70);
            this.Cursor = Cursors.Hand;
        }

        private void ctrlPhoneDetailBrowsing_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(30, 30, 46); 
            this.Cursor = Cursors.Default;

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (Pen pen = new Pen(Color.FromArgb(0, 229, 255), 2))
            {
                e.Graphics.DrawRectangle(pen, 0, 0,
                    this.Width - 1, this.Height - 1);
            }
        }

        private void ctrlPhoneDetailBrowsing_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
