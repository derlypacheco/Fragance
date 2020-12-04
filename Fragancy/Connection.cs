using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Fragancy
{
    public class Connection
    {
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection Cnn = new SqlConnection("Data Source=DESKTOP-DKI8E3C; Initial Catalog = fragance; Integrated Security=True");
            Cnn.Open();
            return Cnn;
        }

    }
}
