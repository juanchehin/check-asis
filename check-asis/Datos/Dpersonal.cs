using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using check_asis.Logica;
using System.Windows.Forms;

namespace check_asis.Datos
{
    public class Dpersonal
    {
		public bool InsertarPersonal(Lpersonal parametros)
		{
			try
			{
				CONEXIONMAESTRA.abrir();
				SqlCommand cmd = new SqlCommand("InsertarPersonal", CONEXIONMAESTRA.conectar);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@Nombres", parametros.Nombres);
				cmd.Parameters.AddWithValue("@Identificacion", parametros.Identificacion);
				cmd.Parameters.AddWithValue("@Pais", parametros.Pais);
				cmd.Parameters.AddWithValue("@Id_cargo", parametros.Id_cargo);
				cmd.Parameters.AddWithValue("@SueldoPorHora", parametros.SueldoPorHora);
				cmd.ExecuteNonQuery();
				return true;
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);
				return false;
			}
			finally
			{
				CONEXIONMAESTRA.cerrar();
			}
		}
	}
}
