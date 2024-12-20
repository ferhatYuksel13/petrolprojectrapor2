namespace PetrolProject
{
    partial class Form3
    {
        /// <summary>
        /// Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Temizleme işlemi.
        /// </summary>
        /// <param name="disposing">Yönetilen kaynakları serbest bırakmak için true, aksi takdirde false.</param>
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
        /// Bu metodu tasarımcı tarafından kullanılan kodu içerir.
        /// Form tasarımını değiştirmek için bu metodu kullanın.
        /// Kod düzenleyicisini kullanarak bu metodu değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewSatislar = new System.Windows.Forms.DataGridView();
            this.comboBoxSube = new System.Windows.Forms.ComboBox();
            this.rbtnNakit = new System.Windows.Forms.RadioButton();
            this.rbtnKrediKartı = new System.Windows.Forms.RadioButton();
            this.btnOdemeAl = new System.Windows.Forms.Button();
            this.labelSube = new System.Windows.Forms.Label();
            this.labelOdemeTuru = new System.Windows.Forms.Label();
            this.petrolProjectDataSet = new PetrolProject.PetrolProjectDataSet();
            this.satislarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.satislarTableAdapter = new PetrolProject.PetrolProjectDataSetTableAdapters.SatislarTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plakaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yakitturuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yakitmiktariDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odenecektutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.odendiDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.odemeturuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSatislar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satislarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSatislar
            // 
            this.dataGridViewSatislar.AllowUserToAddRows = false;
            this.dataGridViewSatislar.AllowUserToDeleteRows = false;
            this.dataGridViewSatislar.AutoGenerateColumns = false;
            this.dataGridViewSatislar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSatislar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.subeidDataGridViewTextBoxColumn,
            this.plakaDataGridViewTextBoxColumn,
            this.yakitturuDataGridViewTextBoxColumn,
            this.yakitmiktariDataGridViewTextBoxColumn,
            this.odenecektutarDataGridViewTextBoxColumn,
            this.odendiDataGridViewCheckBoxColumn,
            this.odemeturuDataGridViewTextBoxColumn});
            this.dataGridViewSatislar.DataSource = this.satislarBindingSource;
            this.dataGridViewSatislar.Location = new System.Drawing.Point(12, 64);
            this.dataGridViewSatislar.Name = "dataGridViewSatislar";
            this.dataGridViewSatislar.ReadOnly = true;
            this.dataGridViewSatislar.RowHeadersWidth = 51;
            this.dataGridViewSatislar.Size = new System.Drawing.Size(1053, 200);
            this.dataGridViewSatislar.TabIndex = 0;
            // 
            // comboBoxSube
            // 
            this.comboBoxSube.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSube.FormattingEnabled = true;
            this.comboBoxSube.Location = new System.Drawing.Point(451, 24);
            this.comboBoxSube.Name = "comboBoxSube";
            this.comboBoxSube.Size = new System.Drawing.Size(200, 24);
            this.comboBoxSube.TabIndex = 1;
            this.comboBoxSube.SelectedIndexChanged += new System.EventHandler(this.comboBoxSube_SelectedIndexChanged);
            // 
            // rbtnNakit
            // 
            this.rbtnNakit.AutoSize = true;
            this.rbtnNakit.Location = new System.Drawing.Point(451, 287);
            this.rbtnNakit.Name = "rbtnNakit";
            this.rbtnNakit.Size = new System.Drawing.Size(59, 20);
            this.rbtnNakit.TabIndex = 2;
            this.rbtnNakit.TabStop = true;
            this.rbtnNakit.Text = "Nakit";
            this.rbtnNakit.UseVisualStyleBackColor = true;
            // 
            // rbtnKrediKartı
            // 
            this.rbtnKrediKartı.AutoSize = true;
            this.rbtnKrediKartı.Location = new System.Drawing.Point(563, 287);
            this.rbtnKrediKartı.Name = "rbtnKrediKartı";
            this.rbtnKrediKartı.Size = new System.Drawing.Size(88, 20);
            this.rbtnKrediKartı.TabIndex = 3;
            this.rbtnKrediKartı.TabStop = true;
            this.rbtnKrediKartı.Text = "Kredi Kartı";
            this.rbtnKrediKartı.UseVisualStyleBackColor = true;
            // 
            // btnOdemeAl
            // 
            this.btnOdemeAl.Location = new System.Drawing.Point(451, 337);
            this.btnOdemeAl.Name = "btnOdemeAl";
            this.btnOdemeAl.Size = new System.Drawing.Size(200, 30);
            this.btnOdemeAl.TabIndex = 4;
            this.btnOdemeAl.Text = "Ödeme Al";
            this.btnOdemeAl.UseVisualStyleBackColor = true;
            this.btnOdemeAl.Click += new System.EventHandler(this.btnOdemeAl_Click);
            // 
            // labelSube
            // 
            this.labelSube.AutoSize = true;
            this.labelSube.Location = new System.Drawing.Point(316, 32);
            this.labelSube.Name = "labelSube";
            this.labelSube.Size = new System.Drawing.Size(88, 16);
            this.labelSube.TabIndex = 5;
            this.labelSube.Text = "Şube Seçiniz:";
            // 
            // labelOdemeTuru
            // 
            this.labelOdemeTuru.AutoSize = true;
            this.labelOdemeTuru.Location = new System.Drawing.Point(319, 291);
            this.labelOdemeTuru.Name = "labelOdemeTuru";
            this.labelOdemeTuru.Size = new System.Drawing.Size(85, 16);
            this.labelOdemeTuru.TabIndex = 6;
            this.labelOdemeTuru.Text = "Ödeme Türü:";
            // 
            // petrolProjectDataSet
            // 
            this.petrolProjectDataSet.DataSetName = "PetrolProjectDataSet";
            this.petrolProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // satislarBindingSource
            // 
            this.satislarBindingSource.DataMember = "Satislar";
            this.satislarBindingSource.DataSource = this.petrolProjectDataSet;
            // 
            // satislarTableAdapter
            // 
            this.satislarTableAdapter.ClearBeforeFill = true;
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
            // subeidDataGridViewTextBoxColumn
            // 
            this.subeidDataGridViewTextBoxColumn.DataPropertyName = "sube_id";
            this.subeidDataGridViewTextBoxColumn.HeaderText = "sube_id";
            this.subeidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subeidDataGridViewTextBoxColumn.Name = "subeidDataGridViewTextBoxColumn";
            this.subeidDataGridViewTextBoxColumn.ReadOnly = true;
            this.subeidDataGridViewTextBoxColumn.Width = 125;
            // 
            // plakaDataGridViewTextBoxColumn
            // 
            this.plakaDataGridViewTextBoxColumn.DataPropertyName = "plaka";
            this.plakaDataGridViewTextBoxColumn.HeaderText = "plaka";
            this.plakaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.plakaDataGridViewTextBoxColumn.Name = "plakaDataGridViewTextBoxColumn";
            this.plakaDataGridViewTextBoxColumn.ReadOnly = true;
            this.plakaDataGridViewTextBoxColumn.Width = 125;
            // 
            // yakitturuDataGridViewTextBoxColumn
            // 
            this.yakitturuDataGridViewTextBoxColumn.DataPropertyName = "yakit_turu";
            this.yakitturuDataGridViewTextBoxColumn.HeaderText = "yakit_turu";
            this.yakitturuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yakitturuDataGridViewTextBoxColumn.Name = "yakitturuDataGridViewTextBoxColumn";
            this.yakitturuDataGridViewTextBoxColumn.ReadOnly = true;
            this.yakitturuDataGridViewTextBoxColumn.Width = 125;
            // 
            // yakitmiktariDataGridViewTextBoxColumn
            // 
            this.yakitmiktariDataGridViewTextBoxColumn.DataPropertyName = "yakit_miktari";
            this.yakitmiktariDataGridViewTextBoxColumn.HeaderText = "yakit_miktari";
            this.yakitmiktariDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yakitmiktariDataGridViewTextBoxColumn.Name = "yakitmiktariDataGridViewTextBoxColumn";
            this.yakitmiktariDataGridViewTextBoxColumn.ReadOnly = true;
            this.yakitmiktariDataGridViewTextBoxColumn.Width = 125;
            // 
            // odenecektutarDataGridViewTextBoxColumn
            // 
            this.odenecektutarDataGridViewTextBoxColumn.DataPropertyName = "odenecek_tutar";
            this.odenecektutarDataGridViewTextBoxColumn.HeaderText = "odenecek_tutar";
            this.odenecektutarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odenecektutarDataGridViewTextBoxColumn.Name = "odenecektutarDataGridViewTextBoxColumn";
            this.odenecektutarDataGridViewTextBoxColumn.ReadOnly = true;
            this.odenecektutarDataGridViewTextBoxColumn.Width = 125;
            // 
            // odendiDataGridViewCheckBoxColumn
            // 
            this.odendiDataGridViewCheckBoxColumn.DataPropertyName = "odendi";
            this.odendiDataGridViewCheckBoxColumn.HeaderText = "odendi";
            this.odendiDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.odendiDataGridViewCheckBoxColumn.Name = "odendiDataGridViewCheckBoxColumn";
            this.odendiDataGridViewCheckBoxColumn.ReadOnly = true;
            this.odendiDataGridViewCheckBoxColumn.Width = 125;
            // 
            // odemeturuDataGridViewTextBoxColumn
            // 
            this.odemeturuDataGridViewTextBoxColumn.DataPropertyName = "odeme_turu";
            this.odemeturuDataGridViewTextBoxColumn.HeaderText = "odeme_turu";
            this.odemeturuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.odemeturuDataGridViewTextBoxColumn.Name = "odemeturuDataGridViewTextBoxColumn";
            this.odemeturuDataGridViewTextBoxColumn.ReadOnly = true;
            this.odemeturuDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form3
            // 
            this.ClientSize = new System.Drawing.Size(1084, 450);
            this.Controls.Add(this.labelOdemeTuru);
            this.Controls.Add(this.labelSube);
            this.Controls.Add(this.btnOdemeAl);
            this.Controls.Add(this.rbtnKrediKartı);
            this.Controls.Add(this.rbtnNakit);
            this.Controls.Add(this.comboBoxSube);
            this.Controls.Add(this.dataGridViewSatislar);
            this.Name = "Form3";
            this.Text = "Satış Ödeme";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSatislar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satislarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSatislar;
        private System.Windows.Forms.ComboBox comboBoxSube;
        private System.Windows.Forms.RadioButton rbtnNakit;
        private System.Windows.Forms.RadioButton rbtnKrediKartı;
        private System.Windows.Forms.Button btnOdemeAl;
        private System.Windows.Forms.Label labelSube;
        private System.Windows.Forms.Label labelOdemeTuru;
        private PetrolProjectDataSet petrolProjectDataSet;
        private System.Windows.Forms.BindingSource satislarBindingSource;
        private PetrolProjectDataSetTableAdapters.SatislarTableAdapter satislarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plakaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yakitturuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yakitmiktariDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odenecektutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn odendiDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn odemeturuDataGridViewTextBoxColumn;
    }
}
