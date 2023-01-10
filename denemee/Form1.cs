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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtSistemiDataSet9.Ogrenci' table. You can move, or remove it, as needed.
            this.ogrenciTableAdapter2.Fill(this.yurtSistemiDataSet9.Ogrenci);
            


            SqlCommand komut = new SqlCommand("Select Bolum_Id From Bolum", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cbxOgrBolum.Items.Add(oku[0].ToString());

            }
            bgl.baglanti().Close();

            // Boş oda

            SqlCommand komut2 = new SqlCommand("Select OdaNo from Odalar where OdaMaxOgr != OgrSayi", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                cbxOdaNo.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();

        }


        private void btnOgrEkle_Click_2(object sender, EventArgs e)
        {
            try
            {


                SqlCommand komutkaydet = new SqlCommand("insert into Ogrenci(OgrAd, OgrSoyad, OgrTC ,DogTarih, OgrMail, OgrTelNo, KanGrup, OdaNo, Bolum_Id, VeliAdSoyad, VeliTelNo, OgrAdres) values (@a1, @a2, @a3, @a4, @a5, @a6, @a7, @a8, @a9, @a10, @a11, @a12)", bgl.baglanti());
                komutkaydet.Parameters.AddWithValue("@a1", txtOgrAd.Text);
                komutkaydet.Parameters.AddWithValue("@a2", txtOgrSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@a3", mTxtOgrTc.Text);
                komutkaydet.Parameters.AddWithValue("@a4", mTxtDogTarih.Text);
                komutkaydet.Parameters.AddWithValue("@a5", txtOgrMail.Text);
                komutkaydet.Parameters.AddWithValue("@a6", mTxtOgrTel.Text);
                komutkaydet.Parameters.AddWithValue("@a7", txtOgrKan.Text);
                komutkaydet.Parameters.AddWithValue("@a8", cbxOdaNo.Text);
                komutkaydet.Parameters.AddWithValue("@a9", cbxOgrBolum.Text);
                komutkaydet.Parameters.AddWithValue("@a10", txtVeliAdSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@a11", mTxtVeliTel.Text);
                komutkaydet.Parameters.AddWithValue("@a12", rTxtAdres.Text);
                komutkaydet.ExecuteNonQuery();

                MessageBox.Show("Eklendi!");



                this.ogrenciTableAdapter2.Fill(this.yurtSistemiDataSet9.Ogrenci);
                bgl.baglanti().Close();
            }
            catch (Exception)
            {
                throw;

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut5 = new SqlCommand("delete from Ogrenci where OgrTC = @p1 ", bgl.baglanti());
                komut5.Parameters.AddWithValue("@p1", mTxtOgrTc.Text);
                komut5.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Silme işlemi gerçekleştirildi");
                this.ogrenciTableAdapter2.Fill(this.yurtSistemiDataSet9.Ogrenci);
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu! Yeniden Deneyin.");
            }

        }




        private void btnDuzenle_Click(object sender, EventArgs e)
        {

            SqlCommand komutduzenle = new SqlCommand("update Ogrenci set OgrAd=@b1, OgrSoyad=@b2, DogTarih=@b4, OgrMail=@b5, OgrTelNo=@b6, KanGrup=@b7, OdaNo=@b8, Bolum_Id=@b9,VeliAdSoyad=@b10,VeliTelNo=@b11,OgrAdres=@b12 WHERE OgrTC=@b3 ", bgl.baglanti());
            komutduzenle.Parameters.AddWithValue("@b1", txtOgrAd.Text);
            komutduzenle.Parameters.AddWithValue("@b2", txtOgrSoyad.Text);
            komutduzenle.Parameters.AddWithValue("@b3", mTxtOgrTc.Text);
            komutduzenle.Parameters.AddWithValue("@b4", mTxtDogTarih.Text);
            komutduzenle.Parameters.AddWithValue("@b5", txtOgrMail.Text);
            komutduzenle.Parameters.AddWithValue("@b6", mTxtOgrTel.Text);
            komutduzenle.Parameters.AddWithValue("@b7", txtOgrKan.Text);
            komutduzenle.Parameters.AddWithValue("@b8", cbxOdaNo.Text);
            komutduzenle.Parameters.AddWithValue("@b9", cbxOgrBolum.Text);
            komutduzenle.Parameters.AddWithValue("@b10", txtVeliAdSoyad.Text);
            komutduzenle.Parameters.AddWithValue("@b11", mTxtVeliTel.Text);
            komutduzenle.Parameters.AddWithValue("@b12", rTxtAdres.Text);
            komutduzenle.ExecuteNonQuery();

            bgl.baglanti().Close();
            MessageBox.Show("Düzenleme işlemi gerçekleştirildi");
            this.ogrenciTableAdapter2.Fill(this.yurtSistemiDataSet9.Ogrenci);


        }

        int secilen;
        private void dgwOgrIslem_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {


            string ogrAd, ogrSoyad, ogrTc, ogrDogTarih, ogrMail, ogrTelNo, bolum_Id, kanGrup, odaNo, veliAdSoyad, veliTelNo, ogrAdres;

            secilen = dgwOgrIslem.SelectedCells[0].RowIndex;
            ogrAd = dgwOgrIslem.Rows[secilen].Cells[1].Value.ToString();
            ogrSoyad = dgwOgrIslem.Rows[secilen].Cells[2].Value.ToString();
            ogrTc = dgwOgrIslem.Rows[secilen].Cells[3].Value.ToString();
            ogrDogTarih = dgwOgrIslem.Rows[secilen].Cells[4].Value.ToString();
            ogrMail = dgwOgrIslem.Rows[secilen].Cells[5].Value.ToString();
            ogrTelNo = dgwOgrIslem.Rows[secilen].Cells[6].Value.ToString();
            bolum_Id = dgwOgrIslem.Rows[secilen].Cells[7].Value.ToString();
            kanGrup = dgwOgrIslem.Rows[secilen].Cells[8].Value.ToString();
            odaNo = dgwOgrIslem.Rows[secilen].Cells[9].Value.ToString();
            veliAdSoyad = dgwOgrIslem.Rows[secilen].Cells[10].Value.ToString();
            veliTelNo = dgwOgrIslem.Rows[secilen].Cells[11].Value.ToString();
            ogrAdres = dgwOgrIslem.Rows[secilen].Cells[12].Value.ToString();

            txtOgrAd.Text = ogrAd;
            txtOgrSoyad.Text = ogrSoyad;
            mTxtOgrTc.Text = ogrTc;
            mTxtDogTarih.Text = ogrDogTarih;
            txtOgrMail.Text = ogrMail;
            mTxtOgrTel.Text = ogrTelNo;
            cbxOgrBolum.Text = bolum_Id;
            txtOgrKan.Text = kanGrup;
            cbxOdaNo.Text = odaNo;
            txtVeliAdSoyad.Text = veliAdSoyad;
            mTxtVeliTel.Text = veliTelNo;
            rTxtAdres.Text = ogrAdres;



        }

        
    }
}






//Data Source=ERHAN;Initial Catalog=YurtSistemi;Integrated Security=True//