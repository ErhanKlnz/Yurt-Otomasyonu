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
    public partial class FrmOgrKayit : Form
    {
        public FrmOgrKayit()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();


        private void Form1_Load(object sender, EventArgs e)
        {
            //Bölümleri Listeleme
            SqlCommand komut = new SqlCommand("Select Bolum_Id, BolumAd From Bolum", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmbBolum.Items.Add(oku[0].ToString() + ' ' + oku[1].ToString());

            }
            bgl.baglanti().Close();

            // Boş oda

            SqlCommand komut2 = new SqlCommand("Select OdaNo from Odalar where OdaMaxOgr != OgrSayi", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                cmbOdano.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();

        }




        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand komutkaydet = new SqlCommand("insert into Ogrenci(OgrAd,OgrSoyad,OgrTC,Mail,TelNo,KanGrup,OdaNo,Bolum_Id) values (@p1,@p2,@p3,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
                komutkaydet.Parameters.AddWithValue("@p1", txtOgrad.Text);
                komutkaydet.Parameters.AddWithValue("@p2", txtOgrSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p3", mtxtOgrTC.Text);
                //komutkaydet.Parameters.AddWithValue("@p4", mOgrDog.Text);
                komutkaydet.Parameters.AddWithValue("@p5", txtMail.Text);
                komutkaydet.Parameters.AddWithValue("@p6", mtxtOgrTel.Text);
                komutkaydet.Parameters.AddWithValue("@p7", txtOgrKan.Text);
                komutkaydet.Parameters.AddWithValue("@p8", cmbOdano.Text);
                komutkaydet.Parameters.AddWithValue("@p9", cmbBolum.Text);
                //komutkaydet.Parameters.AddWithValue("@p10",txtveliad);
                //komutkaydet.Parameters.AddWithValue("@p11",txtmskVeliTel.Text);
                //komutkaydet.Parameters.AddWithValue("@p12",rtxtAdres.Text);

                komutkaydet.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Öğrenci Eklendi!");


                //Borç
                //SqlCommand komutkaydet2 = new SqlCommand("inser into Ödeme(OdemeId,OgrTC) values(@b1,@b2)", bgl.baglanti());
                //komutkaydet2.Parameters.AddWithValue("@b1", .text);
                //komutkaydet2.Parameters.AddWithValue("@b2", TxtOgrTC);
                //komutkaydet2.ExecuteNonQuery();
                //bgl.baglanti().Close();
            }
            catch (Exception)
            {
                MessageBox.Show("HATA! LÜTFEN YENİDEN DENEYİNİZ.");
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        
    }
}
    

    
    

//Dat//a Source=ERHAN;Initial Catalog=YurtSistemi;Integrated Security=True//