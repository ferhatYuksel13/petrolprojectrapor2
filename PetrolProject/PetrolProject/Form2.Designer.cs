namespace PetrolProject
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petrolProjectDataSet1 = new PetrolProject.PetrolProjectDataSet1();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.cmbPozisyon = new System.Windows.Forms.ComboBox();
            this.cmbSube = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subeidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yakitturuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eklenecekmiktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yakitEklemeleriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petrolProjectDataSet2 = new PetrolProject.PetrolProjectDataSet2();
            this.btnKayitVer = new System.Windows.Forms.Button();
            this.btnYakitVer = new System.Windows.Forms.Button();
            this.lblAnaRezerv = new System.Windows.Forms.Label();
            this.usersTableAdapter = new PetrolProject.PetrolProjectDataSet1TableAdapters.usersTableAdapter();
            this.yakitEklemeleriTableAdapter = new PetrolProject.PetrolProjectDataSet2TableAdapters.YakitEklemeleriTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolProjectDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakitEklemeleriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolProjectDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeight = 29;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.subeidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(37, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(678, 200);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "full_name";
            this.fullnameDataGridViewTextBoxColumn.HeaderText = "full_name";
            this.fullnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            this.fullnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "position";
            this.positionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.Width = 125;
            // 
            // subeidDataGridViewTextBoxColumn
            // 
            this.subeidDataGridViewTextBoxColumn.DataPropertyName = "sube_id";
            this.subeidDataGridViewTextBoxColumn.HeaderText = "sube_id";
            this.subeidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subeidDataGridViewTextBoxColumn.Name = "subeidDataGridViewTextBoxColumn";
            this.subeidDataGridViewTextBoxColumn.Width = 125;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.petrolProjectDataSet1;
            // 
            // petrolProjectDataSet1
            // 
            this.petrolProjectDataSet1.DataSetName = "PetrolProjectDataSet1";
            this.petrolProjectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.ForeColor = System.Drawing.Color.Gray;
            this.txtAdSoyad.Location = new System.Drawing.Point(75, 230);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtAdSoyad.TabIndex = 13;
            this.txtAdSoyad.Text = "Ad Soyad";
            this.txtAdSoyad.Enter += new System.EventHandler(this.txtAdSoyad_Enter);
            this.txtAdSoyad.Leave += new System.EventHandler(this.txtAdSoyad_Leave);
            // 
            // txtSifre
            // 
            this.txtSifre.ForeColor = System.Drawing.Color.Gray;
            this.txtSifre.Location = new System.Drawing.Point(215, 230);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(100, 22);
            this.txtSifre.TabIndex = 12;
            this.txtSifre.Text = "Şifre";
            this.txtSifre.Enter += new System.EventHandler(this.txtSifre_Enter);
            this.txtSifre.Leave += new System.EventHandler(this.txtSifre_Leave);
            // 
            // cmbPozisyon
            // 
            this.cmbPozisyon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPozisyon.Items.AddRange(new object[] {
            "Pompacı",
            "Personel"});
            this.cmbPozisyon.Location = new System.Drawing.Point(350, 230);
            this.cmbPozisyon.Name = "cmbPozisyon";
            this.cmbPozisyon.Size = new System.Drawing.Size(150, 24);
            this.cmbPozisyon.TabIndex = 3;
            // 
            // cmbSube
            // 
            this.cmbSube.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSube.Items.AddRange(new object[] {
            "Şube 1",
            "Şube 2",
            "Şube 3"});
            this.cmbSube.Location = new System.Drawing.Point(520, 230);
            this.cmbSube.Name = "cmbSube";
            this.cmbSube.Size = new System.Drawing.Size(150, 24);
            this.cmbSube.TabIndex = 4;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(162, 270);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 30);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(329, 270);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 30);
            this.btnSil.TabIndex = 6;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(484, 270);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 30);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeight = 29;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.subeidDataGridViewTextBoxColumn1,
            this.yakitturuDataGridViewTextBoxColumn,
            this.eklenecekmiktarDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.yakitEklemeleriBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(89, 320);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(554, 200);
            this.dataGridView2.TabIndex = 8;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // subeidDataGridViewTextBoxColumn1
            // 
            this.subeidDataGridViewTextBoxColumn1.DataPropertyName = "sube_id";
            this.subeidDataGridViewTextBoxColumn1.HeaderText = "sube_id";
            this.subeidDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.subeidDataGridViewTextBoxColumn1.Name = "subeidDataGridViewTextBoxColumn1";
            this.subeidDataGridViewTextBoxColumn1.Width = 125;
            // 
            // yakitturuDataGridViewTextBoxColumn
            // 
            this.yakitturuDataGridViewTextBoxColumn.DataPropertyName = "yakit_turu";
            this.yakitturuDataGridViewTextBoxColumn.HeaderText = "yakit_turu";
            this.yakitturuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yakitturuDataGridViewTextBoxColumn.Name = "yakitturuDataGridViewTextBoxColumn";
            this.yakitturuDataGridViewTextBoxColumn.Width = 125;
            // 
            // eklenecekmiktarDataGridViewTextBoxColumn
            // 
            this.eklenecekmiktarDataGridViewTextBoxColumn.DataPropertyName = "eklenecek_miktar";
            this.eklenecekmiktarDataGridViewTextBoxColumn.HeaderText = "eklenecek_miktar";
            this.eklenecekmiktarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.eklenecekmiktarDataGridViewTextBoxColumn.Name = "eklenecekmiktarDataGridViewTextBoxColumn";
            this.eklenecekmiktarDataGridViewTextBoxColumn.Width = 125;
            // 
            // yakitEklemeleriBindingSource
            // 
            this.yakitEklemeleriBindingSource.DataMember = "YakitEklemeleri";
            this.yakitEklemeleriBindingSource.DataSource = this.petrolProjectDataSet2;
            // 
            // petrolProjectDataSet2
            // 
            this.petrolProjectDataSet2.DataSetName = "PetrolProjectDataSet2";
            this.petrolProjectDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnKayitVer
            // 
            this.btnKayitVer.Location = new System.Drawing.Point(231, 540);
            this.btnKayitVer.Name = "btnKayitVer";
            this.btnKayitVer.Size = new System.Drawing.Size(105, 30);
            this.btnKayitVer.TabIndex = 9;
            this.btnKayitVer.Text = "Yakıt Reddet";
            this.btnKayitVer.UseVisualStyleBackColor = true;
            this.btnKayitVer.Click += new System.EventHandler(this.btnYakitReddet_Click);
            // 
            // btnYakitVer
            // 
            this.btnYakitVer.Location = new System.Drawing.Point(369, 540);
            this.btnYakitVer.Name = "btnYakitVer";
            this.btnYakitVer.Size = new System.Drawing.Size(105, 30);
            this.btnYakitVer.TabIndex = 10;
            this.btnYakitVer.Text = "Yakıt Ver";
            this.btnYakitVer.UseVisualStyleBackColor = true;
            this.btnYakitVer.Click += new System.EventHandler(this.btnYakitVer_Click);
            // 
            // lblAnaRezerv
            // 
            this.lblAnaRezerv.AutoSize = true;
            this.lblAnaRezerv.Location = new System.Drawing.Point(176, 586);
            this.lblAnaRezerv.Name = "lblAnaRezerv";
            this.lblAnaRezerv.Size = new System.Drawing.Size(372, 16);
            this.lblAnaRezerv.TabIndex = 11;
            this.lblAnaRezerv.Text = "Benzin: 10000L | Elektrik: 10000W | Dizel: 10000L | LPG: 10000L";
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // yakitEklemeleriTableAdapter
            // 
            this.yakitEklemeleriTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(766, 631);
            this.Controls.Add(this.lblAnaRezerv);
            this.Controls.Add(this.btnYakitVer);
            this.Controls.Add(this.btnKayitVer);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cmbSube);
            this.Controls.Add(this.cmbPozisyon);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Yönetici Paneli";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolProjectDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakitEklemeleriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolProjectDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.ComboBox cmbPozisyon;
        private System.Windows.Forms.ComboBox cmbSube;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnKayitVer;
        private System.Windows.Forms.Button btnYakitVer;
        private System.Windows.Forms.Label lblAnaRezerv;
        private PetrolProject.PetrolProjectDataSet1 petrolProjectDataSet1;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private PetrolProject.PetrolProjectDataSet1TableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subeidDataGridViewTextBoxColumn;
        private PetrolProjectDataSet2 petrolProjectDataSet2;
        private System.Windows.Forms.BindingSource yakitEklemeleriBindingSource;
        private PetrolProjectDataSet2TableAdapters.YakitEklemeleriTableAdapter yakitEklemeleriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn subeidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn yakitturuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eklenecekmiktarDataGridViewTextBoxColumn;
    }
}
