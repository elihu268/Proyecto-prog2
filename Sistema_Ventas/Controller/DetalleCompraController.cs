using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Ventas.Data;
using Sistema_Ventas.Utilities;
using Sistema_Ventas.Bussines;
using NLog;
using System.Collections;
using System.Data;
using Sistema_Ventas.Model;
namespace Sistema_Ventas.Controller
{
    public class DetalleCompraController
    {
        private static readonly Logger _logger = LoggingManager.GetLogger("Sistema_Ventas.Controller.DetalleCompraController");
        private readonly ProductosController _productosController;
        private readonly DetalleCompraDataAccess _detalleData;

        public DetalleCompraController()
        {
            try
            {
                _productosController = new ProductosController();
                _detalleData = new DetalleCompraDataAccess();
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "error al inicializar el controlador de detalle compra");
                throw;
            }
        }
        /// <summary>
        /// para validar que la cantidad que desea comprar no supera la existencia
        /// </summary>
        /// <param name="codigo">saber que producto es</param>
        /// <param name="cantidad">cantidad que desea comprar</param>
        /// <returns>verdadero si encuentra el producto y que la cantidad que desea comprar ssea valida</returns>
        public bool ValidarCantidad(string codigo, string cantidad)
        {
            try
            {
                int existencia = _productosController.ObtenerExistenciaDeProducto(codigo);
                if (existencia == -1)
                {
                    _logger.Warn($"Producto con código {codigo} no encontrado.");
                    return false;
                }

                bool resultado = CompraNegocio.CantidadEnRango(cantidad, existencia);
                return resultado;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"No se pudo validar cantidad para realizar la compra del producto con código {codigo}.");
                return false;
            }
        }
        public bool AgregarProductoADetalle(int idCompra, Producto producto, int cantidad)
        {
            try
            {
                return _detalleData.AgregarProductoADetalle(idCompra, producto, cantidad);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"No se pudo agregar producto al detalle");
                return false;
            }
        }
    }
}
