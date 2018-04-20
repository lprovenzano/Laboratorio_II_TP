using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Clases
{
    public class Numero
    {
        #region Atributos
        private double numero;
        #endregion

        #region Propiedades
        /// <summary>
        /// Setea un numero y valida.
        /// </summary>
        public string SetNumero {
            set
            {
                this.numero = this.ValidarNumero(value);
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Cto default
        /// </summary>
        public Numero() { }

        /// <summary>
        /// Cto de instancia con número double
        /// </summary>
        /// <param name="numero"></param>
        public Numero(double numero)
            : this()
        {
            this.numero = numero;
        }
        /// <summary>
        /// Ctor de instancia con string a número
        /// </summary>
        /// <param name="numero"></param>
        public Numero(string numero)
        {
            this.SetNumero = numero;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Comprobará que el valor recibido sea numérico, y lo retornará formato double. Caso contrario, retornará 0.
        /// </summary>
        /// <param name="numero">string numero</param>
        /// <returns></returns>
        private double ValidarNumero(string numero)
        {
            double valor;

            if (double.TryParse(numero, out valor))
                return valor;
            else
                return 0;
        }
        /// <summary>
        /// Convierte un número decimal a binario
        /// </summary>
        /// <param name="numDecimal">Numero decimal a convertir</param>
        /// <returns></returns>
        public string DecimalBinario(double numDecimal)
        {
            string binario = "";
            int numDecimalInt = Convert.ToInt32(numDecimal);

            if (numDecimalInt == 0)
            {
                binario = "0";
            }

            while (numDecimalInt > 0)
            {
                //Traigo el resto.
                double operacion = numDecimalInt % 2;
                //Divido
                numDecimalInt /= 2;
                if (operacion == 0 || operacion == 1)
                {
                    binario += Convert.ToString(operacion) + "";
                }
            }

            return ReverseString(binario);

        }

        /// <summary>
        /// Convierte un número decimal a binario
        /// </summary>
        /// <param name="numDecimal">Numero decimal a convertir</param>
        /// <returns></returns>
        public string DecimalBinario(string numDecimal)
        {
            Regex Val = new Regex(@"[0-9]$");

            numDecimal = numDecimal.Replace(" ", "");

            if (Val.IsMatch(numDecimal))
            {
                return this.DecimalBinario(Convert.ToDouble(numDecimal));
            }
            else
            {
                return "Valor invalido";
            }

        }

        /// <summary>
        /// Convierte de numero binario a decimal.
        /// </summary>
        /// <param name="numBinario">numero binario</param>
        /// <returns></returns>
        public string BinarioDecimal(string numBinario)
        {
            //Uso una expresion regular para validar que solo contenga 0-1 el string, con que solo haya un caracter
            //que no sea 0-1 no hay match, por lo tanto false.
            Regex Val = new Regex(@"[0-1]$");

            numBinario = numBinario.Replace(" ", "");

            if (Val.IsMatch(numBinario))
            {
                numBinario = ReverseString(numBinario);
                int digito;
                int i = 0;
                double numDouble = 0;

                while (numBinario.Contains("0") || numBinario.Contains("1"))
                {
                    digito = (int)Char.GetNumericValue(numBinario[i]);
                    numDouble += digito * (Math.Pow(2, i));
                    i++;

                    if (i == numBinario.Length)
                    {
                        break;
                    }
                }

                return numDouble.ToString();
            }
            else
            {
                return "Valor invalido";
            }

        }

        /// <summary>
        /// Revierte un string del último al primero.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        #endregion

        #region Sobrecargas

        /// <summary>
        /// Sobrecarga suma
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator +(Numero n1, Numero n2)
        {
            return n1.numero + n2.numero;
        }

        /// <summary>
        /// Sobrecarga resta
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator -(Numero n1, Numero n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Sobrecarga multiplicacion
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator *(Numero n1, Numero n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Sobrecarga division
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double operator /(Numero n1, Numero n2)
        {
            return n1.numero / n2.numero;
        }
        #endregion
    }
}
