﻿using Sistema_Ventas.Utilities;
using NLog;
using Npgsql;
using Sistema_Ventas.Model;
using System.Data; // Agregado para manejo de errores

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
                _logger.Fatal(e, "Error al inicializar CompraDataAccess");
                throw;
            }
        }

        /// <summary>
        /// insertar una compra en labd
        /// </summary>
        /// <param name="idCliente"> id del cliente</param>
        /// <param name="estatus">estatus de la compra-0,1,2-proceso,...</param>
        /// <param name="metodoPago">tarjeta,efectivo</param>
        /// <param name="iva">se calcula en controller</param>
        /// <param name="subtotal"></param>
        /// <param name="descuento"></param>
        /// <param name="total"></param>
        /// <returns></returns>
        public int InsertarCompra(int idCliente, int estatus, int metodoPago, decimal iva, decimal subtotal, decimal descuento, decimal total)
        {
            try
            {
                _dbAccess.Connect(); // Conectar a la base de datos

                // para generar un codigo unico de la compra-con la fecha: año,mes,dia-,hora,mes y segundo
                string codigoCompra = "COMP-" + DateTime.Now.ToString("yyMMdd-HHmmss");

                // Query 
                string insertCompraQuery = @"
                    INSERT INTO compra (id_cliente, codigo, metodo_de_pago, iva, subtotal, descuento, total, fecha_de_compra, estatus)
                    VALUES (@id_cliente, @codigo, @metodo_pago, @iva, @subtotal, @descuento, @total, @fecha, @estatus)
                    RETURNING id_compra;";
                //debe retornar el id inertar despues en detalle
                // Parámetros
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
                //creacion de parametros
                // Ejecutar la inserción y obtener el ID de la compra
                var result = _dbAccess.ExecuteScalar(insertCompraQuery, parametrosCompra.ToArray());

                if (result != null)
                {
                    return Convert.ToInt32(result); // Convertir el resultado a int y devolverlo
                }
                else
                {
                  _logger.Error("No se pudo obtener el ID de la compra.");
                    return -1;
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al insertar la compra");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect(); // Asegurar que se cierre la conexión
            }
        }

        

        /// <summary>
        /// Obtiene una lista de todas las compras registradas en la base de datos.
        /// </summary>
        public List<Compra> ObtenerCompras()
        {
            List<Compra> compras = new List<Compra>();
            try
            {
                _dbAccess.Connect();

                string query = @"
                    SELECT id_compra, id_cliente, codigo, metodo_de_pago, iva, subtotal, descuento, total, fecha_de_compra, estatus
                    FROM compra
                    ORDER BY fecha_de_compra DESC;";

                var result = _dbAccess.ExecuteQuery_Reader(query);

                foreach (DataRow row in result.Rows)
                {
                    Compra compra = new Compra
                    {
                        IdCompra = Convert.ToInt32(row["id_compra"]),
                        IdCliente = Convert.ToInt32(row["id_cliente"]),
                        Codigo = row["codigo"].ToString() ?? "",
                        MetodoPago = Convert.ToInt32(row["metodo_de_pago"]),
                        Iva = Convert.ToDecimal(row["iva"]),
                        Subtotal = Convert.ToDecimal(row["subtotal"]),
                        Descuento = Convert.ToDecimal(row["descuento"]),
                        Total = Convert.ToDecimal(row["total"]),
                        FechaCompra = Convert.ToDateTime(row["fecha_de_compra"]),
                        Estatus = Convert.ToInt32(row["estatus"])
                    };
                    compras.Add(compra);
                }

                _logger.Info($"Se obtuvieron {compras.Count} compras de la base de datos.");
                return compras;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener las compras");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }

        /// <summary>
        /// Obtiene una compra específica por su ID.
        /// </summary>
        public Compra? ObtenerCompraPorId(int idCompra)
        {
            try
            {
                _dbAccess.Connect();

                string query = @"
                    SELECT id_compra, id_cliente, codigo, metodo_de_pago, iva, subtotal, descuento, total, fecha_de_compra, estatus
                    FROM compra
                    WHERE id_compra = @id_compra;";

                var param = _dbAccess.CreateParameter("@id_compra", idCompra);
                var result = _dbAccess.ExecuteQuery_Reader(query, param);

                if (result.Rows.Count == 0)
                {
                    _logger.Warn($"No se encontró compra con ID {idCompra}");
                    return null;
                }

                DataRow row = result.Rows[0];
                Compra compra = new Compra
                {
                    IdCompra = Convert.ToInt32(row["id_compra"]),
                    IdCliente = Convert.ToInt32(row["id_cliente"]),
                    Codigo = row["codigo"].ToString() ?? "",
                    MetodoPago = Convert.ToInt32(row["metodo_de_pago"]),
                    Iva = Convert.ToDecimal(row["iva"]),
                    Subtotal = Convert.ToDecimal(row["subtotal"]),
                    Descuento = Convert.ToDecimal(row["descuento"]),
                    Total = Convert.ToDecimal(row["total"]),
                    FechaCompra = Convert.ToDateTime(row["fecha_de_compra"]),
                    Estatus = Convert.ToInt32(row["estatus"])
                };

                _logger.Info($"Compra obtenida correctamente con ID {idCompra}");
                return compra;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al obtener la compra con ID {idCompra}");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }

        /// <summary>
        /// Actualiza una compra existente en la base de datos.
        /// </summary>
        public bool ActualizarCompra(Compra compra)
        {
            try
            {
                _dbAccess.Connect();

                string query = @"
            UPDATE compra
            SET 
                id_cliente = @id_cliente,
                metodo_de_pago = @metodo_pago,
                iva = @iva,
                subtotal = @subtotal,
                descuento = @descuento,
                total = @total,
                fecha_de_compra = @fecha,
                estatus = @estatus
            WHERE id_compra = @id_compra;";

                List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
        {
            new NpgsqlParameter("@id_compra", compra.IdCompra),
            new NpgsqlParameter("@id_cliente", compra.IdCliente),
            new NpgsqlParameter("@metodo_pago", compra.MetodoPago),
            new NpgsqlParameter("@iva", compra.Iva),
            new NpgsqlParameter("@subtotal", compra.Subtotal),
            new NpgsqlParameter("@descuento", compra.Descuento),
            new NpgsqlParameter("@total", compra.Total),
            new NpgsqlParameter("@fecha", compra.FechaCompra),
            new NpgsqlParameter("@estatus", compra.Estatus)
        };

                int filasAfectadas = _dbAccess.ExecuteNonQuery(query, parametros.ToArray());

                if (filasAfectadas > 0)
                {
                    _logger.Info($"Compra actualizada correctamente con ID {compra.IdCompra}.");
                    return true;
                }
                else
                {
                    _logger.Warn($"No se encontró la compra con ID {compra.IdCompra} para actualizar.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al actualizar la compra con ID {compra.IdCompra}.");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }

        /// <summary>
        /// Busca compras basadas en filtros opcionales: cliente, producto, rango de fechas y estatus.
        /// </summary>
        public List<Compra> BuscarCompras(int? idCliente = null, int? idProducto = null, DateTime? fechaInicio = null, DateTime? fechaFin = null, int? estatus = null)
        {
            List<Compra> compras = new List<Compra>();
            try
            {
                _dbAccess.Connect();

                string query = @"
            SELECT DISTINCT
                c.id_compra,
                c.id_cliente,
                c.codigo,
                c.metodo_de_pago,
                c.iva,
                c.subtotal,
                c.descuento,
                c.total,
                c.fecha_de_compra,
                c.estatus,
                COALESCE(p.nombre_completo, 'Desconocido') AS nombre_cliente
            FROM compra c
            LEFT JOIN cliente cli ON c.id_cliente = cli.id_cliente
            LEFT JOIN personas p ON cli.id_persona = p.id_persona
            LEFT JOIN detalle_compra dc ON c.id_compra = dc.id_compra
            WHERE 1=1";

                List<NpgsqlParameter> parametros = new List<NpgsqlParameter>();

                if (idCliente.HasValue)
                {
                    query += " AND c.id_cliente = @id_cliente";
                    parametros.Add(new NpgsqlParameter("@id_cliente", idCliente.Value));
                }

                if (idProducto.HasValue)
                {
                    query += " AND dc.id_producto = @id_producto";
                    parametros.Add(new NpgsqlParameter("@id_producto", idProducto.Value));
                }

                if (fechaInicio.HasValue && fechaFin.HasValue)
                {
                    query += " AND c.fecha_de_compra BETWEEN @fechaInicio AND @fechaFin";
                    parametros.Add(new NpgsqlParameter("@fechaInicio", fechaInicio.Value));
                    parametros.Add(new NpgsqlParameter("@fechaFin", fechaFin.Value));
                }

                if (estatus.HasValue)
                {
                    query += " AND c.estatus = @estatus";
                    parametros.Add(new NpgsqlParameter("@estatus", estatus.Value.ToString()));
                }

                query += " ORDER BY c.id_compra;";

                var result = _dbAccess.ExecuteQuery_Reader(query, parametros.ToArray());

                foreach (DataRow row in result.Rows)
                {
                    Compra compra = new Compra
                    {
                        IdCompra = Convert.ToInt32(row["id_compra"]),
                        IdCliente = Convert.ToInt32(row["id_cliente"]),
                        Codigo = row["codigo"].ToString() ?? "",
                        MetodoPago = Convert.ToInt32(row["metodo_de_pago"]),
                        Iva = Convert.ToDecimal(row["iva"]),
                        Subtotal = Convert.ToDecimal(row["subtotal"]),
                        Descuento = Convert.ToDecimal(row["descuento"]),
                        Total = Convert.ToDecimal(row["total"]),
                        FechaCompra = Convert.ToDateTime(row["fecha_de_compra"]),
                        Estatus = Convert.ToInt32(row["estatus"]),
                        NombreCliente = row["nombre_cliente"].ToString() ?? "Desconocido"
                    };
                    compras.Add(compra);
                }

                _logger.Info($"Se encontraron {compras.Count} compras con los filtros especificados.");
                return compras;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al buscar las compras filtradas.");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }


    }
}
