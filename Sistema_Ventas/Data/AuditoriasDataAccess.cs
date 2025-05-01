using NLog;
using Npgsql;
using Sistema_Ventas.Model;
using Sistema_Ventas.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Ventas.Data
{
    class AuditoriaDataAccess
    {
        private static readonly Logger _logger = LoggingManager.GetLogger("Sistema_Ventas.Data.AuditoriaDataAccess");
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
                string query = "SELECT * FROM auditoria";
                List<NpgsqlParameter> parameters = new List<NpgsqlParameter>();
                _logger.Info("Ejecutando consulta: {0}", query);
                DataTable auditoriaData = _dbAccess.ExecuteQuery_Reader(query, parameters.ToArray());

                foreach (DataRow row in auditoriaData.Rows)
                {
                    Auditoria auditoria = new Auditoria(
                        Convert.ToString(row["accion"]),
                        Convert.ToString(row["tipo"]),
                        Convert.ToInt32(row["usuario_id"]),
                        Convert.ToInt32(row["id_movimiento"]),
                        Convert.ToString(row["ip_acceso"]),
                        Convert.ToString(row["nombre_equipo"])

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
        public async Task AuditoriaAdd(Auditoria auditoria)
        {
            try
            {
                _dbAccess.Connect(); // Conectar a la base de datos
                string query = "INSERT INTO auditoria (accion, fecha, ip_acceso, nombre_equipo, tipo, usuario_id, id_movimiento) " +
                               "VALUES (@accion, @fecha, @ip_acceso, @nombre_equipo, @tipo, @usuario_id, @id_movimiento)";
                List<NpgsqlParameter> parameters = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter("@accion", auditoria.Accion),
                    new NpgsqlParameter("@fecha", auditoria.Fecha),
                    new NpgsqlParameter("@ip_acceso", auditoria.IpAcceso),
                    new NpgsqlParameter("@nombre_equipo", auditoria.NombreEquipo),
                    new NpgsqlParameter("@tipo", auditoria.Tipo),
                    new NpgsqlParameter("@usuario_id", auditoria.UsuarioId ?? (object)DBNull.Value),
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
    }
}
