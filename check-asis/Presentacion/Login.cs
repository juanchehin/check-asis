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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        string Usuario;
        int Idusuario;
        int Contador;
        string Indicador;

        private void Login_Load(object sender, EventArgs e)
        {
            validar_conexion();
        }
        private void validar_conexion()
        {
            VerificarConexion();
            if (Indicador == "Correcto")
            {
                MostrarUsuarios();
                if (Contador == 0)
                {
                    Dispose();
                    UsuarioPrincipal frm = new UsuarioPrincipal();
                    frm.ShowDialog();
                }
                else
                {
                    DibujarUsuarios();
                }

            }
            else
            {
                Dispose();
                ElecccionServidor frm = new ElecccionServidor();
                frm.ShowDialog();
            }
        }
    }
}
