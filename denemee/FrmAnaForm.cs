using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace denemee
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtSistemiDataSet5.Ogrenci' table. You can move, or remove it, as needed.
            this.ogrenciTableAdapter4.Fill(this.yurtSistemiDataSet5.Ogrenci);


            timer1.Start();  


        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTimer.Text=DateTime.Now.ToLongDateString();
            lblTimer.Text = DateTime.Now.ToLongTimeString();

        }

        private void öğrenciEkleVeDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }

        private void bölümDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBolumler bol = new FrmBolumler();
            bol.Show();
        }

        private void ödemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOdeme ode = new FrmOdeme();
            ode.Show();
        }
        private void personelEkleVeDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonel per = new FrmPersonel();
            per.Show();
        }

        private void kullanıcıAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sifreislemleri sifre = new sifreislemleri();
            sifre.Show();
        }

        private void öğrenciAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrArama ara = new FrmOgrArama();
            ara.Show();
        }

        private void kayıtSildirenÖğrencilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSilinmisOgr silin= new FrmSilinmisOgr();
            silin.Show();
        }

        private void girişÇıkışKayıtlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGirCik gir = new FrmGirCik();
            gir.Show();
        }

        private void raporAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRapor rap = new FrmRapor(); 
            rap.Show();
        }

        private void yedekVeGeriYüklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBackRestore back= new FrmBackRestore();
            back.Show();
        }

        private void raporAlToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmRapor rap = new FrmRapor();
            rap.Show();
        }
    }
}
