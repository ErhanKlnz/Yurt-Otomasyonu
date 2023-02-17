using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace denemee
{
    public partial class FrmOdeme : Form
    {
        public FrmOdeme()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();

        private void frmOdeme_Load(object sender, EventArgs e)
        {
            TableUpdate();

        }

        private void TableUpdate()
        {
            SqlCommand komut = new SqlCommand("SELECT Ogrenci.OgrAd, Ogrenci.OgrSoyad, Ogrenci.OgrTC, Odeme.KalanBorc FROM Ogrenci INNER JOIN Odeme ON Ogrenci.OgrTC = Odeme.OgrTC", bgl.baglanti());
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = komut;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgwOgrOdeme.DataSource = dt;
            dgwOgrOdeme.Columns[0].HeaderText = "Öğrenci Adı";
            dgwOgrOdeme.Columns[1].HeaderText = "Öğrenci Soyadı";
            dgwOgrOdeme.Columns[2].HeaderText = "Öğrenci TC";
            dgwOgrOdeme.Columns[3].HeaderText = "Kalan Borç";
        }

        private void dgwOgrOdeme_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            string ogrAd, ogrTc, kalanBorc;
            secilen = dgwOgrOdeme.SelectedCells[0].RowIndex;
            ogrAd = dgwOgrOdeme.Rows[secilen].Cells[0].Value.ToString();
            ogrTc = dgwOgrOdeme.Rows[secilen].Cells[2].Value.ToString();
            kalanBorc = dgwOgrOdeme.Rows[secilen].Cells[3].Value.ToString();

            txtOgrAdOdeme.Text = ogrAd;
            txtOgrTcOdeme.Text = ogrTc;
            txtKalanBorc.Text = kalanBorc;


        }

        private void btnOdemeAl_Click(object sender, EventArgs e)
        {
            try
            {
                int odenen, kalan, yeniBorc;
                odenen = Convert.ToInt16(txtOdenen.Text);
                kalan = Convert.ToInt16(txtKalanBorc.Text);
                yeniBorc = kalan - odenen;
                txtKalanBorc.Text = yeniBorc.ToString();

                SqlCommand komut2 = new SqlCommand("update Odeme set KalanBorc=@p1 where OgrTC=@p2 ", bgl.baglanti());
                komut2.Parameters.AddWithValue("@p2", txtOgrTcOdeme.Text);
                komut2.Parameters.AddWithValue("@p1", txtKalanBorc.Text);
                komut2.ExecuteNonQuery();

                MessageBox.Show("Ödeme Alınmıştır!");
                TableUpdate();
                bgl.baglanti().Close();
            }
            catch (Exception)
            {

                throw;
            }
           

        }

        private void txtOdenen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOdemeAl_Click(this, new EventArgs());
            }
        }
    }
}
