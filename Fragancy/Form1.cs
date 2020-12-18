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
using Fragancy.Clientes;
using Fragancy.FrmArticulos;
using Fragancy.Ventas;

namespace Fragancy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Connection connection = new Connection();

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection.ObtenerConexion();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Clientes ", Connection.ObtenerConexion());
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            MessageBox.Show("Registros totales: " + dt.Rows.Count);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.ObtenerConexion();
                SqlCommand cmd = new SqlCommand("insert into Clientes (nombre, celular, telefono, correo, limite_credito) values ('Derly', '6561256987', '65635845920', 'mail@correo.com', '2500')", Connection.ObtenerConexion());
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception)
            {

            }
        }


        private void iconClientes_Click(object sender, EventArgs e)
        {
            FrmListClientes frmClientes = new FrmListClientes();
            frmClientes.ShowDialog();
        }

        private void panelTopNav_MouseDown(object sender, MouseEventArgs e)
        {
            Functions.ReleaseCapture();
            Functions.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmListItems listItem = new FrmListItems();
            listItem.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Ventas 
            FrmListVentas frmVenta = new FrmListVentas();
            frmVenta.ShowDialog();
        }

        private void Form1_Validated(object sender, EventArgs e)
        {

        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
