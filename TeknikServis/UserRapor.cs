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
    public partial class UserRapor : UserControl
    {
        SQLiteConnection baglanti = new SQLiteConnection("Data Source = dbTeknikServis.db; Version = 3");

        string calisan_id;

        public UserRapor()
        {
            InitializeComponent();
        }

        private void combobox_doldur()
        {
            cmbCalisanSec.Items.Clear();

            string[] alanlar = { "calisan_ad", "calisan_soyad" };
            SQLiteCommand sorgu = new SQLiteCommand("select * from tblCalisanlar", baglanti);

            baglanti.Open();
            SQLiteDataReader dr = sorgu.ExecuteReader();

            while (dr.Read())
            {
                cmbCalisanSec.Items.Add(dr[alanlar[0]] + " " + dr[alanlar[1]].ToString());
            }

            baglanti.Close();

            txtCalisanTc.Text = string.Empty;
            txtCalisanAd.Text = string.Empty;
            txtCalisanSoyad.Text = string.Empty;
            txtCalisanMaas.Text = string.Empty;
        }

        private void UserRapor_VisibleChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;

            btnCalisanlar.Visible = true;
            btnMusteriler.Visible = true;
            btnIslemler.Visible = true;
        }

        private void btnCalisanlar_Click(object sender, EventArgs e)
        {
            btnCalisanlar.Visible = false;
            btnMusteriler.Visible = false;
            btnIslemler.Visible = false;
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;

            combobox_doldur();
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            btnCalisanlar.Visible = false;
            btnMusteriler.Visible = false;
            btnIslemler.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = false;

            SQLiteCommand sorgu = new SQLiteCommand("select * from tblMusteriler", baglanti);
            SQLiteDataAdapter da = new SQLiteDataAdapter(sorgu);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvMusteriler.DataSource = dt;
        }

        private void btnIslemler_Click(object sender, EventArgs e)
        {
            btnCalisanlar.Visible = false;
            btnMusteriler.Visible = false;
            btnIslemler.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;

            SQLiteCommand sorgu = new SQLiteCommand("select musteri_id, bilgisayar_id, alim_tarihi, teslim_tarihi, tamir_aciklama, tamir_ucreti from tblYapilanIs", baglanti);
            SQLiteDataAdapter da = new SQLiteDataAdapter(sorgu);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvIslemler.DataSource = dt;
        }

        private void cmbCalisanSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLiteCommand sorgu = new SQLiteCommand("select * from tblCalisanlar where calisan_ad = @calisan_ad and calisan_soyad = @calisan_soyad", baglanti);

            sorgu.Parameters.AddWithValue("@calisan_ad", cmbCalisanSec.Text.Split(' ')[0]);
            sorgu.Parameters.AddWithValue("@calisan_soyad", cmbCalisanSec.Text.Split(' ')[1]);

            baglanti.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter(sorgu);
            DataTable dt = new DataTable();
            da.Fill(dt);

            calisan_id = dt.Rows[0][0].ToString();
            txtCalisanTc.Text = dt.Rows[0][1].ToString();
            txtCalisanAd.Text = dt.Rows[0][2].ToString();
            txtCalisanSoyad.Text = dt.Rows[0][3].ToString();
            txtCalisanMaas.Text = dt.Rows[0][4].ToString();

            baglanti.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SQLiteCommand sorgu = new SQLiteCommand("update tblCalisanlar set calisan_tc = @calisan_tc, calisan_ad = @calisan_ad, calisan_soyad = @calisan_soyad, calisan_maas = @calisan_maas where calisan_id = @calisan_id", baglanti);

            sorgu.Parameters.AddWithValue("@calisan_id", calisan_id);
            sorgu.Parameters.AddWithValue("@calisan_tc", txtCalisanTc.Text);
            sorgu.Parameters.AddWithValue("@calisan_ad", txtCalisanAd.Text);
            sorgu.Parameters.AddWithValue("@calisan_soyad", txtCalisanSoyad.Text);
            sorgu.Parameters.AddWithValue("@calisan_maas", txtCalisanMaas.Text);

            baglanti.Open();
            sorgu.ExecuteNonQuery();
            MessageBox.Show("Güncelleme işlemi başarıyla gerçekleşti", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();

            combobox_doldur();
        }
    }
}
