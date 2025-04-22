using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Ventas.Data;
using Sistema_Ventas.Utilities;
using NLog;
using Sistema_Ventas.Model;
using System.Linq.Expressions;
namespace Sistema_Ventas.Controller
{
    public class CompraController
    {
        private static readonly Logger _logger = LoggingManager.GetLogger("Sistema_Ventas.Controller.CompraController");
        private readonly CompraDataAccess _compraData;
        private readonly DetalleCompraDataAccess _detalleData;

        public CompraController()
        {
            try
            {
                _compraData = new CompraDataAccess();
                _detalleData = new DetalleCompraDataAccess();

            }
            catch (Exception ex)
            {
                _logger.Error(ex, "error al inicializar el controlador de compra");
                throw;
            }
        }
        public bool InsertarCompra(List<DetalleCompra> detalles)
        {
            try { 
            decimal subtotal = detalles.Sum(d => d.Cantidad * d.Productoi.Precio);
            decimal iva = subtotal * 0.16m;
            decimal descuento = 0;
            decimal total = subtotal + iva - descuento;

            return true;
        }catch (Exception ex)
            {
                _logger.Error(ex, "error al insertar nueva compra");
                throw;
            }
}

    }
}
