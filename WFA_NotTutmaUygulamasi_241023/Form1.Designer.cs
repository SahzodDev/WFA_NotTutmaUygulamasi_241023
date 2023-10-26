namespace WFA_NotTutmaUygulamasi_241023
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtKullaniciAdi = new TextBox();
            label2 = new Label();
            txtPassword = new TextBox();
            btnGirisYap = new Button();
            linkKayitOl = new LinkLabel();
            chkSifreyiGoster = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(46, 50);
            label1.Name = "label1";
            label1.Size = new Size(95, 21);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(46, 89);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(258, 23);
            txtKullaniciAdi.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(46, 134);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(46, 183);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(258, 23);
            txtPassword.TabIndex = 3;
            // 
            // btnGirisYap
            // 
            btnGirisYap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGirisYap.Location = new Point(46, 257);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(258, 48);
            btnGirisYap.TabIndex = 4;
            btnGirisYap.Text = "Giriş Yap";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // linkKayitOl
            // 
            linkKayitOl.AutoSize = true;
            linkKayitOl.Location = new Point(94, 324);
            linkKayitOl.Name = "linkKayitOl";
            linkKayitOl.Size = new Size(144, 15);
            linkKayitOl.TabIndex = 5;
            linkKayitOl.TabStop = true;
            linkKayitOl.Text = "Kayıt Olmak İçin Tıklayınız";
            linkKayitOl.LinkClicked += linkKayitOl_LinkClicked;
            // 
            // chkSifreyiGoster
            // 
            chkSifreyiGoster.AutoSize = true;
            chkSifreyiGoster.Location = new Point(46, 222);
            chkSifreyiGoster.Name = "chkSifreyiGoster";
            chkSifreyiGoster.Size = new Size(94, 19);
            chkSifreyiGoster.TabIndex = 6;
            chkSifreyiGoster.Text = "Şifreyi göster";
            chkSifreyiGoster.UseVisualStyleBackColor = true;
            chkSifreyiGoster.CheckedChanged += chkSifreyiGoster_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 417);
            Controls.Add(chkSifreyiGoster);
            Controls.Add(linkKayitOl);
            Controls.Add(btnGirisYap);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Giriş Ekranı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtKullaniciAdi;
        private Label label2;
        private TextBox txtPassword;
        private Button btnGirisYap;
        private LinkLabel linkKayitOl;
        private CheckBox chkSifreyiGoster;
    }
}