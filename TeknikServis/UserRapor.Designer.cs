namespace TeknikServis
{
    partial class UserRapor
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCalisanMaas = new System.Windows.Forms.TextBox();
            this.txtCalisanSoyad = new System.Windows.Forms.TextBox();
            this.txtCalisanAd = new System.Windows.Forms.TextBox();
            this.txtCalisanTc = new System.Windows.Forms.TextBox();
            this.cmbCalisanSec = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvMusteriler = new System.Windows.Forms.DataGridView();
            this.musteri_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteri_tc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteri_ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteri_soyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteri_cepno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteri_adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMusteriler = new System.Windows.Forms.Button();
            this.btnCalisanlar = new System.Windows.Forms.Button();
            this.btnIslemler = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvIslemler = new System.Windows.Forms.DataGridView();
            this.yapilanIs_musteri_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yapilanIs_Bilgisayar_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alim_tarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teslim_tarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamir_aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamir_ucreti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIslemler)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txtCalisanMaas);
            this.groupBox1.Controls.Add(this.txtCalisanSoyad);
            this.groupBox1.Controls.Add(this.txtCalisanAd);
            this.groupBox1.Controls.Add(this.txtCalisanTc);
            this.groupBox1.Controls.Add(this.cmbCalisanSec);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 292);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tüm Çalışanlar";
            this.groupBox1.Visible = false;
            // 
            // txtCalisanMaas
            // 
            this.txtCalisanMaas.Location = new System.Drawing.Point(179, 154);
            this.txtCalisanMaas.Name = "txtCalisanMaas";
            this.txtCalisanMaas.Size = new System.Drawing.Size(359, 23);
            this.txtCalisanMaas.TabIndex = 4;
            // 
            // txtCalisanSoyad
            // 
            this.txtCalisanSoyad.Location = new System.Drawing.Point(179, 125);
            this.txtCalisanSoyad.Name = "txtCalisanSoyad";
            this.txtCalisanSoyad.Size = new System.Drawing.Size(359, 23);
            this.txtCalisanSoyad.TabIndex = 3;
            // 
            // txtCalisanAd
            // 
            this.txtCalisanAd.Location = new System.Drawing.Point(179, 96);
            this.txtCalisanAd.Name = "txtCalisanAd";
            this.txtCalisanAd.Size = new System.Drawing.Size(359, 23);
            this.txtCalisanAd.TabIndex = 2;
            // 
            // txtCalisanTc
            // 
            this.txtCalisanTc.Location = new System.Drawing.Point(179, 67);
            this.txtCalisanTc.Name = "txtCalisanTc";
            this.txtCalisanTc.Size = new System.Drawing.Size(359, 23);
            this.txtCalisanTc.TabIndex = 1;
            // 
            // cmbCalisanSec
            // 
            this.cmbCalisanSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCalisanSec.FormattingEnabled = true;
            this.cmbCalisanSec.Location = new System.Drawing.Point(91, 22);
            this.cmbCalisanSec.Name = "cmbCalisanSec";
            this.cmbCalisanSec.Size = new System.Drawing.Size(447, 24);
            this.cmbCalisanSec.TabIndex = 0;
            this.cmbCalisanSec.SelectedIndexChanged += new System.EventHandler(this.cmbCalisanSec_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Maaş:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Soyad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Çalişan Seç:";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(222, 209);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(100, 50);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.dgvMusteriler);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 292);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tüm Müşteriler";
            this.groupBox2.Visible = false;
            // 
            // dgvMusteriler
            // 
            this.dgvMusteriler.AllowUserToAddRows = false;
            this.dgvMusteriler.AllowUserToDeleteRows = false;
            this.dgvMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteriler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteri_id,
            this.musteri_tc,
            this.musteri_ad,
            this.musteri_soyad,
            this.musteri_cepno,
            this.musteri_adres});
            this.dgvMusteriler.Location = new System.Drawing.Point(6, 22);
            this.dgvMusteriler.Name = "dgvMusteriler";
            this.dgvMusteriler.ReadOnly = true;
            this.dgvMusteriler.RowHeadersVisible = false;
            this.dgvMusteriler.Size = new System.Drawing.Size(532, 264);
            this.dgvMusteriler.TabIndex = 0;
            // 
            // musteri_id
            // 
            this.musteri_id.DataPropertyName = "musteri_id";
            this.musteri_id.HeaderText = "No";
            this.musteri_id.Name = "musteri_id";
            this.musteri_id.ReadOnly = true;
            this.musteri_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.musteri_id.Width = 45;
            // 
            // musteri_tc
            // 
            this.musteri_tc.DataPropertyName = "musteri_tc";
            this.musteri_tc.HeaderText = "TC";
            this.musteri_tc.Name = "musteri_tc";
            this.musteri_tc.ReadOnly = true;
            this.musteri_tc.Width = 95;
            // 
            // musteri_ad
            // 
            this.musteri_ad.DataPropertyName = "musteri_ad";
            this.musteri_ad.HeaderText = "Ad";
            this.musteri_ad.Name = "musteri_ad";
            this.musteri_ad.ReadOnly = true;
            this.musteri_ad.Width = 95;
            // 
            // musteri_soyad
            // 
            this.musteri_soyad.DataPropertyName = "musteri_soyad";
            this.musteri_soyad.HeaderText = "Soyad";
            this.musteri_soyad.Name = "musteri_soyad";
            this.musteri_soyad.ReadOnly = true;
            this.musteri_soyad.Width = 95;
            // 
            // musteri_cepno
            // 
            this.musteri_cepno.DataPropertyName = "musteri_cepno";
            this.musteri_cepno.HeaderText = "Telefon";
            this.musteri_cepno.Name = "musteri_cepno";
            this.musteri_cepno.ReadOnly = true;
            this.musteri_cepno.Width = 95;
            // 
            // musteri_adres
            // 
            this.musteri_adres.DataPropertyName = "musteri_adres";
            this.musteri_adres.HeaderText = "Adres";
            this.musteri_adres.Name = "musteri_adres";
            this.musteri_adres.ReadOnly = true;
            // 
            // btnMusteriler
            // 
            this.btnMusteriler.Location = new System.Drawing.Point(200, 124);
            this.btnMusteriler.Name = "btnMusteriler";
            this.btnMusteriler.Size = new System.Drawing.Size(150, 50);
            this.btnMusteriler.TabIndex = 1;
            this.btnMusteriler.Text = "Müşteriler";
            this.btnMusteriler.UseVisualStyleBackColor = true;
            this.btnMusteriler.Click += new System.EventHandler(this.btnMusteriler_Click);
            // 
            // btnCalisanlar
            // 
            this.btnCalisanlar.Location = new System.Drawing.Point(44, 124);
            this.btnCalisanlar.Name = "btnCalisanlar";
            this.btnCalisanlar.Size = new System.Drawing.Size(150, 50);
            this.btnCalisanlar.TabIndex = 1;
            this.btnCalisanlar.Text = "Çalışanlar";
            this.btnCalisanlar.UseVisualStyleBackColor = true;
            this.btnCalisanlar.Click += new System.EventHandler(this.btnCalisanlar_Click);
            // 
            // btnIslemler
            // 
            this.btnIslemler.Location = new System.Drawing.Point(356, 124);
            this.btnIslemler.Name = "btnIslemler";
            this.btnIslemler.Size = new System.Drawing.Size(150, 50);
            this.btnIslemler.TabIndex = 1;
            this.btnIslemler.Text = "İşlemler";
            this.btnIslemler.UseVisualStyleBackColor = true;
            this.btnIslemler.Click += new System.EventHandler(this.btnIslemler_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.dgvIslemler);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(544, 292);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tüm İşlemler";
            this.groupBox3.Visible = false;
            // 
            // dgvIslemler
            // 
            this.dgvIslemler.AllowUserToAddRows = false;
            this.dgvIslemler.AllowUserToDeleteRows = false;
            this.dgvIslemler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIslemler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yapilanIs_musteri_id,
            this.yapilanIs_Bilgisayar_id,
            this.alim_tarihi,
            this.teslim_tarihi,
            this.tamir_aciklama,
            this.tamir_ucreti});
            this.dgvIslemler.Location = new System.Drawing.Point(6, 22);
            this.dgvIslemler.Name = "dgvIslemler";
            this.dgvIslemler.ReadOnly = true;
            this.dgvIslemler.RowHeadersVisible = false;
            this.dgvIslemler.Size = new System.Drawing.Size(532, 264);
            this.dgvIslemler.TabIndex = 0;
            // 
            // yapilanIs_musteri_id
            // 
            this.yapilanIs_musteri_id.DataPropertyName = "musteri_id";
            this.yapilanIs_musteri_id.HeaderText = "Musteri";
            this.yapilanIs_musteri_id.Name = "yapilanIs_musteri_id";
            this.yapilanIs_musteri_id.ReadOnly = true;
            this.yapilanIs_musteri_id.Width = 60;
            // 
            // yapilanIs_Bilgisayar_id
            // 
            this.yapilanIs_Bilgisayar_id.DataPropertyName = "bilgisayar_id";
            this.yapilanIs_Bilgisayar_id.HeaderText = "Bilgisayar";
            this.yapilanIs_Bilgisayar_id.Name = "yapilanIs_Bilgisayar_id";
            this.yapilanIs_Bilgisayar_id.ReadOnly = true;
            this.yapilanIs_Bilgisayar_id.Width = 70;
            // 
            // alim_tarihi
            // 
            this.alim_tarihi.DataPropertyName = "alim_tarihi";
            this.alim_tarihi.HeaderText = "G. Tarih";
            this.alim_tarihi.Name = "alim_tarihi";
            this.alim_tarihi.ReadOnly = true;
            // 
            // teslim_tarihi
            // 
            this.teslim_tarihi.DataPropertyName = "teslim_tarihi";
            this.teslim_tarihi.HeaderText = "Ç. Tarih";
            this.teslim_tarihi.Name = "teslim_tarihi";
            this.teslim_tarihi.ReadOnly = true;
            // 
            // tamir_aciklama
            // 
            this.tamir_aciklama.DataPropertyName = "tamir_aciklama";
            this.tamir_aciklama.HeaderText = "Açıklama";
            this.tamir_aciklama.Name = "tamir_aciklama";
            this.tamir_aciklama.ReadOnly = true;
            // 
            // tamir_ucreti
            // 
            this.tamir_ucreti.DataPropertyName = "tamir_ucreti";
            this.tamir_ucreti.HeaderText = "Ücret";
            this.tamir_ucreti.Name = "tamir_ucreti";
            this.tamir_ucreti.ReadOnly = true;
            this.tamir_ucreti.Width = 95;
            // 
            // UserRapor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnIslemler);
            this.Controls.Add(this.btnCalisanlar);
            this.Controls.Add(this.btnMusteriler);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "UserRapor";
            this.Size = new System.Drawing.Size(550, 298);
            this.VisibleChanged += new System.EventHandler(this.UserRapor_VisibleChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriler)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIslemler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvMusteriler;
        private System.Windows.Forms.Button btnMusteriler;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteri_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteri_tc;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteri_ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteri_soyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteri_cepno;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteri_adres;
        private System.Windows.Forms.Button btnCalisanlar;
        private System.Windows.Forms.ComboBox cmbCalisanSec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtCalisanMaas;
        private System.Windows.Forms.TextBox txtCalisanSoyad;
        private System.Windows.Forms.TextBox txtCalisanAd;
        private System.Windows.Forms.TextBox txtCalisanTc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIslemler;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvIslemler;
        private System.Windows.Forms.DataGridViewTextBoxColumn yapilanIs_musteri_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn yapilanIs_Bilgisayar_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn alim_tarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn teslim_tarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamir_aciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamir_ucreti;
    }
}
