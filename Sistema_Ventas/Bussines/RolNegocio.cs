using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Ventas.Utilities;

namespace Sistema_Ventas.Bussines
{
    internal class RolNegocio
    {
        
            /// <summary>
            /// Valida el formato del código de un rol
            /// </summary>
            /// <param name="codigo">Código a validar</param>
            /// <returns>True si el formato es válido</returns>
            public static bool EsCodigoValido(string codigo)
            {
                return Validaciones.EsCodigoRolValido(codigo);
            }
        }
    
}
