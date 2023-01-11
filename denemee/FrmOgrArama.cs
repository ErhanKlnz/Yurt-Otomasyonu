using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace denemee
{
    public partial class FrmOgrArama : Form
    {
        public FrmOgrArama()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        SqlDataAdapter adapt;
        DataTable dt;

        private void FrmOgrArama_Load(object sender, EventArgs e)
        {
            OgrAramaListele();

            SqlCommand komut = new SqlCommand("Select Bolum_Id From Bolum", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cbxBolumeGore.Items.Add(oku[0].ToString());

            }
            bgl.baglanti().Close();

        }

        private void OgrAramaListele()
        {
            SqlCommand komut2 = new SqlCommand("SELECT * FROM Ogrenci", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = komut2;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgwOgrArama.DataSource = dt;
            dgwOgrArama.Columns[0].HeaderText = "Öğrenci Id";
            dgwOgrArama.Columns[1].HeaderText = "Öğrenci Adı";
            dgwOgrArama.Columns[2].HeaderText = "Öğrenci Soyadı";
            dgwOgrArama.Columns[3].HeaderText = "Öğrenci TC";
            dgwOgrArama.Columns[4].HeaderText = "Doğum Tarihi";
            dgwOgrArama.Columns[5].HeaderText = "Mail";
            dgwOgrArama.Columns[6].HeaderText = "Telefon Numarası";
            dgwOgrArama.Columns[7].HeaderText = "Bölüm ID";
            dgwOgrArama.Columns[8].HeaderText = "Kan Grup";
            dgwOgrArama.Columns[9].HeaderText = "Veli Ad Soyad";
            dgwOgrArama.Columns[10].HeaderText = "Veli Telefon";
            dgwOgrArama.Columns[11].HeaderText = "Adres";

        }

        private void pbxTC_Click(object sender, EventArgs e)
        {

            adapt = new SqlDataAdapter("SELECT * FROM Ogrenci WHERE OgrTC Like '" + tbxTCgore.Text + "%'", bgl.baglanti());

            dt = new DataTable();
            adapt.Fill(dt);
            dgwOgrArama.DataSource = dt;
            bgl.baglanti().Close();

        }

        private void pbxAd_Click(object sender, EventArgs e)
        {
            adapt = new SqlDataAdapter("SELECT * FROM Ogrenci WHERE OgrAd Like '" + tbxAdaGore.Text + "%'", bgl.baglanti());

            dt = new DataTable();
            adapt.Fill(dt);
            dgwOgrArama.DataSource = dt;
            bgl.baglanti().Close();
        }

        private void pbxSoyad_Click(object sender, EventArgs e)
        {
            adapt = new SqlDataAdapter("SELECT * FROM Ogrenci WHERE OgrSoyad Like '" + tbxSoyadaGore.Text + "%'", bgl.baglanti());

            dt = new DataTable();
            adapt.Fill(dt);
            dgwOgrArama.DataSource = dt;
            bgl.baglanti().Close();
        }

        private void pbxBolum_Click(object sender, EventArgs e)
        {
            adapt = new SqlDataAdapter("SELECT * FROM Ogrenci WHERE Bolum_Id Like '" + cbxBolumeGore.Text + "%'", bgl.baglanti());

            dt = new DataTable();
            adapt.Fill(dt);
            dgwOgrArama.DataSource = dt;
            bgl.baglanti().Close();
        }

        private void öğrenciKayıdıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void ödemeAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOdeme ode= new FrmOdeme();
            ode.Show();
                    
        }

        private void şifreİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sifreislemleri sifre = new sifreislemleri(); 
            sifre.Show();
        }

        private void personelDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonel per =   new FrmPersonel();
            per.Show();
        }

        private void bölümEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBolumler bol = new FrmBolumler();
            bol.Show();
        }
    }
}


