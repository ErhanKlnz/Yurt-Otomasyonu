using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace denemee
{
    public partial class FrmAnasayfaPersonel : Form
    {
        public FrmAnasayfaPersonel()
        {
            InitializeComponent();
        }

        private void FrmAnasayfaPersonel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtSistemiDataSet14.Ogrenci' table. You can move, or remove it, as needed.
            this.ogrenciTableAdapter.Fill(this.yurtSistemiDataSet14.Ogrenci);
            timer2.Start();
        }

        private void öğrenciEkleVeDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 ogr = new Form1();
            ogr.Show();
        }

        private void öğrenciAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrArama ograra = new FrmOgrArama();
            ograra.Show();
        }

        private void kayıtSildirenÖğrencilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSilinmisOgr sili = new FrmSilinmisOgr(); 
            sili.Show();
        }

        private void bölümDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBolumler bol = new FrmBolumler();   
            bol.Show();
        }

        private void ödemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOdeme odeme= new FrmOdeme();
            odeme.Show();   
        }
         
        private void timer2_Tick(object sender, EventArgs e)
        {
            lblDateTimer.Text = DateTime.Now.ToLongDateString();
            lblTimer.Text = DateTime.Now.ToLongTimeString();
        }

        private void girişÇıkışKayıtlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGirCik gir = new FrmGirCik();
            gir.Show();
        }
    }
}
