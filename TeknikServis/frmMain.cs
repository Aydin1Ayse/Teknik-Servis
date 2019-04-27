using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace TeknikServis
{
    public partial class frmMain : Form
    {
        SQLiteConnection baglanti = new SQLiteConnection("Data Source = dbTeknikServis.db; Version = 3");

        public frmMain()
        {
            InitializeComponent();

            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void btnCalisanEkle_Click(object sender, EventArgs e)
        {
            userCalisan1.Visible = !userCalisan1.Visible;
            userIslem1.Visible = false;
            userMusteri1.Visible = false;
            userRapor1.Visible = false;
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            userCalisan1.Visible = false;
            userIslem1.Visible = false;
            userMusteri1.Visible = !userMusteri1.Visible;
            userRapor1.Visible = false;
        }

        private void btnIslemEkle_Click(object sender, EventArgs e)
        {
            userCalisan1.Visible = false;
            userIslem1.Visible = !userIslem1.Visible;
            userMusteri1.Visible = false;
            userRapor1.Visible = false;
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            userCalisan1.Visible = false;
            userIslem1.Visible = false;
            userMusteri1.Visible = false;
            userRapor1.Visible = !userRapor1.Visible;
        }

        private void userRapor1_Load(object sender, EventArgs e)
        {
            ///değişiklik
        }
    }
}
