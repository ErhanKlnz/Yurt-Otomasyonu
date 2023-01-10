using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace denemee
{
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtSistemiDataSet10.Bolum' table. You can move, or remove it, as needed.
            this.bolumTableAdapter1.Fill(this.yurtSistemiDataSet10.Bolum);
;

        }

        private void pcbBolumEkle_Click(object sender, EventArgs e)
        {
            try
            {
                bgl.baglanti();
                
                SqlCommand komut1 = new SqlCommand("insert into Bolum (BolumAd) values (@p1)" , bgl.baglanti());
                komut1.Parameters.AddWithValue("@p1", txtBolumAd.Text);
                komut1.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Bölüm Eklendi!");
                this.bolumTableAdapter1.Fill(this.yurtSistemiDataSet10.Bolum);
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu! Yeniden Deneyin.");
            }
            

        }

        private void pcbBolumSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut2 = new SqlCommand("delete from Bolum where Bolum_Id=@p1", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", txtBolumId.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Silme işlemi gerçekleştirildi");
                this.bolumTableAdapter1.Fill(this.yurtSistemiDataSet10.Bolum);
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu! Yeniden Deneyin.");
            }
            

        }

        private void pcbBolumDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut3 = new SqlCommand("update Bolum set BolumAd=@p1 where Bolum_Id=@p2", bgl.baglanti());
                komut3.Parameters.AddWithValue("@p2", txtBolumId.Text);
                komut3.Parameters.AddWithValue("@p1", txtBolumAd.Text);
                komut3.ExecuteNonQuery();
                MessageBox.Show("İşleminiz Gerçekleşmiştir");
                this.bolumTableAdapter1.Fill(this.yurtSistemiDataSet10.Bolum);

            }
            catch (Exception)
            {

                MessageBox.Show("İşleminiz Gerçekleştirile!");
            }

        }

        int secilen;
        private void dgwBolumler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, bolumad;
            
            secilen = dgwBolumler.SelectedCells[0].RowIndex;
            id = dgwBolumler.Rows[secilen].Cells[0].Value.ToString();
            bolumad = dgwBolumler.Rows[secilen].Cells[1].Value.ToString();

            txtBolumId.Text= id;
            txtBolumAd.Text= bolumad;

        }
    }
}
