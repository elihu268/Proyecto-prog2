using Sistema_Ventas.Utilities;
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
        /// Inserta una nueva compra en la base de datos.
        /// </summary>
        public int InsertarCompra(int idCliente, int estatus, int metodoPago, decimal iva, decimal subtotal, decimal descuento, decimal total)
        {
            try
            {
                _dbAccess.Connect(); // Conectar a la base de datos

                // Generar el código único de la compra
                string codigoCompra = "COMP-" + DateTime.Now.Ticks.ToString();

                // Query de inserción
                string insertCompraQuery = @"
                    INSERT INTO compra (id_cliente, codigo, metodo_de_pago, iva, subtotal, descuento, total, fecha_de_compra, estatus)
                    VALUES (@id_cliente, @codigo, @metodo_pago, @iva, @subtotal, @descuento, @total, @fecha, @estatus)
                    RETURNING id_compra;";

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

                // Ejecutar la inserción y obtener el ID de la compra
                var result = _dbAccess.ExecuteScalar(insertCompraQuery, parametrosCompra.ToArray());

                if (result != null)
                {
                    return Convert.ToInt32(result); // Convertir el resultado a int y devolverlo
                }
                else
                {
                    throw new Exception("No se pudo obtener el ID de la compra.");
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
        /// Inserta una compra y sus detalles sin usar transacciones.
        /// </summary>
        public bool InsertarCompraConDetalles(Compra compra, List<DetalleCompra> detalles)
        {
            try
            {
                _dbAccess.Connect();

                // Insertar compra principal
                string insertCompraQuery = @"
                    INSERT INTO compra (id_cliente, codigo, metodo_de_pago, iva, subtotal, descuento, total, fecha_de_compra, estatus)
                    VALUES (@id_cliente, @codigo, @metodo_pago, @iva, @subtotal, @descuento, @total, @fecha, @estatus)
                    RETURNING id_compra;";

                List<NpgsqlParameter> parametrosCompra = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter("@id_cliente", compra.IdCliente),
                    new NpgsqlParameter("@codigo", compra.Codigo),
                    new NpgsqlParameter("@metodo_pago", compra.MetodoPago),
                    new NpgsqlParameter("@iva", compra.Iva),
                    new NpgsqlParameter("@subtotal", compra.Subtotal),
                    new NpgsqlParameter("@descuento", compra.Descuento),
                    new NpgsqlParameter("@total", compra.Total),
                    new NpgsqlParameter("@fecha", compra.FechaCompra),
                    new NpgsqlParameter("@estatus", compra.Estatus)
                };

                var idCompraObj = _dbAccess.ExecuteScalar(insertCompraQuery, parametrosCompra.ToArray());
                if (idCompraObj == null)
                {
                    throw new Exception("No se pudo insertar la compra principal.");
                }

                int idCompraGenerado = Convert.ToInt32(idCompraObj);

                // Insertar detalles uno por uno
                foreach (var detalle in detalles)
                {
                    try
                    {
                        string insertDetalleQuery = @"
                            INSERT INTO detalle_compra (id_compra, id_producto, cantidad, total_por_unidad)
                            VALUES (@id_compra, @id_producto, @cantidad, @total_por_unidad);";

                        List<NpgsqlParameter> parametrosDetalle = new List<NpgsqlParameter>
                        {
                            new NpgsqlParameter("@id_compra", idCompraGenerado),
                            new NpgsqlParameter("@id_producto", detalle.IdProducto),
                            new NpgsqlParameter("@cantidad", detalle.Cantidad),
                            new NpgsqlParameter("@total_por_unidad", detalle.TotalPorUnidad)
                        };

                        _dbAccess.ExecuteNonQuery(insertDetalleQuery, parametrosDetalle.ToArray());
                    }
                    catch (Exception exDetalle)
                    {
                        _logger.Error(exDetalle, $"Error al insertar detalle para producto ID {detalle.IdProducto}");
                        // Continuar con el siguiente detalle
                    }
                }

                _logger.Info("Compra y detalles insertados correctamente (sin transacción). Comprueba si hay errores en los detalles.");
                return true;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error general al insertar la compra y detalles");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect();
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
        /// Busca compras basadas en filtros opcionales: cliente, rango de fechas y estatus.
        /// </summary>
        public List<Compra> BuscarCompras(int? idCliente = null, DateTime? fechaInicio = null, DateTime? fechaFin = null, int? estatus = null)
        {
            List<Compra> compras = new List<Compra>();
            try
            {
                _dbAccess.Connect();

                string query = @"
            SELECT id_compra, id_cliente, codigo, metodo_de_pago, iva, subtotal, descuento, total, fecha_de_compra, estatus
            FROM compra
            WHERE 1=1"; // Condición inicial para facilitar concatenación

                List<NpgsqlParameter> parametros = new List<NpgsqlParameter>();

                // Filtros dinámicos
                if (idCliente.HasValue)
                {
                    query += " AND id_cliente = @id_cliente";
                    parametros.Add(new NpgsqlParameter("@id_cliente", idCliente.Value));
                }
                if (fechaInicio.HasValue && fechaFin.HasValue)
                {
                    query += " AND fecha_de_compra BETWEEN @fechaInicio AND @fechaFin";
                    parametros.Add(new NpgsqlParameter("@fechaInicio", fechaInicio.Value));
                    parametros.Add(new NpgsqlParameter("@fechaFin", fechaFin.Value));
                }
                if (estatus.HasValue)
                {
                    query += " AND estatus = @estatus";
                    parametros.Add(new NpgsqlParameter("@estatus", estatus.Value));
                }

                query += " ORDER BY fecha_de_compra DESC";

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
                        Estatus = Convert.ToInt32(row["estatus"])
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
