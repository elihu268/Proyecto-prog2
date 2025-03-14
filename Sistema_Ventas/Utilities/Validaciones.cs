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
        /// <param name="cadena">intenta pasar una cadena ingresada a numero</param>
        /// <returns>si es numero retorna verdadero</returns>
        public static bool EsUnNumero(string cadena)
        {
            int resultado;
            return (int.TryParse(cadena, out resultado));
        }
        /// <summary>
        /// metodo para saber si la cadena es un RFC
        /// </summary>
        /// <param name="rfc">se espera que el valor de la cadena RFC</param>
        /// <returns>se retorna un true si la cadena hace Ismach con la expresion regular y si coincide manda un true</returns>
        public static bool ValidarRFC(string rfc)
        {
            string patron = @"^([A-ZÑ\x26]{3,4}([0-9]{2})(0[1-9]|1[0-2])(0[1-9]|1[0-9]|2[0-9]|3[0-1])([A-Z]|[0-9]){2}([A]|[0-9]){1})?$";
            return Regex.IsMatch(rfc, patron);
        }
        /// <summary>
        /// metodo para saber si la cadena es telefono
        /// </summary>
        /// <param name="telefono">se captura el string de telefono</param>
        /// <returns>se retornara un true o false dependiendo si hace mach con la expresion regular</returns>
        public static bool ValidarTelefono(string telefono)
        {
            //string patron = @"^(\+)?(\d{1,2})?[( .-](\d{3})[) .-](\d{3,4})[ .-]?(\d{4})$";
            string patron = @"^\A[0-9]{7,10}\z";
            return Regex.IsMatch(telefono, patron);
        }
    }
}
