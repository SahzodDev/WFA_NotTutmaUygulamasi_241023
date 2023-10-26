namespace WFA_NotTutmaUygulamasi_241023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Form2 form2 = new Form2();


        }

        private void linkKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();

            form2.ShowDialog();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            bool girisCheck = false;
            foreach (Kullanici kullanici in Form2.kullanicilar)
            {
                if (txtKullaniciAdi.Text == kullanici.KullaniciAdi && txtPassword.Text == kullanici.Password)
                {
                    girisCheck = true;
                    MessageBox.Show("Giriþ Baþarýlý");

                    Form3 form3 = new Form3(kullanici);

                    form3.ShowDialog();

                    return;
                }
            }

            if (!girisCheck)
            {
                MessageBox.Show("Kullanýcý adý veya þifre yanlýþ.");
            }
        }

        private void chkSifreyiGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSifreyiGoster.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}