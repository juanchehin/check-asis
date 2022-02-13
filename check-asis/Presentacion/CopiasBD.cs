using check_asis.Datos;
using check_asis.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace check_asis.Presentacion
{
    public partial class CopiasBD : UserControl
    {
        public CopiasBD()
        {
            InitializeComponent();
        }
        string ruta;
        string txtsoftware = "Check-Asis";
        string Base_De_datos = "checkasis";
        private Thread Hilo;
        private bool hiloFinalizado = false;

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            GenerarCopia();
        }
        private void GenerarCopia()
        {
            if (!string.IsNullOrEmpty(txtRuta.Text))
            {
                Hilo = new Thread(new ThreadStart(ejecucion));
                Hilo.Start();
                timer1.Start();

            }
            else
            {
                MessageBox.Show("Selecciona una Ruta donde Guardar las Copias de Seguridad", "Seleccione Ruta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRuta.Focus();
            }
        }
        private void ObtenerRuta()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtRuta.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        private void ejecucion()
        {
            string miCarpeta = "Copias_de_Seguridad_de_" + txtsoftware;
            if (System.IO.Directory.Exists(txtRuta.Text + miCarpeta))
            {

            }
            else
            {
                System.IO.Directory.CreateDirectory(txtRuta.Text + miCarpeta);
            }
            string ruta_completa = txtRuta.Text + miCarpeta;
            string SubCarpeta = ruta_completa + @"\Respaldo_al_" + DateTime.Now.Day + "_" + (DateTime.Now.Month) + "_" + DateTime.Now.Year + "_" + DateTime.Now.Hour + "_" + DateTime.Now.Minute;
            try
            {
                System.IO.Directory.CreateDirectory(System.IO.Path.Combine(ruta_completa, SubCarpeta));

            }
            catch (Exception)
            {

            }
            try
            {
                string v_nombre_respaldo = Base_De_datos + ".bak";
                ConexionMaestra.abrir();
                SqlCommand cmd = new SqlCommand("BACKUP DATABASE " + Base_De_datos + " TO DISK = '" + SubCarpeta + @"\" + v_nombre_respaldo + "'", ConexionMaestra.conectar);
                cmd.ExecuteNonQuery();
                hiloFinalizado = true;

            }
            catch (Exception ex)
            {
                hiloFinalizado = false;
                MessageBox.Show(ex.Message);

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hiloFinalizado == true)
            {
                timer1.Stop();
                editarRespaldos();

            }
        }

        // Inserta la nueva ruta en caso de que el usuario la modifique
        private void editarRespaldos()
        {
            LCopiasBD parametros = new LCopiasBD();
            DCopiasBD funcion = new DCopiasBD();
            parametros.Ruta = txtRuta.Text;
            if (funcion.EditarCopiasBd(parametros) == true)
            {
                MessageBox.Show("Copia de Base de datos Generada", "Generacion de Copia de Bd", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            ObtenerRuta();
        }
    }
}
