using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Fragancy
{
    public class Functions
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public void DragElement(IntPtr frmDrag)
        {
            ReleaseCapture();
            SendMessage(frmDrag, 0x112, 0xf012, 0);
        }

        public string GetCostumer(string ID)
        {
            string result = "";
            try
            {
                Connection.ObtenerConexion();
                SqlDataAdapter adapter = new SqlDataAdapter("select nombre from Clientes where id_cliente = '"+ID+"' and activo = '1'", Connection.ObtenerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    result = dt.Rows[0]["nombre"].ToString();
                } else
                {
                    result = "Cliente generico";
                }
            }
            catch (Exception)
            {
                
            }
            return result;
        }

        public string GetTypeSales(string type)
        {
            string result = "";
            try
            {
                switch (type)
                {
                    case "1":
                        result = "Credito";
                        break;
                    case "2":
                        result = "Contado";
                        break;
                    default:
                        result = "";
                        break;
                }
                return result;
            }
            catch (Exception)
            {
                return result;
            }
        }

    }
}
