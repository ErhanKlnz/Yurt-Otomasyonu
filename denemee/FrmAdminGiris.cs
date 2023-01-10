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
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ERHAN;Initial Catalog=YurtSistemi;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "Select * From Yonetici where KullaniciAdi=@ad AND Sifre=@sifre";
                SqlParameter prm1 = new SqlParameter("ad", txtkullanıcıadi.Text);
                SqlParameter prm2 = new SqlParameter("sifre", txtadmsifre.Text);
                SqlCommand komut = new SqlCommand(sql,baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    FrmAnaForm fr  = new FrmAnaForm();
                    fr.Show();
                }
                
           }
            catch (Exception)
            {

                throw;
            }
        }

        private void FrmAdminGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
