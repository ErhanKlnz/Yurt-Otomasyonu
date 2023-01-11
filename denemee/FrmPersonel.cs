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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtSistemiDataSet7.Personel' table. You can move, or remove it, as needed.
            
                this.personelTableAdapter.Fill(this.yurtSistemiDataSet7.Personel);
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into Personel(PerAd,PerSoyad,PerTC,Cinsiyet,PerTelNo,KanGrup,Departman) values (@a1,@a2,@a3,@a4,@a5,@a6,@a7)", bgl.baglanti());
                komut.Parameters.AddWithValue("@a1", txtPerAd.Text);
                komut.Parameters.AddWithValue("@a2", txtPerSoyad.Text);
                komut.Parameters.AddWithValue("@a3", mtxtPerTC.Text);
                komut.Parameters.AddWithValue("@a4", txtPercins.Text);
                komut.Parameters.AddWithValue("@a5", mtxtPerTel.Text);
                komut.Parameters.AddWithValue("@a6", txtPerkan.Text);
                komut.Parameters.AddWithValue("@a7", txtPerDep.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Personel Eklendi");
                this.personelTableAdapter.Fill(this.yurtSistemiDataSet7.Personel);
            }
            catch (Exception)
            {

                MessageBox.Show("Yeniden Dene");
            }
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("delete from Personel where PerTC=@a1", bgl.baglanti());
                komut.Parameters.AddWithValue("@a1", mtxtPerTC.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Personel Kaydı Silindi");
                this.personelTableAdapter.Fill(this.yurtSistemiDataSet7.Personel);
            }
            catch (Exception)
            {

                MessageBox.Show("Bu TC başka bir kullanıcı personele bağlı yada aynı TC den iki personel olamaz !!");
            } 
        }
        int secilen;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            string ad, soyad, Tc, cinsiyet, Tel, Kan, Dep;
            ad = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            soyad = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            Tc = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cinsiyet = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            Tel = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            Kan = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            Dep = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txtPerAd.Text = ad;
            txtPerSoyad.Text = soyad;
            mtxtPerTC.Text = Tc;
            txtPercins.Text = cinsiyet;
            mtxtPerTel.Text = Tel;
            txtPerkan.Text= Kan;
            txtPerDep.Text = Dep;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komutgun = new SqlCommand("update Personel  set PerAd=@b1,PerSoyad=@b2,Cinsiyet=@b3,PerTelNo=@b4,KanGrup=@b5,Departman=@b6 where PerTC=@b7", bgl.baglanti());
            komutgun.Parameters.AddWithValue("@b1", txtPerAd.Text);
            komutgun.Parameters.AddWithValue("@b2", txtPerSoyad.Text);  
            komutgun.Parameters.AddWithValue("@b3", txtPercins.Text);
            komutgun.Parameters.AddWithValue("@b4", mtxtPerTel.Text);
            komutgun.Parameters.AddWithValue("@b5", txtPerkan.Text);
            komutgun.Parameters.AddWithValue("@b6", txtPerDep.Text);
            komutgun.Parameters.AddWithValue("@b7", mtxtPerTC.Text);
            komutgun.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Personel Bilgisi Güncellenmiştir");
            this.personelTableAdapter.Fill(this.yurtSistemiDataSet7.Personel);
        }

     
    }
}
