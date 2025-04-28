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
        public int MetodoDePago { get; set; }
        public decimal Iva { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }
        public DateTime FechaDeCompra { get; set; }
        public int Estatus { get; set; }

        public List<DetalleCompra> Detalles { get; set; } = new();
        public int MetodoPago { get; internal set; }
        public DateTime FechaCompra { get; internal set; }

        // Constructor para crear una nueva compra desde la interfaz
        public Compra(int idCliente, string codigo, int metodoDePago, decimal descuento)
        {
            IdCliente = idCliente;
            Codigo = codigo;
            MetodoDePago = metodoDePago;
            Descuento = descuento;
            FechaDeCompra = DateTime.Today;
            Estatus = 1;
        }

        // Constructor vacío (recomendado para ORM o deserialización)
        public Compra() { }

        // Método para calcular los valores y preparar la compra antes de guardar
        public void CalcularTotales()
        {
            Subtotal = Detalles.Sum(d => d.TotalPorUnidad);
            Iva = Subtotal * 0.16m; 
            Total = Subtotal + Iva - Descuento;
        }
    }

}
