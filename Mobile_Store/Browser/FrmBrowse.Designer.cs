namespace Mobile_Store.Browser
{
    partial class FrmBrowse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBrowse));
            this.txtSearchPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbBrands = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.flpPhones = new System.Windows.Forms.FlowLayoutPanel();
            this.ctrlPhoneDetailBrowsing1 = new Mobile_Store.Browser.Browsing_Cards.ctrlPhoneDetailBrowsing();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbFilterCategory = new System.Windows.Forms.ComboBox();
            this.flpPhones.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearchPhone
            // 
            this.txtSearchPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchPhone.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchPhone.Location = new System.Drawing.Point(22, 111);
            this.txtSearchPhone.Name = "txtSearchPhone";
            this.txtSearchPhone.Size = new System.Drawing.Size(304, 38);
            this.txtSearchPhone.TabIndex = 0;
            this.txtSearchPhone.TextChanged += new System.EventHandler(this.txtSearchPhone_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(509, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(477, 74);
            this.label1.TabIndex = 1;
            this.label1.Text = "Browsing Phones";
            // 
            // cbBrands
            // 
            this.cbBrands.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBrands.FormattingEnabled = true;
            this.cbBrands.Items.AddRange(new object[] {
            "None",
            "Phone Name",
            "Brand",
            "Category",
            "Price Range "});
            this.cbBrands.Location = new System.Drawing.Point(358, 110);
            this.cbBrands.Name = "cbBrands";
            this.cbBrands.Size = new System.Drawing.Size(278, 39);
            this.cbBrands.TabIndex = 2;
            this.cbBrands.SelectedIndexChanged += new System.EventHandler(this.cbBrands_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 772);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 41);
            this.label2.TabIndex = 6;
            this.label2.Text = "Record ";
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordCount.Location = new System.Drawing.Point(119, 775);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(53, 38);
            this.lblRecordCount.TabIndex = 7;
            this.lblRecordCount.Text = "???";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1273, 750);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 63);
            this.button1.TabIndex = 9;
            this.button1.Text = "      Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flpPhones
            // 
            this.flpPhones.AutoScroll = true;
            this.flpPhones.BackColor = System.Drawing.Color.Silver;
            this.flpPhones.Controls.Add(this.ctrlPhoneDetailBrowsing1);
            this.flpPhones.Location = new System.Drawing.Point(4, 232);
            this.flpPhones.Name = "flpPhones";
            this.flpPhones.Size = new System.Drawing.Size(1333, 512);
            this.flpPhones.TabIndex = 10;
            this.flpPhones.Scroll += new System.Windows.Forms.ScrollEventHandler(this.flpPhones_Scroll);
            // 
            // ctrlPhoneDetailBrowsing1
            // 
            this.ctrlPhoneDetailBrowsing1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ctrlPhoneDetailBrowsing1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ctrlPhoneDetailBrowsing1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ctrlPhoneDetailBrowsing1.Location = new System.Drawing.Point(3, 3);
            this.ctrlPhoneDetailBrowsing1.Name = "ctrlPhoneDetailBrowsing1";
            this.ctrlPhoneDetailBrowsing1.Size = new System.Drawing.Size(629, 483);
            this.ctrlPhoneDetailBrowsing1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1196, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "---------------------------------------------------------------------------------" +
    "-------------------------------------------------------------------";
            // 
            // txtMin
            // 
            this.txtMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMin.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMin.Location = new System.Drawing.Point(289, 188);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(304, 38);
            this.txtMin.TabIndex = 12;
            this.txtMin.TextChanged += new System.EventHandler(this.txtMin_TextChanged);
            // 
            // txtMax
            // 
            this.txtMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMax.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMax.Location = new System.Drawing.Point(712, 188);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(304, 38);
            this.txtMax.TabIndex = 13;
            this.txtMax.TextChanged += new System.EventHandler(this.txtMax_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(612, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "  TO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(209, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 31);
            this.label5.TabIndex = 15;
            this.label5.Text = " Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1036, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 31);
            this.label6.TabIndex = 16;
            this.label6.Text = " Max ";
            // 
            // cbFilterCategory
            // 
            this.cbFilterCategory.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterCategory.FormattingEnabled = true;
            this.cbFilterCategory.Items.AddRange(new object[] {
            "None",
            "Phone Name",
            "Brand",
            "Category",
            "Price Range "});
            this.cbFilterCategory.Location = new System.Drawing.Point(659, 110);
            this.cbFilterCategory.Name = "cbFilterCategory";
            this.cbFilterCategory.Size = new System.Drawing.Size(273, 39);
            this.cbFilterCategory.TabIndex = 17;
            this.cbFilterCategory.SelectedIndexChanged += new System.EventHandler(this.cbFilterCategory_SelectedIndexChanged);
            // 
            // FrmBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1471, 818);
            this.Controls.Add(this.cbFilterCategory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flpPhones);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbBrands);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchPhone);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmBrowse";
            this.Text = "FrmBrowse";
            this.Load += new System.EventHandler(this.FrmBrowse_Load);
            this.flpPhones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbBrands;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flpPhones;
        private Browsing_Cards.ctrlPhoneDetailBrowsing ctrlPhoneDetailBrowsing1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbFilterCategory;
    }
}