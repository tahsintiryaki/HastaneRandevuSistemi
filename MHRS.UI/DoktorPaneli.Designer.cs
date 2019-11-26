namespace MHRS.UI
{
    partial class DoktorPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorPaneli));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstDoktorRandevulari = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnYeniRandevuKaydet = new System.Windows.Forms.Button();
            this.cmbSeanslar = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnReceteKaydet = new System.Windows.Forms.Button();
            this.TxtIlaclar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReceteKodu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbTeshis = new System.Windows.Forms.ComboBox();
            this.btnTeshisKaydet = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstDoktorRandevulari);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(791, 304);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Randevularım";
            // 
            // lstDoktorRandevulari
            // 
            this.lstDoktorRandevulari.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lstDoktorRandevulari.Font = new System.Drawing.Font("Calibri", 11F);
            this.lstDoktorRandevulari.ForeColor = System.Drawing.Color.Gray;
            this.lstDoktorRandevulari.FullRowSelect = true;
            this.lstDoktorRandevulari.GridLines = true;
            this.lstDoktorRandevulari.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstDoktorRandevulari.HideSelection = false;
            this.lstDoktorRandevulari.Location = new System.Drawing.Point(7, 21);
            this.lstDoktorRandevulari.Name = "lstDoktorRandevulari";
            this.lstDoktorRandevulari.Size = new System.Drawing.Size(778, 275);
            this.lstDoktorRandevulari.TabIndex = 6;
            this.lstDoktorRandevulari.UseCompatibleStateImageBehavior = false;
            this.lstDoktorRandevulari.View = System.Windows.Forms.View.Details;
            this.lstDoktorRandevulari.Click += new System.EventHandler(this.lstDoktorRandevulari_Click);
            this.lstDoktorRandevulari.DoubleClick += new System.EventHandler(this.lstDoktorRandevulari_DoubleClick);
            this.lstDoktorRandevulari.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LstDoktorRandevulari_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Randevu No";
            this.columnHeader1.Width = 87;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tarih";
            this.columnHeader2.Width = 95;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Saat";
            this.columnHeader3.Width = 66;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "HastaNo";
            this.columnHeader4.Width = 74;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Muayene Durumu";
            this.columnHeader5.Width = 135;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Teşhis";
            this.columnHeader6.Width = 140;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Notlar";
            this.columnHeader7.Width = 166;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnYeniRandevuKaydet);
            this.groupBox2.Controls.Add(this.cmbSeanslar);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.monthCalendar1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(466, 335);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 330);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İleri Tarihe Randevu Oluştur";
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancel.Location = new System.Drawing.Point(261, 254);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(54, 34);
            this.btnCancel.TabIndex = 49;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnYeniRandevuKaydet
            // 
            this.btnYeniRandevuKaydet.BackColor = System.Drawing.Color.White;
            this.btnYeniRandevuKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnYeniRandevuKaydet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnYeniRandevuKaydet.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnYeniRandevuKaydet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnYeniRandevuKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniRandevuKaydet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnYeniRandevuKaydet.Location = new System.Drawing.Point(195, 254);
            this.btnYeniRandevuKaydet.Name = "btnYeniRandevuKaydet";
            this.btnYeniRandevuKaydet.Size = new System.Drawing.Size(63, 34);
            this.btnYeniRandevuKaydet.TabIndex = 48;
            this.btnYeniRandevuKaydet.Text = "Kaydet";
            this.btnYeniRandevuKaydet.UseVisualStyleBackColor = false;
            // 
            // cmbSeanslar
            // 
            this.cmbSeanslar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSeanslar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmbSeanslar.FormattingEnabled = true;
            this.cmbSeanslar.Location = new System.Drawing.Point(81, 216);
            this.cmbSeanslar.Name = "cmbSeanslar";
            this.cmbSeanslar.Size = new System.Drawing.Size(234, 45);
            this.cmbSeanslar.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(6, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 37);
            this.label8.TabIndex = 46;
            this.label8.Text = "Saat:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.monthCalendar1.Location = new System.Drawing.Point(81, 42);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(8, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 37);
            this.label7.TabIndex = 44;
            this.label7.Text = "Tarih:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnReceteKaydet);
            this.groupBox3.Controls.Add(this.TxtIlaclar);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtReceteKodu);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(12, 479);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 184);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reçete Oluştur";
            // 
            // btnReceteKaydet
            // 
            this.btnReceteKaydet.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnReceteKaydet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnReceteKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceteKaydet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReceteKaydet.Location = new System.Drawing.Point(246, 128);
            this.btnReceteKaydet.Name = "btnReceteKaydet";
            this.btnReceteKaydet.Size = new System.Drawing.Size(63, 34);
            this.btnReceteKaydet.TabIndex = 13;
            this.btnReceteKaydet.Text = "Kaydet";
            this.btnReceteKaydet.UseVisualStyleBackColor = true;
            this.btnReceteKaydet.Click += new System.EventHandler(this.btnReceteKaydet_Click);
            // 
            // TxtIlaclar
            // 
            this.TxtIlaclar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TxtIlaclar.Location = new System.Drawing.Point(110, 84);
            this.TxtIlaclar.Name = "TxtIlaclar";
            this.TxtIlaclar.Size = new System.Drawing.Size(199, 44);
            this.TxtIlaclar.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(11, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 37);
            this.label3.TabIndex = 11;
            this.label3.Text = "İlaçlar:";
            // 
            // txtReceteKodu
            // 
            this.txtReceteKodu.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtReceteKodu.Location = new System.Drawing.Point(110, 42);
            this.txtReceteKodu.Name = "txtReceteKodu";
            this.txtReceteKodu.ReadOnly = true;
            this.txtReceteKodu.Size = new System.Drawing.Size(199, 44);
            this.txtReceteKodu.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(11, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "Reçete Kodu: ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbTeshis);
            this.groupBox4.Controls.Add(this.btnTeshisKaydet);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(12, 333);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(347, 140);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Teşhis Oluştur";
            // 
            // cmbTeshis
            // 
            this.cmbTeshis.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbTeshis.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cmbTeshis.FormattingEnabled = true;
            this.cmbTeshis.Location = new System.Drawing.Point(110, 42);
            this.cmbTeshis.Name = "cmbTeshis";
            this.cmbTeshis.Size = new System.Drawing.Size(199, 45);
            this.cmbTeshis.TabIndex = 48;
            // 
            // btnTeshisKaydet
            // 
            this.btnTeshisKaydet.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnTeshisKaydet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnTeshisKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeshisKaydet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTeshisKaydet.Location = new System.Drawing.Point(246, 86);
            this.btnTeshisKaydet.Name = "btnTeshisKaydet";
            this.btnTeshisKaydet.Size = new System.Drawing.Size(63, 34);
            this.btnTeshisKaydet.TabIndex = 13;
            this.btnTeshisKaydet.Text = "Kaydet";
            this.btnTeshisKaydet.UseVisualStyleBackColor = true;
            this.btnTeshisKaydet.Click += new System.EventHandler(this.btnTeshisKaydet_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(14, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 37);
            this.label9.TabIndex = 7;
            this.label9.Text = "Teşhis:";
            // 
            // DoktorPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(817, 677);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DoktorPaneli";
            this.Text = "DoktorPaneli";
            this.Load += new System.EventHandler(this.DoktorPaneli_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lstDoktorRandevulari;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnYeniRandevuKaydet;
        private System.Windows.Forms.ComboBox cmbSeanslar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnReceteKaydet;
        private System.Windows.Forms.TextBox TxtIlaclar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReceteKodu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbTeshis;
        private System.Windows.Forms.Button btnTeshisKaydet;
        private System.Windows.Forms.Label label9;
    }
}