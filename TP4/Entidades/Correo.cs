using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Entidades
{
    public class Correo : IMostrar<List<Paquete>>
    {
        #region Atributos
        List<Thread> mockPaquetes;
        List<Paquete> paquetes;
        #endregion

        #region Propiedades
        public List<Paquete> Paquetes
        {
            get { return this.paquetes; }
            set { this.paquetes = value; }
        }
        #endregion

        #region Metodos
		/// <summary>
		/// Ctor Correo
		/// </summary>
        public Correo()
        {
            mockPaquetes = new List<Thread>();
            paquetes = new List<Paquete>();
        }

		/// <summary>
		/// Muestra cada paquete de la lista
		/// </summary>
		/// <param name="elemento">Lista de paquetes</param>
		/// <returns></returns>
        public string MostrarDatos(IMostrar<List<Paquete>> elemento)
        {
            StringBuilder sb = new StringBuilder();
            List<Paquete> paquetes = ((Correo)elemento).paquetes;

            foreach (var p in paquetes)
            {
                sb.AppendLine(string.Format("{0} para {1} ({2})", p.TrackingID, p.DireccionEntrega, p.Estado.ToString()));
            }

            return sb.ToString();
        }

		/// <summary>
		/// Sobrecarga sumando
		/// </summary>
		/// <param name="C">Correo</param>
		/// <param name="p">Paquete</param>
		/// <returns></returns>
        public static Correo operator +(Correo C, Paquete p)
        {
            foreach (var item in C.Paquetes)
            {
                if (item == p)
                    throw new TrackingIdRepetidoException(string.Format("El paquete {0} ya se encuentra en la lista de envios.", p.TrackingID), null);
            }

            C.Paquetes.Add(p);
            Thread t = new Thread(p.MockCicloDeVida);
            t.Start();
            C.mockPaquetes.Add(t);
            return C;
        }

		/// <summary>
		/// Termina todos los hilos en ejecución.
		/// </summary>
		public void FinEntregas()
        {
            foreach (var item in mockPaquetes)
            {
                item.Abort();
            }
        }

        #endregion

    }//Class
}//NameSpace
