
using HavaDurumuUygulamasi;
using login_signup_forget_pw;
using MesafeHesaplayici;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KullaniciUygulamasi
{
    public partial class GirisForm : Form
    {
        private int girisHakki = 5;

        public GirisForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-ECDGUAF;Initial Catalog=GeziRehberi;Integrated Security=True");


        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txt_user.Text;
            string sifre = txt_pass.Text;

            conn.Open();

            SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM GirisK WHERE KullaniciAdi = @kullaniciAdi AND Sifre = @sifre", conn);
            komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
            komut.Parameters.AddWithValue("@sifre", sifre);

            int sonuc = (int)komut.ExecuteScalar();




            if (sonuc > 0)
            {
                Menü1 HomeP = new Menü1();
                HomeP.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalý Kullanýcý Adý veya Þifre");


            }
            conn.Close();
        }

        private void btnSifremiUnuttum_Click(object sender, EventArgs e)
        {
            SifremiUnuttumForm sifremiUnuttumForm = new SifremiUnuttumForm();
            sifremiUnuttumForm.Show();
            this.Hide();
        }

        private void btnKayýtOl_Click(object sender, EventArgs e)
        {
            KayitForm kayitForm = new KayitForm();
            kayitForm.Show();
            this.Hide();
        }

     

        private void button1_Click_1(object sender, EventArgs e)
        {

            AdminG adminPanel = new AdminG();
            adminPanel.Show();
            this.Hide();

        }
    }
}
