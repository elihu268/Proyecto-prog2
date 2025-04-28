using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog.LayoutRenderers;

namespace Sistema_Ventas.Model
{
    public class DetalleCompra
    {
        public int IdDetalle { get; set; }
        public int IdCompra { get; set; } // Se asigna al guardar en base de datos
        public Producto Productoi { get; set; }
        public int Cantidad { get; set; }
        public decimal TotalPorUnidad { get; set; }
        public int IdProducto { get; internal set; }

        // Constructor para agregar detalle manualmente
        public DetalleCompra(Producto productoi, int cantidad)
        {
            Productoi = productoi;
            Cantidad = cantidad;
            TotalPorUnidad = cantidad * productoi.Precio;
        }

        // Constructor vacío
        public DetalleCompra() { }


    }
}
