namespace TeknikServis
{
    partial class UserCalisan
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
            this.btnCalisanKaydet = new System.Windows.Forms.Button();
            this.txtCalisanMaas = new System.Windows.Forms.TextBox();
            this.txtCalisanSoyad = new System.Windows.Forms.TextBox();
            this.txtCalisanAd = new System.Windows.Forms.TextBox();
            this.txtCalisanTc = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Controls.Add(this.btnCalisanKaydet);
            this.groupBox1.Controls.Add(this.txtCalisanMaas);
            this.groupBox1.Controls.Add(this.txtCalisanSoyad);
            this.groupBox1.Controls.Add(this.txtCalisanAd);
            this.groupBox1.Controls.Add(this.txtCalisanTc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 292);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Çalişan Kaydı";
            // 
            // btnCalisanKaydet
            // 
            this.btnCalisanKaydet.Location = new System.Drawing.Point(394, 209);
            this.btnCalisanKaydet.Name = "btnCalisanKaydet";
            this.btnCalisanKaydet.Size = new System.Drawing.Size(100, 35);
            this.btnCalisanKaydet.TabIndex = 4;
            this.btnCalisanKaydet.Text = "Kaydet";
            this.btnCalisanKaydet.UseVisualStyleBackColor = true;
            this.btnCalisanKaydet.Click += new System.EventHandler(this.btnCalisanKaydet_Click);
            // 
            // txtCalisanMaas
            // 
            this.txtCalisanMaas.Location = new System.Drawing.Point(141, 137);
            this.txtCalisanMaas.Name = "txtCalisanMaas";
            this.txtCalisanMaas.Size = new System.Drawing.Size(353, 23);
            this.txtCalisanMaas.TabIndex = 3;
            // 
            // txtCalisanSoyad
            // 
            this.txtCalisanSoyad.Location = new System.Drawing.Point(141, 108);
            this.txtCalisanSoyad.Name = "txtCalisanSoyad";
            this.txtCalisanSoyad.Size = new System.Drawing.Size(353, 23);
            this.txtCalisanSoyad.TabIndex = 2;
            // 
            // txtCalisanAd
            // 
            this.txtCalisanAd.Location = new System.Drawing.Point(141, 79);
            this.txtCalisanAd.Name = "txtCalisanAd";
            this.txtCalisanAd.Size = new System.Drawing.Size(353, 23);
            this.txtCalisanAd.TabIndex = 1;
            // 
            // txtCalisanTc
            // 
            this.txtCalisanTc.Location = new System.Drawing.Point(141, 50);
            this.txtCalisanTc.Name = "txtCalisanTc";
            this.txtCalisanTc.Size = new System.Drawing.Size(353, 23);
            this.txtCalisanTc.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Maaş:";
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
            // UserCalisan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "UserCalisan";
            this.Size = new System.Drawing.Size(550, 298);
            this.Load += new System.EventHandler(this.UserCalisan_Load);
            this.VisibleChanged += new System.EventHandler(this.UserCalisan_VisibleChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCalisanMaas;
        private System.Windows.Forms.TextBox txtCalisanSoyad;
        private System.Windows.Forms.TextBox txtCalisanAd;
        private System.Windows.Forms.TextBox txtCalisanTc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalisanKaydet;
    }
}
