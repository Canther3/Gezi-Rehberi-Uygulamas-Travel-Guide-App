using HavaDurumuUygulamasi;
using login_signup_forget_pw;
using RestoranUygulamasi;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KullaniciUygulamasi
{
    public partial class SifreSifirlama : Form
    {
        public SifreSifirlama()
        {
            InitializeComponent();
        }

        private void btnSifreSifirla_Click(object sender, EventArgs e)
        {
            string adı = txt_ad.Text;
            string yeniSifre = txtSifre.Text;
            string sifreTekrar = txtSifreTekrar.Text;

            if (yeniSifre != sifreTekrar)
            {
                MessageBox.Show("Şifreler uyuşmuyor. Lütfen tekrar deneyin.");
                return;
            }

            string connectionString = "Data Source=DESKTOP-ECDGUAF; Initial Catalog=GeziRehberi; Integrated Security=True"; 
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE GirisK SET Sifre = @Sifre WHERE KullanaiciAdi = @ad";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Sifre", yeniSifre);
                command.Parameters.AddWithValue("@ad", txt_ad);

                connection.Open();
                int result = command.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Şifre başarıyla güncellendi.");
                }
                else
                {
                    MessageBox.Show("Adınız bulunamadı. Lütfen tekrar deneyin.");
                }
            }
        }

        private void labelHesap_Click(object sender, EventArgs e)
        {
            SifreSifirlama ŞifreSıfırlamaForm = new SifreSifirlama();
            ŞifreSıfırlamaForm.Show();
            this.Hide();
        }

        private void labelRestorantlar_Click(object sender, EventArgs e)
        {
            Restorantlar RestorantForm = new Restorantlar();
            RestorantForm.Show();
            this.Hide();
        }

        private void labelHavaD_Click(object sender, EventArgs e)
        {
            HavaDurumu havaDurumuForm = new HavaDurumu();
            havaDurumuForm.Show();
            this.Hide();
        }

        private void labelGeri_Click(object sender, EventArgs e)
        {
            Menü1 Menü1Form = new Menü1();
            Menü1Form.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
