﻿namespace KullaniciUygulamasi
{
    partial class SifreSifirlama
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifreSifirlama));
            txt_ad = new TextBox();
            txtSifre = new TextBox();
            txtSifreTekrar = new TextBox();
            lblTCKimlikNo = new Label();
            lblSifre = new Label();
            lblSifreTekrar = new Label();
            btnSifreSifirla = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label9 = new Label();
            label8 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txt_ad
            // 
            txt_ad.Location = new Point(478, 152);
            txt_ad.Name = "txt_ad";
            txt_ad.Size = new Size(200, 23);
            txt_ad.TabIndex = 0;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(478, 192);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(200, 23);
            txtSifre.TabIndex = 1;
            // 
            // txtSifreTekrar
            // 
            txtSifreTekrar.Location = new Point(478, 232);
            txtSifreTekrar.Name = "txtSifreTekrar";
            txtSifreTekrar.Size = new Size(200, 23);
            txtSifreTekrar.TabIndex = 2;
            // 
            // lblTCKimlikNo
            // 
            lblTCKimlikNo.AutoSize = true;
            lblTCKimlikNo.Location = new Point(368, 155);
            lblTCKimlikNo.Name = "lblTCKimlikNo";
            lblTCKimlikNo.Size = new Size(40, 15);
            lblTCKimlikNo.TabIndex = 3;
            lblTCKimlikNo.Text = "Adınız";
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.Location = new Point(368, 195);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(33, 15);
            lblSifre.TabIndex = 4;
            lblSifre.Text = "Şifre:";
            // 
            // lblSifreTekrar
            // 
            lblSifreTekrar.AutoSize = true;
            lblSifreTekrar.Location = new Point(368, 235);
            lblSifreTekrar.Name = "lblSifreTekrar";
            lblSifreTekrar.Size = new Size(67, 15);
            lblSifreTekrar.TabIndex = 5;
            lblSifreTekrar.Text = "Şifre Tekrar:";
            // 
            // btnSifreSifirla
            // 
            btnSifreSifirla.Location = new Point(478, 272);
            btnSifreSifirla.Name = "btnSifreSifirla";
            btnSifreSifirla.Size = new Size(200, 30);
            btnSifreSifirla.TabIndex = 6;
            btnSifreSifirla.Text = "Şifre Sıfırla";
            btnSifreSifirla.UseVisualStyleBackColor = true;
            btnSifreSifirla.Click += btnSifreSifirla_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(600, 52);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 8;
            label1.Text = "TC Kimlik No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlLightLight;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(513, 52);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 9;
            label2.Text = "TC Kimlik No:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ControlLightLight;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(254, 52);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 10;
            label3.Text = "TC Kimlik No:";
            label3.Click += labelHesap_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlLightLight;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(345, 52);
            label4.Name = "label4";
            label4.Size = new Size(78, 15);
            label4.TabIndex = 11;
            label4.Text = "TC Kimlik No:";
            label4.Click += labelHavaD_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(192, 192, 0);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(70, 314);
            label9.Name = "label9";
            label9.Size = new Size(32, 15);
            label9.TabIndex = 13;
            label9.Text = "Çıkış";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(192, 192, 0);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(70, 272);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 14;
            label8.Text = "Geri";
            label8.Click += labelGeri_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(192, 192, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(70, 222);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 15;
            label5.Text = "Hava Durumu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(192, 192, 0);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(70, 170);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 16;
            label6.Text = "Restorantlar";
            label6.Click += labelRestorantlar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(192, 192, 0);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(70, 118);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 17;
            label7.Text = "Hesap";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-2, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(930, 489);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // SifreSifirlama
            // 
            ClientSize = new Size(927, 487);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSifreSifirla);
            Controls.Add(lblSifreTekrar);
            Controls.Add(lblSifre);
            Controls.Add(lblTCKimlikNo);
            Controls.Add(txtSifreTekrar);
            Controls.Add(txtSifre);
            Controls.Add(txt_ad);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(pictureBox2);
            Name = "SifreSifirlama";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Şifre Sıfırlama";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtSifreTekrar;
        private System.Windows.Forms.Label lblTCKimlikNo;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblSifreTekrar;
        private System.Windows.Forms.Button btnSifreSifirla;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label9;
        private Label label8;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox2;
    }
}
