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
        internal const int CANTIDAD_MIN = 3;
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

                if (!int.TryParse(cantidad, out int cant))
                {
                    // Si no se puede convertir la cantidad, no es válida
                    return false;
                }

                int resultado = cantidadStock - cant;
                return resultado >= CANTIDAD_MIN;
            }
            catch (Exception e)
            {

                throw;
            }
    }
        internal static int CalcularStock(string cantidad, int stock)
        {
            int cant;
            int nvoStock;
            int.TryParse(cantidad, out cant);
            nvoStock = stock - cant;
            return nvoStock;
        }
    }
    
}
