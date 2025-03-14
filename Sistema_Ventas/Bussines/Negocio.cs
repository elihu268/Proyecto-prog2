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
            internal static bool EsTelefonoValido(string telefono)
            {
                return Validaciones.ValidarTelefono(telefono);
            }
        }
        internal class CompraNegocio
        {
            internal static bool EsCantidadValida(string cantidad)
            {
                return Validaciones.EsMayorACero(cantidad);
            }
        }
        internal class RolNegocio
        {
            internal static bool EsCodigoValido(string codigo)
            {
                return Validaciones.EsCodigoRolValido(codigo);
            }
        }
        internal class ClientesNegocio
        {
            internal static bool EsRFCValido(string rfc)
            {
                return Validaciones.ValidarRFC(rfc);
            }
            internal static bool EsTelefonoValido(string telefono)
            {
                return Validaciones.ValidarTelefono(telefono);
            }
            internal static bool EsFormatoValido(string correo)
            {
                return Validaciones.EsCorreoValido(correo);
            }
        }
        

    }
}
