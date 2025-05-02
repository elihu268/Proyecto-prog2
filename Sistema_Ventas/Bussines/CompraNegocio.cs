using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Sistema_Ventas.Model;
using Sistema_Ventas.Utilities;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sistema_Ventas.Bussines
{
    internal class CompraNegocio
    {
        //internal const int CANTIDAD_MIN = 3;
        /// <summary>
        /// Valida que la cantidad sea mayor a cero
        /// </summary>
        /// <param name="cantidad">Cantidad a validar</param>
        /// <returns>True si la cantidad es válida</returns>
        internal static bool EsCantidadValida(string cantidad)
        {
            return Validaciones.EsMayorACero(cantidad);
        }
        internal static (decimal resultado,bool valido) EsDescuentoValido(string descuento){
            decimal desc=-1;
            bool valido=false;
            valido=Decimal.TryParse(descuento, out decimal val);
            if (valido==true&&(desc<0||desc>50))
            {
                valido = false;
            }
            return (desc,valido);
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
                return resultado >= 0;
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
    
     /// <summary>
     /// funcion para mostrar una notificacion si hay productos con existencia menor a la minima
     /// </summary>
     /// <param name="productos">lista de productos activos</param>
     /// <returns> bool para saber si hay productos con existencia minima, string para saber cuales son</returns>
      internal static (bool hay, string mnj)AlertaExistencia(List<Producto> productos)
        {
            int existenciaMinima = int.Parse(ConfigurationManager.AppSettings["ExistenciaMinima"]);//toma la variable appconfig 
            string mensaje = "\t\t¡Alerta!\n";
            bool hay = false;
            foreach (var producto in productos)
            {
                if (producto.Existencia <= existenciaMinima)
                {
                  
                         mensaje+= $"➮ El producto '{producto.Nombre}' tiene  {producto.Existencia} en existencia.\n";
                    hay= true;
                }
            }
            return (hay, mensaje);
        }
        }
    }
