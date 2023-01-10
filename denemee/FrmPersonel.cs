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
    }
}
