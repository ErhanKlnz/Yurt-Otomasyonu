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
    public partial class FrmSilinmisOgr : Form
    {
        public FrmSilinmisOgr()
        {
            InitializeComponent();
        }

        private void FrmSilinmisOgr_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'yurtSistemiDataSet12.SilinmisOgrKayitlar' table. You can move, or remove it, as needed.
            this.silinmisOgrKayitlarTableAdapter.Fill(this.yurtSistemiDataSet12.SilinmisOgrKayitlar);
           

        }
    }
}
