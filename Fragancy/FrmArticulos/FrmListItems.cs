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
    public partial class FrmListItems : Form
    {
        public FrmListItems()
        {
            InitializeComponent();
            ListItems();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ListItems()
        {
            try
            {
                dataGridViewItems.Rows.Clear();
                Connection.ObtenerConexion();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Articulos order by articulo", Connection.ObtenerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        dataGridViewItems.Rows.Add(
                            dt.Rows[i]["id_articulo"].ToString(),
                            dt.Rows[i]["articulo"].ToString(),
                            dt.Rows[i]["marca"].ToString(),
                            dt.Rows[i]["costo_credito"].ToString(),
                            dt.Rows[i]["stock"].ToString()
                            );
                    }
                }
            }
            catch (Exception)
            {
                FrmModalAlert modal = new FrmModalAlert("Error", "Hay un error al listar sus artículos \n intente una vez más", "error");
                modal.ShowDialog();
            }
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAddItem frmAddItem = new FrmAddItem();
                frmAddItem.ShowDialog();
                if (frmAddItem.DialogResult == DialogResult.OK)
                {
                    ListItems();
                }
            }
            catch (Exception)
            {
                FrmModalAlert modal = new FrmModalAlert("Aviso", "Tienes un problema con tu PC, se recomienda reiniciar la aplicación y intentar una vez más", "warning");
                modal.ShowDialog();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Functions.ReleaseCapture();
            Functions.SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
