namespace MesafeHesaplayici
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBoxSlider;
        private System.Windows.Forms.Timer sliderTimer;
        private System.Windows.Forms.Button btnNextImage;
        private System.Windows.Forms.Button btnPreviousImage;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            comboBoxStart = new ComboBox();
            comboBoxEnd = new ComboBox();
            buttonCalculate = new Button();
            labelResult = new Label();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            pictureBoxSlider = new PictureBox();
            sliderTimer = new System.Windows.Forms.Timer(components);
            btnNextImage = new Button();
            btnPreviousImage = new Button();
            label5 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSlider).BeginInit();
            SuspendLayout();
            // 
            // comboBoxStart
            // 
            comboBoxStart.FormattingEnabled = true;
            comboBoxStart.Location = new Point(265, 89);
            comboBoxStart.Name = "comboBoxStart";
            comboBoxStart.Size = new Size(177, 23);
            comboBoxStart.TabIndex = 0;
            // 
            // comboBoxEnd
            // 
            comboBoxEnd.FormattingEnabled = true;
            comboBoxEnd.Location = new Point(518, 89);
            comboBoxEnd.Name = "comboBoxEnd";
            comboBoxEnd.Size = new Size(177, 23);
            comboBoxEnd.TabIndex = 1;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(732, 84);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(150, 37);
            buttonCalculate.TabIndex = 2;
            buttonCalculate.Text = "Mesafeyi Hesapla";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.BackColor = Color.White;
            labelResult.Location = new Point(265, 155);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(51, 15);
            labelResult.TabIndex = 3;
            labelResult.Text = "Mesafe: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(409, 23);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 4;
            label1.Text = "Başlangıç";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(576, 23);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 4;
            label2.Text = "Varış";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(930, 489);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(73, 118);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 6;
            label3.Text = "Hesap";
            label3.Click += labelHesap_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(73, 222);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 6;
            label4.Text = "Hava Durumu";
            label4.Click += labelHavaD_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(192, 192, 0);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(73, 170);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 6;
            label6.Text = "Restorantlar";
            label6.Click += labelRestorantlar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(73, 272);
            label8.Name = "label8";
            label8.Size = new Size(28, 15);
            label8.TabIndex = 6;
            label8.Text = "Geri";
            label8.Click += labelGeri_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(73, 314);
            label9.Name = "label9";
            label9.Size = new Size(32, 15);
            label9.TabIndex = 6;
            label9.Text = "Çıkış";
            label9.Click += label9_Click;
            // 
            // pictureBoxSlider
            // 
            pictureBoxSlider.BackColor = Color.White;
            pictureBoxSlider.Image = login_signup_forget_pw.Properties.Resources.ist2;
            pictureBoxSlider.Location = new Point(265, 191);
            pictureBoxSlider.Name = "pictureBoxSlider";
            pictureBoxSlider.Size = new Size(617, 233);
            pictureBoxSlider.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxSlider.TabIndex = 7;
            pictureBoxSlider.TabStop = false;
            pictureBoxSlider.Click += pictureBoxSlider_Click;
            // 
            // sliderTimer
            // 
            sliderTimer.Interval = 2000;
            sliderTimer.Tick += sliderTimer_Tick;
            // 
            // btnNextImage
            // 
            btnNextImage.Location = new Point(649, 441);
            btnNextImage.Name = "btnNextImage";
            btnNextImage.Size = new Size(106, 35);
            btnNextImage.TabIndex = 8;
            btnNextImage.Text = "İleri";
            btnNextImage.UseVisualStyleBackColor = true;
            btnNextImage.Click += btnNextImage_Click;
            // 
            // btnPreviousImage
            // 
            btnPreviousImage.Location = new Point(334, 441);
            btnPreviousImage.Name = "btnPreviousImage";
            btnPreviousImage.Size = new Size(108, 35);
            btnPreviousImage.TabIndex = 9;
            btnPreviousImage.Text = "Geri";
            btnPreviousImage.UseVisualStyleBackColor = true;
            btnPreviousImage.Click += btnPreviousImage_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.FromArgb(192, 192, 0);
            label5.Location = new Point(265, 49);
            label5.Name = "label5";
            label5.Size = new Size(213, 37);
            label5.TabIndex = 10;
            label5.Text = "Başlangıç Noktası";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Poppins", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.ForeColor = Color.FromArgb(192, 192, 0);
            label7.Location = new Point(518, 49);
            label7.Name = "label7";
            label7.Size = new Size(162, 37);
            label7.TabIndex = 10;
            label7.Text = "Varış Noktası";
            // 
            // Form1
            // 
            BackColor = Color.FromArgb(192, 192, 0);
            ClientSize = new Size(932, 488);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(btnPreviousImage);
            Controls.Add(btnNextImage);
            Controls.Add(pictureBoxSlider);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(labelResult);
            Controls.Add(buttonCalculate);
            Controls.Add(comboBoxEnd);
            Controls.Add(comboBoxStart);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mesafe Hesaplayıcı";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSlider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxStart;
        private System.Windows.Forms.ComboBox comboBoxEnd;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Label label5;
        private Label label7;
    }
}
