namespace login_signup_forget_pw
{
    partial class AdminG
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_user = new TextBox();
            txt_pass = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(160, 42);
            label1.TabIndex = 0;
            label1.Text = "Admin Giriş";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(74, 137);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 1;
            label2.Text = "Kullanıcı Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(74, 223);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 1;
            label3.Text = "Şifre";
            // 
            // txt_user
            // 
            txt_user.Location = new Point(153, 137);
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(100, 23);
            txt_user.TabIndex = 2;
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(153, 220);
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(100, 23);
            txt_pass.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(126, 289);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Giriş";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AdminG
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 0);
            ClientSize = new Size(381, 389);
            Controls.Add(button1);
            Controls.Add(txt_pass);
            Controls.Add(txt_user);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminG";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Giriş";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_user;
        private TextBox txt_pass;
        private Button button1;
    }
}