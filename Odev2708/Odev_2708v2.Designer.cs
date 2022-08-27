namespace Odev2708
{
    partial class Odev_2708v2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_urun = new System.Windows.Forms.ComboBox();
            this.lbl_beden = new System.Windows.Forms.Label();
            this.btn_urunEkle = new System.Windows.Forms.Button();
            this.cb_bedenGomlek = new System.Windows.Forms.ComboBox();
            this.lbl_ayakNo = new System.Windows.Forms.Label();
            this.cb_ayakNo = new System.Windows.Forms.ComboBox();
            this.cb_bedenPantolon = new System.Windows.Forms.ComboBox();
            this.lbl_boy = new System.Windows.Forms.Label();
            this.cb_boy = new System.Windows.Forms.ComboBox();
            this.gb_urunEklendi = new System.Windows.Forms.GroupBox();
            this.lbl_boyEklendi = new System.Windows.Forms.Label();
            this.lbl_bedenEklendi = new System.Windows.Forms.Label();
            this.lbl_ayakNoEklendi = new System.Windows.Forms.Label();
            this.lbl_urunEklendi = new System.Windows.Forms.Label();
            this.lbl_boyuBilgisi = new System.Windows.Forms.Label();
            this.lbl_ayakNoBilgisi = new System.Windows.Forms.Label();
            this.lbl_bedenBilgisi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gb_urunEkle = new System.Windows.Forms.GroupBox();
            this.btn_yeniUrunEkle = new System.Windows.Forms.Button();
            this.gb_urunEklendi.SuspendLayout();
            this.gb_urunEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(51, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÜRÜN EKLEME SAYFASINA HOŞGELDİNİZ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün";
            // 
            // cb_urun
            // 
            this.cb_urun.FormattingEnabled = true;
            this.cb_urun.Items.AddRange(new object[] {
            "Gömlek",
            "Pantolon",
            "Ayakkabı"});
            this.cb_urun.Location = new System.Drawing.Point(101, 32);
            this.cb_urun.Name = "cb_urun";
            this.cb_urun.Size = new System.Drawing.Size(121, 24);
            this.cb_urun.TabIndex = 2;
            this.cb_urun.SelectedIndexChanged += new System.EventHandler(this.cb_urun_SelectedIndexChanged);
            // 
            // lbl_beden
            // 
            this.lbl_beden.AutoSize = true;
            this.lbl_beden.Location = new System.Drawing.Point(6, 83);
            this.lbl_beden.Name = "lbl_beden";
            this.lbl_beden.Size = new System.Drawing.Size(47, 16);
            this.lbl_beden.TabIndex = 3;
            this.lbl_beden.Text = "Beden";
            // 
            // btn_urunEkle
            // 
            this.btn_urunEkle.BackColor = System.Drawing.Color.Olive;
            this.btn_urunEkle.ForeColor = System.Drawing.Color.Blue;
            this.btn_urunEkle.Location = new System.Drawing.Point(114, 184);
            this.btn_urunEkle.Name = "btn_urunEkle";
            this.btn_urunEkle.Size = new System.Drawing.Size(108, 23);
            this.btn_urunEkle.TabIndex = 4;
            this.btn_urunEkle.Text = "Ürünü Ekle";
            this.btn_urunEkle.UseVisualStyleBackColor = false;
            this.btn_urunEkle.Click += new System.EventHandler(this.btn_urunEkle_Click);
            // 
            // cb_bedenGomlek
            // 
            this.cb_bedenGomlek.FormattingEnabled = true;
            this.cb_bedenGomlek.Items.AddRange(new object[] {
            "XS",
            "S",
            "M",
            "L",
            "XL"});
            this.cb_bedenGomlek.Location = new System.Drawing.Point(101, 80);
            this.cb_bedenGomlek.Name = "cb_bedenGomlek";
            this.cb_bedenGomlek.Size = new System.Drawing.Size(121, 24);
            this.cb_bedenGomlek.TabIndex = 5;
            // 
            // lbl_ayakNo
            // 
            this.lbl_ayakNo.AutoSize = true;
            this.lbl_ayakNo.Location = new System.Drawing.Point(6, 83);
            this.lbl_ayakNo.Name = "lbl_ayakNo";
            this.lbl_ayakNo.Size = new System.Drawing.Size(65, 16);
            this.lbl_ayakNo.TabIndex = 6;
            this.lbl_ayakNo.Text = "Ayak. No.";
            // 
            // cb_ayakNo
            // 
            this.cb_ayakNo.FormattingEnabled = true;
            this.cb_ayakNo.Items.AddRange(new object[] {
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44"});
            this.cb_ayakNo.Location = new System.Drawing.Point(101, 80);
            this.cb_ayakNo.Name = "cb_ayakNo";
            this.cb_ayakNo.Size = new System.Drawing.Size(121, 24);
            this.cb_ayakNo.TabIndex = 7;
            // 
            // cb_bedenPantolon
            // 
            this.cb_bedenPantolon.FormattingEnabled = true;
            this.cb_bedenPantolon.Items.AddRange(new object[] {
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35"});
            this.cb_bedenPantolon.Location = new System.Drawing.Point(101, 80);
            this.cb_bedenPantolon.Name = "cb_bedenPantolon";
            this.cb_bedenPantolon.Size = new System.Drawing.Size(121, 24);
            this.cb_bedenPantolon.TabIndex = 8;
            // 
            // lbl_boy
            // 
            this.lbl_boy.AutoSize = true;
            this.lbl_boy.Location = new System.Drawing.Point(6, 128);
            this.lbl_boy.Name = "lbl_boy";
            this.lbl_boy.Size = new System.Drawing.Size(38, 16);
            this.lbl_boy.TabIndex = 9;
            this.lbl_boy.Text = "Boyu";
            // 
            // cb_boy
            // 
            this.cb_boy.FormattingEnabled = true;
            this.cb_boy.Items.AddRange(new object[] {
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35"});
            this.cb_boy.Location = new System.Drawing.Point(101, 125);
            this.cb_boy.Name = "cb_boy";
            this.cb_boy.Size = new System.Drawing.Size(121, 24);
            this.cb_boy.TabIndex = 10;
            // 
            // gb_urunEklendi
            // 
            this.gb_urunEklendi.Controls.Add(this.btn_yeniUrunEkle);
            this.gb_urunEklendi.Controls.Add(this.lbl_boyEklendi);
            this.gb_urunEklendi.Controls.Add(this.lbl_bedenEklendi);
            this.gb_urunEklendi.Controls.Add(this.lbl_ayakNoEklendi);
            this.gb_urunEklendi.Controls.Add(this.lbl_urunEklendi);
            this.gb_urunEklendi.Controls.Add(this.lbl_boyuBilgisi);
            this.gb_urunEklendi.Controls.Add(this.lbl_ayakNoBilgisi);
            this.gb_urunEklendi.Controls.Add(this.lbl_bedenBilgisi);
            this.gb_urunEklendi.Controls.Add(this.label4);
            this.gb_urunEklendi.Controls.Add(this.label3);
            this.gb_urunEklendi.Location = new System.Drawing.Point(359, 61);
            this.gb_urunEklendi.Name = "gb_urunEklendi";
            this.gb_urunEklendi.Size = new System.Drawing.Size(254, 303);
            this.gb_urunEklendi.TabIndex = 11;
            this.gb_urunEklendi.TabStop = false;
            this.gb_urunEklendi.Text = "gb_eklendi";
            // 
            // lbl_boyEklendi
            // 
            this.lbl_boyEklendi.AutoSize = true;
            this.lbl_boyEklendi.Location = new System.Drawing.Point(53, 140);
            this.lbl_boyEklendi.Name = "lbl_boyEklendi";
            this.lbl_boyEklendi.Size = new System.Drawing.Size(51, 16);
            this.lbl_boyEklendi.TabIndex = 8;
            this.lbl_boyEklendi.Text = "label11";
            // 
            // lbl_bedenEklendi
            // 
            this.lbl_bedenEklendi.AutoSize = true;
            this.lbl_bedenEklendi.Location = new System.Drawing.Point(62, 105);
            this.lbl_bedenEklendi.Name = "lbl_bedenEklendi";
            this.lbl_bedenEklendi.Size = new System.Drawing.Size(51, 16);
            this.lbl_bedenEklendi.TabIndex = 7;
            this.lbl_bedenEklendi.Text = "label10";
            // 
            // lbl_ayakNoEklendi
            // 
            this.lbl_ayakNoEklendi.AutoSize = true;
            this.lbl_ayakNoEklendi.Location = new System.Drawing.Point(80, 105);
            this.lbl_ayakNoEklendi.Name = "lbl_ayakNoEklendi";
            this.lbl_ayakNoEklendi.Size = new System.Drawing.Size(44, 16);
            this.lbl_ayakNoEklendi.TabIndex = 6;
            this.lbl_ayakNoEklendi.Text = "label9";
            // 
            // lbl_urunEklendi
            // 
            this.lbl_urunEklendi.AutoSize = true;
            this.lbl_urunEklendi.Location = new System.Drawing.Point(50, 70);
            this.lbl_urunEklendi.Name = "lbl_urunEklendi";
            this.lbl_urunEklendi.Size = new System.Drawing.Size(44, 16);
            this.lbl_urunEklendi.TabIndex = 5;
            this.lbl_urunEklendi.Text = "label8";
            // 
            // lbl_boyuBilgisi
            // 
            this.lbl_boyuBilgisi.AutoSize = true;
            this.lbl_boyuBilgisi.Location = new System.Drawing.Point(6, 140);
            this.lbl_boyuBilgisi.Name = "lbl_boyuBilgisi";
            this.lbl_boyuBilgisi.Size = new System.Drawing.Size(41, 16);
            this.lbl_boyuBilgisi.TabIndex = 4;
            this.lbl_boyuBilgisi.Text = "Boyu:";
            // 
            // lbl_ayakNoBilgisi
            // 
            this.lbl_ayakNoBilgisi.AutoSize = true;
            this.lbl_ayakNoBilgisi.Location = new System.Drawing.Point(6, 105);
            this.lbl_ayakNoBilgisi.Name = "lbl_ayakNoBilgisi";
            this.lbl_ayakNoBilgisi.Size = new System.Drawing.Size(68, 16);
            this.lbl_ayakNoBilgisi.TabIndex = 3;
            this.lbl_ayakNoBilgisi.Text = "Ayak. No.:";
            // 
            // lbl_bedenBilgisi
            // 
            this.lbl_bedenBilgisi.AutoSize = true;
            this.lbl_bedenBilgisi.Location = new System.Drawing.Point(6, 105);
            this.lbl_bedenBilgisi.Name = "lbl_bedenBilgisi";
            this.lbl_bedenBilgisi.Size = new System.Drawing.Size(50, 16);
            this.lbl_bedenBilgisi.TabIndex = 2;
            this.lbl_bedenBilgisi.Text = "Beden:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ürün:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(6, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ürün Eklendi! Ürün Bilgisi:";
            // 
            // gb_urunEkle
            // 
            this.gb_urunEkle.Controls.Add(this.label2);
            this.gb_urunEkle.Controls.Add(this.cb_urun);
            this.gb_urunEkle.Controls.Add(this.btn_urunEkle);
            this.gb_urunEkle.Controls.Add(this.cb_boy);
            this.gb_urunEkle.Controls.Add(this.lbl_beden);
            this.gb_urunEkle.Controls.Add(this.lbl_boy);
            this.gb_urunEkle.Controls.Add(this.cb_bedenGomlek);
            this.gb_urunEkle.Controls.Add(this.cb_bedenPantolon);
            this.gb_urunEkle.Controls.Add(this.lbl_ayakNo);
            this.gb_urunEkle.Controls.Add(this.cb_ayakNo);
            this.gb_urunEkle.Location = new System.Drawing.Point(55, 61);
            this.gb_urunEkle.Name = "gb_urunEkle";
            this.gb_urunEkle.Size = new System.Drawing.Size(254, 303);
            this.gb_urunEkle.TabIndex = 12;
            this.gb_urunEkle.TabStop = false;
            this.gb_urunEkle.Text = "gb_ekle";
            // 
            // btn_yeniUrunEkle
            // 
            this.btn_yeniUrunEkle.BackColor = System.Drawing.Color.Olive;
            this.btn_yeniUrunEkle.ForeColor = System.Drawing.Color.Blue;
            this.btn_yeniUrunEkle.Location = new System.Drawing.Point(126, 214);
            this.btn_yeniUrunEkle.Name = "btn_yeniUrunEkle";
            this.btn_yeniUrunEkle.Size = new System.Drawing.Size(120, 23);
            this.btn_yeniUrunEkle.TabIndex = 9;
            this.btn_yeniUrunEkle.Text = "Yeni Ürün Ekle";
            this.btn_yeniUrunEkle.UseVisualStyleBackColor = false;
            this.btn_yeniUrunEkle.Click += new System.EventHandler(this.btn_yeniUrunEkle_Click);
            // 
            // Odev_2708v2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 647);
            this.Controls.Add(this.gb_urunEkle);
            this.Controls.Add(this.gb_urunEklendi);
            this.Controls.Add(this.label1);
            this.Name = "Odev_2708v2";
            this.Text = "Odev_2708v2";
            this.Load += new System.EventHandler(this.Odev_2708v2_Load);
            this.gb_urunEklendi.ResumeLayout(false);
            this.gb_urunEklendi.PerformLayout();
            this.gb_urunEkle.ResumeLayout(false);
            this.gb_urunEkle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_urun;
        private System.Windows.Forms.Label lbl_beden;
        private System.Windows.Forms.Button btn_urunEkle;
        private System.Windows.Forms.ComboBox cb_bedenGomlek;
        private System.Windows.Forms.Label lbl_ayakNo;
        private System.Windows.Forms.ComboBox cb_ayakNo;
        private System.Windows.Forms.ComboBox cb_bedenPantolon;
        private System.Windows.Forms.Label lbl_boy;
        private System.Windows.Forms.ComboBox cb_boy;
        private System.Windows.Forms.GroupBox gb_urunEklendi;
        private System.Windows.Forms.Label lbl_boyEklendi;
        private System.Windows.Forms.Label lbl_bedenEklendi;
        private System.Windows.Forms.Label lbl_ayakNoEklendi;
        private System.Windows.Forms.Label lbl_urunEklendi;
        private System.Windows.Forms.Label lbl_boyuBilgisi;
        private System.Windows.Forms.Label lbl_ayakNoBilgisi;
        private System.Windows.Forms.Label lbl_bedenBilgisi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gb_urunEkle;
        private System.Windows.Forms.Button btn_yeniUrunEkle;
    }
}