using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KullaniciUygulamasi
{
    public partial class KayitForm : Form
    {
        public KayitForm()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-ECDGUAF;Initial Catalog=GeziRehberi;Integrated Security=True");

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand VeriKaydet = new SqlCommand("insert into GirisK(KullaniciAdi,Sifre) values(@KullaniciAdi,@Sifre)", conn);
            VeriKaydet.Parameters.AddWithValue("@KullaniciAdi", txt_user.Text);
            VeriKaydet.Parameters.AddWithValue("@Sifre", txt_pass.Text);
            VeriKaydet.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show(" Kayıt Başarılı..");
            ClearTextBoxes();



        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            GirisForm girisForm= new GirisForm();
            girisForm.Show();
            this.Hide();
        }
        private void ClearTextBoxes()
        {
            txt_user.Clear();
            txt_pass.Clear();

        }
    }
}
