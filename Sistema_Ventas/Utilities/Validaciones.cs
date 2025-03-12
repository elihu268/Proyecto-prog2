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
        public static bool EsCorreoValido(string correo)
        {
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(correo, patron);
        }
       
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
