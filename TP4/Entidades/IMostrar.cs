using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public interface IMostrar<T>
    {
        /// <summary>
        /// Muestra datos.
        /// </summary>
        /// <param name="elemento"></param>
        /// <returns></returns>
        string MostrarDatos(IMostrar<T> elementos);
    }
}
