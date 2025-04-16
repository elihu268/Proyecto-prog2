using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Ventas.Model
{
    public class DetalleCompra
    {
        public int IdCompra { get; set; }

        public int IdDetalle { get; set; }

        public int IdProducto { get; set; }

        public int cantidad { get; set; }
        public double TotalPorUnidad { get; set; }
    }
}
