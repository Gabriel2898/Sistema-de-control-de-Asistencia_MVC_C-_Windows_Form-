using ORUSCURSO.Logica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ORUSCURSO.Datos
{
   public class DcopiasBd
    {
		public bool InsertarCopiasBd()
		{
			try
			{
				CONEXIONMAESTRA.abrir();
				SqlCommand cmd = new SqlCommand("InsertarCopiasBd", CONEXIONMAESTRA.conectar);			
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
		public void MostrarRuta(ref string ruta)
		{
			try
			{
				CONEXIONMAESTRA.abrir();
				SqlCommand da = new SqlCommand("select Ruta from CopiasBd", CONEXIONMAESTRA.conectar);
				ruta =Convert.ToString(da.ExecuteScalar());
				CONEXIONMAESTRA.cerrar();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.StackTrace);
			}
		}
		public bool EditarCopiasBd(Lcopiasbd parametros)
		{
			try
			{
				CONEXIONMAESTRA.abrir();
				SqlCommand cmd = new SqlCommand("EditarCopiasBd", CONEXIONMAESTRA.conectar);
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
				CONEXIONMAESTRA.cerrar();
			}
		}
	}
}
