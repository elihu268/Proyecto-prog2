using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        public static bool EsMayorACero(string numero)
        {
            int resultado;
            if (int.TryParse(numero, out resultado))
            {
                return resultado > 0;
            }
            return false; 
        }

        /// <summary>
        /// validar que el string sea un codigo valido para rol
        /// </summary>
        /// <param name="codigo"> recepcion de cadena</param>
        /// <returns>retorna verdadero si es un formato de codigo de rol</returns>
        public static bool EsCodigoRolValido(string codigo)
        {
            string patron = @"^[A-Z]{2,4}-\d{3,4}$";
            return Regex.IsMatch(codigo, patron);
        }
 
        /// <summary>
        /// metodo para saber si es un numero
        /// </summary>
        /// <param name="cadena">intenta pasar una cadena a numero</param>
        /// <returns>si es numero retorna verdadero</returns>
        public static bool EsUnNumero(string cadena)
        {
            int resultado;
            return (int.TryParse(cadena, out resultado));
        }
    }
}
