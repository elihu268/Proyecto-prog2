using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_VentasCore.Model
{
    public class VentaPorArticulo
    {
        public int IdCompra { get; set; }
        public int CodigoCompra { get; set; }
        public DateTime FechaCompra { get; set; }
        public int IdCliente { get; set; }
        public int Cantidad { get; set; }
    }
}
