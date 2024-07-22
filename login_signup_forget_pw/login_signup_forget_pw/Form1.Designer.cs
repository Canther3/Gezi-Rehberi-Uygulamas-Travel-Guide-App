namespace KullaniciUygulamasi
{
    partial class GirisForm
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
            txt_user = new TextBox();
            txt_pass = new TextBox();
            btnGiris = new Button();
            btnSifremiUnuttum = new Button();
            label1 = new Label();
            label2 = new Label();
            btnKayıtOl = new Button();
            label7 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_admin = new Button();
            SuspendLayout();
            // 
            // txt_user
            // 
            txt_user.BackColor = SystemColors.Control;
            txt_user.Location = new Point(253, 128);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(158, 23);
            txt_user.TabIndex = 0;
            // 
            // txt_pass
            // 
            txt_pass.BackColor = SystemColors.Control;
            txt_pass.Location = new Point(253, 175);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(158, 23);
            txt_pass.TabIndex = 1;
            txt_pass.UseSystemPasswordChar = true;
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(175, 244);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(90, 38);
            btnGiris.TabIndex = 2;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // btnSifremiUnuttum
            // 
            btnSifremiUnuttum.Location = new Point(305, 244);
            btnSifremiUnuttum.Name = "btnSifremiUnuttum";
            btnSifremiUnuttum.Size = new Size(90, 38);
            btnSifremiUnuttum.TabIndex = 3;
            btnSifremiUnuttum.Text = "Şifremi Unuttum";
            btnSifremiUnuttum.UseVisualStyleBackColor = true;
            btnSifremiUnuttum.Click += btnSifremiUnuttum_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(130, 128);
            label1.Name = "label1";
            label1.Size = new Size(28, 23);
            label1.TabIndex = 8;
            label1.Text = "AD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 9.75F);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(130, 175);
            label2.Name = "label2";
            label2.Size = new Size(43, 23);
            label2.TabIndex = 9;
            label2.Text = "ŞİFRE";
            // 
            // btnKayıtOl
            // 
            btnKayıtOl.Location = new Point(206, 393);
            btnKayıtOl.Name = "btnKayıtOl";
            btnKayıtOl.Size = new Size(132, 38);
            btnKayıtOl.TabIndex = 10;
            btnKayıtOl.Text = "Kayıt Ol";
            btnKayıtOl.UseVisualStyleBackColor = true;
            btnKayıtOl.Click += btnKayıtOl_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.Cursor = Cursors.No;
            label7.FlatStyle = FlatStyle.Popup;
            label7.Font = new Font("Poppins", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(130, 9);
            label7.Name = "label7";
            label7.Size = new Size(281, 101);
            label7.TabIndex = 11;
            label7.Text = "GEZİ REHBERİ";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.Cursor = Cursors.No;
            label3.FlatStyle = FlatStyle.Popup;
            label3.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(130, 298);
            label3.Name = "label3";
            label3.Size = new Size(281, 30);
            label3.TabIndex = 12;
            label3.Text = "---------------------------------------------";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.Cursor = Cursors.No;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Poppins", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(130, 341);
            label4.Name = "label4";
            label4.Size = new Size(281, 33);
            label4.TabIndex = 13;
            label4.Text = "Hesabın Yok Mu?";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_admin
            // 
            btn_admin.Location = new Point(12, 435);
            btn_admin.Name = "btn_admin";
            btn_admin.Size = new Size(75, 23);
            btn_admin.TabIndex = 14;
            btn_admin.Text = "Admin";
            btn_admin.UseVisualStyleBackColor = true;
            btn_admin.Click += button1_Click_1;
            // 
            // GirisForm
            // 
            BackColor = Color.FromArgb(192, 192, 0);
            ClientSize = new Size(537, 470);
            Controls.Add(btn_admin);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(btnKayıtOl);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSifremiUnuttum);
            Controls.Add(btnGiris);
            Controls.Add(txt_pass);
            Controls.Add(txt_user);
            ForeColor = SystemColors.ControlText;
            Name = "GirisForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Giriş Yap";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnSifremiUnuttum;
        private Label label1;
        private Label label2;
        private Button btnKayıtOl;
        private Label label7;
        private Label label3;
        private Label label4;
        private Button btn_admin;
    }
}
