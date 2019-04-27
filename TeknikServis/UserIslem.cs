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
using System.Threading;

namespace TeknikServis
{
    public partial class UserIslem : UserControl
    {
        SQLiteConnection baglanti = new SQLiteConnection("Data Source = dbTeknikServis.db; Version = 3");

        string bilgisayar_id, calisan_id, musteri_id;

        public UserIslem()
        {
            InitializeComponent();
        }

        private void alan_temizle()
        {
            cmbTeslimAlan.Items.Clear();
            cmbMusteriGiris.Items.Clear();
            txtBilgisayarMarka.Text = string.Empty;
            txtBilgisayarModel.Text = string.Empty;
            txtAciklamaGiriş.Text = string.Empty;

            cmbTeslimEden.Items.Clear();
            cmbMusteriCikis.Items.Clear();
            cmbBilgisayarCikis.Items.Clear();
            txtAciklamaCikis.Text = string.Empty;
            txtUcret.Text = string.Empty;
        }

        private void combobox_doldur(ComboBox comboBox, string _sorgu, string[] alanlar)
        {
            SQLiteCommand sorgu = new SQLiteCommand(_sorgu, baglanti);

            baglanti.Open();
            SQLiteDataReader dr = sorgu.ExecuteReader();

            while (dr.Read())
            {
                comboBox.Items.Add(dr[alanlar[0]] + " " + dr[alanlar[1]].ToString());
            }

            baglanti.Close();
        }

        private void UserIslem_VisibleChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;

            btnGiris.Visible = true;
            btnCikis.Visible = true;

            alan_temizle();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            alan_temizle();

            groupBox1.Visible = true;
            groupBox2.Visible = false;

            string[] alanlar_calisan = { "calisan_ad", "calisan_soyad" };
            combobox_doldur(cmbTeslimAlan, "select * from tblCalisanlar", alanlar_calisan);

            string[] alanlar_musteri = { "musteri_ad", "musteri_soyad" };
            combobox_doldur(cmbMusteriGiris, "select * from tblMusteriler", alanlar_musteri);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            alan_temizle();

            groupBox1.Visible = false;
            groupBox2.Visible = true;

            string[] alanlar_calisan = { "calisan_ad", "calisan_soyad" };
            combobox_doldur(cmbTeslimEden, "select * from tblCalisanlar", alanlar_calisan);

            string[] alanlar_musteri = { "musteri_ad", "musteri_soyad" };
            combobox_doldur(cmbMusteriCikis, "select * from tblMusteriler", alanlar_musteri);

            string[] alanlar_bilgisayar = { "bilgisayar_marka", "bilgisayar_model" };
            combobox_doldur(cmbBilgisayarCikis, "select * from tblBilgisayarlar", alanlar_bilgisayar);
        }

        private void button_gizle(object sender, EventArgs e)
        {
            btnGiris.Visible = false;
            btnCikis.Visible = false;
        }

        private void btnGeriGiris_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;

