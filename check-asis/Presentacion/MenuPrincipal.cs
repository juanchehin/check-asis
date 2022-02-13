using check_asis.Datos;
using check_asis.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace check_asis.Presentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        public int Idusuario;
        public string LoginV;
        string Base_De_datos = "ORUS369";
        string Servidor = @".\SQLEXPRESS";
        string ruta;
        private void btnPersonal_Click(object sender, EventArgs e)
        {
            PanelPadre.Controls.Clear();
            Personal control = new Personal();
            control.Dock = DockStyle.Fill;
            PanelPadre.Controls.Add(control);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            PanelPadre.Controls.Clear();
            CtlUsuarios control = new CtlUsuarios();
            control.Dock = DockStyle.Fill;
            PanelPadre.Controls.Add(control);
        }
        private void validarPermisos()
        {
            DataTable dt = new DataTable();
            Dpermisos funcion = new Dpermisos();
            Lpermisos parametros = new Lpermisos();
            parametros.IdUsuario = Idusuario;
            funcion.mostrar_Permisos(ref dt, parametros);
            btnPlanilla.Enabled = false;
            btnPersonal.Enabled = false;
            btnRegistro.Enabled = false;
            btnUsuarios.Enabled = false;

            btnRestaurar.Enabled = false;
            btnRespaldos.Enabled = false;

            foreach (DataRow rowPermisos in dt.Rows)
            {
                string Modulo = Convert.ToString(rowPermisos["Modulo"]);
                if (Modulo == "PrePlanillas")
                {
                    btnPlanilla.Enabled = true;
                }
                if (Modulo == "Usuarios")
                {
                    btnUsuarios.Enabled = true;
                    btnRegistro.Enabled = true;
                }
                if (Modulo == "Personal")
                {
                    btnPersonal.Enabled = true;
                }
                if (Modulo == "Respaldos")
                {
                    btnRespaldos.Enabled = true;
                    btnRestaurar.Enabled = true;
                }



            }
        }

        private void btnPlanilla_Click(object sender, EventArgs e)
        {
            PanelPadre.Controls.Clear();
            Preplanilla control = new Preplanilla();
            control.Dock = DockStyle.Fill;
            PanelPadre.Controls.Add(control);
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Dispose();
            TomarAsistencia frm = new TomarAsistencia();
            frm.ShowDialog();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRespaldos_Click(object sender, EventArgs e)
        {
            PanelPadre.Controls.Clear();
            CopiasBD control = new CopiasBD();
            control.Dock = DockStyle.Fill;
            PanelPadre.Controls.Add(control);
        }
    }
}
