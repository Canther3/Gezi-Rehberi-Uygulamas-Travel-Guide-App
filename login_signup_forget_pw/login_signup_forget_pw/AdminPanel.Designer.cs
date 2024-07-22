namespace HavaDurumuUygulamasi
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            dataGridView1 = new DataGridView();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            txt_user = new TextBox();
            txt_pass = new TextBox();
            pictureBox1 = new PictureBox();
            dataGridView2 = new DataGridView();
            txt_user2 = new TextBox();
            txt_pass2 = new TextBox();
            pictureBox2 = new PictureBox();
            btn_ekle2 = new Button();
            btn_gunc2 = new Button();
            btn_sil2 = new Button();
            label1 = new Label();
            label2 = new Label();
            btn_geridon = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(372, 250);
            dataGridView1.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(421, 275);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(97, 50);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Ekle";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(558, 275);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(97, 50);
            buttonUpdate.TabIndex = 2;
            buttonUpdate.Text = "Güncelle";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(693, 277);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(97, 48);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Sil";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // txt_user
            // 
            txt_user.Location = new Point(421, 115);
            txt_user.Name = "txt_user";
            txt_user.PlaceholderText = "Ad";
            txt_user.Size = new Size(134, 23);
            txt_user.TabIndex = 5;
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(421, 180);
            txt_pass.Name = "txt_pass";
            txt_pass.PlaceholderText = "Şifre";
            txt_pass.Size = new Size(134, 23);
            txt_pass.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(597, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(193, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 401);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(372, 250);
            dataGridView2.TabIndex = 12;
            // 
            // txt_user2
            // 
            txt_user2.Location = new Point(421, 401);
            txt_user2.Name = "txt_user2";
            txt_user2.Size = new Size(134, 23);
            txt_user2.TabIndex = 13;
            txt_user2.Text = "Ad";
            // 
            // txt_pass2
            // 
            txt_pass2.Location = new Point(421, 460);
            txt_pass2.Name = "txt_pass2";
            txt_pass2.Size = new Size(134, 23);
            txt_pass2.TabIndex = 14;
            txt_pass2.Text = "Şifre";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(597, 395);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(193, 88);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // btn_ekle2
            // 
            btn_ekle2.Location = new Point(421, 553);
            btn_ekle2.Name = "btn_ekle2";
            btn_ekle2.Size = new Size(97, 50);
            btn_ekle2.TabIndex = 15;
            btn_ekle2.Text = "Ekle";
            btn_ekle2.UseVisualStyleBackColor = true;
            btn_ekle2.Click += btn_ekle2_Click;
            // 
            // btn_gunc2
            // 
            btn_gunc2.Location = new Point(558, 553);
            btn_gunc2.Name = "btn_gunc2";
            btn_gunc2.Size = new Size(97, 50);
            btn_gunc2.TabIndex = 16;
            btn_gunc2.Text = "Güncelle";
            btn_gunc2.UseVisualStyleBackColor = true;
            btn_gunc2.Click += btn_gunc2_Click;
            // 
            // btn_sil2
            // 
            btn_sil2.Location = new Point(693, 553);
            btn_sil2.Name = "btn_sil2";
            btn_sil2.Size = new Size(97, 50);
            btn_sil2.TabIndex = 17;
            btn_sil2.Text = "Sil";
            btn_sil2.UseVisualStyleBackColor = true;
            btn_sil2.Click += btn_sil2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 57);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 18;
            label1.Text = "Kullanıcı Paneli";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 383);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 18;
            label2.Text = "Admin Paneli";
            // 
            // btn_geridon
            // 
            btn_geridon.Location = new Point(739, 12);
            btn_geridon.Name = "btn_geridon";
            btn_geridon.Size = new Size(75, 23);
            btn_geridon.TabIndex = 19;
            btn_geridon.Text = "Geri Dön";
            btn_geridon.UseVisualStyleBackColor = true;
            btn_geridon.Click += btn_geridon_Click;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 0);
            ClientSize = new Size(826, 696);
            Controls.Add(btn_geridon);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_sil2);
            Controls.Add(btn_gunc2);
            Controls.Add(btn_ekle2);
            Controls.Add(txt_pass2);
            Controls.Add(txt_user2);
            Controls.Add(dataGridView2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txt_pass);
            Controls.Add(txt_user);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridView1);
            Name = "AdminPanel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Panel";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_pass;
        private PictureBox pictureBox1;
        private DataGridView dataGridView2;
        private TextBox txt_user2;
        private TextBox txt_pass2;
        private PictureBox pictureBox2;
        private Button btn_ekle2;
        private Button btn_gunc2;
        private Button btn_sil2;
        private Label label1;
        private Label label2;
        private Button btn_geridon;
    }
}
