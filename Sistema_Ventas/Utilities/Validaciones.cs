using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace Sistema_Ventas.Utilities
{
    class Validaciones
    {
        /// <summary>
        /// validar que el string sea un correo
        /// </summary>
        /// <param name="correo"> recepcion de correo</param>
        /// <returns>retorna verdadreo si es un formato de correo</returns>
        public static bool EsCorreoValido(string correo)
        {
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(correo, patron);
        }
       /// <summary>
       /// validar que es un numero entero mayor a cero
       /// </summary>
       /// <param name="numero">recibe una cadena</param>
       /// <returns>retorna falso si no es entero o tambien si es menor a 0</returns>
        public static bool EsMayorACero(String numero)
        {
            int resultado;
            if (int.TryParse(numero, out resultado))
            {
                return resultado > 0;
            }
            return false; 
        }

        /*public static bool EsUnNumeroEntero(String numeroEntero)
       {
           int resultado;

           return int.TryParse(numeroEntero, out resultado); 
       }*/
    }
}