            btnGiris.Visible = true;
            btnCikis.Visible = true;
        }

        private void btnGeriCikis_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;

            btnGiris.Visible = true;
            btnCikis.Visible = true;
        }

        private void cmbTeslimAlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLiteCommand sorgu = new SQLiteCommand("select * from tblCalisanlar where calisan_ad = @calisan_ad and calisan_soyad = @calisan_soyad", baglanti);

            sorgu.Parameters.AddWithValue("@calisan_ad", cmbTeslimAlan.Text.Split(' ')[0]);
            sorgu.Parameters.AddWithValue("@calisan_soyad", cmbTeslimAlan.Text.Split(' ')[1]);

            baglanti.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter(sorgu);
            DataTable dt = new DataTable();
            da.Fill(dt);

            calisan_id = dt.Rows[0][0].ToString();
            baglanti.Close();
        }

        private void cmbMusteriGiris_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLiteCommand sorgu = new SQLiteCommand("select * from tblMusteriler where musteri_ad = @musteri_ad and musteri_soyad = @musteri_soyad", baglanti);

            sorgu.Parameters.AddWithValue("@musteri_ad", cmbMusteriGiris.Text.Split(' ')[0]);
            sorgu.Parameters.AddWithValue("@musteri_soyad", cmbMusteriGiris.Text.Split(' ')[1]);

            baglanti.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter(sorgu);
            DataTable dt = new DataTable();
            da.Fill(dt);

            musteri_id = dt.Rows[0][0].ToString();
            baglanti.Close();
        }

        private void cmbTeslimEden_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLiteCommand sorgu = new SQLiteCommand("select * from tblCalisanlar where calisan_ad = @calisan_ad and calisan_soyad = @calisan_soyad", baglanti);

            sorgu.Parameters.AddWithValue("@calisan_ad", cmbTeslimEden.Text.Split(' ')[0]);
            sorgu.Parameters.AddWithValue("@calisan_soyad", cmbTeslimEden.Text.Split(' ')[1]);

            baglanti.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter(sorgu);
            DataTable dt = new DataTable();
            da.Fill(dt);

            calisan_id = dt.Rows[0][0].ToString();
            baglanti.Close();
        }

        private void cmbMusteriCikis_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLiteCommand sorgu = new SQLiteCommand("select * from tblMusteriler where musteri_ad = @musteri_ad and musteri_soyad = @musteri_soyad", baglanti);

            sorgu.Parameters.AddWithValue("@musteri_ad", cmbMusteriCikis.Text.Split(' ')[0]);
            sorgu.Parameters.AddWithValue("@musteri_soyad", cmbMusteriCikis.Text.Split(' ')[1]);

            baglanti.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter(sorgu);
            DataTable dt = new DataTable();
            da.Fill(dt);

            musteri_id = dt.Rows[0][0].ToString();
            baglanti.Close();
        }

        private void cmbBilgisayarCikis_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLiteCommand sorgu = new SQLiteCommand("select * from tblBilgisayarlar where bilgisayar_marka = @bilgisayar_marka and bilgisayar_model = @bilgisayar_model", baglanti);

            sorgu.Parameters.AddWithValue("@bilgisayar_marka", cmbBilgisayarCikis.Text.Split(' ')[0]);
            sorgu.Parameters.AddWithValue("@bilgisayar_model", cmbBilgisayarCikis.Text.Split(' ')[1]);

            baglanti.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter(sorgu);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();

            bilgisayar_id = dt.Rows[0][0].ToString();
        }

        private void btnIslemKaydetGiris_Click(object sender, EventArgs e)
        {
            SQLiteCommand sorgu_1 = new SQLiteCommand("insert into tblBilgisayarlar (bilgisayar_marka, bilgisayar_model) values (@bilgisayar_marka, @bilgisayar_model)", baglanti);

            sorgu_1.Parameters.AddWithValue("@bilgisayar_marka", txtBilgisayarMarka.Text);
            sorgu_1.Parameters.AddWithValue("@bilgisayar_model", txtBilgisayarModel.Text);

            baglanti.Open();
            sorgu_1.ExecuteNonQuery();
            baglanti.Close();

            SQLiteCommand sorgu_2 = new SQLiteCommand("select * from tblBilgisayarlar where bilgisayar_marka = @bilgisayar_marka and bilgisayar_model = @bilgisayar_model", baglanti);

            sorgu_2.Parameters.AddWithValue("@bilgisayar_marka", txtBilgisayarMarka.Text);
            sorgu_2.Parameters.AddWithValue("@bilgisayar_model", txtBilgisayarModel.Text);

            baglanti.Open();
            SQLiteDataAdapter da = new SQLiteDataAdapter(sorgu_2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();

            bilgisayar_id = dt.Rows[0][0].ToString();

            SQLiteCommand sorgu_3 = new SQLiteCommand("insert into tblYapilanIs (bilgisayar_id, calisan_id, musteri_id, alim_tarihi, tamir_aciklama) values (@bilgisayar_id, @calisan_id, @musteri_id, @alim_tarihi, @tamir_aciklama)", baglanti);

            sorgu_3.Parameters.AddWithValue("@bilgisayar_id", bilgisayar_id);
            sorgu_3.Parameters.AddWithValue("@calisan_id", calisan_id);
            sorgu_3.Parameters.AddWithValue("@musteri_id", musteri_id);
            sorgu_3.Parameters.AddWithValue("@alim_tarihi", DateTime.Now.ToLongDateString());
            sorgu_3.Parameters.AddWithValue("@tamir_aciklama", txtAciklamaGiriş.Text);

            baglanti.Open();
            sorgu_3.ExecuteNonQuery();
            MessageBox.Show("İşlem kaydı başarıyla yapıldı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();

            groupBox1.Visible = false;

            btnGiris.Visible = true;
            btnCikis.Visible = true;
        }

        private void btnIslemKaydetCikis_Click(object sender, EventArgs e)
        {
            SQLiteCommand sorgu = new SQLiteCommand("insert into tblYapilanIs (bilgisayar_id, calisan_id, musteri_id, teslim_tarihi, tamir_aciklama, tamir_ucreti) values (@bilgisayar_id, @calisan_id, @musteri_id, @teslim_tarihi, @tamir_aciklama, @tamir_ucreti)", baglanti);

            sorgu.Parameters.AddWithValue("@bilgisayar_id", bilgisayar_id);
            sorgu.Parameters.AddWithValue("@calisan_id", calisan_id);
            sorgu.Parameters.AddWithValue("@musteri_id", musteri_id);
            sorgu.Parameters.AddWithValue("@teslim_tarihi", DateTime.Now.ToLongDateString());
            sorgu.Parameters.AddWithValue("@tamir_aciklama", txtAciklamaCikis.Text);
            sorgu.Parameters.AddWithValue("@tamir_ucreti", txtUcret.Text);

            baglanti.Open();
            sorgu.ExecuteNonQuery();
            MessageBox.Show("İşlem kaydı başarıyla yapıldı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();

            groupBox2.Visible = false;

            btnGiris.Visible = true;
            btnCikis.Visible = true;
        }
    }
}
