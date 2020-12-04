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

namespace Fragancy.Clientes
{
    public partial class FrmListClientes : Form
    {
        public FrmListClientes()
        {
            InitializeComponent();
        }

        Functions fn = new Functions();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadCostumers()
        {
            try
            {
                dataGridViewClientes.Rows.Clear();
                Connection.ObtenerConexion();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Clientes where activo = '1' ", Connection.ObtenerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dataGridViewClientes.Rows.Add(
                        dt.Rows[i]["id_cliente"].ToString(),
                        dt.Rows[i]["nombre"].ToString(),
                        dt.Rows[i]["celular"].ToString(),
                        dt.Rows[i]["correo"].ToString()
                        );
                    }
                }
                Connection.ObtenerConexion().Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pueden cargar los registros de la base de datos");
            }
        }

        private void FrmListClientes_Load(object sender, EventArgs e)
        {
            //Connection.ObtenerConexion();
            //SqlCommand cmd = new SqlCommand("insert into Clientes (nombre, celular, telefono, correo, limite_credito, direccion) values ('Derly', '6561256987', '65635845920', 'mail@correo.com', '2500', 'Direccion donde vives');", Connection.ObtenerConexion());
            //cmd.ExecuteNonQuery();
            LoadCostumers();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Functions.ReleaseCapture();
            Functions.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddCliente frmAddCliente = new FrmAddCliente();
                frmAddCliente.ShowDialog();
            }
            catch (Exception)
            {

            }
        }
    }
}
