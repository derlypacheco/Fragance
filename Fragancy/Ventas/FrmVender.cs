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
using Fragancy.ClassForder;

namespace Fragancy.Ventas
{
    public partial class FrmVender : Form
    {
        public bool Existencias = true; 
        public FrmVender()
        {
            InitializeComponent();
        }

        private void picBtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ControlsMaker makeControl = new ControlsMaker();

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
                }
            }
            catch (Exception)
            {
                FrmModalAlert modal = new FrmModalAlert("Error", "No es posible mostrar los clientes registrados para las ventas a credito", "error");
                modal.ShowDialog();

            }
        }

        public void ListToMark()
        {
            try
            {
                Connection.ObtenerConexion();
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Marcas where activo = '1' order by marca;", Connection.ObtenerConexion());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    comboMarcas.DataSource = dt;
                    comboMarcas.ValueMember = "id_marca";
                    comboMarcas.DisplayMember = "marca";
                }
            }
            catch (Exception)
            {
                FrmModalAlert modal = new FrmModalAlert("Error", "No es posible listar las marcas de los productos", "error");
                modal.ShowDialog();
            }
        }

        private void FrmVender_Load(object sender, EventArgs e)
        {
            btnVender.Text = "(F5)\nProcesar";
            ListCostumesCombo();
            ListToMark();
            for (int i = 0; i < 25; i++)
            {
                flowLayoutPanelItems.Controls.Add(makeControl.CreateItemShop(Convert.ToString(i)));
            }
        }

        private void btnCollasp_Click(object sender, EventArgs e)
        {
            if (panelListado.Width == 250)
            {
                panelListado.Width = 0;
            }
            else
            {
                panelListado.Width = 250;
            }
        }

        private void ExistenciasStatus()
        {
            try
            {
                
                switch (Existencias)
                {
                    case true:
                        checkPicExistencias.Image = Properties.Resources.checkbox_true_35_32x;
                        Existencias = false;
                        break;
                    case false:
                        checkPicExistencias.Image = Properties.Resources.checkbox_empty_35_32x;
                        Existencias = true;
                        FrmModalAlert modal = new FrmModalAlert("Solo se mostraran solo su stock que tenga en almacén");
                        modal.ShowDialog();
                        break;
                    default:
                        checkPicExistencias.Image = Properties.Resources.checkbox_empty_35_32x;
                        Existencias = false;
                        break;
                }
            }
            catch (Exception)
            {

            }
        }

        private void lblExistencias_Click(object sender, EventArgs e)
        {
            ExistenciasStatus();
        }

        private void checkPicExistencias_Click(object sender, EventArgs e)
        {
            ExistenciasStatus();
        }
    }
}
