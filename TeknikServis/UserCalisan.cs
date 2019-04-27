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
    public partial class UserCalisan : UserControl
    {
        SQLiteConnection baglanti = new SQLiteConnection("Data Source = dbTeknikServis.db; Version = 3");

        public UserCalisan()
        {
            InitializeComponent();
        }

        private void textbox_temizle()
        {
            txtCalisanTc.Text = string.Empty;
            txtCalisanAd.Text = string.Empty;
            txtCalisanSoyad.Text = string.Empty;
            txtCalisanMaas.Text = string.Empty;

            txtCalisanTc.Focus();
        }

        private void UserCalisan_Load(object sender, EventArgs e)
        {
            txtCalisanTc.Focus();
        }

        private void UserCalisan_VisibleChanged(object sender, EventArgs e)
        {
            textbox_temizle();
        }

        private void btnCalisanKaydet_Click(object sender, EventArgs e)
        {
            SQLiteCommand sorgu = new SQLiteCommand("insert into tblCalisanlar (calisan_tc, calisan_ad, calisan_soyad, calisan_maas) values (@Tc, @Ad, @Soyad, @Maas)", baglanti);

            sorgu.Parameters.AddWithValue("@Tc", txtCalisanTc.Text);
            sorgu.Parameters.AddWithValue("@Ad", txtCalisanAd.Text);
            sorgu.Parameters.AddWithValue("@Soyad", txtCalisanSoyad.Text);
            sorgu.Parameters.AddWithValue("@Maas", txtCalisanMaas.Text);

            baglanti.Open();
            sorgu.ExecuteNonQuery();
            MessageBox.Show("Çalışan kaydı başarıyla yapıldı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();

            textbox_temizle();
        }
    }
}
