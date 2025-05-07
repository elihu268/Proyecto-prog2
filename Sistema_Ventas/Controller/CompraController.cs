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

        /// <summary>
        /// Constructor del controlador de compras.
        /// </summary>
        public CompraController()
        {
            try
            {
                _compraData = new CompraDataAccess();
                _detalleData = new DetalleCompraDataAccess();
                _productoData = new ProductosDataAccess();
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al inicializar el controlador de compra");
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

        /// <summary>
        /// Calcula el total de la compra.
        /// </summary>
        public decimal DatosCompraTotal(List<DetalleCompra> detalles)
        {
            decimal subtotal = DatosCompraSubtotal(detalles);
            decimal iva = DatosCompraIva(detalles);
            decimal descuento = DatosCompraDescuento();
            decimal total = subtotal + iva - descuento;
            return total;
        }

       /// <summary>
       /// insertar compra, perimmero la compra luego los detalles
       /// </summary>
       /// <param name="idCliente"> cliente </param>
       /// <param name="estatus">estatsu de la compra</param>
       /// <param name="metodo">metodo de pago</param>
       /// <param name="detalles">arrelo de detalles que tendran el mismo cliente e id de copra</param>
       /// <returns>verdadero si se inserto bien la compra con sus detalle</returns>
        public bool InsertarCompra(int idCliente, int estatus, int metodo, List<DetalleCompra> detalles)
        {
            decimal subtotal = DatosCompraSubtotal(detalles);
            decimal iva = DatosCompraIva(detalles);
            decimal descuento = DatosCompraDescuento();
            decimal total = subtotal + iva - descuento;
            //calculo para la compra
            try
            {
                int id_Compra = _compraData.InsertarCompra(idCliente, estatus, metodo, iva, subtotal, descuento, total);
                //insertar primero compra
                foreach (var detalle in detalles)//insertar los detalle
                {
                    bool detalleAgregado = _detalleData.AgregarProductoADetalle(id_Compra, detalle.Productoi, detalle.Cantidad);
                    if (!detalleAgregado)
                    {
                        _logger.Error($"Error al agregar el producto {detalle.Productoi.IdProducto} al detalle de compra.");
                        return false;
                    }
                    //modificar la existencia del producto
                    bool existenciaModificada = _productoData.ModificarExistencia(detalle.Productoi.IdProducto, detalle.Cantidad);
                    if (!existenciaModificada)
                    {
                        _logger.Error($"Error al modificar la existencia del producto {detalle.Productoi.IdProducto}.");
                        return false;
                    }
                }

                _logger.Info($"Compra realizada exitosamente. ID: {id_Compra}");
                return true;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al realizar la compra.");
                return false;
            }
        }

        /// <summary>
        /// Busca compras aplicando filtros opcionales, incluyendo cliente, producto, fechas y estatus.
        /// </summary>
        public List<Compra> BuscarCompras(int? idCliente = null, int? idProducto = null, DateTime? fechaInicio = null, DateTime? fechaFin = null, int? estatus = null)
        {
            try
            {
                var compras = _compraData.BuscarCompras(idCliente, idProducto, fechaInicio, fechaFin, estatus);
                _logger.Info($"Compras obtenidas con filtros: {compras.Count} registros encontrados");
                return compras;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al buscar compras filtradas.");
                throw;
            }
        }


        /// <summary>
        /// Obtiene el detalle de una compra incluyendo sus productos.
        /// </summary>
        public (Compra? compra, List<DetalleCompra> detalles) ObtenerDetalleCompra(int idCompra)
        {
            try
            {
                _logger.Debug($"Solicitando detalle de la compra con ID: {idCompra}");

                var compra = _compraData.ObtenerCompraPorId(idCompra);
                if (compra == null)
                {
                    _logger.Warn($"No se encontró la compra con ID {idCompra}");
                    return (null, new List<DetalleCompra>());
                }

                var detalles = _detalleData.ObtenerDetallePorCompra(idCompra);
                _logger.Info($"Compra y detalles obtenidos exitosamente para ID {idCompra}");

                return (compra, detalles);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al obtener detalle de la compra con ID: {idCompra}");
                throw;
            }
        }

        /// <summary>
        /// Actualiza el estatus de una compra (ej. cancelar).
        /// </summary>
        public (bool exito, string mensaje) ActualizarEstatusCompra(int idCompra, int nuevoEstatus)
        {
            try
            {
                var compra = _compraData.ObtenerCompraPorId(idCompra);
                if (compra == null)
                {
                    return (false, $"No se encontró la compra con ID {idCompra}");
                }

                compra.Estatus = nuevoEstatus;
                bool actualizado = _compraData.ActualizarCompra(compra);

                if (actualizado)
                {
                    _logger.Info($"Compra con ID {idCompra} actualizada al nuevo estatus {nuevoEstatus}");
                    return (true, "Estatus de la compra actualizado exitosamente.");
                }
                else
                {
                    _logger.Warn($"No se pudo actualizar la compra con ID {idCompra}");
                    return (false, "No se pudo actualizar el estatus de la compra.");
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al actualizar el estatus de la compra ID {idCompra}");
                return (false, $"Error inesperado: {ex.Message}");
            }
        }

        /// <summary>
        /// Obtiene todas las compras sin filtros.
        /// </summary>
        public List<Compra> ObtenerTodasLasCompras()
        {
            try
            {
                var compras = _compraData.ObtenerCompras();
                _logger.Info($"Todas las compras obtenidas correctamente: {compras.Count} registros");
                return compras;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener todas las compras.");
                throw;
            }
        }
    }
}
