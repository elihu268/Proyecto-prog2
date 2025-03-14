﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Ventas.Utilities;

namespace Sistema_Ventas.Bussines
{
    /// <summary>
    /// Clase principal que contiene la lógica de negocio del sistema
    /// </summary>
    internal class Negocio
    {
        /// <summary>
        /// Clase para manejar reglas de negocio relacionadas con usuarios
        /// </summary>
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

        /// <summary>
        /// Clase para manejar reglas de negocio relacionadas con compras
        /// </summary>
        internal class CompraNegocio
        {
            /// <summary>
            /// Valida que la cantidad sea mayor a cero
            /// </summary>
            /// <param name="cantidad">Cantidad a validar</param>
            /// <returns>True si la cantidad es válida</returns>
            internal static bool EsCantidadValida(string cantidad)
            {
                return Validaciones.EsMayorACero(cantidad);
            }
        }

        /// <summary>
        /// Clase para manejar reglas de negocio relacionadas con roles
        /// </summary>
        internal class RolNegocio
        {
            /// <summary>
            /// Valida el formato del código de un rol
            /// </summary>
            /// <param name="codigo">Código a validar</param>
            /// <returns>True si el formato es válido</returns>
            internal static bool EsCodigoValido(string codigo)
            {
                return Validaciones.EsCodigoRolValido(codigo);
            }
        }

        /// <summary>
        /// Clase para manejar reglas de negocio relacionadas con clientes
        /// </summary>
        internal class ClientesNegocio
        {
            /// <summary>
            /// Valida el formato de un RFC
            /// </summary>
            /// <param name="rfc">RFC a validar</param>
            /// <returns>True si el formato es válido</returns>
            internal static bool EsRFCValido(string rfc)
            {
                return Validaciones.ValidarRFC(rfc);
            }

            /// <summary>
            /// Valida el formato de un número telefónico para clientes
            /// </summary>
            /// <param name="telefono">Número telefónico a validar</param>
            /// <returns>True si el formato es válido</returns>
            internal static bool EsTelefonoValido(string telefono)
            {
                return Validaciones.ValidarTelefono(telefono);
            }

            /// <summary>
            /// Valida el formato de un correo electrónico para clientes
            /// </summary>
            /// <param name="correo">Correo electrónico a validar</param>
            /// <returns>True si el formato es válido</returns>
            internal static bool EsFormatoValido(string correo)
            {
                return Validaciones.EsCorreoValido(correo);
            }
        }
    }
}