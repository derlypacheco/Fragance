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

namespace Fragancy.Ventas
{
    public partial class FrmVender : Form
    {
        public FrmVender()
        {
            InitializeComponent();
        }

        private void picBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ListCostumesCombo()
        {
            try
            {
                Connection.ObtenerConexion();
                SqlDataAdapter adapter = new SqlDataAdapter("select id_cliente, nombre from Clientes where activo = '1' order by nombre;", Connection.ObtenerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    comboCostumers.DataSource = dt;
                    comboCostumers.ValueMember = "id_cliente";
                    comboCostumers.DisplayMember = "nombre";
                    //for (int i = 0; i < dt.Rows.Count; i++)
                    //{
                    //    comboCostumers.Items.Add(dt.Rows[i]["nombre"].ToString());
                    //}
                }
            }
            catch (Exception)
            {
                FrmModalAlert modal = new FrmModalAlert("Error", "No es posible mostrar los clientes registrados para las ventas a credito", "error");
                modal.ShowDialog();

            }
        }
        private void FrmVender_Load(object sender, EventArgs e)
        {
            ListCostumesCombo();
        }
    }
}
