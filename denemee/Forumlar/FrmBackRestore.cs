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
    public partial class FrmBackRestore : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=ERHAN;Initial Catalog=YurtSistemi;Integrated Security=True");
        public FrmBackRestore()
        {
            InitializeComponent();
        }
        
        private void FrmBackRestore_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if(dlg.ShowDialog() == DialogResult.OK )
            {
                txtklasor1.Text = dlg.SelectedPath;
                btnbackup.Enabled = true;
            }
        }

        private void btnbackup_Click(object sender, EventArgs e)
        {
            string database = baglanti.Database.ToString();
            if(txtklasor1.Text == string.Empty)
            {
                MessageBox.Show("Lütfen dosya konumunu seçiniz");
            }
            else
            {
                string cmd="BACKUP DATABASE["+ database+"] TO DISK= '"+ txtklasor1.Text+"\\"+"database"+"-"+DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")+".bak'";
                baglanti.Open();
                SqlCommand komut = new SqlCommand(cmd,baglanti);
                komut.ExecuteNonQuery();
                MessageBox.Show("Veri tabanı yükleme başarılı.");
                baglanti.Close();
                btnbackup.Enabled = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog  dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER database backup files|*.bak";
            dlg.Title = "Database restore";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtrestore.Text = dlg.FileName;
                btnrestore.Enabled = true;

            }
        }

        private void btnrestore_Click(object sender, EventArgs e)
        {
            string database =baglanti.Database.ToString();
            baglanti.Open();
            try
            {
                string str1 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand komut1 = new SqlCommand(str1,baglanti);
                komut1.ExecuteNonQuery();

                string str2 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + txtrestore.Text + "' WITH REPLACE;";
                SqlCommand komut2 = new SqlCommand(str2,baglanti);
                komut2.ExecuteNonQuery();

                string str3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                SqlCommand komut3 = new SqlCommand(str3,baglanti);
                komut3.ExecuteNonQuery();

                MessageBox.Show("Veri tabanı geri yüklendi.");
                baglanti.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
