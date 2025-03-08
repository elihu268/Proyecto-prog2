using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Sistema_Ventas.Utilities
{
    internal class Validaciones
    {
        public static bool EsCorreoValido(string correo)//static no llamar un objeto 
        {
            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            //es boleano--
            return Regex.IsMatch(correo, patron);
        }
    }
}
