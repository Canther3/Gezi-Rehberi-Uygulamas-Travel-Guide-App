namespace KullaniciUygulamasi
{
    partial class SifremiUnuttumForm
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
            btnSifirla = new Button();
            label3 = new Label();
            label7 = new Label();
            button1 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // txt_user
            // 
            txt_user.Location = new Point(244, 141);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(140, 23);
            txt_user.TabIndex = 0;
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(244, 196);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(140, 23);
            txt_pass.TabIndex = 1;
            // 
            // btnSifirla
            // 
            btnSifirla.Location = new Point(188, 263);
            btnSifirla.Name = "btnSifirla";
            btnSifirla.Size = new Size(132, 32);
            btnSifirla.TabIndex = 2;
            btnSifirla.Text = "Şifremi Sıfırla";
            btnSifirla.UseVisualStyleBackColor = true;
            btnSifirla.Click += btnSifirla_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(126, 141);
            label3.Name = "label3";
            label3.Size = new Size(22, 15);
            label3.TabIndex = 9;
            label3.Text = "Ad";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.Cursor = Cursors.No;
            label7.FlatStyle = FlatStyle.Popup;
            label7.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(126, 9);
            label7.Name = "label7";
            label7.Size = new Size(258, 101);
            label7.TabIndex = 11;
            label7.Text = "GEZİ REHBERİ";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(12, 390);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Geri Dön";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(126, 199);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 10;
            label5.Text = "Şifre";
            // 
            // SifremiUnuttumForm
            // 
            BackColor = Color.FromArgb(192, 192, 0);
            ClientSize = new Size(532, 425);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(btnSifirla);
            Controls.Add(txt_pass);
            Controls.Add(txt_user);
            Name = "SifremiUnuttumForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Şifremi Unuttum";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Button btnSifirla;
        private Label label3;
        private Label label7;
        private Button button1;
        private Label label5;
    }
}
