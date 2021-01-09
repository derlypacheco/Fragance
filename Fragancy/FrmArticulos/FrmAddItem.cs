using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Fragancy.FrmArticulos
{
    public partial class FrmAddItem : Form
    {
        public string RutaImagenFile;
        public FrmAddItem()
        {
            InitializeComponent();
        }

        private void AddItem()
        {
            if (txtItem.Text != "" && txtMarca.Text != "" && txtCostoCompra.Text != "" && txtCostoVenta.Text != "" && txtCostoCredito.Text != "" && numericStock.Value >= 0)
            {
                try
                {
                    Connection.ObtenerConexion();
                    string sql = "insert into Articulos (articulo, marca, modelo, cod_barras, costo_compra, costo_venta, costo_credito, stock, descripcion) values " +
                        "('"+txtItem.Text+"', '"+txtMarca.Text+"', '"+txtModelo.Text+"', '"+txtBarras.Text+"', '"+Convert.ToDecimal(txtCostoCompra.Text)+ "', '"+Convert.ToDecimal(txtCostoVenta.Text)+"', '"+Convert.ToDecimal(txtCostoCredito.Text)+"', '"+numericStock.Value+"', '"+txtDesc.Text+"')";
                    MySqlCommand cmd = new MySqlCommand(sql, Connection.ObtenerConexion());
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

        private void btnAddItem_Click_1(object sender, EventArgs e)
        {
            AddItem();
        }

        private void picClose_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception)
            {

            }
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            Functions.ReleaseCapture();
            Functions.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtCostoCredito_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtCostoVenta_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtCostoCompra_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Solo imagenes | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                dialog.Title = "Seleccione la imagen del Artículo";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    RutaImagenFile = dialog.FileName;
                    FileInfo infoFile = new FileInfo(RutaImagenFile);
                    pictureBox1.Image = Image.FromFile(RutaImagenFile);
                    string destino = @"c:\Fragrance\Imagen\"+infoFile.Name+infoFile.Extension;
                    File.Copy(RutaImagenFile, destino, true);
                    
                    // C:\Fragrance\Imagen
                }
            }
            catch (Exception)
            {
                FrmModalAlert alert = new FrmModalAlert("Esta imagen no es valida para ser adjunta");
                alert.ShowDialog();
            }
        }
    }
}
