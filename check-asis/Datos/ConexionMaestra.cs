using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace check_asis.Datos
{
    public class ConexionMaestra
    {
        //public static string conexion = Convert.ToString(Logica.Desencryptacion.checkServer());
        public static string conexion = @"Data source=DESKTOP-9BKC47G\SQLEXPRESS;Initial Catalog=check;Integrated Security=false";
        public static SqlConnection conectar = new SqlConnection(conexion);
        public static void abrir()
        {
            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }
        }
        public static void cerrar()
        {
            if (conectar.State == ConnectionState.Open)
            {
                conectar.Close();
            }
        }
    }
}
