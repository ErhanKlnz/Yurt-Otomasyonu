using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace denemee
{
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtkullanıcıadi.Text == "select from Yonetici " && txtadmsifre.Text == "1234")
            {
                FrmAnaForm fr = new FrmAnaForm();
                fr.Show();
            }
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız.");
            }
        }

        private void FrmAdminGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
