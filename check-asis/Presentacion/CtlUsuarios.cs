using check_asis.Datos;
using check_asis.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace check_asis.Presentacion
{
    public partial class CtlUsuarios : UserControl
    {
        public CtlUsuarios()
        {
            InitializeComponent();
        }
        int IdUsuario;
        string login;
        string estado;
        private void Limpiar()
        {
            txtNombre.Clear();
            txtContraseña.Clear();
            txtUsuario.Clear();
            txtUsuario.Enabled = true;
            // datalistadoModulos.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Limpiar();
            habilitarPaneles();
            MostrarModulos();
        }
        private void insertarUsuarios()
        {
            Lusuarios parametros = new Lusuarios();
            Dusuarios funcion = new Dusuarios();
            parametros.Nombre = txtNombre.Text;
            parametros.Login = txtUsuario.Text;
            parametros.Password = txtContraseña.Text;
            MemoryStream ms = new MemoryStream();
            Icono.Image.Save(ms, Icono.Image.RawFormat);
            parametros.Icono = ms.GetBuffer();
            if (funcion.InsertarUsuarios(parametros) == true)
            {
                ObtenerIdUsuario();
                InsertarPermisos();
            }

        }
        private void ObtenerIdUsuario()
        {
            Dusuarios funcion = new Dusuarios();
            funcion.ObtenerIdUsuario(ref IdUsuario, txtUsuario.Text);

        }
        private void InsertarPermisos()
        {
            foreach (DataGridViewRow row in dataListadoModulos.Rows)
            {
                int IdModulo = Convert.ToInt32(row.Cells["IdModulo"].Value);
                bool marcado = Convert.ToBoolean(row.Cells["Marcar"].Value);
                if (marcado == true)
                {
                    Lpermisos parametros = new Lpermisos();
                    Dpermisos funcion = new Dpermisos();
                    parametros.IdModulo = IdModulo;
                    parametros.IdUsuario = IdUsuario;
                    funcion.Insertar_Permisos(parametros);

                }
            }
            MostrarUsuarios();
            panelRegistro.Visible = false;
        }
        private void habilitarPaneles()
        {
            panelRegistro.Visible = true;
            lblAnuncioIcono.Visible = true;
            panelIcono.Visible = false;
            panelRegistro.Dock = DockStyle.Fill;
            panelRegistro.BringToFront();
            btnGuardar.Visible = true;
            btnActualizar.Visible = false;
        }
        private void MostrarModulos()
        {
            Dmodulos funcion = new Dmodulos();
            DataTable dt = new DataTable();
            funcion.mostrar_Modulos(ref dt);
            dataListadoModulos.DataSource = dt;
            dataListadoModulos.Columns[1].Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNombre.Text))
            {
                if (!string.IsNullOrEmpty(txtUsuario.Text))
                {
                    if (!string.IsNullOrEmpty(txtContraseña.Text))
                    {
                        if (lblAnuncioIcono.Visible == false)
                        {
                            insertarUsuarios();
                        }
                        else
                        {
                            MessageBox.Show("Seleccione un Icono");

                        }

                    }
                    else
                    {
                        MessageBox.Show("Ingrese la contraseña");


                    }
                }
                else
                {
                    MessageBox.Show("Ingrese el Usuario");


                }
            }
            else
            {

                MessageBox.Show("Ingrese el Nombre");
            }
        }
        private void MostrarUsuarios()
        {
            DataTable dt = new DataTable();
            Dusuarios funcion = new Dusuarios();
            funcion.mostrar_Usuarios(ref dt);
            dataListadoUsuarios.DataSource = dt;
            DiseñarDtvUsuarios();
        }
        private void DiseñarDtvUsuarios()
        {
            Bases.DiseñoDtv(ref dataListadoUsuarios);
            Bases.DiseñoDtvEliminar(ref dataListadoUsuarios);
            dataListadoUsuarios.Columns[2].Visible = false;
            dataListadoUsuarios.Columns[5].Visible = false;
            dataListadoUsuarios.Columns[6].Visible = false;
        }
    }
}
