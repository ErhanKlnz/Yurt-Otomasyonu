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
                CmbBolum.Items.Add(oku[0].ToString());

            }
            bgl.baglanti().Close();

            // Boş oda
           
            SqlCommand komut2 = new SqlCommand("Select OdaNo from Odalar where OdaMaxOgr != OgrSayi", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                CmbOdaNo.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();
           
        }
         
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand komutkaydet = new SqlCommand("insert into Ogrenci(Ad,Soyad,Ogr_TC,DogTarih,Mail,TelNo,KanGrup,OdaNo,Bolum_Id) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9)", bgl.baglanti());
                komutkaydet.Parameters.AddWithValue("@p1", CmbOgrAd.Text);
                komutkaydet.Parameters.AddWithValue("@p2", CmbOgrSoyad.Text);
                komutkaydet.Parameters.AddWithValue("@p3", CmbOgrTC.Text);
                komutkaydet.Parameters.AddWithValue("@p4", cmbDogtarih.Text);
                komutkaydet.Parameters.AddWithValue("@p5", CmbOgrMail.Text);
                komutkaydet.Parameters.AddWithValue("@p6", CmbOgrTel.Text);
                komutkaydet.Parameters.AddWithValue("@p7", txtKangrup.Text);
                komutkaydet.Parameters.AddWithValue("@p8", CmbOdaNo.Text);
                komutkaydet.Parameters.AddWithValue("@p9", CmbBolum.Text);
                komutkaydet.ExecuteNonQuery();
                MessageBox.Show("Öğrenci Eklendi!");
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