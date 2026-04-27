namespace Mobile_Store.Admin
{
    partial class FrmAdmin
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPhones = new System.Windows.Forms.DataGridView();
            this.CmsOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.txtFilterSearch = new System.Windows.Forms.TextBox();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ctrlPhoneInfoAdmin1 = new Mobile_Store.Admin.ctrlPhoneInfoAdmin();
            this.btnCheckClose = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhones)).BeginInit();
            this.CmsOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(466, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Products Mangament ";
            // 
            // dgvPhones
            // 
            this.dgvPhones.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPhones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhones.ContextMenuStrip = this.CmsOptions;
            this.dgvPhones.Location = new System.Drawing.Point(1, 167);
            this.dgvPhones.Name = "dgvPhones";
            this.dgvPhones.ReadOnly = true;
            this.dgvPhones.RowHeadersWidth = 51;
            this.dgvPhones.RowTemplate.Height = 26;
            this.dgvPhones.Size = new System.Drawing.Size(894, 475);
            this.dgvPhones.TabIndex = 7;
            this.dgvPhones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhones_CellClick_1);
            // 
            // CmsOptions
            // 
            this.CmsOptions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmsOptions.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.CmsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.CmsOptions.Name = "contextMenuStrip1";
            this.CmsOptions.Size = new System.Drawing.Size(171, 96);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.Image = global::Mobile_Store.Properties.Resources.icons8_edit_100;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(170, 46);
            this.editToolStripMenuItem.Text = "Edit ";
            this.editToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::Mobile_Store.Properties.Resources.icons8_delete_100;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(170, 46);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Phone Name",
            "Brand",
            "Category"});
            this.cbFilterBy.Location = new System.Drawing.Point(12, 122);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(241, 39);
            this.cbFilterBy.TabIndex = 6;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // txtFilterSearch
            // 
            this.txtFilterSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterSearch.Location = new System.Drawing.Point(259, 123);
            this.txtFilterSearch.Name = "txtFilterSearch";
            this.txtFilterSearch.Size = new System.Drawing.Size(261, 38);
            this.txtFilterSearch.TabIndex = 5;
            this.txtFilterSearch.TextChanged += new System.EventHandler(this.txtFilterSearch_TextChanged);
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordCount.ForeColor = System.Drawing.Color.White;
            this.lblRecordCount.Location = new System.Drawing.Point(135, 645);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(57, 41);
            this.lblRecordCount.TabIndex = 10;
            this.lblRecordCount.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 645);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 41);
            this.label2.TabIndex = 9;
            this.label2.Text = "Record ";
            // 
            // ctrlPhoneInfoAdmin1
            // 
            this.ctrlPhoneInfoAdmin1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ctrlPhoneInfoAdmin1.Location = new System.Drawing.Point(918, 69);
            this.ctrlPhoneInfoAdmin1.Name = "ctrlPhoneInfoAdmin1";
            this.ctrlPhoneInfoAdmin1.Size = new System.Drawing.Size(618, 654);
            this.ctrlPhoneInfoAdmin1.TabIndex = 12;
            // 
            // btnCheckClose
            // 
            this.btnCheckClose.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckClose.Image = global::Mobile_Store.Properties.Resources.icons8_close_963;
            this.btnCheckClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckClose.Location = new System.Drawing.Point(12, 692);
            this.btnCheckClose.Name = "btnCheckClose";
            this.btnCheckClose.Size = new System.Drawing.Size(194, 93);
            this.btnCheckClose.TabIndex = 14;
            this.btnCheckClose.Text = "Close ";
            this.btnCheckClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheckClose.UseVisualStyleBackColor = true;
            this.btnCheckClose.Click += new System.EventHandler(this.btnCheckClose_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = global::Mobile_Store.Properties.Resources.icons8_clear_64;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(478, 648);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 75);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "        Clear";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Image = global::Mobile_Store.Properties.Resources.icons8_add_new_64;
            this.btnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNew.Location = new System.Drawing.Point(698, 648);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(197, 75);
            this.btnAddNew.TabIndex = 8;
            this.btnAddNew.Text = "        Add ";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.DimGray;
            this.btnBack.Image = global::Mobile_Store.Properties.Resources.icons8_back_96;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(12, 718);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(197, 60);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "      Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1548, 790);
            this.ControlBox = false;
            this.Controls.Add(this.btnCheckClose);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlPhoneInfoAdmin1);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.dgvPhones);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.txtFilterSearch);
            this.Controls.Add(this.label1);
            this.Name = "FrmAdmin";
            this.Text = "FrmAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhones)).EndInit();
            this.CmsOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPhones;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilterSearch;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
        private ctrlPhoneInfoAdmin ctrlPhoneInfoAdmin1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ContextMenuStrip CmsOptions;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button btnCheckClose;
    }
}