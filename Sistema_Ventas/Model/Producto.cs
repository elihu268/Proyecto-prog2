using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Ventas.Model
{
    public class Producto
    {
        public int IdProduco { get; set; }
        public string IdCodigo { get; set; }
        public string Nombre { get; set; }

        public double Precio { get; set; }

        public string Descripcion { get; set; }
        public int Existencia { get; set; }

    }
}
