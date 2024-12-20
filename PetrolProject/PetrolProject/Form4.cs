using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PetrolProject
{
    public partial class Form4 : Form
    {
        private string connectionString = "Data Source=LEGEND;Initial Catalog=PetrolProject;Integrated Security=True;Encrypt=False";
        private int pompaciSubeId;
        public Form4(int kullaniciSubeId) // Kullanıcının şube ID'si parametre olarak alınır
        {
            InitializeComponent();
            pompaciSubeId = kullaniciSubeId; // Kullanıcı şube ID'si saklanır
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Load sırasında olay tetiklenmesin
            comboBoxSube.SelectedIndexChanged -= comboBoxSube_SelectedIndexChanged;
            LoadSubeler();
            comboBoxSube.SelectedIndexChanged += comboBoxSube_SelectedIndexChanged;
        }

        private void LoadSubeler()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Subeler", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                comboBoxSube.DataSource = dt;
                comboBoxSube.DisplayMember = "sube_adi";
                comboBoxSube.ValueMember = "id";

                // Kullanıcının şubesini başlangıçta seçili hale getiriyoruz
                comboBoxSube.SelectedValue = pompaciSubeId;
            }
        }

        private void LoadYakitFiyatlari(int subeId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM YakitFiyatlari WHERE sube_id = @subeId", conn);
                da.SelectCommand.Parameters.AddWithValue("@subeId", subeId);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    lblBenzinFiyati.Text = "Benzin: " + dt.Rows[0]["benzin_fiyati"].ToString();
                    lblDizelFiyati.Text = "Dizel: " + dt.Rows[0]["dizel_fiyati"].ToString();
                    lblElektrikFiyati.Text = "Elektrik: " + dt.Rows[0]["elektrik_fiyati"].ToString();
                    lblLpgFiyati.Text = "LPG: " + dt.Rows[0]["lpg_fiyati"].ToString();
                }
                else
                {
                    MessageBox.Show("Yakıt fiyatları bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void LoadYakitStok(int subeId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM YakitStok WHERE sube_id = @subeId", conn);
                da.SelectCommand.Parameters.AddWithValue("@subeId", subeId);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    lblBenzinMiktar.Text = "Benzin Stok: " + dt.Rows[0]["benzin_miktari"].ToString() + " L";
                    lblDizelMiktar.Text = "Dizel Stok: " + dt.Rows[0]["dizel_miktari"].ToString() + " L";
                    lblElektrikMiktar.Text = "Elektrik Stok: " + dt.Rows[0]["elektrik_miktari"].ToString() + " KWh";
                    lblLpgMiktar.Text = "LPG Stok: " + dt.Rows[0]["lpg_miktari"].ToString() + " L";
                }
                else
                {
                    MessageBox.Show("Yakıt stokları bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void comboBoxSube_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSube.SelectedValue != null)
            {
                // Güvenli dönüşüm
                if (int.TryParse(comboBoxSube.SelectedValue.ToString(), out int subeId))
                {
                    LoadYakitFiyatlari(subeId);
                    LoadYakitStok(subeId);
                }
                else
                {
                    MessageBox.Show("Geçersiz şube değeri!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            // Seçilen şube kontrolü
            if (comboBoxSube.SelectedValue != null && int.TryParse(comboBoxSube.SelectedValue.ToString(), out int secilenSubeId))
            {
                if (secilenSubeId != pompaciSubeId)
                {
                    MessageBox.Show("Yanlış şube seçtiniz! Kendi şubenizde işlem yapabilirsiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // İşlemler buradan devam eder...
                if (string.IsNullOrEmpty(txtPlaka.Text) || string.IsNullOrEmpty(txtYakitMiktar.Text))
                {
                    MessageBox.Show("Lütfen araç plakası ve yakıt miktarını girin.");
                    return;
                }

                string plaka = txtPlaka.Text;
                string yakitTuru = comboBoxYakitTuru.SelectedItem.ToString();
                double yakitMiktari = Convert.ToDouble(txtYakitMiktar.Text);
                double odenecekTutar = HesaplaOdenecekTutar(yakitTuru, yakitMiktari);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        // Satış ekleme
                        SqlCommand cmdSatis = new SqlCommand("INSERT INTO Satislar (sube_id, plaka, yakit_turu, yakit_miktari, odenecek_tutar) VALUES (@subeId, @plaka, @yakitTuru, @yakitMiktari, @odenecekTutar)", conn, transaction);
                        cmdSatis.Parameters.AddWithValue("@subeId", secilenSubeId);
                        cmdSatis.Parameters.AddWithValue("@plaka", plaka);
                        cmdSatis.Parameters.AddWithValue("@yakitTuru", yakitTuru);
                        cmdSatis.Parameters.AddWithValue("@yakitMiktari", yakitMiktari);
                        cmdSatis.Parameters.AddWithValue("@odenecekTutar", odenecekTutar);
                        cmdSatis.ExecuteNonQuery();

                        // Yakıt stok güncelleme
                        SqlCommand cmdGuncelleStok = new SqlCommand("UPDATE YakitStok SET " +
                                                                    "benzin_miktari = CASE WHEN @yakitTuru = 'Benzin' THEN benzin_miktari - @yakitMiktari ELSE benzin_miktari END, " +
                                                                    "dizel_miktari = CASE WHEN @yakitTuru = 'Dizel' THEN dizel_miktari - @yakitMiktari ELSE dizel_miktari END, " +
                                                                    "elektrik_miktari = CASE WHEN @yakitTuru = 'Elektrik' THEN elektrik_miktari - @yakitMiktari ELSE elektrik_miktari END, " +
                                                                    "lpg_miktari = CASE WHEN @yakitTuru = 'LPG' THEN lpg_miktari - @yakitMiktari ELSE lpg_miktari END " +
                                                                    "WHERE sube_id = @subeId", conn, transaction);
                        cmdGuncelleStok.Parameters.AddWithValue("@subeId", secilenSubeId);
                        cmdGuncelleStok.Parameters.AddWithValue("@yakitTuru", yakitTuru);
                        cmdGuncelleStok.Parameters.AddWithValue("@yakitMiktari", yakitMiktari);

                        cmdGuncelleStok.ExecuteNonQuery();

                        // Değişikliklerin veritabanına kaydedilmesi
                        transaction.Commit();

                        MessageBox.Show("Satış başarılı. Ödeme tutarı: " + odenecekTutar + " TL.");
                    }
                    catch (Exception ex)
                    {
                        // Bir hata oluşursa, işlemi geri al
                        transaction.Rollback();
                        MessageBox.Show("Hata oluştu: " + ex.Message);
                    }
                }

                MessageBox.Show("Fiş: \nŞube: " + comboBoxSube.Text + "\nPlaka: " + plaka + "\nYakıt Türü: " + yakitTuru + "\nYakıt Miktarı: " + yakitMiktari + " L\nÖdenecek Tutar: " + odenecekTutar + " TL\nTekrar bekleriz!");
                txtPlaka.Clear();
                txtYakitMiktar.Clear();
            }
            else
            {
                MessageBox.Show("Geçersiz şube seçimi!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private double HesaplaOdenecekTutar(string yakitTuru, double yakitMiktari)
        {
            double fiyat = 0;

            try
            {
                if (yakitTuru == "Benzin" && !string.IsNullOrWhiteSpace(lblBenzinFiyati.Text))
                    fiyat = Convert.ToDouble(lblBenzinFiyati.Text.Split(':')[1].Trim());
                else if (yakitTuru == "Dizel" && !string.IsNullOrWhiteSpace(lblDizelFiyati.Text))
                    fiyat = Convert.ToDouble(lblDizelFiyati.Text.Split(':')[1].Trim());
                else if (yakitTuru == "Elektrik" && !string.IsNullOrWhiteSpace(lblElektrikFiyati.Text))
                    fiyat = Convert.ToDouble(lblElektrikFiyati.Text.Split(':')[1].Trim());
                else if (yakitTuru == "LPG" && !string.IsNullOrWhiteSpace(lblLpgFiyati.Text))
                    fiyat = Convert.ToDouble(lblLpgFiyati.Text.Split(':')[1].Trim());
                else
                    MessageBox.Show("Yakıt türü veya fiyat bilgisi hatalı!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Fiyat değeri hatalı formatta, lütfen kontrol edin.");
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Fiyat bilgisi doğru biçimde yüklenmedi.");
            }

            return fiyat * yakitMiktari;
        }


        private void btnYakitEkle_Click(object sender, EventArgs e)
        {
            if (comboBoxYakitTuru.SelectedItem == null || string.IsNullOrEmpty(txtYakitMiktar.Text))
            {
                MessageBox.Show("Lütfen yakıt türü ve miktarını girin.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string yakitTuru = comboBoxYakitTuru.SelectedItem.ToString();
            if (!double.TryParse(txtYakitMiktar.Text, out double eklenecekMiktar) || eklenecekMiktar <= 0)
            {
                MessageBox.Show("Geçerli bir yakıt miktarı girin.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO YakitEklemeleri (sube_id, yakit_turu, eklenecek_miktar) VALUES (@subeId, @yakitTuru, @eklenecekMiktar)", conn);
                    cmd.Parameters.AddWithValue("@subeId", pompaciSubeId); // Kullanıcının bağlı olduğu şube
                    cmd.Parameters.AddWithValue("@yakitTuru", yakitTuru);
                    cmd.Parameters.AddWithValue("@eklenecekMiktar", eklenecekMiktar);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Yakıt ekleme talebi başarıyla gönderildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Temizlik
                    comboBoxYakitTuru.SelectedIndex = -1;
                    txtYakitMiktar.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Yakıt ekleme sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


    }
}
