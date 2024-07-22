using HavaDurumuUygulamasi;
using KullaniciUygulamasi;
using MesafeHesaplayici;
using RestoranUygulamasi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_signup_forget_pw
{
    public partial class Menü1 : Form
    {
        public Menü1()
        {
            InitializeComponent();
        }




        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 FormMenu = new Form1();
            FormMenu.Show();
            this.Hide();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            HavaDurumu havaDurumuForm = new HavaDurumu();
            havaDurumuForm.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Restorantlar restorantlar = new Restorantlar();
            restorantlar.Show();
            this.Hide();
        }

        private void btn_cıkıs_Click(object sender, EventArgs e)
        {
            GirisForm girisForm = new GirisForm();
            girisForm.Show();
            this.Hide();
        }
    }
}
