using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Fragancy.Ventas
{
    public partial class FrmListVentas : Form
    {
        public FrmListVentas()
        {
            InitializeComponent();
        }

        Functions fn = new Functions();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception)
            {
                
            }
        }

        private void LoadVentas()
        {
            try
            {
                Connection.ObtenerConexion();
                dataGridViewVentas.Rows.Clear();
                MySqlDataAdapter adapter = new MySqlDataAdapter("select * from ventas order by fecha_venta desc", Connection.ObtenerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dataGridViewVentas.Rows.Add(
                            dt.Rows[i]["id_venta"].ToString(),
                            dt.Rows[i]["fecha_venta"].ToString(),
                            fn.GetCostumer(dt.Rows[i]["id_cliente"].ToString()),
                            fn.GetTypeSales(dt.Rows[i]["tipo_venta"].ToString()),
                           "4,652"
                            );
                    }
                }
            }
            catch (Exception)
            {
                FrmModalAlert aviso = new FrmModalAlert("Error", "Hay un probema al listar las ventas de la base de datos, reinicie la aplicación", "error");
                aviso.ShowDialog();
                this.Close();
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            Functions.ReleaseCapture();
            Functions.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAddVenta_Click(object sender, EventArgs e)
        {
            FrmVender venta = new  FrmVender();
            venta.ShowDialog();

            //try
            //{
            //    SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Ventas (costo_credito, cantidad, id_cliente, fecha_venta, fecha_limite, tipo_venta, cant_art, descripcion) VALUES ('458.25', 1, 1, '2020-12-18', '2021-01-18', '1', '1', 'Descripcion')", Connection.ObtenerConexion());
            //    cmd.ExecuteNonQuery();
            //    LoadVentas();
            //}
            //catch (SqlException ex)
            //{
            //    FrmModalAlert aviso = new FrmModalAlert(Convert.ToString(ex));
            //    aviso.ShowDialog();
            //}

        }

        private void FrmListVentas_Load(object sender, EventArgs e)
        {
            LoadVentas();
        }
    }
}
