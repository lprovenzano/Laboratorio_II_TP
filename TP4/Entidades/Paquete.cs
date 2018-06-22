using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Entidades
{
    public class Paquete : IMostrar<Paquete>
    {
        #region Eventos
        public delegate void DelegadoEstado(object sender, EventArgs e);
        public event DelegadoEstado InformaEstado;
        #endregion

        #region Atributos
        private string direccionEntrega;
        private EEstado estado;
        private string trackingID;
        #endregion

        #region Propiedades
        public string DireccionEntrega
        {
            get { return this.direccionEntrega; }
            set { this.direccionEntrega = value; }
        }

        public EEstado Estado
        {
            get { return this.estado; }
            set { this.estado = value; }
        }

        public string TrackingID
        {
            get { return this.trackingID; }
            set { this.trackingID = value; }
        }
        #endregion

        #region Métodos

		/// <summary>
		/// Devuelve los datos del paquete.
		/// </summary>
		/// <param name="elementos">Un paquete</param>
		/// <returns></returns>
        public string MostrarDatos(IMostrar<Paquete> elementos)
        {
            return string.Format("{0} para {1}", TrackingID, DireccionEntrega);
        }

		/// <summary>
		/// Sobreescritura método ToString();
		/// </summary>
		/// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Tracking ID: {0} | ", TrackingID);
            sb.AppendFormat("Dirección: {0} |", DireccionEntrega);
            sb.AppendFormat("Estado: {0}", Estado);
            return sb.ToString();
        }

		/// <summary>
		/// Sobrecarga igualdad entre paquetes
		/// </summary>
		/// <param name="p1">Paquete 1</param>
		/// <param name="p2">Paquete 2</param>
		/// <returns></returns>
		public static bool operator ==(Paquete p1, Paquete p2)
        {
            //Si es cero, son iguales.
            return (string.Compare(p1.TrackingID, p2.TrackingID) == 0);
        }

		/// <summary>
		/// Sobrecarga desigualdad entre paquetes
		/// </summary>
		/// <param name="p1">Paquete 1</param>
		/// <param name="p2">Paquete 2</param>
		/// <returns></returns>
		public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }

		/// <summary>
		/// Cambia el estado del paquete cada 10 segundos e inserta en la base de datos el mismo junto con sus datos.
		/// </summary>
        public void MockCicloDeVida()
        {
            while (true)
            {
                Thread.Sleep(10 * 1000);
                InformaEstado.Invoke(this, EventArgs.Empty);

                if (estado != EEstado.Entregado)
                    estado++;
                else
                    break;
            }
            try
            {
                PaqueteDAO.Insertar(this);

            }
            catch (Exception e)
            {
                throw new Exception("No se pudo guardar.", e);
            }

        }

		/// <summary>
		/// Ctor Paquete
		/// </summary>
		/// <param name="direccion"></param>
		/// <param name="trackingID"></param>
        public Paquete(string direccion, string trackingID)
        {
            DireccionEntrega = direccion;
            TrackingID = trackingID;
            Estado = EEstado.Ingresado;
        }

		/// <summary>
		/// Enumerado estados del paquete
		/// </summary>
        public enum EEstado
        {
            Ingresado,
            EnViaje,
            Entregado
        }

        #endregion

    }//Class

}//NameSpace
