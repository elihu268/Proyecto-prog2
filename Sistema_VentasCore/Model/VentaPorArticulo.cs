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
        public string CodigoCompra { get; set; }
        public DateTime FechaCompra { get; set; }
        public string Cliente { get; set; }
        public int Cantidad { get; set; }
        public decimal Costo { get; set; }
        public string Estatus { get; set; }
    }
}
