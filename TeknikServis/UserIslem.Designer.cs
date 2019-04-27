namespace TeknikServis
{
    partial class UserIslem
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
            this.cmbMusteriGiris = new System.Windows.Forms.ComboBox();
            this.cmbTeslimAlan = new System.Windows.Forms.ComboBox();
            this.btnGeriGiris = new System.Windows.Forms.Button();
            this.btnIslemKaydetGiris = new System.Windows.Forms.Button();
            this.txtAciklamaGiriş = new System.Windows.Forms.TextBox();
            this.txtBilgisayarModel = new System.Windows.Forms.TextBox();
            this.txtBilgisayarMarka = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbBilgisayarCikis = new System.Windows.Forms.ComboBox();
            this.cmbMusteriCikis = new System.Windows.Forms.ComboBox();
            this.cmbTeslimEden = new System.Windows.Forms.ComboBox();
            this.btnGeriCikis = new System.Windows.Forms.Button();
            this.btnIslemKaydetCikis = new System.Windows.Forms.Button();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAciklamaCikis = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.cmbMusteriGiris);
            this.groupBox1.Controls.Add(this.cmbTeslimAlan);
            this.groupBox1.Controls.Add(this.btnGeriGiris);
            this.groupBox1.Controls.Add(this.btnIslemKaydetGiris);
            this.groupBox1.Controls.Add(this.txtAciklamaGiriş);
            this.groupBox1.Controls.Add(this.txtBilgisayarModel);
            this.groupBox1.Controls.Add(this.txtBilgisayarMarka);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 292);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni İşlem Kaydı - Giriş";
            this.groupBox1.Visible = false;
            this.groupBox1.VisibleChanged += new System.EventHandler(this.button_gizle);
            // 
            // cmbMusteriGiris
            // 
            this.cmbMusteriGiris.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMusteriGiris.FormattingEnabled = true;
            this.cmbMusteriGiris.Location = new System.Drawing.Point(160, 79);
            this.cmbMusteriGiris.Name = "cmbMusteriGiris";
            this.cmbMusteriGiris.Size = new System.Drawing.Size(334, 24);
            this.cmbMusteriGiris.TabIndex = 1;
            this.cmbMusteriGiris.SelectedIndexChanged += new System.EventHandler(this.cmbMusteriGiris_SelectedIndexChanged);
            // 
            // cmbTeslimAlan
            // 
            this.cmbTeslimAlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeslimAlan.FormattingEnabled = true;
            this.cmbTeslimAlan.Location = new System.Drawing.Point(160, 50);
            this.cmbTeslimAlan.Name = "cmbTeslimAlan";
            this.cmbTeslimAlan.Size = new System.Drawing.Size(334, 24);
            this.cmbTeslimAlan.TabIndex = 0;
            this.cmbTeslimAlan.SelectedIndexChanged += new System.EventHandler(this.cmbTeslimAlan_SelectedIndexChanged);
            // 
            // btnGeriGiris
            // 
            this.btnGeriGiris.Location = new System.Drawing.Point(288, 236);
            this.btnGeriGiris.Name = "btnGeriGiris";
            this.btnGeriGiris.Size = new System.Drawing.Size(100, 35);
            this.btnGeriGiris.TabIndex = 6;
            this.btnGeriGiris.Text = "< Geri";
            this.btnGeriGiris.UseVisualStyleBackColor = true;
            this.btnGeriGiris.Click += new System.EventHandler(this.btnGeriGiris_Click);
            // 
            // btnIslemKaydetGiris
            // 
            this.btnIslemKaydetGiris.Location = new System.Drawing.Point(394, 236);
            this.btnIslemKaydetGiris.Name = "btnIslemKaydetGiris";
            this.btnIslemKaydetGiris.Size = new System.Drawing.Size(100, 35);
            this.btnIslemKaydetGiris.TabIndex = 5;
            this.btnIslemKaydetGiris.Text = "Kaydet";
            this.btnIslemKaydetGiris.UseVisualStyleBackColor = true;
            this.btnIslemKaydetGiris.Click += new System.EventHandler(this.btnIslemKaydetGiris_Click);
            // 
            // txtAciklamaGiriş
            // 
            this.txtAciklamaGiriş.Location = new System.Drawing.Point(160, 162);
            this.txtAciklamaGiriş.Name = "txtAciklamaGiriş";
            this.txtAciklamaGiriş.Size = new System.Drawing.Size(334, 23);
            this.txtAciklamaGiriş.TabIndex = 4;
            // 
            // txtBilgisayarModel
            // 
            this.txtBilgisayarModel.Location = new System.Drawing.Point(394, 133);
            this.txtBilgisayarModel.Name = "txtBilgisayarModel";
            this.txtBilgisayarModel.Size = new System.Drawing.Size(100, 23);
            this.txtBilgisayarModel.TabIndex = 3;
            // 
            // txtBilgisayarMarka
            // 
            this.txtBilgisayarMarka.Location = new System.Drawing.Point(160, 133);
            this.txtBilgisayarMarka.Name = "txtBilgisayarMarka";
            this.txtBilgisayarMarka.Size = new System.Drawing.Size(100, 23);
            this.txtBilgisayarMarka.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Açıklama:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bilgisatar Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bilgisatar Marka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Müşteri:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teslim Alan:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.cmbBilgisayarCikis);
            this.groupBox2.Controls.Add(this.cmbMusteriCikis);
            this.groupBox2.Controls.Add(this.cmbTeslimEden);
            this.groupBox2.Controls.Add(this.btnGeriCikis);
            this.groupBox2.Controls.Add(this.btnIslemKaydetCikis);
            this.groupBox2.Controls.Add(this.txtUcret);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtAciklamaCikis);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 292);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yeni İşlem Kaydı - Çıkış";
            this.groupBox2.Visible = false;
            this.groupBox2.VisibleChanged += new System.EventHandler(this.button_gizle);
            // 
            // cmbBilgisayarCikis
            // 
            this.cmbBilgisayarCikis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBilgisayarCikis.FormattingEnabled = true;
            this.cmbBilgisayarCikis.Location = new System.Drawing.Point(160, 133);
            this.cmbBilgisayarCikis.Name = "cmbBilgisayarCikis";
            this.cmbBilgisayarCikis.Size = new System.Drawing.Size(334, 24);
            this.cmbBilgisayarCikis.TabIndex = 1;
            this.cmbBilgisayarCikis.SelectedIndexChanged += new System.EventHandler(this.cmbBilgisayarCikis_SelectedIndexChanged);
            // 
            // cmbMusteriCikis
            // 
            this.cmbMusteriCikis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMusteriCikis.FormattingEnabled = true;
            this.cmbMusteriCikis.Location = new System.Drawing.Point(160, 79);
            this.cmbMusteriCikis.Name = "cmbMusteriCikis";
            this.cmbMusteriCikis.Size = new System.Drawing.Size(334, 24);
            this.cmbMusteriCikis.TabIndex = 1;
            this.cmbMusteriCikis.SelectedIndexChanged += new System.EventHandler(this.cmbMusteriCikis_SelectedIndexChanged);
            // 
            // cmbTeslimEden
            // 
            this.cmbTeslimEden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeslimEden.FormattingEnabled = true;
            this.cmbTeslimEden.Location = new System.Drawing.Point(160, 50);
            this.cmbTeslimEden.Name = "cmbTeslimEden";
            this.cmbTeslimEden.Size = new System.Drawing.Size(334, 24);
            this.cmbTeslimEden.TabIndex = 0;
            this.cmbTeslimEden.SelectedIndexChanged += new System.EventHandler(this.cmbTeslimEden_SelectedIndexChanged);
            // 
            // btnGeriCikis
            // 
            this.btnGeriCikis.Location = new System.Drawing.Point(288, 236);
            this.btnGeriCikis.Name = "btnGeriCikis";
            this.btnGeriCikis.Size = new System.Drawing.Size(100, 35);
            this.btnGeriCikis.TabIndex = 6;
            this.btnGeriCikis.Text = "< Geri";
            this.btnGeriCikis.UseVisualStyleBackColor = true;
            this.btnGeriCikis.Click += new System.EventHandler(this.btnGeriCikis_Click);
            // 
            // btnIslemKaydetCikis
            // 
            this.btnIslemKaydetCikis.Location = new System.Drawing.Point(394, 236);
            this.btnIslemKaydetCikis.Name = "btnIslemKaydetCikis";
            this.btnIslemKaydetCikis.Size = new System.Drawing.Size(100, 35);
            this.btnIslemKaydetCikis.TabIndex = 5;
            this.btnIslemKaydetCikis.Text = "Kaydet";
            this.btnIslemKaydetCikis.UseVisualStyleBackColor = true;
            this.btnIslemKaydetCikis.Click += new System.EventHandler(this.btnIslemKaydetCikis_Click);
            // 
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(160, 191);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(334, 23);
            this.txtUcret.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ücret:";
            // 
            // txtAciklamaCikis
            // 
            this.txtAciklamaCikis.Location = new System.Drawing.Point(160, 162);
            this.txtAciklamaCikis.Name = "txtAciklamaCikis";
            this.txtAciklamaCikis.Size = new System.Drawing.Size(334, 23);
            this.txtAciklamaCikis.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Açıklama:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Bilgisatar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Müşteri:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Teslim Eden:";
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(122, 124);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(150, 50);
            this.btnGiris.TabIndex = 0;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(278, 124);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(150, 50);
            this.btnCikis.TabIndex = 1;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // UserIslem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "UserIslem";
            this.Size = new System.Drawing.Size(550, 298);
            this.VisibleChanged += new System.EventHandler(this.UserIslem_VisibleChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAciklamaGiriş;
        private System.Windows.Forms.TextBox txtBilgisayarMarka;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMusteriGiris;
        private System.Windows.Forms.ComboBox cmbTeslimAlan;
        private System.Windows.Forms.TextBox txtBilgisayarModel;
        private System.Windows.Forms.Button btnIslemKaydetGiris;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbBilgisayarCikis;
        private System.Windows.Forms.ComboBox cmbMusteriCikis;
        private System.Windows.Forms.ComboBox cmbTeslimEden;
        private System.Windows.Forms.Button btnIslemKaydetCikis;
        private System.Windows.Forms.TextBox txtAciklamaCikis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnGeriGiris;
        private System.Windows.Forms.Button btnGeriCikis;
    }
}
