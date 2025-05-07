using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Ventas.Utilities;
using NLog;
using Npgsql;
using Sistema_Ventas.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Sistema_Ventas.Data
{
    public class DetalleCompraDataAccess
    {
        private static readonly Logger _logger = LoggingManager.GetLogger("Sistema_Ventas.Data.DetalleCompraDataAccess");
        private readonly PostgreSQLDataAccess _dbAccess;

        /// <summary>
        /// Constructor de la clase DetalleCompraDataAccess.
        /// </summary>
        public DetalleCompraDataAccess()
        {
            try
            {
                _dbAccess = PostgreSQLDataAccess.GetInstance();
            }
            catch (Exception e)
            {
                _logger.Fatal(e, "Error al inicializar DetalleCompraDataAccess");
                throw;
            }
        }

        /// <summary>
        /// Agrega un producto al detalle de una compra.
        /// </summary>
        public bool AgregarProductoADetalle(int id_compra, Producto producto, int cantidad)
        {
            try
            {
                _dbAccess.Connect(); // Conectar a la base de datos

                decimal totalPorUnidad = producto.Precio * cantidad;

                string insertDetalleQuery = @"
                    INSERT INTO detalle_compra (id_compra, id_producto, cantidad, total_por_unidad)
                    VALUES (@id_compra, @id_producto, @cantidad, @totalPorUnidad);
                ";

                List<NpgsqlParameter> parametrosDetalle = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter("@id_compra", id_compra),
                    new NpgsqlParameter("@id_producto", producto.IdProducto),
                    new NpgsqlParameter("@cantidad", cantidad),
                    new NpgsqlParameter("@totalPorUnidad", totalPorUnidad)
                };

                _dbAccess.ExecuteNonQuery(insertDetalleQuery, parametrosDetalle.ToArray());

                return true;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al agregar producto al detalle de compra");
                return false;
            }
            finally
            {
                _dbAccess.Disconnect(); // Cerrar la conexión
            }
        }

        /// <summary>
        /// Obtiene todos los detalles de una compra específica por su ID.
        /// </summary>
        //public List<DetalleCompra> ObtenerDetallePorCompra(int idCompra)
        //{
        //    List<DetalleCompra> detalles = new List<DetalleCompra>();
        //    try
        //    {
        //        _dbAccess.Connect();

        //        string query = @"
        //            SELECT id_detalle, id_compra, id_producto, cantidad, total_por_unidad
        //            FROM detalle_compra
        //            WHERE id_compra = @id_compra;
        //        ";

        //        var param = _dbAccess.CreateParameter("@id_compra", idCompra);

        //        var result = _dbAccess.ExecuteQuery_Reader(query, param);

        //        foreach (System.Data.DataRow row in result.Rows)
        //        {
        //            DetalleCompra detalle = new DetalleCompra
        //            {
        //                IdDetalle = Convert.ToInt32(row["id_detalle"]),
        //                IdCompra = Convert.ToInt32(row["id_compra"]),
        //                IdProducto = Convert.ToInt32(row["id_producto"]),
        //                Cantidad = Convert.ToInt32(row["cantidad"]),
        //                TotalPorUnidad = Convert.ToDecimal(row["total_por_unidad"])
        //            };

        //            detalles.Add(detalle);
        //        }

        //        _logger.Info($"Se encontraron {detalles.Count} detalles para la compra ID {idCompra}");
        //        return detalles;
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.Error(ex, $"Error al obtener los detalles de la compra ID {idCompra}");
        //        throw;
        //    }
        //    finally
        //    {
        //        _dbAccess.Disconnect();
        //    }
        //}

        /// <summary>
        /// Actualiza la cantidad y el total por unidad de un detalle de compra.
        /// </summary>
        public bool ActualizarDetalleCompra(DetalleCompra detalle)
        {
            try
            {
                _dbAccess.Connect();

                string query = @"
            UPDATE detalle_compra
            SET cantidad = @cantidad,
                total_por_unidad = @total_por_unidad
            WHERE id_detalle = @id_detalle;
        ";

                List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
        {
            new NpgsqlParameter("@cantidad", detalle.Cantidad),
            new NpgsqlParameter("@total_por_unidad", detalle.TotalPorUnidad),
            new NpgsqlParameter("@id_detalle", detalle.IdDetalle)
        };

                int filasAfectadas = _dbAccess.ExecuteNonQuery(query, parametros.ToArray());

                _logger.Info($"Detalle de compra actualizado correctamente. ID Detalle: {detalle.IdDetalle}");
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al actualizar el detalle de compra con ID {detalle.IdDetalle}");
                return false;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }

        /// <summary>
        /// Obtiene todos los detalles de una compra específica por su ID, incluyendo información del producto.
        /// </summary>
        public List<DetalleCompra> ObtenerDetallePorCompra(int idCompra)
        {
            List<DetalleCompra> detalles = new List<DetalleCompra>();
            try
            {
                _dbAccess.Connect();

                string query = @"
            SELECT 
                d.id_detalle, 
                d.id_compra, 
                d.id_producto, 
                d.cantidad, 
                d.total_por_unidad,
                p.cod_producto,
                p.nombre AS nombre_producto,
                p.precio
            FROM detalle_compra d
            INNER JOIN producto p ON d.id_producto = p.id_producto
            WHERE d.id_compra = @id_compra;
        ";

                var param = _dbAccess.CreateParameter("@id_compra", idCompra);

                var result = _dbAccess.ExecuteQuery_Reader(query, param);

                foreach (System.Data.DataRow row in result.Rows)
                {
                    // Crear el objeto producto
                    Producto producto = new Producto
                    {
                        IdProducto = Convert.ToInt32(row["id_producto"]),
                        Codigo = row["cod_producto"].ToString() ?? "",
                        Nombre = row["nombre_producto"].ToString() ?? "",
                        Precio = Convert.ToDecimal(row["precio"])
                    };

                    // Crear el detalle con producto embebido
                    DetalleCompra detalle = new DetalleCompra
                    {
                        IdDetalle = Convert.ToInt32(row["id_detalle"]),
                        IdCompra = Convert.ToInt32(row["id_compra"]),
                        IdProducto = producto.IdProducto,
                        Cantidad = Convert.ToInt32(row["cantidad"]),
                        TotalPorUnidad = Convert.ToDecimal(row["total_por_unidad"]),
                        Productoi = producto
                    };

                    detalles.Add(detalle);
                }

                _logger.Info($"Se encontraron {detalles.Count} detalles para la compra ID {idCompra}");
                return detalles;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al obtener los detalles de la compra ID {idCompra}");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }
    }
}
