namespace WFA_NotTutmaUygulamasi_241023
{
    partial class Form2
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
            txtKullaniciAdi = new TextBox();
            txtPassword = new TextBox();
            chkSozlesme = new CheckBox();
            btnKayitEkle = new Button();
            chkSifreyiGoster = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(32, 75);
            label1.Name = "label1";
            label1.Size = new Size(95, 21);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(32, 185);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(32, 114);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(315, 23);
            txtKullaniciAdi.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(32, 237);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(315, 23);
            txtPassword.TabIndex = 3;
            // 
            // chkSozlesme
            // 
            chkSozlesme.AutoSize = true;
            chkSozlesme.Location = new Point(32, 315);
            chkSozlesme.Name = "chkSozlesme";
            chkSozlesme.Size = new Size(191, 19);
            chkSozlesme.TabIndex = 4;
            chkSozlesme.Text = "Kullanıcı sözleşmesini okudum.";
            chkSozlesme.UseVisualStyleBackColor = true;
            // 
            // btnKayitEkle
            // 
            btnKayitEkle.Location = new Point(32, 373);
            btnKayitEkle.Name = "btnKayitEkle";
            btnKayitEkle.Size = new Size(315, 38);
            btnKayitEkle.TabIndex = 5;
            btnKayitEkle.Text = "Kayıt Ekle";
            btnKayitEkle.UseVisualStyleBackColor = true;
            btnKayitEkle.Click += btnKayitEkle_Click;
            // 
            // chkSifreyiGoster
            // 
            chkSifreyiGoster.AutoSize = true;
            chkSifreyiGoster.Location = new Point(32, 275);
            chkSifreyiGoster.Name = "chkSifreyiGoster";
            chkSifreyiGoster.Size = new Size(94, 19);
            chkSifreyiGoster.TabIndex = 6;
            chkSifreyiGoster.Text = "Şifreyi göster";
            chkSifreyiGoster.UseVisualStyleBackColor = true;
            chkSifreyiGoster.CheckedChanged += chkSifreyiGoster_CheckedChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 437);
            Controls.Add(chkSifreyiGoster);
            Controls.Add(btnKayitEkle);
            Controls.Add(chkSozlesme);
            Controls.Add(txtPassword);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Kayıt Ekranı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtKullaniciAdi;
        private TextBox txtPassword;
        private CheckBox chkSozlesme;
        private Button btnKayitEkle;
        private CheckBox chkSifreyiGoster;
    }
}