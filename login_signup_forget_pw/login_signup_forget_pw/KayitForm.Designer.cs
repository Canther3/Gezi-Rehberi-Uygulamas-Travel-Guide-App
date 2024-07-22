namespace KullaniciUygulamasi
{
    partial class KayitForm
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
            btnKaydol = new Button();
            label1 = new Label();
            label7 = new Label();
            txt_pass = new TextBox();
            label6 = new Label();
            btn_geri = new Button();
            SuspendLayout();
            // 
            // txt_user
            // 
            txt_user.Location = new Point(241, 146);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(200, 23);
            txt_user.TabIndex = 0;
            // 
            // btnKaydol
            // 
            btnKaydol.Cursor = Cursors.Hand;
            btnKaydol.Location = new Point(103, 267);
            btnKaydol.Name = "btnKaydol";
            btnKaydol.Size = new Size(109, 46);
            btnKaydol.TabIndex = 6;
            btnKaydol.Text = "Kaydol";
            btnKaydol.UseVisualStyleBackColor = true;
            btnKaydol.Click += btnKaydol_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(103, 146);
            label1.Name = "label1";
            label1.Size = new Size(34, 26);
            label1.TabIndex = 7;
            label1.Text = "AD";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.Cursor = Cursors.No;
            label7.FlatStyle = FlatStyle.Popup;
            label7.Font = new Font("Poppins", 27.75F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(12, 9);
            label7.Name = "label7";
            label7.Size = new Size(516, 101);
            label7.TabIndex = 9;
            label7.Text = "GEZİ REHBERİ";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(241, 189);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(200, 23);
            txt_pass.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins SemiBold", 11.25F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(103, 197);
            label6.Name = "label6";
            label6.Size = new Size(51, 26);
            label6.TabIndex = 8;
            label6.Text = "ŞİFRE";
            // 
            // btn_geri
            // 
            btn_geri.Location = new Point(12, 419);
            btn_geri.Name = "btn_geri";
            btn_geri.Size = new Size(75, 23);
            btn_geri.TabIndex = 10;
            btn_geri.Text = "Geri Dön";
            btn_geri.UseVisualStyleBackColor = true;
            btn_geri.Click += btn_geri_Click;
            // 
            // KayitForm
            // 
            BackColor = Color.FromArgb(192, 192, 0);
            ClientSize = new Size(540, 454);
            Controls.Add(btn_geri);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(btnKaydol);
            Controls.Add(txt_pass);
            Controls.Add(txt_user);
            Name = "KayitForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kaydol";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Button btnKaydol;
        private Label label1;
        private Label label7;
        private TextBox txt_pass;
        private Label label6;
        private Button btn_geri;
    }
}
