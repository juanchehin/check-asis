using check_asis.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace check_asis.Datos
{
    public class DAsistencias
    {
		public void buscarAsistenciasId(ref DataTable dt, int Idpersonal)
		{
			try
			{
				ConexionMaestra.abrir();
				SqlDataAdapter da = new SqlDataAdapter("buscarAsistenciasId", ConexionMaestra.conectar);
				da.SelectCommand.CommandType = CommandType.StoredProcedure;
				da.SelectCommand.Parameters.AddWithValue("@Idpersonal", Idpersonal);
				da.Fill(dt);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.StackTrace);
			}
			finally
			{
				ConexionMaestra.cerrar();
			}
		}
		public bool InsertarAsistencias(LAsistencias parametros)
		{
			try
			{
				ConexionMaestra.abrir();
				SqlCommand cmd = new SqlCommand("Insertar_ASISTENCIAS", ConexionMaestra.conectar);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@Id_personal", parametros.Id_personal);
				cmd.Parameters.AddWithValue("@Fecha_entrada", parametros.Fecha_entrada);
				cmd.Parameters.AddWithValue("@Fecha_salida", parametros.Fecha_salida);
				cmd.Parameters.AddWithValue("@Estado", parametros.Estado);
				cmd.Parameters.AddWithValue("@Horas", parametros.Horas);
				cmd.Parameters.AddWithValue("@Observacion", parametros.Observacion);
				cmd.ExecuteNonQuery();
				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.StackTrace);
				return false;
			}
			finally
			{
				ConexionMaestra.cerrar();
			}
		}
		public bool ConfirmarSalida(LAsistencias parametros)
		{
			try
			{
				ConexionMaestra.abrir();

				SqlCommand cmd = new SqlCommand("ConfirmarSalida", ConexionMaestra.conectar);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@Id_personal", parametros.Id_personal);
				cmd.Parameters.AddWithValue("@Fecha_salida", parametros.Fecha_salida);
				cmd.Parameters.AddWithValue("@Horas", parametros.Horas);
				cmd.ExecuteNonQuery();
				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.StackTrace);
				return false;
			}
			finally
			{
				ConexionMaestra.cerrar();
			}
		}
		public void mostrar_asistencias_diarias(ref DataTable dt, DateTime desde, DateTime hasta, int semana)
		{
			try
			{
				ConexionMaestra.abrir();
				SqlDataAdapter da = new SqlDataAdapter("mostrar_asistencias_diarias", ConexionMaestra.conectar);
				da.SelectCommand.CommandType = CommandType.StoredProcedure;
				da.SelectCommand.Parameters.AddWithValue("@desde", desde);
				da.SelectCommand.Parameters.AddWithValue("@hasta", hasta);
				da.SelectCommand.Parameters.AddWithValue("@semana", semana);
				da.Fill(dt);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.StackTrace);
			}
			finally
			{
				ConexionMaestra.cerrar();
			}
		}
	}
}
