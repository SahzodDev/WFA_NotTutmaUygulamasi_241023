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
    public partial class Form3 : Form
    {
        private readonly Kullanici _currentKullanici;
        const string filePath = "notlar.json";
        List<Not> notlar = new List<Not>();
        public Form3(Kullanici kullanici)
        {
            InitializeComponent();
            _currentKullanici = kullanici;

            if (File.Exists(filePath))
            {
                using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    if (stream.Length > 0)
                    {
                        notlar = JsonSerializer.Deserialize<List<Not>>(stream);
                    }
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            foreach (Not not in notlar)
            {
                if (not.NotunKullanicisi.KullaniciAdi == _currentKullanici.KullaniciAdi)
                {
                    lstNotlar.Items.Add(not);
                }
            }
        }

        private void btnNotEkle_Click(object sender, EventArgs e)
        {
            Not not = new Not()
            {
                NotBasligi = txtBaslik.Text,
                NotGovdesi = txtGovde.Text,
                NotunKullanicisi = _currentKullanici
            };


            notlar.Add(not);
            lstNotlar.Items.Add(not);

            Temizle();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                JsonSerializer.Serialize(fileStream, notlar);
            }
        }

        private void btnNotSil_Click(object sender, EventArgs e)
        {
            if (lstNotlar.SelectedItems.Count > 0)
            {
                Not seciliNot = (Not)lstNotlar.SelectedItem;



                lstNotlar.Items.Remove(seciliNot);

                notlar.Remove(seciliNot);
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
            }
        }

        private void lstNotlar_DoubleClick(object sender, EventArgs e)
        {
            btnNotEkle.Enabled = false;

            btnGuncelle.Enabled = true;

            Not seciliNot = (Not)lstNotlar.SelectedItem;

            txtBaslik.Text = seciliNot.NotBasligi;
            txtGovde.Text = seciliNot.NotGovdesi;


        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Not seciliNot = (Not)lstNotlar.SelectedItem;

            seciliNot.NotBasligi = txtBaslik.Text;
            seciliNot.NotGovdesi = txtGovde.Text;

            btnNotEkle.Enabled= true;

            Temizle();

            btnGuncelle.Enabled= false;
        }
    }
}
