using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Ventas.Utilities;
using NLog;
using Npgsql;
using Sistema_Ventas.Model;
namespace Sistema_Ventas.Data
{
    public class CompraDataAccess
    {
        private static readonly Logger _logger = LoggingManager.GetLogger("Sistema_Ventas.Data.CompraDataAccess");
        
        private readonly PostgreSQLDataAccess _dbAccess;

        public CompraDataAccess()
        {
            try
            {
                _dbAccess = PostgreSQLDataAccess.GetInstance();
            }
            catch (Exception e)
            {
                _logger.Fatal(e, "Error al instializar CompraDataAccess");
                throw;
            }
        }
        public int GuardarCompra(Compra compra)
        {
            try
            {
                // Iniciar una lista de parámetros para la compra
                List<NpgsqlParameter> parametrosCompra = new List<NpgsqlParameter>
        {
            new NpgsqlParameter("@id_cliente", compra.IdCliente),
            new NpgsqlParameter("@codigo", compra.Codigo),
            new NpgsqlParameter("@metodo_de_pago", compra.MetodoDePago),
            new NpgsqlParameter("@iva", compra.Iva),
            new NpgsqlParameter("@subtotal", compra.Subtotal),
            new NpgsqlParameter("@descuento", compra.Descuento),
            new NpgsqlParameter("@total", compra.Total),
            new NpgsqlParameter("@fecha_de_compra", compra.FechaDeCompra),
            new NpgsqlParameter("@estatus", compra.Estatus)
        };

                // Consulta para insertar la compra
                string queryCompra = @"
            INSERT INTO compra (id_cliente, codigo, metodo_de_pago, iva, subtotal, descuento, total, fecha_de_compra, estatus)
            VALUES (@id_cliente, @codigo, @metodo_de_pago, @iva, @subtotal, @descuento, @total, @fecha_de_compra, @estatus)
            RETURNING id_compra;
        ";

                // Ejecutar la consulta y obtener el ID generado
                int idCompraGenerado = Convert.ToInt32(_dbAccess.ExecuteQuery_Reader(queryCompra, parametrosCompra.ToArray()));

                // Insertar los detalles de la compra
                foreach (var detalle in compra.Detalles)
                {
                    // Parametros para el detalle de compra
                    List<NpgsqlParameter> parametrosDetalle = new List<NpgsqlParameter>
            {
                new NpgsqlParameter("@id_compra", idCompraGenerado),
                new NpgsqlParameter("@id_producto", detalle.IdProducto),
                new NpgsqlParameter("@cantidad", detalle.Cantidad),
                new NpgsqlParameter("@total_por_unidad", detalle.TotalPorUnidad)
            };

                    string queryDetalle = @"
                INSERT INTO detalle_compra (id_compra, id_producto, cantidad, total_por_unidad)
                VALUES (@id_compra, @id_producto, @cantidad, @total_por_unidad);
            ";

                    // Ejecutar la consulta para insertar cada detalle
                    _dbAccess.ExecuteQuery_Reader(queryDetalle, parametrosDetalle.ToArray());
                }

                return idCompraGenerado;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al guardar la compra y sus detalles en la base de datos");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect(); // Siempre cerrar la conexión
            }
        }

        /* public bool RealizarCompra(Compra compra, List<Producto> productos)
         {
             _dbAccess.Connect();
                     try
                     {
                         // Insertar compra
                         string insertCompraQuery = @"
                     INSERT INTO compra (id_cliente, codigo, metodo_de_pago, iva, subtotal, descuento, total, fecha_de_compra, estatus)
                     VALUES (@id_cliente, @codigo, @metodo, @iva, @subtotal, @descuento, @total, @fecha, @estatus)
                     RETURNING id_compra;
                 ";

                         var cmdCompra = new NpgsqlCommand(insertCompraQuery, conn, trans);
                         cmdCompra.Parameters.AddWithValue("@id_cliente", compra.IdCliente);
                         cmdCompra.Parameters.AddWithValue("@codigo", compra.Codigo);
                         cmdCompra.Parameters.AddWithValue("@metodo", compra.MetodoDePago);
                         cmdCompra.Parameters.AddWithValue("@iva", compra.Iva);
                         cmdCompra.Parameters.AddWithValue("@subtotal", compra.Subtotal);
                         cmdCompra.Parameters.AddWithValue("@descuento", compra.Descuento);
                         cmdCompra.Parameters.AddWithValue("@total", compra.Total);
                         cmdCompra.Parameters.AddWithValue("@fecha", DateTime.Now);
                         cmdCompra.Parameters.AddWithValue("@estatus", "completada");

                         int idCompra = Convert.ToInt32(cmdCompra.ExecuteScalar());

                         // Insertar cada producto en detalle_compra
                         foreach (var producto in productos)
                         {
                             string insertDetalle = @"
                         INSERT INTO detalle_compra (id_compra, id_producto, cantidad, total_por_unidad)
                         VALUES (@id_compra, @id_producto, @cantidad, @total_por_unidad);
                     ";

                             var cmdDetalle = new NpgsqlCommand(insertDetalle, conn, trans);
                             cmdDetalle.Parameters.AddWithValue("@id_compra", idCompra);
                             cmdDetalle.Parameters.AddWithValue("@id_producto", producto.Id);
                             cmdDetalle.Parameters.AddWithValue("@cantidad", producto.Cantidad);
                             cmdDetalle.Parameters.AddWithValue("@total_por_unidad", producto.Precio * producto.Cantidad);
                             cmdDetalle.ExecuteNonQuery();

                             // Actualizar existencia
                             string updateStock = @"
                         UPDATE producto SET existencia = existencia - @cantidad
                         WHERE id_producto = @id_producto;
                     ";
                             var cmdUpdate = new NpgsqlCommand(updateStock, conn, trans);
                             cmdUpdate.Parameters.AddWithValue("@cantidad", producto.Cantidad);
                             cmdUpdate.Parameters.AddWithValue("@id_producto", producto.Id);
                             cmdUpdate.ExecuteNonQuery();
                         }

                         trans.Commit();
                         return true;
                     }
                     catch (Exception ex)
                     {
                         trans.Rollback();
                         _logger.Error(ex, "Error al realizar la compra.");
                         return false;
                     }
                 }
             }
         }*/

    }
}
