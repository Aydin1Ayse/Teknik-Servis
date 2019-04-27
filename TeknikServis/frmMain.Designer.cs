namespace TeknikServis
{
    partial class frmMain
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnRapor = new System.Windows.Forms.Button();
            this.btnIslemEkle = new System.Windows.Forms.Button();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.btnCalisanEkle = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userRapor1 = new TeknikServis.UserRapor();
            this.userMusteri1 = new TeknikServis.UserMusteri();
            this.userCalisan1 = new TeknikServis.UserCalisan();
            this.userIslem1 = new TeknikServis.UserIslem();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.btnRapor);
            this.panel1.Controls.Add(this.btnIslemEkle);
            this.panel1.Controls.Add(this.btnMusteriEkle);
            this.panel1.Controls.Add(this.btnCalisanEkle);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 298);
            this.panel1.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(12, 197);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(176, 20);
            this.lblDate.TabIndex = 1;
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRapor
            // 
            this.btnRapor.BackColor = System.Drawing.SystemColors.Control;
            this.btnRapor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRapor.Location = new System.Drawing.Point(12, 236);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(176, 50);
            this.btnRapor.TabIndex = 0;
            this.btnRapor.TabStop = false;
            this.btnRapor.Text = "Rapor";
            this.btnRapor.UseVisualStyleBackColor = false;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // btnIslemEkle
            // 
            this.btnIslemEkle.BackColor = System.Drawing.SystemColors.Control;
            this.btnIslemEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIslemEkle.Location = new System.Drawing.Point(12, 124);
            this.btnIslemEkle.Name = "btnIslemEkle";
            this.btnIslemEkle.Size = new System.Drawing.Size(176, 50);
            this.btnIslemEkle.TabIndex = 0;
            this.btnIslemEkle.TabStop = false;
            this.btnIslemEkle.Text = "İşlem Ekle";
            this.btnIslemEkle.UseVisualStyleBackColor = false;
            this.btnIslemEkle.Click += new System.EventHandler(this.btnIslemEkle_Click);
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.BackColor = System.Drawing.SystemColors.Control;
            this.btnMusteriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriEkle.Location = new System.Drawing.Point(12, 68);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(176, 50);
            this.btnMusteriEkle.TabIndex = 0;
            this.btnMusteriEkle.TabStop = false;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = false;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // btnCalisanEkle
            // 
            this.btnCalisanEkle.BackColor = System.Drawing.SystemColors.Control;
            this.btnCalisanEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalisanEkle.Location = new System.Drawing.Point(12, 12);
            this.btnCalisanEkle.Name = "btnCalisanEkle";
            this.btnCalisanEkle.Size = new System.Drawing.Size(176, 50);
            this.btnCalisanEkle.TabIndex = 0;
            this.btnCalisanEkle.TabStop = false;
            this.btnCalisanEkle.Text = "Çalışan Ekle";
            this.btnCalisanEkle.UseVisualStyleBackColor = false;
            this.btnCalisanEkle.Click += new System.EventHandler(this.btnCalisanEkle_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.userRapor1);
            this.panel2.Controls.Add(this.userMusteri1);
            this.panel2.Controls.Add(this.userCalisan1);
            this.panel2.Controls.Add(this.userIslem1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(550, 298);
            this.panel2.TabIndex = 1;
            // 
            // userRapor1
            // 
            this.userRapor1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userRapor1.Location = new System.Drawing.Point(0, 0);
            this.userRapor1.Name = "userRapor1";
            this.userRapor1.Size = new System.Drawing.Size(550, 298);
            this.userRapor1.TabIndex = 2;
            this.userRapor1.Visible = false;
            this.userRapor1.Load += new System.EventHandler(this.userRapor1_Load);
            // 
            // userMusteri1
            // 
            this.userMusteri1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userMusteri1.Location = new System.Drawing.Point(0, 0);
            this.userMusteri1.Name = "userMusteri1";
            this.userMusteri1.Size = new System.Drawing.Size(550, 298);
            this.userMusteri1.TabIndex = 0;
            this.userMusteri1.Visible = false;
            // 
            // userCalisan1
            // 
            this.userCalisan1.BackColor = System.Drawing.SystemColors.Control;
            this.userCalisan1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userCalisan1.Location = new System.Drawing.Point(0, 0);
            this.userCalisan1.Name = "userCalisan1";
            this.userCalisan1.Size = new System.Drawing.Size(550, 298);
            this.userCalisan1.TabIndex = 0;
            this.userCalisan1.Visible = false;
            // 
            // userIslem1
            // 
            this.userIslem1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userIslem1.Location = new System.Drawing.Point(0, 0);
            this.userIslem1.Name = "userIslem1";
            this.userIslem1.Size = new System.Drawing.Size(550, 298);
            this.userIslem1.TabIndex = 1;
            this.userIslem1.Visible = false;
            // 
            // label1
            // 
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 298);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teknik Servis";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(750, 298);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teknik Servis";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCalisanEkle;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.Button btnIslemEkle;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel panel2;
        private UserMusteri userMusteri1;
        private UserCalisan userCalisan1;
        private UserIslem userIslem1;
        private System.Windows.Forms.Label label1;
        private UserRapor userRapor1;
    }
}

