using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace denemee
{
     public class SqlBaglantim
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source = ERHAN; Initial Catalog = YurtSistemi; Integrated Security = True");
           baglan.Open();
            return baglan;
        }
    }
}
