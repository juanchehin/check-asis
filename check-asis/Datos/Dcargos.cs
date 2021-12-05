﻿using check_asis.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace check_asis.Datos
{
    public class Dcargos
    {
		public bool insertar_Cargo(Lcargos parametros)
		{
			try
			{
				ConexionMaestra.abrir();
				SqlCommand cmd = new SqlCommand("insertar_Cargo", ConexionMaestra.conectar);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@Cargo", parametros.Cargo);
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
				ConexionMaestra.cerrar();
			}
		}
		public bool editar_Cargo(Lcargos parametros)
		{
			try
			{
				ConexionMaestra.abrir();
				SqlCommand cmd = new SqlCommand("editar_Cargo", ConexionMaestra.conectar);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@id", parametros.Id_cargo);
				cmd.Parameters.AddWithValue("@Cargo", parametros.Cargo);
				cmd.Parameters.AddWithValue("@Sueldo", parametros.SueldoPorHora);
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
		public void buscarCargos(ref DataTable dt, string buscador)
		{
			try
			{
				ConexionMaestra.abrir();
				SqlDataAdapter da = new SqlDataAdapter("buscarCargos", ConexionMaestra.conectar);
				da.SelectCommand.CommandType = CommandType.StoredProcedure;
				da.SelectCommand.Parameters.AddWithValue("@buscador", buscador);
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
