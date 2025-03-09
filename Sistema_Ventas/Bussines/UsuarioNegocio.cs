using Sistema_Ventas.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Ventas.Bussines
{
    class UsuarioNegocio
    {
        internal static bool EsCorreoValido(string correo)
        {
            return Validaciones.EsCorreoValido(correo);
        }
    }
}
