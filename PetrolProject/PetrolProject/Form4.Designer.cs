namespace PetrolProject
{
    partial class Form4
    {
        /// <summary>
        /// Gerekli tasarım bileşenlerini içerir.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary
        /// Kaynakları temizler.
        /// </summary>
        /// <param name="disposing">Yönetilen kaynakları serbest bırakmak için true; aksi takdirde false.</param>
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
        /// Tasarım bileşenlerini buraya ekler.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxSube = new System.Windows.Forms.ComboBox();
            this.comboBoxYakitTuru = new System.Windows.Forms.ComboBox();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.txtYakitMiktar = new System.Windows.Forms.TextBox();
            this.btnSatisYap = new System.Windows.Forms.Button();
            this.lblBenzinFiyati = new System.Windows.Forms.Label();
            this.lblDizelFiyati = new System.Windows.Forms.Label();
            this.lblElektrikFiyati = new System.Windows.Forms.Label();
            this.lblLpgFiyati = new System.Windows.Forms.Label();
            this.lblBenzinMiktar = new System.Windows.Forms.Label();
            this.lblDizelMiktar = new System.Windows.Forms.Label();
            this.lblElektrikMiktar = new System.Windows.Forms.Label();
            this.lblLpgMiktar = new System.Windows.Forms.Label();
            this.btnYakitEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxSube
            // 
            this.comboBoxSube.FormattingEnabled = true;
            this.comboBoxSube.Location = new System.Drawing.Point(36, 34);
            this.comboBoxSube.Name = "comboBoxSube";
            this.comboBoxSube.Size = new System.Drawing.Size(200, 24);
            this.comboBoxSube.TabIndex = 0;
            this.comboBoxSube.SelectedIndexChanged += new System.EventHandler(this.comboBoxSube_SelectedIndexChanged);
            // 
            // comboBoxYakitTuru
            // 
            this.comboBoxYakitTuru.FormattingEnabled = true;
            this.comboBoxYakitTuru.Items.AddRange(new object[] {
            "Benzin",
            "Dizel",
            "Elektrik",
            "LPG"});
            this.comboBoxYakitTuru.Location = new System.Drawing.Point(36, 92);
            this.comboBoxYakitTuru.Name = "comboBoxYakitTuru";
            this.comboBoxYakitTuru.Size = new System.Drawing.Size(200, 24);
            this.comboBoxYakitTuru.TabIndex = 1;
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(36, 154);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(200, 22);
            this.txtPlaka.TabIndex = 2;
            // 
            // txtYakitMiktar
            // 
            this.txtYakitMiktar.Location = new System.Drawing.Point(36, 216);
            this.txtYakitMiktar.Name = "txtYakitMiktar";
            this.txtYakitMiktar.Size = new System.Drawing.Size(200, 22);
            this.txtYakitMiktar.TabIndex = 3;
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.Location = new System.Drawing.Point(36, 249);
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(200, 23);
            this.btnSatisYap.TabIndex = 4;
            this.btnSatisYap.Text = "Satışı Yap";
            this.btnSatisYap.UseVisualStyleBackColor = true;
            this.btnSatisYap.Click += new System.EventHandler(this.btnSatisYap_Click);
            // 
            // lblBenzinFiyati
            // 
            this.lblBenzinFiyati.AutoSize = true;
            this.lblBenzinFiyati.Location = new System.Drawing.Point(338, 20);
            this.lblBenzinFiyati.Name = "lblBenzinFiyati";
            this.lblBenzinFiyati.Size = new System.Drawing.Size(88, 16);
            this.lblBenzinFiyati.TabIndex = 5;
            this.lblBenzinFiyati.Text = "Benzin Fiyatı: ";
            // 
            // lblDizelFiyati
            // 
            this.lblDizelFiyati.AutoSize = true;
            this.lblDizelFiyati.Location = new System.Drawing.Point(338, 50);
            this.lblDizelFiyati.Name = "lblDizelFiyati";
            this.lblDizelFiyati.Size = new System.Drawing.Size(78, 16);
            this.lblDizelFiyati.TabIndex = 6;
            this.lblDizelFiyati.Text = "Dizel Fiyatı: ";
            // 
            // lblElektrikFiyati
            // 
            this.lblElektrikFiyati.AutoSize = true;
            this.lblElektrikFiyati.Location = new System.Drawing.Point(338, 80);
            this.lblElektrikFiyati.Name = "lblElektrikFiyati";
            this.lblElektrikFiyati.Size = new System.Drawing.Size(92, 16);
            this.lblElektrikFiyati.TabIndex = 7;
            this.lblElektrikFiyati.Text = "Elektrik Fiyatı: ";
            // 
            // lblLpgFiyati
            // 
            this.lblLpgFiyati.AutoSize = true;
            this.lblLpgFiyati.Location = new System.Drawing.Point(338, 110);
            this.lblLpgFiyati.Name = "lblLpgFiyati";
            this.lblLpgFiyati.Size = new System.Drawing.Size(74, 16);
            this.lblLpgFiyati.TabIndex = 8;
            this.lblLpgFiyati.Text = "LPG Fiyatı: ";
            // 
            // lblBenzinMiktar
            // 
            this.lblBenzinMiktar.AutoSize = true;
            this.lblBenzinMiktar.Location = new System.Drawing.Point(343, 200);
            this.lblBenzinMiktar.Name = "lblBenzinMiktar";
            this.lblBenzinMiktar.Size = new System.Drawing.Size(83, 16);
            this.lblBenzinMiktar.TabIndex = 9;
            this.lblBenzinMiktar.Text = "Benzin Stok: ";
            // 
            // lblDizelMiktar
            // 
            this.lblDizelMiktar.AutoSize = true;
            this.lblDizelMiktar.Location = new System.Drawing.Point(343, 230);
            this.lblDizelMiktar.Name = "lblDizelMiktar";
            this.lblDizelMiktar.Size = new System.Drawing.Size(73, 16);
            this.lblDizelMiktar.TabIndex = 10;
            this.lblDizelMiktar.Text = "Dizel Stok: ";
            // 
            // lblElektrikMiktar
            // 
            this.lblElektrikMiktar.AutoSize = true;
            this.lblElektrikMiktar.Location = new System.Drawing.Point(343, 260);
            this.lblElektrikMiktar.Name = "lblElektrikMiktar";
            this.lblElektrikMiktar.Size = new System.Drawing.Size(87, 16);
            this.lblElektrikMiktar.TabIndex = 11;
            this.lblElektrikMiktar.Text = "Elektrik Stok: ";
            // 
            // lblLpgMiktar
            // 
            this.lblLpgMiktar.AutoSize = true;
            this.lblLpgMiktar.Location = new System.Drawing.Point(343, 290);
            this.lblLpgMiktar.Name = "lblLpgMiktar";
            this.lblLpgMiktar.Size = new System.Drawing.Size(69, 16);
            this.lblLpgMiktar.TabIndex = 12;
            this.lblLpgMiktar.Text = "LPG Stok: ";
            // 
            // btnYakitEkle
            // 
            this.btnYakitEkle.Location = new System.Drawing.Point(36, 283);
            this.btnYakitEkle.Name = "btnYakitEkle";
            this.btnYakitEkle.Size = new System.Drawing.Size(200, 23);
            this.btnYakitEkle.TabIndex = 13;
            this.btnYakitEkle.Text = "Yakıt Ekleme İsteği";
            this.btnYakitEkle.UseVisualStyleBackColor = true;
            this.btnYakitEkle.Click += new System.EventHandler(this.btnYakitEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Şube ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Yakıt Türü";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Plaka";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Yakıt Miktarı";
            // 
            // Form4
            // 
            this.ClientSize = new System.Drawing.Size(556, 344);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYakitEkle);
            this.Controls.Add(this.lblLpgMiktar);
            this.Controls.Add(this.lblElektrikMiktar);
            this.Controls.Add(this.lblDizelMiktar);
            this.Controls.Add(this.lblBenzinMiktar);
            this.Controls.Add(this.lblLpgFiyati);
            this.Controls.Add(this.lblElektrikFiyati);
            this.Controls.Add(this.lblDizelFiyati);
            this.Controls.Add(this.lblBenzinFiyati);
            this.Controls.Add(this.btnSatisYap);
            this.Controls.Add(this.txtYakitMiktar);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.comboBoxYakitTuru);
            this.Controls.Add(this.comboBoxSube);
            this.Name = "Form4";
            this.Text = "Petrol Satışı İşlem Ekranı";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSube;
        private System.Windows.Forms.ComboBox comboBoxYakitTuru;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.TextBox txtYakitMiktar;
        private System.Windows.Forms.Button btnSatisYap;
        private System.Windows.Forms.Label lblBenzinFiyati;
        private System.Windows.Forms.Label lblDizelFiyati;
        private System.Windows.Forms.Label lblElektrikFiyati;
        private System.Windows.Forms.Label lblLpgFiyati;
        private System.Windows.Forms.Label lblBenzinMiktar;
        private System.Windows.Forms.Label lblDizelMiktar;
        private System.Windows.Forms.Label lblElektrikMiktar;
        private System.Windows.Forms.Label lblLpgMiktar;
        private System.Windows.Forms.Button btnYakitEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
