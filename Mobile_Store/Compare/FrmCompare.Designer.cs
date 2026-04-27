namespace Mobile_Store.Compare
{
    partial class FrmCompare
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.txtFilterSearch = new System.Windows.Forms.TextBox();
            this.cbFilterBy2 = new System.Windows.Forms.ComboBox();
            this.txtFilterSearch2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblRam = new System.Windows.Forms.Label();
            this.lblStorage1 = new System.Windows.Forms.Label();
            this.lblBattery1 = new System.Windows.Forms.Label();
            this.lblPrice1 = new System.Windows.Forms.Label();
            this.lblPrice2 = new System.Windows.Forms.Label();
            this.lblBattery2 = new System.Windows.Forms.Label();
            this.lblStorage2 = new System.Windows.Forms.Label();
            this.lblRam2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCompareClick = new System.Windows.Forms.Button();
            this.pbPrice2 = new System.Windows.Forms.PictureBox();
            this.pbBattery2 = new System.Windows.Forms.PictureBox();
            this.pbStorage2 = new System.Windows.Forms.PictureBox();
            this.pbRam2 = new System.Windows.Forms.PictureBox();
            this.pbPrice1 = new System.Windows.Forms.PictureBox();
            this.pbBattery = new System.Windows.Forms.PictureBox();
            this.pbStorage = new System.Windows.Forms.PictureBox();
            this.pbRam1 = new System.Windows.Forms.PictureBox();
            this.ctrlPhoneComparing2 = new Mobile_Store.Compare.CompareCtrl.ctrlPhoneComparing();
            this.ctrlPhoneComparing1 = new Mobile_Store.Compare.CompareCtrl.ctrlPhoneComparing();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBattery2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStorage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRam2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBattery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRam1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(517, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phone Comapring ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(379, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(670, 59);
            this.label2.TabIndex = 1;
            this.label2.Text = "Compare For BETTER choosing !";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(70, 526);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1335, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "---------------------------------------------------------------------------------" +
    "-----------------------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(404, 560);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(349, 45);
            this.label4.TabIndex = 6;
            this.label4.Text = "[ Phone Comapring ] ";
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
            this.cbFilterBy.Location = new System.Drawing.Point(12, 138);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(257, 39);
            this.cbFilterBy.TabIndex = 8;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // txtFilterSearch
            // 
            this.txtFilterSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterSearch.Location = new System.Drawing.Point(284, 140);
            this.txtFilterSearch.Name = "txtFilterSearch";
            this.txtFilterSearch.Size = new System.Drawing.Size(304, 38);
            this.txtFilterSearch.TabIndex = 7;
            // 
            // cbFilterBy2
            // 
            this.cbFilterBy2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBy2.FormattingEnabled = true;
            this.cbFilterBy2.Items.AddRange(new object[] {
            "None",
            "Phone Name",
            "Brand",
            "Category"});
            this.cbFilterBy2.Location = new System.Drawing.Point(847, 138);
            this.cbFilterBy2.Name = "cbFilterBy2";
            this.cbFilterBy2.Size = new System.Drawing.Size(257, 39);
            this.cbFilterBy2.TabIndex = 10;
            this.cbFilterBy2.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy2_SelectedIndexChanged);
            // 
            // txtFilterSearch2
            // 
            this.txtFilterSearch2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterSearch2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterSearch2.HideSelection = false;
            this.txtFilterSearch2.Location = new System.Drawing.Point(1120, 138);
            this.txtFilterSearch2.Name = "txtFilterSearch2";
            this.txtFilterSearch2.Size = new System.Drawing.Size(304, 38);
            this.txtFilterSearch2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(12, 637);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 50);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ram ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(12, 717);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 50);
            this.label6.TabIndex = 12;
            this.label6.Text = "Storage";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(12, 801);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 50);
            this.label7.TabIndex = 15;
            this.label7.Text = "Battery";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(12, 893);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 50);
            this.label8.TabIndex = 17;
            this.label8.Text = "Price ";
            // 
            // lblRam
            // 
            this.lblRam.AutoSize = true;
            this.lblRam.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRam.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRam.Location = new System.Drawing.Point(175, 637);
            this.lblRam.Name = "lblRam";
            this.lblRam.Size = new System.Drawing.Size(53, 38);
            this.lblRam.TabIndex = 18;
            this.lblRam.Text = "???";
            // 
            // lblStorage1
            // 
            this.lblStorage1.AutoSize = true;
            this.lblStorage1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStorage1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblStorage1.Location = new System.Drawing.Point(175, 727);
            this.lblStorage1.Name = "lblStorage1";
            this.lblStorage1.Size = new System.Drawing.Size(53, 38);
            this.lblStorage1.TabIndex = 19;
            this.lblStorage1.Text = "???";
            // 
            // lblBattery1
            // 
            this.lblBattery1.AutoSize = true;
            this.lblBattery1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBattery1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBattery1.Location = new System.Drawing.Point(175, 825);
            this.lblBattery1.Name = "lblBattery1";
            this.lblBattery1.Size = new System.Drawing.Size(53, 38);
            this.lblBattery1.TabIndex = 20;
            this.lblBattery1.Text = "???";
            // 
            // lblPrice1
            // 
            this.lblPrice1.AutoSize = true;
            this.lblPrice1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPrice1.Location = new System.Drawing.Point(175, 918);
            this.lblPrice1.Name = "lblPrice1";
            this.lblPrice1.Size = new System.Drawing.Size(53, 38);
            this.lblPrice1.TabIndex = 21;
            this.lblPrice1.Text = "???";
            // 
            // lblPrice2
            // 
            this.lblPrice2.AutoSize = true;
            this.lblPrice2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPrice2.Location = new System.Drawing.Point(1034, 920);
            this.lblPrice2.Name = "lblPrice2";
            this.lblPrice2.Size = new System.Drawing.Size(53, 38);
            this.lblPrice2.TabIndex = 26;
            this.lblPrice2.Text = "???";
            // 
            // lblBattery2
            // 
            this.lblBattery2.AutoSize = true;
            this.lblBattery2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBattery2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBattery2.Location = new System.Drawing.Point(1034, 824);
            this.lblBattery2.Name = "lblBattery2";
            this.lblBattery2.Size = new System.Drawing.Size(53, 38);
            this.lblBattery2.TabIndex = 25;
            this.lblBattery2.Text = "???";
            // 
            // lblStorage2
            // 
            this.lblStorage2.AutoSize = true;
            this.lblStorage2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStorage2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblStorage2.Location = new System.Drawing.Point(1034, 728);
            this.lblStorage2.Name = "lblStorage2";
            this.lblStorage2.Size = new System.Drawing.Size(53, 38);
            this.lblStorage2.TabIndex = 24;
            this.lblStorage2.Text = "???";
            // 
            // lblRam2
            // 
            this.lblRam2.AutoSize = true;
            this.lblRam2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRam2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRam2.Location = new System.Drawing.Point(1034, 636);
            this.lblRam2.Name = "lblRam2";
            this.lblRam2.Size = new System.Drawing.Size(53, 38);
            this.lblRam2.TabIndex = 23;
            this.lblRam2.Text = "???";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(835, 908);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 50);
            this.label9.TabIndex = 40;
            this.label9.Text = "Price ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Location = new System.Drawing.Point(835, 812);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 50);
            this.label10.TabIndex = 39;
            this.label10.Text = "Battery";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Location = new System.Drawing.Point(835, 718);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 50);
            this.label11.TabIndex = 38;
            this.label11.Text = "Storage";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.Location = new System.Drawing.Point(835, 626);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 50);
            this.label12.TabIndex = 37;
            this.label12.Text = "Ram ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Mobile_Store.Properties.Resources.icons8_close_963;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1243, 846);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 113);
            this.button1.TabIndex = 36;
            this.button1.Text = "Close ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCompareClick
            // 
            this.btnCompareClick.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompareClick.Image = global::Mobile_Store.Properties.Resources.icons8_comparephones_100;
            this.btnCompareClick.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompareClick.Location = new System.Drawing.Point(445, 637);
            this.btnCompareClick.Name = "btnCompareClick";
            this.btnCompareClick.Size = new System.Drawing.Size(269, 112);
            this.btnCompareClick.TabIndex = 35;
            this.btnCompareClick.Text = "Compare ";
            this.btnCompareClick.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCompareClick.UseVisualStyleBackColor = true;
            this.btnCompareClick.Click += new System.EventHandler(this.btnCompareClick_Click);
            // 
            // pbPrice2
            // 
            this.pbPrice2.Location = new System.Drawing.Point(1041, 865);
            this.pbPrice2.Name = "pbPrice2";
            this.pbPrice2.Size = new System.Drawing.Size(63, 49);
            this.pbPrice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPrice2.TabIndex = 34;
            this.pbPrice2.TabStop = false;
            // 
            // pbBattery2
            // 
            this.pbBattery2.Location = new System.Drawing.Point(1041, 772);
            this.pbBattery2.Name = "pbBattery2";
            this.pbBattery2.Size = new System.Drawing.Size(63, 49);
            this.pbBattery2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBattery2.TabIndex = 33;
            this.pbBattery2.TabStop = false;
            // 
            // pbStorage2
            // 
            this.pbStorage2.Location = new System.Drawing.Point(1041, 677);
            this.pbStorage2.Name = "pbStorage2";
            this.pbStorage2.Size = new System.Drawing.Size(63, 49);
            this.pbStorage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStorage2.TabIndex = 32;
            this.pbStorage2.TabStop = false;
            // 
            // pbRam2
            // 
            this.pbRam2.Location = new System.Drawing.Point(1041, 585);
            this.pbRam2.Name = "pbRam2";
            this.pbRam2.Size = new System.Drawing.Size(63, 49);
            this.pbRam2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRam2.TabIndex = 31;
            this.pbRam2.TabStop = false;
            // 
            // pbPrice1
            // 
            this.pbPrice1.Location = new System.Drawing.Point(168, 866);
            this.pbPrice1.Name = "pbPrice1";
            this.pbPrice1.Size = new System.Drawing.Size(63, 49);
            this.pbPrice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPrice1.TabIndex = 30;
            this.pbPrice1.TabStop = false;
            // 
            // pbBattery
            // 
            this.pbBattery.Location = new System.Drawing.Point(168, 772);
            this.pbBattery.Name = "pbBattery";
            this.pbBattery.Size = new System.Drawing.Size(63, 49);
            this.pbBattery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBattery.TabIndex = 29;
            this.pbBattery.TabStop = false;
            // 
            // pbStorage
            // 
            this.pbStorage.Location = new System.Drawing.Point(168, 678);
            this.pbStorage.Name = "pbStorage";
            this.pbStorage.Size = new System.Drawing.Size(63, 49);
            this.pbStorage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStorage.TabIndex = 28;
            this.pbStorage.TabStop = false;
            // 
            // pbRam1
            // 
            this.pbRam1.Location = new System.Drawing.Point(168, 586);
            this.pbRam1.Name = "pbRam1";
            this.pbRam1.Size = new System.Drawing.Size(63, 49);
            this.pbRam1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRam1.TabIndex = 27;
            this.pbRam1.TabStop = false;
            // 
            // ctrlPhoneComparing2
            // 
            this.ctrlPhoneComparing2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ctrlPhoneComparing2.Location = new System.Drawing.Point(720, 173);
            this.ctrlPhoneComparing2.Name = "ctrlPhoneComparing2";
            this.ctrlPhoneComparing2.Size = new System.Drawing.Size(714, 350);
            this.ctrlPhoneComparing2.TabIndex = 4;
            // 
            // ctrlPhoneComparing1
            // 
            this.ctrlPhoneComparing1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ctrlPhoneComparing1.Location = new System.Drawing.Point(1, 173);
            this.ctrlPhoneComparing1.Name = "ctrlPhoneComparing1";
            this.ctrlPhoneComparing1.Size = new System.Drawing.Size(713, 350);
            this.ctrlPhoneComparing1.TabIndex = 3;
            // 
            // FrmCompare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1466, 968);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCompareClick);
            this.Controls.Add(this.pbPrice2);
            this.Controls.Add(this.pbBattery2);
            this.Controls.Add(this.pbStorage2);
            this.Controls.Add(this.pbRam2);
            this.Controls.Add(this.pbPrice1);
            this.Controls.Add(this.pbBattery);
            this.Controls.Add(this.pbStorage);
            this.Controls.Add(this.pbRam1);
            this.Controls.Add(this.lblPrice2);
            this.Controls.Add(this.lblBattery2);
            this.Controls.Add(this.lblStorage2);
            this.Controls.Add(this.lblRam2);
            this.Controls.Add(this.lblPrice1);
            this.Controls.Add(this.lblBattery1);
            this.Controls.Add(this.lblStorage1);
            this.Controls.Add(this.lblRam);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbFilterBy2);
            this.Controls.Add(this.txtFilterSearch2);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.txtFilterSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ctrlPhoneComparing2);
            this.Controls.Add(this.ctrlPhoneComparing1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmCompare";
            this.Text = "FrmCompare";
            this.Load += new System.EventHandler(this.FrmCompare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBattery2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStorage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRam2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBattery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRam1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CompareCtrl.ctrlPhoneComparing ctrlPhoneComparing1;
        private CompareCtrl.ctrlPhoneComparing ctrlPhoneComparing2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox txtFilterSearch;
        private System.Windows.Forms.ComboBox cbFilterBy2;
        private System.Windows.Forms.TextBox txtFilterSearch2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblRam;
        private System.Windows.Forms.Label lblStorage1;
        private System.Windows.Forms.Label lblBattery1;
        private System.Windows.Forms.Label lblPrice1;
        private System.Windows.Forms.Label lblPrice2;
        private System.Windows.Forms.Label lblBattery2;
        private System.Windows.Forms.Label lblStorage2;
        private System.Windows.Forms.Label lblRam2;
        private System.Windows.Forms.PictureBox pbRam1;
        private System.Windows.Forms.PictureBox pbStorage;
        private System.Windows.Forms.PictureBox pbBattery;
        private System.Windows.Forms.PictureBox pbPrice1;
        private System.Windows.Forms.PictureBox pbRam2;
        private System.Windows.Forms.PictureBox pbStorage2;
        private System.Windows.Forms.PictureBox pbBattery2;
        private System.Windows.Forms.PictureBox pbPrice2;
        private System.Windows.Forms.Button btnCompareClick;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}