using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_NotTutmaUygulamasi_241023
{
    public partial class Form2 : Form
    {
        public static List<Kullanici> kullanicilar = new List<Kullanici>();
        const string filePath = "kullanicilar.json";
        public Form2()
        {
            InitializeComponent();

            if (File.Exists(filePath))
            {
                using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    if (stream.Length > 0)
                    {
                        kullanicilar = JsonSerializer.Deserialize<List<Kullanici>>(stream);
                    }

                }
            }
        }



        private void btnKayitEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Kullanici kullanici = new Kullanici()
                {
                    KullaniciAdi = txtKullaniciAdi.Text,
                    Password = txtPassword.Text
                };

                bool checkBoxCheck = false;

                if (chkSozlesme.Checked)
                {
                    checkBoxCheck = true;
                }
                else
                {
                    throw new Exception("Kullanıcı sözleşmesini onaylamalısnız.");
                }

                bool kullaniciAdiCheck = kullanicilar.Any(k => k.KullaniciAdi == kullanici.KullaniciAdi);

                if (kullaniciAdiCheck)
                {
                    throw new Exception("Kullanıcı adı zaten mevcut.");
                }

                if (checkBoxCheck && !kullaniciAdiCheck)
                {
                    kullanicilar.Add(kullanici);
                    Temizle();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                JsonSerializer.Serialize(fileStream, kullanicilar);
            }






        }

        public void Temizle()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = string.Empty;
                }
                if (control is CheckBox chk)
                {
                    chk.Checked = false;
                }
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
