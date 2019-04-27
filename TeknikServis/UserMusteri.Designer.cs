namespace TeknikServis
{
    partial class UserMusteri
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
            this.btnMusteriKaydet = new System.Windows.Forms.Button();
            this.txtMusteriAdres = new System.Windows.Forms.TextBox();
            this.txtMusteriTelefon = new System.Windows.Forms.TextBox();
            this.txtMusteriSoyad = new System.Windows.Forms.TextBox();
            this.txtMusteriAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMusteriTc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnMusteriKaydet);
            this.groupBox1.Controls.Add(this.txtMusteriAdres);
            this.groupBox1.Controls.Add(this.txtMusteriTelefon);
            this.groupBox1.Controls.Add(this.txtMusteriSoyad);
            this.groupBox1.Controls.Add(this.txtMusteriAd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMusteriTc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 292);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Müşteri Kaydı";
            // 
            // btnMusteriKaydet
            // 
            this.btnMusteriKaydet.Location = new System.Drawing.Point(394, 223);
            this.btnMusteriKaydet.Name = "btnMusteriKaydet";
            this.btnMusteriKaydet.Size = new System.Drawing.Size(100, 35);
            this.btnMusteriKaydet.TabIndex = 5;
            this.btnMusteriKaydet.Text = "Kaydet";
            this.btnMusteriKaydet.UseVisualStyleBackColor = true;
            this.btnMusteriKaydet.Click += new System.EventHandler(this.btnMusteriKaydet_Click);
            // 
            // txtMusteriAdres
            // 
            this.txtMusteriAdres.Location = new System.Drawing.Point(141, 166);
            this.txtMusteriAdres.Name = "txtMusteriAdres";
            this.txtMusteriAdres.Size = new System.Drawing.Size(353, 23);
            this.txtMusteriAdres.TabIndex = 4;
            // 
            // txtMusteriTelefon
            // 
            this.txtMusteriTelefon.Location = new System.Drawing.Point(141, 137);
            this.txtMusteriTelefon.Name = "txtMusteriTelefon";
            this.txtMusteriTelefon.Size = new System.Drawing.Size(353, 23);
            this.txtMusteriTelefon.TabIndex = 3;
            // 
            // txtMusteriSoyad
            // 
            this.txtMusteriSoyad.Location = new System.Drawing.Point(141, 108);
            this.txtMusteriSoyad.Name = "txtMusteriSoyad";
            this.txtMusteriSoyad.Size = new System.Drawing.Size(353, 23);
            this.txtMusteriSoyad.TabIndex = 2;
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.Location = new System.Drawing.Point(141, 79);
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.Size = new System.Drawing.Size(353, 23);
            this.txtMusteriAd.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Adres:";
            // 
            // txtMusteriTc
            // 
            this.txtMusteriTc.Location = new System.Drawing.Point(141, 50);
            this.txtMusteriTc.Name = "txtMusteriTc";
            this.txtMusteriTc.Size = new System.Drawing.Size(353, 23);
            this.txtMusteriTc.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No:";
            // 
            // UserMusteri
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "UserMusteri";
            this.Size = new System.Drawing.Size(550, 298);
            this.Load += new System.EventHandler(this.UserMusteri_Load);
            this.VisibleChanged += new System.EventHandler(this.UserMusteri_VisibleChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnMusteriKaydet;
        private System.Windows.Forms.TextBox txtMusteriTelefon;
        private System.Windows.Forms.TextBox txtMusteriSoyad;
        private System.Windows.Forms.TextBox txtMusteriAd;
        private System.Windows.Forms.TextBox txtMusteriTc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMusteriAdres;
        private System.Windows.Forms.Label label5;
    }
}
