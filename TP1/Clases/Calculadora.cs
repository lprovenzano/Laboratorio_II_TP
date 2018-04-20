using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Calculadora
    {
        /// <summary>
        /// Valido que el string ingresado sea un operador válido
        /// </summary>
        /// <param name="operador">operador</param>
        /// <returns></returns>
        private static string ValidarOperador(string operador)
        {
            string[] operadores = new string[] { "+", "-", "*", "/" };

            if (operadores.Contains(operador))
                return operador;
            else
                return "+";
        }

        /// <summary>
        /// Toma los numeros ingresados y realiza la operacion especificada.
        /// </summary>
        /// <param name="n1">Primer operador</param>
        /// <param name="n2">Segundo operador</param>
        /// <param name="operador">operacion</param>
        /// <returns></returns>
        public static double Operar(Numero n1, Numero n2, string operador)
        {
            switch (ValidarOperador(operador))
            {
                case "+":
                    return n1 + n2;
                case "-":
                    return n1 - n2;
                case "*":
                    return n1 * n2;
                case "/":
                    return n1 / n2;
            }
            return n1 + n2;

        }
    }
}
