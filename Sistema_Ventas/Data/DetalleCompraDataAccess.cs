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
    public class DetalleCompraDataAccess
    {
        private static readonly Logger _logger = LoggingManager.GetLogger("Sistema_Ventas.Data.DetalleCompraDataAccess");
      private readonly PostgreSQLDataAccess _dbAccess;

        public  DetalleCompraDataAccess()
        {
            try
            {
                _dbAccess = PostgreSQLDataAccess.GetInstance();
            }
            catch (Exception e)
            {
                _logger.Fatal(e, "Error al instializar DetalleCompraDataAccess");
                throw;
            }
        }
        public bool AgregarProductoADetalle(int idCompra, Producto producto, int cantidad)
        {
            try
            {
                decimal totalPorUnidad = producto.Precio * cantidad;

                string query = @"
            INSERT INTO detalle_compra (id_compra, id_producto, cantidad, total_por_unidad)
            VALUES (@idCompra, @idProducto, @cantidad, @totalPorUnidad);

            UPDATE producto 
            SET existencia = existencia - @cantidad
            WHERE id_producto = @idProducto;
        ";

                List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
        {
            new NpgsqlParameter("@idCompra", idCompra),
            new NpgsqlParameter("@idProducto", producto.Id),
            new NpgsqlParameter("@cantidad", cantidad),
            new NpgsqlParameter("@totalPorUnidad", totalPorUnidad)
        };

                int filasAfectadas = _dbAccess.ExecuteNonQuery(query, parametros.ToArray());

                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al agregar producto al detalle de compra");
                return false;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }

    }
}
