using System;

namespace Entidades
{
    public class TrackingIdRepetidoException : Exception
    {
        #region Metodos

        public TrackingIdRepetidoException(string mensaje)
            : this(mensaje, null)
        {

        }

        public TrackingIdRepetidoException(string mensaje, Exception innerException)
            : base(mensaje, innerException)
        {

        }

        #endregion
    }
}
