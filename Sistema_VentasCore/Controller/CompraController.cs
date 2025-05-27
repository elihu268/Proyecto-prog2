using NLog;
using Npgsql;
using OfficeOpenXml;
using Sistema_VentasCore.Data;
using Sistema_VentasCore.Model;
using Sistema_VentasCore.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.IO.RecyclableMemoryStreamManager;

namespace Sistema_VentasCore.Controller
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
                bool actualizado = _compraData.ActualizarEstatusCompra(compra);

                if (actualizado)
                {
                    _logger.Info($"Compra con ID {idCompra} actualizada al nuevo estatus {nuevoEstatus}");
                    return (true, "Estatus de la compra actualizado exitosamente");
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

        /// <summary>
        /// Exporta a Excel la lista de compras filtradas.
        /// </summary>
        /// <param name="rutaArchivo">Ruta donde se guardará el archivo .xlsx</param>
        /// <param name="idCliente">ID del cliente (opcional)</param>
        /// <param name="idProducto">ID del producto (opcional)</param>
        /// <param name="fechaInicio">Fecha de inicio (opcional)</param>
        /// <param name="fechaFin">Fecha de fin (opcional)</param>
        /// <param name="estatus">Estatus de las compras (opcional)</param>
        /// <returns>True si se exportó correctamente, False en caso contrario</returns>
        public bool ExportarComprasExcel(string rutaArchivo, int? idCliente = null, int? idProducto = null,
                                         DateTime? fechaInicio = null, DateTime? fechaFin = null, int? estatus = 1)
        {
            try
            {
                var compras = _compraData.BuscarCompras(idCliente, idProducto, fechaInicio, fechaFin, estatus);

                if (compras == null || compras.Count == 0)
                {
                    _logger.Warn("No hay compras para exportar");
                    return false;
                }

                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Compras");

                    // Encabezados
                    worksheet.Cells[1, 1].Value = "ID Compra";
                    worksheet.Cells[1, 2].Value = "Código";
                    worksheet.Cells[1, 3].Value = "Cliente";
                    worksheet.Cells[1, 4].Value = "Subtotal";
                    worksheet.Cells[1, 5].Value = "IVA";
                    worksheet.Cells[1, 6].Value = "Descuento";
                    worksheet.Cells[1, 7].Value = "Total";
                    worksheet.Cells[1, 8].Value = "Fecha de Compra";
                    worksheet.Cells[1, 9].Value = "Estatus";

                    using (var range = worksheet.Cells[1, 1, 1, 9])
                    {
                        range.Style.Font.Bold = true;
                        range.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                        range.Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                    }

                    int row = 2;
                    foreach (var compra in compras)
                    {
                        worksheet.Cells[row, 1].Value = compra.IdCompra;
                        worksheet.Cells[row, 2].Value = compra.Codigo;
                        worksheet.Cells[row, 3].Value = compra.NombreCliente;
                        worksheet.Cells[row, 4].Value = compra.Subtotal;
                        worksheet.Cells[row, 5].Value = compra.Iva;
                        worksheet.Cells[row, 6].Value = compra.Descuento;
                        worksheet.Cells[row, 7].Value = compra.Total;
                        worksheet.Cells[row, 8].Value = compra.FechaCompra;
                        worksheet.Cells[row, 8].Style.Numberformat.Format = "dd/MM/yyyy";
                        worksheet.Cells[row, 9].Value = EstatusVentaHelper.ObtenerDescripcionEstatus(compra.Estatus);
                        row++;
                    }

                    worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                    FileInfo fileInfo = new FileInfo(rutaArchivo);
                    package.SaveAs(fileInfo);

                    _logger.Info($"Archivo Excel exportado correctamente: {rutaArchivo}");
                    return true;
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al exportar compras a Excel");
                throw;
            }
        }

        public List<VentaPorArticulo> ObtenerVentasPorArticulo(int codigoArticulo)
        {
            try
            {
                var ventas = _compraData.ObtenerVentasPorCodigoArticulo(codigoArticulo);
                _logger.Info($"Ventas obtenidas para artículo {codigoArticulo}: {ventas.Count} registros");
                return ventas;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener ventas por artículo.");
                throw;
            }
        }


        public ResumenVenta ObtenerResumenVentasPorArticulo(int codigoArticulo)
        {
            try
            {
                var ventas = _compraData.ObtenerVentasPorCodigoArticulo(codigoArticulo);

                if (!ventas.Any())
                    return null;

                return new ResumenVenta
                {
                    CodigoArticulo = codigoArticulo,
                    TotalVentas = ventas.Sum(venta => venta.Cantidad),
                    Ventas = ventas
                };
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener resumen de ventas por artículo.");
                throw;
            }
        }

    }
}
