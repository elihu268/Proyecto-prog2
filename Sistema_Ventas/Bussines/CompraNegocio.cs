using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Sistema_Ventas.Utilities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sistema_Ventas.Bussines
{
    internal class CompraNegocio
    {
        public const int CANTIDAD_MIN = 3;
        /// <summary>
        /// Valida que la cantidad sea mayor a cero
        /// </summary>
        /// <param name="cantidad">Cantidad a validar</param>
        /// <returns>True si la cantidad es válida</returns>
        internal static bool EsCantidadValida(string cantidad)
            {
                return Validaciones.EsMayorACero(cantidad);
            }
        internal static bool CantidadEnRango(string cantidad, int cantidadStock)
        {
            try
            {

                int cant;
                int resultado;
                int.TryParse(cantidad, out cant);
                resultado = cantidadStock-cant;
                if (resultado <= CANTIDAD_MIN)
                {
                    return false;
                }
                return true;
            }
            catch (Exception e)
            {

                throw;
            }
            
    }
    }
    
}
