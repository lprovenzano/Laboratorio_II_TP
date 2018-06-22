using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Entidades
{
    public static class GuardaString
    {
		/// <summary>
		/// Método de extensión a String, el cual escribe su contenido en el archivo especificado en el Escritorio.
		/// </summary>
		/// <param name="texto">String base</param>
		/// <param name="archivo">Path</param>
		/// <returns></returns>
        public static bool Guardar(this string texto, string archivo)
        {
            string path;
            string subArchivo = archivo.Substring(0, 2);

            if (string.Compare(subArchivo, "\\\\") != 0)
                path = string.Format("{0}\\{1}", Environment.GetFolderPath(Environment.SpecialFolder.Desktop), archivo);
            else
                return false;

            StreamWriter sw = new StreamWriter(path, true);

            try
            {
                sw.WriteLine(texto);
                return true;
            }
            catch (FileNotFoundException e)
            {
                throw new FileNotFoundException("No se encontro el archivo", e);
            }
            catch (DirectoryNotFoundException e)
            {
                throw new DirectoryNotFoundException("No se encontro el directorio", e);
            }
            catch (PathTooLongException e)
            {
                throw new PathTooLongException("El nombre del archivo es muy largo", e);
            }
            catch (Exception e)
            {
                throw new Exception("Ha ocurrido un error", e);
            }
            finally
            {
                sw.Close();
            }

        }
    }
}
