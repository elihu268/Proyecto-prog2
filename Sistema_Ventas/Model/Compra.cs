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
        public double Descuento { get; set; }
        public int Total { get; set; }
        public DateTime FechaCompra { get; set; }
        public int Estatus { get; set; }

        public Compra(int id_compra,int id_cliente,string codigo,int metodo_de_pago,double iva,double subtotal,double descuento,int total,DateTime fecha_de_compra, int estatus)
        {
            this.IdCompra = id_compra;
            this.IdCliente = id_cliente;
            this.Codigo = codigo;
            this.MetodoPago = metodo_de_pago;
            this.Iva = iva;
            this.Subtotal = subtotal;
            this.Descuento = descuento;
            this.Total = total;
            this.FechaCompra = fecha_de_compra;
            this.Estatus = estatus;
        }
    }
}
