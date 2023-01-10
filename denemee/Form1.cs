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
            //Bölümleri Listeleme

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

                //this.ogrenciTableAdapter1.Fill(this.yurtSistemiDataSet4.Ogrenci);
                bgl.baglanti().Close();
            }
            catch (Exception)
            {
                MessageBox.Show("HATA! LÜTFEN YENİDEN DENEYİNİZ.");
            }
        }
    }
}





//Dat//a Source=ERHAN;Initial Catalog=YurtSistemi;Integrated Security=True//