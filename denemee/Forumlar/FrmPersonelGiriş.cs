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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace denemee
{
    public partial class FrmPersonelGiriş : Form
    {
        public FrmPersonelGiriş()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ERHAN;Initial Catalog=YurtSistemi;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "Select * From KullaniciPersonel where KullaniciAdi=@ad AND Sifre=@sifre";
                SqlParameter prm1 = new SqlParameter("ad", txtkullanıcıadi.Text);
                SqlParameter prm2 = new SqlParameter("sifre", txtadmsifre.Text);
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    FrmAnasayfaPersonel fraper = new FrmAnasayfaPersonel();

                    fraper.ShowDialog();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı Giriş");
            }
        }

        private void txtadmsifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }

        private void FrmPersonelGiriş_Load(object sender, EventArgs e)
        {

        }
    }
    
}
