
using Sistema_Ventas.Utilities;

namespace Sistema_Ventas.Bussines
{
    internal class UsuariosNegocio
    {
        /// <summary>
        /// Valida el formato de un correo electrónico
        /// </summary>
        /// <param name="correo">Correo electrónico a validar</param>
        /// <returns>True si el formato es válido</returns>
        internal static bool EsFormatoValido(string correo)
            {
                return Validaciones.EsCorreoValido(correo);
            }

            /// <summary>
            /// Valida el formato de un número telefónico
            /// </summary>
            /// <param name="telefono">Número telefónico a validar</param>
            /// <returns>True si el formato es válido</returns>
            internal static bool EsTelefonoValido(string telefono)
            {
                return Validaciones.ValidarTelefono(telefono);
            }
    }
}
