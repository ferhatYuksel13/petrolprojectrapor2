using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;

namespace PetrolProject
{
    public partial class Form2 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=LEGEND;Initial Catalog=PetrolProject;Integrated Security=True;Encrypt=False");

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // YakitEklemeleri tablosunu yüklerken id sütununu kontrol et.
            this.yakitEklemeleriTableAdapter.Fill(this.petrolProjectDataSet2.YakitEklemeleri);
            this.usersTableAdapter.Fill(this.petrolProjectDataSet1.users);
            txtAdSoyad.Text = "Ad Soyad";
            txtAdSoyad.ForeColor = Color.Gray;

            txtSifre.Text = "Şifre";
            txtSifre.ForeColor = Color.Gray;
        }

        private void txtAdSoyad_Enter(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text == "Ad Soyad")
            {
                txtAdSoyad.Text = "";
                txtAdSoyad.ForeColor = Color.Black;
            }
        }

        private void txtAdSoyad_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdSoyad.Text))
            {
                txtAdSoyad.Text = "Ad Soyad";
                txtAdSoyad.ForeColor = Color.Gray;
            }
        }

        private void txtSifre_Enter(object sender, EventArgs e)
        {
            if (txtSifre.Text == "Şifre")
            {
                txtSifre.Text = "";
                txtSifre.ForeColor = Color.Black;
            }
        }

        private void txtSifre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                txtSifre.Text = "Şifre";
                txtSifre.ForeColor = Color.Gray;
            }
        }

        private void LoadUsers()
        {
            try
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM users", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void LoadYakitEklemeleriData()
        {
            try
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM YakitEklemeleri", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt; // Verileri DataGridView'e yükler.
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }



        private void PopulateComboBoxes()
        {
            cmbPozisyon.Items.Add("Pozisyon");
            cmbPozisyon.Items.Add("Pompacı");

            cmbSube.Items.Add("Şube 1");
            cmbSube.Items.Add("Şube 2");
            cmbSube.Items.Add("Şube 3");
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO users (full_name, password, position, sube_id) VALUES (@full_name, @password, @position, @sube_id)",
                    connection);
                cmd.Parameters.AddWithValue("@full_name", txtAdSoyad.Text);
                cmd.Parameters.AddWithValue("@password", txtSifre.Text);
                cmd.Parameters.AddWithValue("@position", cmbPozisyon.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@sube_id", cmbSube.SelectedIndex + 1); // Şube ID'si 1, 2, 3 olarak atanır
                cmd.ExecuteNonQuery();
                connection.Close();
                LoadUsers();
                MessageBox.Show("Kullanıcı eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                connection.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM users WHERE id = @id", connection);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                connection.Close();
                LoadUsers();
                MessageBox.Show("Kullanıcı silindi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                connection.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE users SET full_name = @full_name, password = @password, position = @position, sube_id = @sube_id WHERE id = @id",
                    connection);
                cmd.Parameters.AddWithValue("@full_name", txtAdSoyad.Text);
                cmd.Parameters.AddWithValue("@password", txtSifre.Text);
                cmd.Parameters.AddWithValue("@position", cmbPozisyon.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@sube_id", cmbSube.SelectedIndex + 1); // Şube ID'si 1, 2, 3 olarak atanır
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                connection.Close();
                LoadUsers();
                MessageBox.Show("Kullanıcı güncellendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void btnYakitReddet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yakıt isteği reddedildi.");
            // İlgili SQL işlemleri buraya eklenecek.
        }

        private void btnYakitVer_Click(object sender, EventArgs e)
        {
            try
            {
                // Seçilen satırdan yakıt türü, eklenecek miktar ve şube_id'yi alıyoruz
                int id = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["id"].Value);
                int subeId = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells["sube_id"].Value);
                string yakitTuru = dataGridView2.SelectedRows[0].Cells["yakit_turu"].Value.ToString();
                decimal eklenecekMiktar = Convert.ToDecimal(dataGridView2.SelectedRows[0].Cells["eklenecek_miktar"].Value);

                // Bağlantıyı açıyoruz
                connection.Open();

                // Şubedeki mevcut yakıt miktarını almak için sorgu
                SqlCommand cmd = new SqlCommand("SELECT benzin_miktari, dizel_miktari, elektrik_miktari, lpg_miktari FROM YakitStok WHERE sube_id = @sube_id", connection);
                cmd.Parameters.AddWithValue("@sube_id", subeId);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    decimal mevcutBenzin = Convert.ToDecimal(reader["benzin_miktari"]);
                    decimal mevcutDizel = Convert.ToDecimal(reader["dizel_miktari"]);
                    decimal mevcutElektrik = Convert.ToDecimal(reader["elektrik_miktari"]);
                    decimal mevcutLPG = Convert.ToDecimal(reader["lpg_miktari"]);
                    reader.Close();

                    // Yakıt türüne göre stokta yeterli miktar var mı kontrol ediyoruz
                    if ((yakitTuru == "Benzin" && mevcutBenzin >= eklenecekMiktar) ||
                        (yakitTuru == "Dizel" && mevcutDizel >= eklenecekMiktar) ||
                        (yakitTuru == "Elektrik" && mevcutElektrik >= eklenecekMiktar) ||
                        (yakitTuru == "LPG" && mevcutLPG >= eklenecekMiktar))
                    {
                        // Yeterli miktar varsa, YakitStok tablosunu güncelliyoruz
                        string updateQuery = "UPDATE YakitStok SET ";

                        if (yakitTuru == "Benzin")
                            updateQuery += "benzin_miktari = benzin_miktari + @eklenecek_miktar ";
                        else if (yakitTuru == "Dizel")
                            updateQuery += "dizel_miktari = dizel_miktari + @eklenecek_miktar ";
                        else if (yakitTuru == "Elektrik")
                            updateQuery += "elektrik_miktari = elektrik_miktari + @eklenecek_miktar ";
                        else if (yakitTuru == "LPG")
                            updateQuery += "lpg_miktari = lpg_miktari + @eklenecek_miktar ";

                        updateQuery += "WHERE sube_id = @sube_id";

                        SqlCommand updateCmd = new SqlCommand(updateQuery, connection);
                        updateCmd.Parameters.AddWithValue("@eklenecek_miktar", eklenecekMiktar);
                        updateCmd.Parameters.AddWithValue("@sube_id", subeId);
                        updateCmd.ExecuteNonQuery();

                        // YakitEklemeleri tablosundan bu kaydı silmek
                        SqlCommand deleteCmd = new SqlCommand("DELETE FROM YakitEklemeleri WHERE id = @id", connection);
                        deleteCmd.Parameters.AddWithValue("@id", id);
                        deleteCmd.ExecuteNonQuery();

                        connection.Close();

                        // Başarılı mesajı
                        MessageBox.Show("Yakıt verme işlemi başarıyla gerçekleştirildi.");
                    }
                    else
                    {
                        MessageBox.Show("Stokta yeterli yakıt yok.");
                        connection.Close();
                    }
                }
                else
                {
                    connection.Close();
                    MessageBox.Show("YakitStok tablosunda bu şube bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }







        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
