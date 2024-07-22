using System;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KullaniciUygulamasi
{
    public partial class SifremiUnuttumForm : Form
    {
        public SifremiUnuttumForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string password = GenerateRandomPassword(12); // 12 karakter uzunluğunda bir şifre oluştur
        }

        private string GenerateRandomPassword(int length)
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder result = new StringBuilder();
            Random random = new Random();

            while (0 < length--)
            {
                result.Append(validChars[random.Next(validChars.Length)]);
            }

            return result.ToString();
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            string ad = txt_user.Text;
            string sifre = txt_pass.Text;

            using (SqlConnection conn = new SqlConnection("Data Source=DESKTOP-ECDGUAF;Initial Catalog=GeziRehberi;Integrated Security=True"))
            {
                conn.Open();

                // 1. Prepared Statement for Login Validation
                string loginQuery = "SELECT COUNT(1) FROM GirisK WHERE KullaniciAdi = @KullaniciAdi AND Sifre = @Sifre";
                using (SqlCommand loginCmd = new SqlCommand(loginQuery, conn))
                {
                    loginCmd.Parameters.AddWithValue("@KullaniciAdi", ad);
                    loginCmd.Parameters.AddWithValue("@Sifre", sifre);

                    int count = Convert.ToInt32(loginCmd.ExecuteScalar());

                    if (count == 1)
                    {
                        // 2. Separate Prepared Statement for Password Reset
                        string updateQuery = "UPDATE GirisK SET Sifre = @YeniSifre WHERE KullaniciAdi = @KullaniciAdi";
                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                        {
                            updateCmd.Parameters.AddWithValue("@KullaniciAdi", ad);

                            string password = GenerateRandomPassword(12); // 12 karakter uzunluğunda bir şifre oluştur

                            updateCmd.Parameters.AddWithValue("@YeniSifre", password);

                            updateCmd.ExecuteNonQuery();

                            MessageBox.Show("Şifreniz sıfırlanmıştır. Yeni şifreniz: " + password);
                            GirisForm girisForm = new GirisForm();
                            girisForm.Show();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bilgiler eşleşmiyor. Lütfen tekrar deneyiniz.");
                    }
                }
            }
        }
            private void button1_Click(object sender, EventArgs e)
            {
                GirisForm girisForm = new GirisForm();
                girisForm.Show();
                this.Hide();
            }




        
    }
    
}




