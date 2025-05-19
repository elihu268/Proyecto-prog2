
using Sistema_VentasCore.Utilities;

namespace Sistema_VentasCore.Bussines
{
    public class UsuariosNegocio
    {
        /// <summary>
        /// Valida el formato de un correo electrónico
        /// </summary>
        /// <param name="correo">Correo electrónico a validar</param>
        /// <returns>True si el formato es válido</returns>
        public static bool EsFormatoValido(string correo)
            {
                return Validaciones.EsCorreoValido(correo);
            }

            /// <summary>
            /// Valida el formato de un número telefónico
            /// </summary>
            /// <param name="telefono">Número telefónico a validar</param>
            /// <returns>True si el formato es válido</returns>
            public static bool EsTelefonoValido(string telefono)
            {
                return Validaciones.ValidarTelefono(telefono);
            }
    }
}
