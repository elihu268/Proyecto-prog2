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
        public int IdCompra { get; set; }
        public int IdProducto { get; set; }

        public int cantidad { get; set; }
        public double TotalPorUnidad { get; set; }
        //constructor
        public DetalleCompra(int id_detalle, int id_compra,int id_producto,int cantidad
) { 
            this.IdDetalle = id_detalle;
            this.IdCompra = id_compra;
            this.IdProducto = id_producto;
            this.cantidad = cantidad;
            this.TotalPorUnidad = CalcularTotalDetalle();
        }
        public double CalcularTotalDetalle()
        {
            double total =0;
            Producto producto = new Producto();
            double precio = producto.Precio;
            total=  this.cantidad*precio;
                return total;
        }
       
    }
}
