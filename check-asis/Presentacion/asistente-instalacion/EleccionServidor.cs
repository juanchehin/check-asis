using System;
using System.Windows.Forms;

namespace check_asis.Presentacion.asistente_instalacion
{
    public partial class EleccionServidor : Form
    {
        public EleccionServidor()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {            
            // Seleccion de PC principal
            if(rbPrincipal.Checked)
            {
                Dispose();
                InstalacionBD frm = new InstalacionBD();
                frm.ShowDialog();
            }
            // Seleccion de PC de punto de control
            if (rbControl.Checked)
            {
                Dispose();
                ConexionRemota frm = new ConexionRemota();
                frm.ShowDialog();

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
