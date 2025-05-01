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
using Npgsql;
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
                id_producto,cod_producto,nombre, precio, descripcion,existencia
            FROM producto
            WHERE estatus = TRUE
            ORDER BY nombre;
        ";
                
                // Ejecutar consulta 
                DataTable resultado = _dbAccess.ExecuteQuery_Reader(query);

                // Procesar 
                foreach (DataRow row in resultado.Rows)
                {
                    Producto producto = new Producto(
                        Convert.ToInt32(row["id_producto"]),
                        row["cod_producto"].ToString(),
                        row["nombre"].ToString(),
                        Convert.ToDecimal(row["precio"]),
                        row["descripcion"].ToString(),
                        Convert.ToInt32(row["existencia"]) 
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
        public List<Producto> ObtenerProductoPorNombre(String nombrePrd)
        {
            
            List<Producto> productos = new List<Producto>();
            try
            {
                string query = @"
            SELECT 
                id_producto, cod_producto, nombre, precio, descripcion, existencia
            FROM producto
            WHERE LOWER(nombre) LIKE LOWER(@nombrePrd) and estatus = TRUE
            ORDER BY nombre;
";
                List<NpgsqlParameter> parametros = new List<NpgsqlParameter>();

                parametros.Add(new NpgsqlParameter("@nombrePrd", $"%{nombrePrd}%"));

                DataTable resultado = _dbAccess.ExecuteQuery_Reader(query, parametros.ToArray());
                // Procesar 
                foreach (DataRow row in resultado.Rows)
                {
                    Producto producto = new Producto(
                        Convert.ToInt32(row["id_producto"]),
                        row["cod_producto"].ToString(),
                        row["nombre"].ToString(),
                        Convert.ToDecimal(row["precio"]),
                        row["descripcion"].ToString(),
                        Convert.ToInt32(row["existencia"])
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

        public int ObtenerExistenciaPorCodigo(string codProducto)
        {
            try
            {
                string query = @"
            SELECT existencia 
            FROM producto 
            WHERE cod_producto = @codProducto
        ";

                List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
        {
            new NpgsqlParameter("@codProducto", codProducto)
        };

                DataTable resultado = _dbAccess.ExecuteQuery_Reader(query, parametros.ToArray());

                if (resultado.Rows.Count > 0)
                {
                    return Convert.ToInt32(resultado.Rows[0]["existencia"]);
                }
                else
                {
                    // Si no se encontró el producto
                    return -1;
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener existencia del producto");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }

        public bool ModificarExistencia(int idProducto, int cantidad)
        {
            try
            {
                _dbAccess.Connect(); // conectar a la base de datos

                string query = @"UPDATE producto
                         SET existencia = existencia - @cantidad
                         WHERE id_producto = @idProducto;";

                List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
        {
            new NpgsqlParameter("@cantidad", cantidad),
            new NpgsqlParameter("@idProducto", idProducto)
        };

                int filasAfectadas = _dbAccess.ExecuteNonQuery(query, parametros.ToArray());

                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al modificar la existencia del producto: {idProducto}");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect(); // cerrar la conexión
            }
        }

    }
}
