using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using check_asis.Datos;
using check_asis.Logica;

namespace check_asis.Presentacion
{
    public partial class Personal : UserControl
    {
        public Personal()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // LocalizarDtvCargos();
            PanelCargos.Visible = false;
            PanelPaginado.Visible = false;
            PanelRegistros.Visible = true;
            PanelRegistros.Dock = DockStyle.Fill;
            btnGuardarPersonal.Visible = true;
            btnGuardarCambiosPersonal.Visible = false;
            // Limpiar();
        }
        private void Limpiar()
        {
            txtNombres.Clear();
            txtIdentifiacion.Clear();
            txtCargo.Clear();
            txtSueldoHora.Clear();
            BuscarCargos();
        }

        private void BuscarCargos()
        {
            DataTable dt = new DataTable();
            /*Dcargos funcion = new Dcargos();
            funcion.buscarCargos(ref dt, txtCargo.Text);
            datalistadoCargos.DataSource = dt;
            Bases.DiseñoDtv(ref datalistadoCargos);
            datalistadoCargos.Columns[1].Visible = false;
            datalistadoCargos.Columns[3].Visible = false;
            datalistadoCargos.Visible = true;*/
        }
    }
}
