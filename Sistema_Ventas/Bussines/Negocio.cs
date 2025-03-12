using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Ventas.Utilities;

namespace Sistema_Ventas.Bussines
{
    internal class Negocio
    {
        internal class UsuariosNegocio
        {
            internal static bool EsFormatoValido(string correo)
            {
                return Validaciones.EsCorreoValido(correo);
            }
        }
        internal class CompraNegocio
        {
            internal static bool EsCantidadValida(string cantidad)
            {
                return Validaciones.EsMayorACero(cantidad);
            }
        }
    }
}
