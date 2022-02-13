using check_asis.Logica;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace check_asis.Datos
{
	internal class DCopiasBD
	{
		public bool InsertarCopiasBd()
		{
			try
			{
				ConexionMaestra.abrir();
				SqlCommand cmd = new SqlCommand("InsertarCopiasBd", ConexionMaestra.conectar);
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
				ConexionMaestra.cerrar();
			}
		}
		public void MostrarRuta(ref string ruta)
		{
			try
			{
				ConexionMaestra.abrir();
				SqlCommand da = new SqlCommand("select Ruta from CopiasBd", ConexionMaestra.conectar);
				ruta = Convert.ToString(da.ExecuteScalar());
				ConexionMaestra.cerrar();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.StackTrace);
			}
		}
		public bool EditarCopiasBd(LCopiasBD parametros)
		{
			try
			{
				ConexionMaestra.abrir();
				SqlCommand cmd = new SqlCommand("EditarCopiasBd", ConexionMaestra.conectar);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@Ruta", parametros.Ruta);
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
				ConexionMaestra.cerrar();
			}
		}
	}
}
