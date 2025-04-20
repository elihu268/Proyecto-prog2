using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Ventas.Utilities;
using NLog;
using Sistema_Ventas.Model;
using System.Data;
using System.Collections;
namespace Sistema_Ventas.Data
{
    public class ProductosDataAccess
    {
        private static readonly Logger _logger = LoggingManager.GetLogger("Sistema_Ventas.Data.ProductosDataAccess");
        /// 
        private readonly PostgreSQLDataAccess _dbAccess;
        public ProductosDataAccess()
        {
            try
            {
                _dbAccess = PostgreSQLDataAccess.GetInstance();
            }
            catch (Exception e)
            {
                _logger.Fatal(e, "Error al instializar PersonasDataAccess");
                throw;
            }
        }
        public List<Producto> ObtenerProductos()
        {
            List<Producto> productos = new List<Producto>();
            try
            {
                // Consulta SQL
                string query = @"
            SELECT 
                id_producto,
                cod_producto,
                nombre,
                precio,
                descripcion,
                existencia
            FROM producto
        ";

                // Ejecutar consulta (sin parámetros en este caso)
                DataTable resultado = _dbAccess.ExecuteQuery_Reader(query);

                // Procesar resultados
                foreach (DataRow row in resultado.Rows)
                {
                    Producto producto = new Producto(
                        Convert.ToInt32(row["id_producto"]),
                        row["cod_producto"].ToString(),
                        row["nombre"].ToString(),
                        Convert.ToDouble(row["precio"]),
                        row["descripcion"].ToString(),
                        Convert.ToInt32(row["existencia"]) // ojo, tenías escrito "esxitencia"
                    );
                    productos.Add(producto);
                }

                return productos;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener información de los productos desde la base de datos");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect(); // Siempre cerrar conexión
            }
        }

    }
}
