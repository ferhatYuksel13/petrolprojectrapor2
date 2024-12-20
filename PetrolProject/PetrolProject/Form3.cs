using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PetrolProject
{
    public partial class Form3 : Form
    {
        private string connectionString = "Data Source=LEGEND;Initial Catalog=PetrolProject;Integrated Security=True;Encrypt=False";
        private int currentSubeId;  // Personelin bağlı olduğu şube ID'si

        public Form3(int subeId)  // Personelin bağlı olduğu şube ID'si parametre olarak alınır
        {
            InitializeComponent();
            currentSubeId = subeId;  // Personelin şubesini al
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Şube seçim kutusunu doldur
            LoadSubeList();

            // Seçilen şubeye ait satışları yükle
            LoadSatislar(currentSubeId);
        }

        private void LoadSubeList()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT id, sube_adi FROM Subeler", conn);  // Subeler tablosu üzerinden şubeleri alıyoruz
                DataTable dt = new DataTable();
                da.Fill(dt);

                // ComboBox'a şubeleri ekle
                comboBoxSube.DataSource = dt;
                comboBoxSube.DisplayMember = "sube_adi";
                comboBoxSube.ValueMember = "id";
                comboBoxSube.SelectedValue = currentSubeId;  // Personelin bağlı olduğu şube otomatik seçilsin
            }
        }

        private void LoadSatislar(int subeId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT id, sube_id, plaka, yakit_turu, yakit_miktari, odenecek_tutar, odendi, odeme_turu FROM Satislar WHERE sube_id = @subeId AND odendi = 0", conn);
                da.SelectCommand.Parameters.AddWithValue("@subeId", subeId);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // DataGridView'e satışları yükle
                dataGridViewSatislar.DataSource = dt;
                dataGridViewSatislar.Columns[0].Name = "id"; // İlk sütun adı olarak 'id' ayarlanıyor

                if (dataGridViewSatislar.Columns["id"] == null)
                {
                    MessageBox.Show("id sütunu bulunamadı.");
                }
            }
        }

        private void btnOdemeAl_Click(object sender, EventArgs e)
        {
            // Seçilen satışın ID'sini al
            if (dataGridViewSatislar.SelectedRows.Count > 0)
            {
                int satisId = Convert.ToInt32(dataGridViewSatislar.SelectedRows[0].Cells["id"].Value);

                // Ödeme türünü belirle
                string odemeTuru = rbtnNakit.Checked ? "Nakit" : "Kredi Kartı";

                // Ödeme alındı, veri tabanında güncelleme yap
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Satış ödemesini al ve durumu güncelle
                    SqlCommand cmd = new SqlCommand("UPDATE Satislar SET odendi = 1, odeme_turu = @odemeTuru WHERE id = @satisId", conn);
                    cmd.Parameters.AddWithValue("@odemeTuru", odemeTuru);
                    cmd.Parameters.AddWithValue("@satisId", satisId);

                    cmd.ExecuteNonQuery();
                }

                // Başarılı ödeme mesajı
                MessageBox.Show("Ödeme başarıyla alındı ve satış kaydı güncellendi.");

                // Satışları tekrar yükle
                LoadSatislar(currentSubeId);
            }
            else
            {
                MessageBox.Show("Lütfen ödeme alınacak bir satış seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ComboBox'tan şube seçildiğinde satışları yeniden yükle
        private void comboBoxSube_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Sadece şube değişikliği yapılırken kontrol yapıyoruz
            if (comboBoxSube.SelectedValue != null)
            {
                int selectedSubeId;
                if (int.TryParse(comboBoxSube.SelectedValue.ToString(), out selectedSubeId))
                {
                    // Eğer personel bağlı olduğu şubeyi seçmediyse, işlem yapılmasın
                    if (selectedSubeId != currentSubeId)
                    {
                        MessageBox.Show("Yanlış şube seçtiniz, lütfen kendi şubenizde işlem yapınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        // ComboBox'ı eski değere geri al
                        comboBoxSube.SelectedValue = currentSubeId;
                    }
                    else
                    {
                        LoadSatislar(selectedSubeId);
                    }
                }

            }
        }
    }
}
