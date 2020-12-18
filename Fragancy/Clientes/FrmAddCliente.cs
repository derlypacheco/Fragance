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
    public partial class FrmAddCliente : Form
    {
        public FrmAddCliente()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
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
                if (txtCelular.Text != "" && txtNombre.Text != "" && txtTelefono.Text != "" && txtLimite.Text != "" && txtDireccion.Text != "")
                {
                    btnAddCliente.Enabled = false;
                    Connection.ObtenerConexion();
                    string sql = "insert into Clientes (nombre, celular, telefono, correo, limite_credito, direccion) values ('" + txtNombre.Text + "', '" + txtCelular.Text + "', '" + txtTelefono.Text + "', '" + txtCorreo.Text + "', '" + Convert.ToDecimal(txtLimite.Text) + "', '" + txtDireccion.Text + "');";
                    SqlCommand cmd = new SqlCommand(sql, Connection.ObtenerConexion());
                    cmd.ExecuteNonQuery();
                    txtNombre.Text = "";
                    txtTelefono.Text = "";
                    txtLimite.Text = "";
                    txtDireccion.Text = "";
                    txtCorreo.Text = "";
                    txtCelular.Text = "";
                    btnAddCliente.Enabled = true;
                } 
                else
                {
                    FrmModalAlert modal = new FrmModalAlert("Aviso", "No deje campos vacios en el formulario", "warning");
                    modal.ShowDialog();
                }
                
            }
            catch (Exception)
            {

            }
        }

        private void txtLimite_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
