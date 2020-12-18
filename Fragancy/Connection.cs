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
            string conexion = @"Data Source=.\SQLEXPRESS;
                             AttachDbFilename=c:\frag\general.mdf;
                             Integrated Security=True;
                             Connect Timeout=30;
                             User Instance=True";
            SqlConnection Cnn = new SqlConnection("Data Source=DESKTOP-DKI8E3C; Initial Catalog = fragance; Integrated Security=True");
            //SqlConnection Cnn = new SqlConnection(conexion);
            Cnn.Open();
            return Cnn;
        }

    }
}
