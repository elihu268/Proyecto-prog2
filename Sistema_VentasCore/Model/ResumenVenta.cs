using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_VentasCore.Model
{
    public class ResumenVenta
    {
        public string CodigoArticulo { get; set; }
        public int TotalVentas { get; set; }
        public List<VentaPorArticulo> Ventas { get; set; }

    }
}
