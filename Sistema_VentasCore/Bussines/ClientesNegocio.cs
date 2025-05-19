using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_VentasCore.Utilities;

namespace Sistema_VentasCore.Bussines
{
    /// <summary>
    /// Clase para manejar reglas de negocio relacionadas con clientes
    /// </summary>
    public class ClientesNegocio
    {
        /// <summary>
        /// Valida el formato de un RFC
        /// </summary>
        /// <param name="rfc">RFC a validar</param>
        /// <returns>True si el formato es válido</returns>
        public static bool EsRFCValido(string rfc)
        {
            return Validaciones.ValidarRFC(rfc);
        }

        /// <summary>
        /// Valida el formato de un número telefónico para clientes
        /// </summary>
        /// <param name="telefono">Número telefónico a validar</param>
        /// <returns>True si el formato es válido</returns>
        public static bool EsTelefonoValido(string telefono)
        {
            return Validaciones.ValidarTelefono(telefono);
        }

        /// <summary>
        /// Valida el formato de un correo electrónico para clientes
        /// </summary>
        /// <param name="correo">Correo electrónico a validar</param>
        /// <returns>True si el formato es válido</returns>
        public static bool EsFormatoValido(string correo)
        {
            return Validaciones.EsCorreoValido(correo);
        }
    }
}