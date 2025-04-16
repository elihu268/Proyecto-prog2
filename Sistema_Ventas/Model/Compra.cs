using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Ventas.Model
{
    public class Compra
    {
        public int IdCompra { get; set; }
        public int IdCliente { get; set; }
        public string Codigo { get; set; }
        public int MetodoPago { get; set; }
        public double Iva { get; set; }
        public double Subtotal { get; set; }
        public int Estatus { get; set; }
        public double Descuento { get; set; }
        public int Total { get; set; }

        public DateTime FechaCompra { get; set; }
    }
}
