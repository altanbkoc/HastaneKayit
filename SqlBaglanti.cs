using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HastaneProjesi
{
    internal class SqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=Aeneis\\SQLEXPRESS;Initial Catalog=HastaneVT;Integrated Security=True;TrustServerCertificate=True");
            baglan.Open();
            return baglan;
        }
    }
}
