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

namespace denemee
{
    public partial class FrmGirCik : Form
    {
        public FrmGirCik()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl=new SqlBaglantim();
        private void FrmGirCik_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtSistemiDataSet16.OgrGiris' table. You can move, or remove it, as needed.
            this.ogrGirisTableAdapter.Fill(this.yurtSistemiDataSet16.OgrGiris);
            // TODO: This line of code loads data into the 'yurtSistemiDataSet15.OgrCikis' table. You can move, or remove it, as needed.
            this.ogrCikisTableAdapter.Fill(this.yurtSistemiDataSet15.OgrCikis);
            // TODO: Bu kod satırı 'yurtSistemiiiDataSet4.OgrCikis' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.

        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand kmt1 = new SqlCommand("INSERT INTO OgrGiris (OgrTc) values (@p1)", bgl.baglanti());
                kmt1.Parameters.AddWithValue("@p1", TxtTCGir.Text);
                kmt1.ExecuteNonQuery();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata");
            }
            

        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand kmt2 = new SqlCommand("INSERT INTO OgrCikis where OgrTC=@p2 (OgrTc) values (@p2)", bgl.baglanti());
                kmt2.Parameters.AddWithValue("@p2", TxtTCCik.Text);
                kmt2.ExecuteNonQuery();

            }
            catch (Exception)
            {

                MessageBox.Show("Hata");
            }
            
        }
    }
}
