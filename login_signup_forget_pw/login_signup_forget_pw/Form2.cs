using HavaDurumuUygulamasi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_signup_forget_pw
{
    public partial class AdminG : Form
    {
        public AdminG()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-ECDGUAF;Initial Catalog=GeziRehberi;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txt_user.Text;
            string sifre = txt_pass.Text;

            conn.Open();

            SqlCommand komut = new SqlCommand("SELECT COUNT(*) FROM GirisA WHERE Admin = @kullaniciAdi AND  Pass = @sifre", conn);
            komut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
            komut.Parameters.AddWithValue("@sifre", sifre);

            int sonuc = (int)komut.ExecuteScalar();




            if (sonuc > 0)
            {
               AdminPanel adminPanel = new AdminPanel();
                adminPanel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre");


            }
            conn.Close();
        }
    }
}
