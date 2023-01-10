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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtSistemiDataSet5.Ogrenci' table. You can move, or remove it, as needed.
            this.ogrenciTableAdapter4.Fill(this.yurtSistemiDataSet5.Ogrenci);


            timer1.Start();  


        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTimer.Text=DateTime.Now.ToLongDateString();
            lblTimer.Text = DateTime.Now.ToLongTimeString();

        }
    }
}
