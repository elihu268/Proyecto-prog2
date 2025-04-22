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

        public int InsertarCompra(int idCliente, int estatus, int metodoPago, decimal iva, decimal subtotal, decimal descuento, decimal total)
        {
            try
            {
                _dbAccess.Connect(); // Conectar a la base de datos

                // Generar el código único de la compra
                string codigoCompra = "COMP-" + DateTime.Now.Ticks.ToString();

                // queyr de inserción
                string insertCompraQuery = @"
        INSERT INTO compra (id_cliente, codigo, metodo_de_pago, iva, subtotal, descuento, total, fecha_de_compra, estatus)
        VALUES (@id_cliente, @codigo, @metodo_pago, @iva, @subtotal, @descuento, @total, @fecha, @estatus)
        RETURNING id_compra;";

                // Parametros
                List<NpgsqlParameter> parametrosCompra = new List<NpgsqlParameter>
        {
            new NpgsqlParameter("@id_cliente", idCliente),
            new NpgsqlParameter("@codigo", codigoCompra),
            new NpgsqlParameter("@metodo_pago", metodoPago),
            new NpgsqlParameter("@iva", iva),
            new NpgsqlParameter("@subtotal", subtotal),
            new NpgsqlParameter("@descuento", descuento),
            new NpgsqlParameter("@total", total),
            new NpgsqlParameter("@fecha", DateTime.Now),
            new NpgsqlParameter("@estatus", estatus)
        };

                // Ejecutar la inserción y obtener el id de la compra
                var result = _dbAccess.ExecuteScalar(insertCompraQuery, parametrosCompra.ToArray());

                if (result != null)
                {
                    return Convert.ToInt32(result); // Convertir el resultado a int y devolverlo
                }
                else
                {
                    // hacer nueva excepcion
                    throw new Exception("No se pudo obtener el ID de la compra.");
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al insertar la compra");
                throw; // Lanza la excepción para que se maneje en un nivel superior
            }
            finally
            {
                _dbAccess.Disconnect(); // Asegurar que se cierre la conexión
            }
        }



    }
}
