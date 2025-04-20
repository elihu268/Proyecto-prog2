using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog.LayoutRenderers;

namespace Sistema_Ventas.Model
{
    public class Producto
    {
        public int IdProduco { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }

        public double Precio { get; set; }

        public string Descripcion { get; set; }
        public int Existencia { get; set; }

        public Producto(int idProducto,string codigo,string nombre,double precio,string  descripcion, int existencia) {
        this.IdProduco = idProducto;
            this.Codigo = codigo; 
            this.Nombre = nombre;
            this.Precio = precio;
            this.Descripcion = descripcion;
            this.Existencia = existencia;
        }
        
        public void CalcularIVA()
        {
            this.Precio = this.Precio * 0.16;
        }
    }
}
