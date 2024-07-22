using KullaniciUygulamasi;
using login_signup_forget_pw;
using MesafeHesaplayici;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HavaDurumuUygulamasi
{
    public partial class AdminPanel : Form
    {
        private SqlConnection kullaniciDbConnection;
        private SqlConnection adminPaneliDbConnection;

        public AdminPanel()
        {
            InitializeComponent();
            VeriListele();
            VeriListele2();


        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-ECDGUAF;Initial Catalog=GeziRehberi;Integrated Security=True");
        SqlDataAdapter da;
        DataSet ds;



        void VeriListele()
        {
            conn.Open();
            SqlDataAdapter veri = new SqlDataAdapter("select *from GirisK", conn);
            DataTable table = new DataTable();
            veri.Fill(table);
            dataGridView1.DataSource = table;
            conn.Close();
        }
        void VeriListele2()
        {
            conn.Open();
            SqlDataAdapter veri = new SqlDataAdapter("select *from GirisA", conn);
            DataTable table = new DataTable();
            veri.Fill(table);
            dataGridView2.DataSource = table;
            conn.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand VeriKaydet = new SqlCommand("insert into GirisK(KullaniciAdi,Sifre) values(@KullaniciAdi,@Sifre)", conn);
            VeriKaydet.Parameters.AddWithValue("@KullaniciAdi", txt_user.Text);
            VeriKaydet.Parameters.AddWithValue("@Sifre", txt_pass.Text);


            VeriKaydet.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kullanıcı Eklendi");
            VeriListele();


        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // güncelleme 
            conn.Open();
            SqlCommand VeriGuncelle = new SqlCommand("update  GirisK set KullaniciAdi=@KullaniciAdi where Sifre=@Sifre", conn);
            VeriGuncelle.Parameters.AddWithValue("@KullaniciAdi", txt_user.Text);
            VeriGuncelle.Parameters.AddWithValue("@Sifre", txt_pass.Text);

            VeriGuncelle.ExecuteNonQuery();
            conn.Close();
            VeriListele();
            MessageBox.Show("Güncellendi");
            ClearTextBoxes();

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // SİLL

            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Lüffen silinecek satırı seçin.");
            }

        }

        private void ClearTextBoxes()
        {
            txt_user.Clear();
            txt_pass.Clear();

        }




        // admin bölümü 

        private void btn_ekle2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand VeriKaydet = new SqlCommand("insert into GirisA(Admin,Pass) values(@Admin,@Pass)", conn);
            VeriKaydet.Parameters.AddWithValue("@Admin", txt_user2.Text);
            VeriKaydet.Parameters.AddWithValue("@Pass", txt_pass2.Text);


            VeriKaydet.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kullancı Eklendi");
            VeriListele();
        }

        private void btn_gunc2_Click(object sender, EventArgs e)
        {
            // güncelleme 
            conn.Open();
            SqlCommand VeriGuncelle = new SqlCommand("update  GirisA set Admin=@Admin where Pass=@Pass", conn);
            VeriGuncelle.Parameters.AddWithValue("@Admin", txt_user2.Text);
            VeriGuncelle.Parameters.AddWithValue("@Pass", txt_pass2.Text);

            VeriGuncelle.ExecuteNonQuery();
            conn.Close();
            VeriListele();
            MessageBox.Show("Güncellendi.");
            ClearTextBoxes();
        }

        private void btn_sil2_Click(object sender, EventArgs e)
        {
            // SİLL

            if (dataGridView2.SelectedRows.Count > 0)
            {
                dataGridView2.Rows.RemoveAt(dataGridView2.SelectedRows[0].Index);
                MessageBox.Show("Kullanıcı Silindi.");

            }
            else
            {
                MessageBox.Show("Lüffen silinecek satırı seçin.");
            }
        }

        private void btn_geridon_Click(object sender, EventArgs e)
        {
            Menü1 formdon = new Menü1();
            formdon.Show();
            this.Hide();
        }
    }
}
