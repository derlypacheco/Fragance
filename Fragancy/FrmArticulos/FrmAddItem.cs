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

namespace Fragancy.FrmArticulos
{
    public partial class FrmAddItem : Form
    {
        public FrmAddItem()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (txtItem.Text != "" && txtMarca.Text != "" && txtCostoCompra.Text != "" && txtCostoVenta.Text != "" && txtCostoCredito.Text != "" && numericStock.Value >= 0)
            {
                try
                {
                    Connection.ObtenerConexion();
                    string sql = "insert into Articulos (articulo, marca, modelo, cod_barras, costo_compra, costo_venta, costo_credito, stock, descripcion) values " +
                        "('"+txtItem.Text+"', '"+txtMarca.Text+"', '"+txtModelo.Text+"', '"+txtBarras.Text+"', '"+Convert.ToDecimal(txtCostoCompra.Text)+ "', '"+Convert.ToDecimal(txtCostoVenta.Text)+"', '"+Convert.ToDecimal(txtCostoCredito.Text)+"', '"+numericStock.Value+"', '"+txtDesc.Text+"')";
                    SqlCommand cmd = new SqlCommand(sql, Connection.ObtenerConexion());
                    cmd.ExecuteNonQuery();
                    txtItem.Text = "";
                    txtMarca.Text = "";
                    txtModelo.Text = "";
                    txtBarras.Text = "";
                    txtCostoCompra.Text = "";
                    txtCostoCredito.Text = "";
                    txtCostoVenta.Text = "";
                    numericStock.Value = 0;
                    txtDesc.Text = "";

                    DialogResult = DialogResult.OK;
                }
                catch (Exception)
                {
                    FrmModalAlert modal = new FrmModalAlert("Error", "Hay un error al almacenar el arículo", "error");
                    modal.ShowDialog();
                }
            }
            else
            {
                FrmModalAlert modal = new FrmModalAlert("Aviso", "No deje campos vacios en el formulario", "warning");
                modal.ShowDialog();
            }
        }

        private void txtCostoCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtCostoVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtCostoCredito_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception)
            {

            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Functions.ReleaseCapture();
            Functions.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
