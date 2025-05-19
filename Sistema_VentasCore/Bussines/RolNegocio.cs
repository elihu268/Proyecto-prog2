using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Sistema_VentasCore.Bussines
{
    public class RolNegocio
    {
        /// <summary>
        /// Valida el formato del código de un rol
        /// Verifica que el string sea un codigo valido para rol
        /// </summary>
        /// <param name="codigo"> recepcion de cadena</param>
        /// <returns>retorna verdadero si es un formato de codigo de rol</returns>
        public static bool EsCodigoValido(string codigo)
        {
            string patron = @"^[A-Z]{2,4}-\d{4}$";
            return Regex.IsMatch(codigo, patron);
        }

    }
    
}
