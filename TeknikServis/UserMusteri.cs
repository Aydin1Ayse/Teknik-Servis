using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace TeknikServis
{
    public partial class UserMusteri : UserControl
    {
        SQLiteConnection baglanti = new SQLiteConnection("Data Source = dbTeknikServis.db; Version = 3");

        public UserMusteri()
        {
            InitializeComponent();
        }

        private void textbox_temizle()
        {
            txtMusteriTc.Text = string.Empty;
            txtMusteriAd.Text = string.Empty;
            txtMusteriSoyad.Text = string.Empty;
            txtMusteriTelefon.Text = string.Empty;
            txtMusteriAdres.Text = string.Empty;

            txtMusteriTc.Focus();
        }

        private void UserMusteri_Load(object sender, EventArgs e)
        {
            txtMusteriTc.Focus();
        }

        private void UserMusteri_VisibleChanged(object sender, EventArgs e)
        {
            textbox_temizle();
        }

        private void btnMusteriKaydet_Click(object sender, EventArgs e)
        {
            SQLiteCommand sorgu = new SQLiteCommand("insert into tblMusteriler (musteri_tc, musteri_ad, musteri_soyad, musteri_cepno, musteri_adres) values (@Tc, @Ad, @Soyad, @Telefon, @Adres)", baglanti);

            sorgu.Parameters.AddWithValue("@Tc", txtMusteriTc.Text);
            sorgu.Parameters.AddWithValue("@Ad", txtMusteriAd.Text);
            sorgu.Parameters.AddWithValue("@Soyad", txtMusteriSoyad.Text);
            sorgu.Parameters.AddWithValue("@Telefon", txtMusteriTelefon.Text);
            sorgu.Parameters.AddWithValue("@Adres", txtMusteriAdres.Text);

            baglanti.Open();
            sorgu.ExecuteNonQuery();
            MessageBox.Show("Müsteri kaydı başarıyla yapıldı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();

            textbox_temizle();
        }
    }
}
