using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PetrolProject
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=LEGEND;Initial Catalog=PetrolProject;Integrated Security=True;Encrypt=False";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbPosition.Items.Add("Yönetici");
            cmbPosition.Items.Add("Personel");
            cmbPosition.Items.Add("Pompacı");
            cmbPosition.SelectedIndex = 0;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string fullName = txtFullName.Text.Trim();
            string password = txtPassword.Text.Trim();
            string position = cmbPosition.SelectedItem.ToString();

            if (string.IsNullOrEmpty(fullName) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(position))
            {
                MessageBox.Show("Adı Soyadı, Şifre ve Pozisyon alanlarını doldurunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool loginSuccess = CheckUserLogin(fullName, password, position);

            if (loginSuccess)
            {
                MessageBox.Show("Giriş Başarılı! " + position + " olarak yönlendiriliyorsunuz.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (position == "Yönetici")
                {
                    Form2 adminForm = new Form2();
                    adminForm.Show();
                }
                else if (position == "Personel")
                {
                    int subeId = GetUserSubeId(fullName, password, position);

                    if (subeId == -1)
                    {
                        MessageBox.Show("Kullanıcının şube bilgisi bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    Form3 personnelForm = new Form3(subeId);
                    personnelForm.Show();
                }
                else if (position == "Pompacı")
                {
                    int subeId = GetUserSubeId(fullName, password, position);

                    if (subeId == -1)
                    {
                        MessageBox.Show("Kullanıcının şube bilgisi bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Form4 pumpAttendantForm = new Form4(subeId);
                    pumpAttendantForm.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Adı Soyadı, Şifre veya Pozisyon hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool CheckUserLogin(string fullName, string password, string position)
        {
            bool isValidUser = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Users WHERE full_name = @FullName AND password = @Password AND position = @Position";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FullName", fullName);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Position", position);

                        int userCount = Convert.ToInt32(command.ExecuteScalar());
                        if (userCount > 0)
                        {
                            isValidUser = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı bağlantısı sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return isValidUser;
        }

        private int GetUserSubeId(string fullName, string password, string position)
        {
            int subeId = -1; // Default değer, eğer kullanıcı bulunamazsa

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT sube_id FROM Users WHERE full_name = @FullName AND password = @Password AND position = @Position";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FullName", fullName);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Position", position);

                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            subeId = Convert.ToInt32(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanı bağlantısı sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return subeId;
        }
    }
}
