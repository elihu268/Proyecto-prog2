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
using Npgsql;
namespace Sistema_Ventas.Controller
{
    public class CompraController
    {
        private static readonly Logger _logger = LoggingManager.GetLogger("Sistema_Ventas.Controller.CompraController");
        private readonly CompraDataAccess _compraData;
        private readonly DetalleCompraDataAccess _detalleData;
        private readonly ProductosDataAccess _productoData;

        public CompraController()
        {
            try
            {
                _compraData = new CompraDataAccess();
                _detalleData = new DetalleCompraDataAccess();
                 _productoData= new ProductosDataAccess();

            }
            catch (Exception ex)
            {
                _logger.Error(ex, "error al inicializar el controlador de compra");
                throw;
            }
        }
        public decimal DatosCompraSubtotal(List<DetalleCompra> detalles)
        {
            decimal subtotal = detalles.Sum(d => d.Cantidad * d.Productoi.Precio);
            return subtotal;
        }
        public decimal DatosCompraIva(List<DetalleCompra> detalles)
        {
            decimal subtotal = DatosCompraSubtotal(detalles);
            decimal iva = subtotal * (decimal)0.16;
            return iva;
        }
        public decimal DatosCompraDescuento()
        {
            decimal des = 0;
            return des;
        }
        public decimal DatosCompraTotal(List<DetalleCompra> detalles)
        {
            decimal subtotal = DatosCompraSubtotal(detalles);
            decimal iva = DatosCompraIva(detalles);
            decimal descuento = DatosCompraDescuento();
            decimal total = subtotal + iva - descuento;
            return total;
        }

        public bool InsertarCompra(int idCliente, int estatus, int metodo, List<DetalleCompra> detalles)
        {
            // 1. Calcular totales
            decimal subtotal = DatosCompraSubtotal(detalles);
            decimal iva = DatosCompraIva(detalles);
            decimal descuento = DatosCompraDescuento();
            decimal total = subtotal + iva - descuento;

            try
            {
                // 2. Insertar en tabla compra
                int id_Compra = _compraData.InsertarCompra(idCliente, estatus, metodo, iva, subtotal, descuento, total);

               
                // 3. Insertar productos en detalle_compra y actualizar existencia
                foreach (var detalle in detalles)
                {
                    // Insertar en detalle_compra
                    bool detalleAgregado = _detalleData.AgregarProductoADetalle(id_Compra, detalle.Productoi, detalle.Cantidad);
                    if (!detalleAgregado)
                    {
                        _logger.Error($"Error al agregar el producto {detalle.Productoi.IdProducto} al detalle de compra.");
                        return false;
                    }

                    // Actualizar existencia del producto
                    bool existenciaModificada = _productoData.ModificarExistencia(detalle.Productoi.IdProducto, detalle.Cantidad);
                    if (!existenciaModificada)
                    {
                        _logger.Error($"Error al modificar la existencia del producto {detalle.Productoi.IdProducto}.");
                        return false;
                    }
                }

                _logger.Info($"Compra realizada exitosamente. ID: {id_Compra}");
                return true; // Retornar éxito solo después de insertar todos los detalles
            }
            catch (Exception ex)
            {
                // Manejo de excepciones en caso de fallos no controlados
                _logger.Error(ex, "Error al realizar la compra.");
                return false;
            }
        }

    }
}
