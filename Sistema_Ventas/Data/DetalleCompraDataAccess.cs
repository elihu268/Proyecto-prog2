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

                return true; // Agregado retorno exitoso
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al agregar producto al detalle de compra");
                return false;
            }
            finally
            {
                _dbAccess.Disconnect(); // cerrar la conexión
            }
        }


    }
}
