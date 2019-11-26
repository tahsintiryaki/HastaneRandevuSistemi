namespace MHRS.UI
{
    partial class EczanePaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EczanePaneli));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstReceteler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnReceteGetir = new System.Windows.Forms.Button();
            this.txtHastaID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstilaclar = new System.Windows.Forms.ListBox();
            this.btnİlaclariGetir = new System.Windows.Forms.Button();
            this.txtReceteID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstReceteler);
            this.groupBox1.Controls.Add(this.btnReceteGetir);
            this.groupBox1.Controls.Add(this.txtHastaID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 277);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hastanın Reçeteleri";
            // 
            // lstReceteler
            // 
            this.lstReceteler.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lstReceteler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstReceteler.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lstReceteler.FullRowSelect = true;
            this.lstReceteler.GridLines = true;
            this.lstReceteler.HideSelection = false;
            this.lstReceteler.Location = new System.Drawing.Point(19, 80);
            this.lstReceteler.Name = "lstReceteler";
            this.lstReceteler.Size = new System.Drawing.Size(311, 177);
            this.lstReceteler.TabIndex = 11;
            this.lstReceteler.UseCompatibleStateImageBehavior = false;
            this.lstReceteler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Reçete Kodu";
            this.columnHeader1.Width = 128;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "İlaçlar";
            this.columnHeader2.Width = 172;
            // 
            // btnReceteGetir
            // 
            this.btnReceteGetir.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnReceteGetir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnReceteGetir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceteGetir.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnReceteGetir.Location = new System.Drawing.Point(251, 33);
            this.btnReceteGetir.Name = "btnReceteGetir";
            this.btnReceteGetir.Size = new System.Drawing.Size(79, 26);
            this.btnReceteGetir.TabIndex = 10;
            this.btnReceteGetir.Text = "Kayıt Getir";
            this.btnReceteGetir.UseVisualStyleBackColor = true;
            this.btnReceteGetir.Click += new System.EventHandler(this.btnReceteGetir_Click);
            // 
            // txtHastaID
            // 
            this.txtHastaID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtHastaID.Location = new System.Drawing.Point(98, 33);
            this.txtHastaID.Name = "txtHastaID";
            this.txtHastaID.Size = new System.Drawing.Size(138, 26);
            this.txtHastaID.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hasta No:\r\n";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstilaclar);
            this.groupBox2.Controls.Add(this.btnİlaclariGetir);
            this.groupBox2.Controls.Add(this.txtReceteID);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(372, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 277);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reçete İçeriğini Görüntüle";
            // 
            // lstilaclar
            // 
            this.lstilaclar.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lstilaclar.FormattingEnabled = true;
            this.lstilaclar.ItemHeight = 18;
            this.lstilaclar.Location = new System.Drawing.Point(19, 84);
            this.lstilaclar.Name = "lstilaclar";
            this.lstilaclar.Size = new System.Drawing.Size(311, 166);
            this.lstilaclar.TabIndex = 7;
            // 
            // btnİlaclariGetir
            // 
            this.btnİlaclariGetir.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnİlaclariGetir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnİlaclariGetir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnİlaclariGetir.Font = new System.Drawing.Font("Calibri", 10F);
            this.btnİlaclariGetir.Location = new System.Drawing.Point(251, 42);
            this.btnİlaclariGetir.Name = "btnİlaclariGetir";
            this.btnİlaclariGetir.Size = new System.Drawing.Size(79, 26);
            this.btnİlaclariGetir.TabIndex = 6;
            this.btnİlaclariGetir.Text = "Kayıt Getir";
            this.btnİlaclariGetir.UseVisualStyleBackColor = true;
            this.btnİlaclariGetir.Click += new System.EventHandler(this.btnİlaclariGetir_Click);
            // 
            // txtReceteID
            // 
            this.txtReceteID.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtReceteID.Location = new System.Drawing.Point(98, 42);
            this.txtReceteID.Name = "txtReceteID";
            this.txtReceteID.Size = new System.Drawing.Size(138, 26);
            this.txtReceteID.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Reçete No:";
            // 
            // EczanePaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(741, 304);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EczanePaneli";
            this.Text = "Eczane Paneli";
            this.Load += new System.EventHandler(this.EczanePaneli_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lstReceteler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnReceteGetir;
        private System.Windows.Forms.TextBox txtHastaID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstilaclar;
        private System.Windows.Forms.Button btnİlaclariGetir;
        private System.Windows.Forms.TextBox txtReceteID;
        private System.Windows.Forms.Label label2;
    }
}