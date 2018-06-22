using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;


namespace Entidades
{
    public static class PaqueteDAO
    {
		#region Atributos
		private static SqlCommand _comando;
		private static SqlConnection _conexion;
		#endregion

		#region Metodos
		/// <summary>
		/// Ctor Paquete Data Acess Obj.
		/// </summary>
		static PaqueteDAO()
        {
            _conexion = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=correo-sp-2017;Integrated Security=True");
            _comando = new SqlCommand();
            _comando.CommandType = CommandType.Text;
            _comando.Connection = _conexion;
        }

		/// <summary>
		/// Inserta un paquete en la db.
		/// </summary>
		/// <param name="p">Paquete</param>
		/// <returns></returns>
        public static bool Insertar(Paquete p)
        {

            string queryString = string.Format("insert into Paquetes (direccionEntrega, trackingID, alumno) values ('{0}', '{1}', 'Luca Provenzano')", p.DireccionEntrega, p.TrackingID);

            try
            {
                _comando.CommandText = queryString;
                _conexion.Open();
                _comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _conexion.Close();
            }
            return true;
        }
		#endregion
	}
}
