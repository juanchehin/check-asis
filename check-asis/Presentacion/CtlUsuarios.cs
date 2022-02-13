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
            //dataListadoUsuarios.Columns[2].Visible = false;
            //dataListadoUsuarios.Columns[5].Visible = false;
            //dataListadoUsuarios.Columns[6].Visible = false;
        }

        private void lblAnuncioIcono_Click(object sender, EventArgs e)
        {
            MostrarPanelIcono();
        }       
        private void ocultarPanelIconos()
        {
            panelIcono.Visible = false;
            lblAnuncioIcono.Visible = false;
            Icono.Visible = true;
        }
        private void MostrarPanelIcono()
        {
            panelIcono.Visible = true;
            panelIcono.Dock = DockStyle.Fill;
            panelIcono.BringToFront();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Icono.Image = pictureBox3.Image;
            ocultarPanelIconos();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Icono.Image = pictureBox4.Image;
            ocultarPanelIconos();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Icono.Image = pictureBox5.Image;
            ocultarPanelIconos();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Icono.Image = pictureBox6.Image;
            ocultarPanelIconos();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Icono.Image = pictureBox7.Image;
            ocultarPanelIconos();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Icono.Image = pictureBox8.Image;
            ocultarPanelIconos();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Icono.Image = pictureBox9.Image;
            ocultarPanelIconos();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            Icono.Image = pictureBox10.Image;
            ocultarPanelIconos();
        }

        private void AgregarIconoPC_Click(object sender, EventArgs e)
        {
            dlg.InitialDirectory = "";
            dlg.Filter = "Imagenes|*.jpg;*.png";
            dlg.FilterIndex = 2;
            dlg.Title = "Cargador de imagenes";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Icono.BackgroundImage = null;
                Icono.Image = new Bitmap(dlg.FileName);
                ocultarPanelIconos();
            }
        }

        private void Icono_Click(object sender, EventArgs e)
        {
            MostrarPanelIcono();
        }

        private void CtlUsuarios_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            panelRegistro.Visible = false;
            btnActualizar.Visible = true;
        }

        private void btnVolverIcono_Click(object sender, EventArgs e)
        {
            ocultarPanelIconos();
        }

        private void dataListadoUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            estado = dataListadoUsuarios.Rows[e.RowIndex].Cells["Estado"].Value.ToString();
            IdUsuario = Convert.ToInt32(dataListadoUsuarios.Rows[e.RowIndex].Cells["IdUsuario"].Value);

            if (e.ColumnIndex == dataListadoUsuarios.Columns["Editar"].Index)
            {
                //obtenerEstado();
                btnActualizar.Visible = false;
                if (estado == "ELIMINADO")
                {
                    DialogResult resultado = MessageBox.Show("Este Usuario se Elimino. ¿Desea Volver a Habilitarlo?", "Restauracion de registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (resultado == DialogResult.OK)
                    {
                        RestaurarUsuario();
                    }
                }
                else
                {
                    txtNombre.Text = dataListadoUsuarios.Rows[e.RowIndex].Cells["NombreApellidos"].Value.ToString();
                    txtUsuario.Text = dataListadoUsuarios.Rows[e.RowIndex].Cells["Login"].Value.ToString();
                    txtContraseña.Text = dataListadoUsuarios.Rows[e.RowIndex].Cells["Password"].Value.ToString();

                    Icono.BackgroundImage = null;
                    byte[] b = (byte[])(dataListadoUsuarios.Rows[e.RowIndex].Cells["Icono"].Value);
                    MemoryStream ms = new MemoryStream(b);
                    Icono.Image = Image.FromStream(ms);

                    ObtenerDatos();
                }

            }
            if (e.ColumnIndex == dataListadoUsuarios.Columns["Eliminar"].Index)
            {
                DialogResult resultado = MessageBox.Show("¿Realmente desea eliminar este Registro?", "Eliminando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (resultado == DialogResult.OK)
                {
                    //capturarIdUsuario();
                    IdUsuario = Convert.ToInt32(dataListadoUsuarios.Rows[e.RowIndex].Cells["IdUsuario"].Value);
                    EliminarUsuarios();
                }

            }
        }
        private void obtenerEstado()
        {
            //estado = dataListadoUsuarios.SelectedCells[7].Value.ToString();.
            //estado = dataListadoUsuarios.Rows[e.RowIndex].Cells["Estado"].Value.ToString()
            //Console.WriteLine(estado);
        }
        private void ObtenerDatos()
        {
            //capturarIdUsuario();
            //txtNombre.Text = dataListadoUsuarios.SelectedCells[3].Value.ToString();
            //txtUsuario.Text = dataListadoUsuarios.SelectedCells[4].Value.ToString();
            if (txtUsuario.Text == "admin")
            {
                txtUsuario.Enabled = false;
                dataListadoModulos.Enabled = false;
            }
            else
            {
                txtUsuario.Enabled = true;
                dataListadoModulos.Enabled = true;
            }
            //txtContraseña.Text = dataListadoUsuarios.SelectedCells[5].Value.ToString();

            /*Icono.BackgroundImage = null;
            byte[] b = (byte[])(dataListadoUsuarios.SelectedCells[6].Value);
            MemoryStream ms = new MemoryStream(b);
            Icono.Image = Image.FromStream(ms);*/
            panelRegistro.Visible = true;
            panelRegistro.Dock = DockStyle.Fill;
            //lblanuncioIcono.Visible = false;
            //btnActualizar.Visible = true;
            btnGuardar.Visible = false;
            MostrarModulos();
            mostrarPermisos();
        }

        private void RestaurarUsuario()
        {
            capturarIdUsuario();
            Lusuarios parametros = new Lusuarios();
            Dusuarios funcion = new Dusuarios();
            parametros.IdUsuario = IdUsuario;
            if (funcion.restaurar_usuario(parametros) == true)
            {
                MostrarUsuarios();
            }
        }
        private void capturarIdUsuario()
        {
            IdUsuario = Convert.ToInt32(dataListadoUsuarios.SelectedCells[2].Value);
            login = dataListadoUsuarios.SelectedCells[4].Value.ToString();
        }
        private void mostrarPermisos()
        {
            DataTable dt = new DataTable();
            Dpermisos funcion = new Dpermisos();
            Lpermisos parametros = new Lpermisos();
            parametros.IdUsuario = IdUsuario;
            funcion.mostrar_Permisos(ref dt, parametros);
            foreach (DataRow rowPermisos in dt.Rows)
            {
                int idmoduloPermisos = Convert.ToInt32(rowPermisos["IdModulo"]);
                foreach (DataGridViewRow rowModulos in dataListadoModulos.Rows)
                {
                    int Idmodulo = Convert.ToInt32(rowModulos.Cells["IdModulo"].Value);
                    if (idmoduloPermisos == Idmodulo)
                    {
                        rowModulos.Cells[0].Value = true;
                    }
                }
            }
        }
        private void EliminarUsuarios()
        {
            Lusuarios parametros = new Lusuarios();
            Dusuarios funcion = new Dusuarios();
            parametros.IdUsuario = IdUsuario;
            parametros.Login = login;
            if (funcion.eliminar_Usuarios(parametros) == true)
            {
                MostrarUsuarios();
            }
        }
    }
}
