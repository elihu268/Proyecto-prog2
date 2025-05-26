using NLog;
using Npgsql;
using Sistema_VentasCore.Model;
using Sistema_VentasCore.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_VentasCore.Data
{
    class AuditoriaDataAccess
    {
        private static readonly Logger _logger = LoggingManager.GetLogger("Sistema_VentasCore.Data.AuditoriaDataAccess");
        private readonly PostgreSQLDataAccess _dbAccess;
        public AuditoriaDataAccess()
        {
            try
            {
                _dbAccess = PostgreSQLDataAccess.GetInstance();
            }
            catch (Exception e)
            {
                _logger.Fatal(e, "Error al inicializar AuditoriaDataAccess");
                throw;
            }
        }
        public List<Auditoria> ObtenerAuditorias()
        {
            List<Auditoria> auditorias = new List<Auditoria>();
            try
            {
                _dbAccess.Connect(); // Conectar a la base de datos
                string query = @"SELECT u.id_usuario, p.nombre_completo, p.correo,
                                b.accion, b.fecha, b.ip_acceso, 
                                b.nombre_equipo, b.tipo, b.id_movimiento as movimiento
	                                FROM bitacora b
	                                JOIN usuarios u ON u.id_usuario = b.id_usuario
	                                JOIN personas p on u.id_persona = p.id_persona
	                                WHERE 1=1";
                //string query = @"SELECT u.id_usuario, p.nombre_completo, p.correo,
                //                b.accion, b.fecha, b.ip_acceso, 
                //                b.nombre_equipo, b.tipo, b.id_movimiento as movimiento
                //                CASE 
					           //     WHEN b.id_movimiento = 0 THEN 'USUARIO AGREGADO'
					           //     WHEN b.id_movimiento = 1 THEN 'ACTUALIZACION USUARIO'
					           //     WHEN b.id_movimiento = 2 THEN 'BAJA USUARIO'
	               //                 WHEN b.id_movimiento = 3 THEN 'VENTA'
	               //                 WHEN b.id_movimiento = 4 THEN 'MODIFICACION'
	               //                 WHEN b.id_movimiento = 5 THEN 'CANCELACION'
					           //     WHEN b.id_movimiento = 6 THEN 'CLIENTE AGREGADO'
	               //                 ELSE
	               //                 'Desconocido'
	               //                 END AS movimiento
	               //                 FROM bitacora b
	               //                 JOIN usuarios u ON u.id_usuario = b.id_usuario
	               //                 JOIN personas p on u.id_persona = p.id_persona
	               //                 WHERE 1=1";
                List<NpgsqlParameter> parameters = new List<NpgsqlParameter>();
                _logger.Info("Ejecutando consulta: {0}", query);
                DataTable auditoriaData = _dbAccess.ExecuteQuery_Reader(query, parameters.ToArray());

                foreach (DataRow row in auditoriaData.Rows)
                {
                    Auditoria auditoria = new Auditoria(
                       Convert.ToInt32(row["id_usuario"]),
                          row["nombre_completo"].ToString() ?? "",
                          row["correo"].ToString() ?? "",
                          row["accion"].ToString() ?? "",
                            Convert.ToDateTime(row["fecha"]),
                            row["ip_acceso"].ToString() ?? "",
                            row["nombre_equipo"].ToString() ?? "",
                            row["tipo"].ToString() ?? "",
                            row["movimiento"].ToString() ?? ""
                            
                    );
                    auditorias.Add(auditoria);
                }
                _logger.Info("Consulta ejecutada exitosamente. Filas Obtenidas: {0}", auditoriaData.Rows.Count);
                _logger.Info("Se encontraron {0} auditorías", auditorias.Count);
                if (auditorias.Count == 0)
                {
                    _logger.Warn("No se encontraron auditorías");
                }
                else
                {
                    _logger.Info("Auditorías obtenidas: {0}", string.Join(", ", auditorias.Select(a => a.ToString())));
                }

                return auditorias;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener auditorías");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect(); // Desconectar de la base de datos
            }
        }
        public void AuditoriaAdd(Auditoria auditoria)
        {
            try
            {
                _dbAccess.Connect(); // Conectar a la base de datos
                string query = @"INSERT INTO bitacora (accion, fecha, ip_acceso, nombre_equipo, tipo, id_usuario, id_movimiento)
                               VALUES (@accion, @fecha, @ip_acceso, @nombre_equipo, @tipo, @id_usuario, @id_movimiento)";
                List<NpgsqlParameter> parameters = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter("@accion", auditoria.Accion),
                    new NpgsqlParameter("@fecha", auditoria.Fecha),
                    new NpgsqlParameter("@ip_acceso", auditoria.IpAcceso),
                    new NpgsqlParameter("@nombre_equipo", auditoria.NombreEquipo),
                    new NpgsqlParameter("@tipo", auditoria.Tipo),
                    new NpgsqlParameter("@id_usuario", auditoria.UsuarioId ?? (object)DBNull.Value),
                    new NpgsqlParameter("@id_movimiento", auditoria.IdMovimiento ?? (object)DBNull.Value)
                };
                _logger.Info("Ejecutando consulta: {0}", query);
                var resul = _dbAccess.ExecuteNonQuery(query, parameters.ToArray());
                if (resul == 0)
                {
                    _logger.Warn("No se pudo agregar la auditoría");
                }
                else
                {
                    _logger.Info("Auditoría agregada exitosamente");
                }
                _logger.Info("Auditoría agregada: {0}", auditoria.ToString());
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al agregar auditoría");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect(); // Desconectar de la base de datos
            }
        }
        public List<Auditoria> ObtenerAuditoriasBusqueda(string nombre,DateTime? fechaInicio, DateTime? fechaFin)
        {
            List<Auditoria> auditorias = new List<Auditoria>();
            try
            {
                string query = @"SELECT u.id_usuario, p.nombre_completo, p.correo,
                                b.accion, b.fecha, b.ip_acceso, 
                                b.nombre_equipo, b.tipo, b.id_movimiento
                                FROM bitacora b
                                   INNER JOIN usuarios u ON u.id_usuario = b.id_usuario
                                   INNER JOIN personas p on u.id_persona = p.id_persona
                                    WHERE (@nombre IS NULL OR LOWER (p.nombre_completo) LIKE @nombre)
                                    AND (@fechaInicio IS NULL OR b.fecha >= @fechaInicio)
                                     AND (@fechaFin IS NULL OR b.fecha <= @fechaFin);";
                List<NpgsqlParameter> parameters = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar)
                    {
                        Value=nombre!= null ? $"%{nombre}%" : (object)DBNull.Value
                    },
                    new NpgsqlParameter("@fechaInicio", NpgsqlTypes.NpgsqlDbType.Date)
                    {
                        Value=fechaInicio != null ? fechaInicio.Value : (object)DBNull.Value
                    },
                    new NpgsqlParameter("@fechaFin", NpgsqlTypes.NpgsqlDbType.Date)
                    {
                        Value=fechaFin != null ? fechaFin.Value : (object)DBNull.Value
                    }

                };
                DataTable auditoriaData = _dbAccess.ExecuteQuery_Reader(query, parameters.ToArray());
                _logger.Info("Ejecutando consulta: {0}", query);
                foreach (DataRow row in auditoriaData.Rows)
                {
                    Auditoria auditoria = new Auditoria(
                       Convert.ToInt32(row["id_usuario"]),
                          row["nombre_completo"].ToString() ?? "",
                          row["correo"].ToString() ?? "",
                          row["accion"].ToString() ?? "",
                            Convert.ToDateTime(row["fecha"]),
                            row["ip_acceso"].ToString() ?? "",
                            row["nombre_equipo"].ToString() ?? "",
                            row["tipo"].ToString() ?? "",
                            row["id_movimiento"].ToString() ?? ""
                    );
                    auditorias.Add(auditoria);

                }
                return auditorias;

            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener auditorías por usuario");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect(); // Desconectar de la base de datos
            }
        }
            
    }
}
