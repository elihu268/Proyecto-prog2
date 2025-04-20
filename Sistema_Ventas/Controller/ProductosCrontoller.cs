using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Ventas.Data;
using Sistema_Ventas.Model;
using Sistema_Ventas.Utilities;
using NLog;

namespace Sistema_Ventas.Controller
{
    public class ProductosCrontoller
    {
        private static readonly Logger _logger = LoggingManager.GetLogger("Sistema_Ventas.Controller.ProductosCrontoller");
        private readonly ProductosDataAccess _productosData;

        public ProductosCrontoller()
        {
            try
            {
                _productosData = new ProductosDataAccess();

            }
            catch (Exception ex)
            {
                _logger.Error(ex, "error al inicializar el controlador de productos");
                throw;
            }
        }
        public List<Producto> ObtenerProductos()
        {
            try
            {
                List<Producto> productos = _productosData.ObtenerProductos();
                _logger.Info($"Se obtuvieron {productos.Count} Productos");
                return productos;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener la lista de productos");
                throw;
            }
        }
    }
}
