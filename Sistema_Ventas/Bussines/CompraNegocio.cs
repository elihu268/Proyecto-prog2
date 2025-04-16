using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Ventas.Utilities;

namespace Sistema_Ventas.Bussines
{
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
    
}
