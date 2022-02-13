using check_asis.Datos;
using check_asis.Logica;
using System;
using System.Data;
using System.Windows.Forms;

namespace check_asis.Presentacion
{
    public partial class TomarAsistencia : Form
    {
        public TomarAsistencia()
        {
            InitializeComponent();
        }
        string Identificacion;
        int IdPersonal;
        int Contador;
        DateTime fechaReg;

        private void timerHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void BuscarPersonalIdent()
        {
            DataTable dt = new DataTable();
            Dpersonal funcion = new Dpersonal();
            funcion.BuscarPersonalIdentidad(ref dt, txtIdentificacion.Text);
            if (dt.Rows.Count > 0)
            {
                Identificacion = dt.Rows[0]["Identificacion"].ToString();
                IdPersonal = Convert.ToInt32(dt.Rows[0]["Id_personal"]);
                // lblNombre.Text = dt.Rows[0]["Nombres"].ToString();
            }
        }

        private void txtIdentificacion_TextChanged(object sender, EventArgs e)
        {
            /*BuscarPersonalIdent();
            if (Identificacion == txtIdentificacion.Text)
            {
                MessageBox.Show("Entrada Registrada", "Check-asis");
                
                buscarAsistenciasId();
                if (Contador == 0)
                {
                    InsertarAsistencias();


                    DialogResult resultado = MessageBox.Show("¿Agregar una Observacion?", "Observaciones", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (resultado == DialogResult.OK)
                    {
                        panelObservacion.Visible = true;
                        panelObservacion.Location = new Point(Panel1.Location.X, Panel1.Location.Y);
                        panelObservacion.Size = new Size(Panel1.Width, Panel1.Height);
                        panelObservacion.BringToFront();
                        txtObservacion.Clear();
                        txtObservacion.Focus();

                }
                else
                    {
                        InsertarAsistencias();
                    }

                    
        }
                else
                {
                    ConfirmarSalida();
                }

            }
            */
        }
        private void buscarAsistenciasId()
        {
            DataTable dt = new DataTable();
            DAsistencias funcion = new DAsistencias();
            funcion.buscarAsistenciasId(ref dt, IdPersonal);
            Contador = dt.Rows.Count;
            if (Contador > 0)
            {
                fechaReg = Convert.ToDateTime(dt.Rows[0]["Fecha_entrada"]);

            }
        }

        private void InsertarAsistencias()
        {
            if (string.IsNullOrEmpty(txtObservaciones.Text))
            {
                // txtObservaciones.Text = "-";
            }
            LAsistencias parametros = new LAsistencias();
            DAsistencias funcion = new DAsistencias();
            parametros.Id_personal = IdPersonal;
            parametros.Fecha_entrada = DateTime.Now;
            parametros.Fecha_salida = DateTime.Now;
            parametros.Estado = "ENTRADA";
            parametros.Horas = 0;
            parametros.Observacion = txtObservaciones.Text;
            if (funcion.InsertarAsistencias(parametros) == true)
            {
                // lblEntradaSalida.Text = "ENTRADA REGISTRADA";
                txtIdentificacion.Clear();
                txtIdentificacion.Focus();
                //panelObservacion.Visible = false;
            }

        }
        private void ConfirmarSalida()
        {
            LAsistencias parametros = new LAsistencias();
            DAsistencias funcion = new DAsistencias();
            parametros.Id_personal = IdPersonal;
            parametros.Fecha_salida = DateTime.Now;
            parametros.Horas = Bases.DateDiff(Bases.DateInterval.Hour, fechaReg, DateTime.Now);
            if (funcion.ConfirmarSalida(parametros) == true)
            {
                // lblEntradaSalida.Text = "SALIDA REGISTRADA";
                txtIdentificacion.Clear();
                txtIdentificacion.Focus();
            }

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            confirmarAsistencia();
        }

        private void confirmarAsistencia()
        {

            DialogResult resultado = MessageBox.Show("¿Desea confirmar la operacion?", "Check-asis", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                BuscarPersonalIdent();
                if (Identificacion == txtIdentificacion.Text)
                {
                    buscarAsistenciasId();
                    if (Contador == 0)
                    {
                        InsertarAsistencias();
                        MessageBox.Show("Entrada Registrada para " + Identificacion, "Check-asis");
                    }
                    else
                    {
                        ConfirmarSalida();
                        MessageBox.Show("Salida Registrada para " + Identificacion, "Check-asis");
                    }

                }
            }
            else
            {
                InsertarAsistencias();
            }
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            Dispose();
            Login frm = new Login();
            frm.ShowDialog();
        }

        private void txtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                confirmarAsistencia();
            }
            
        }
    }
}
