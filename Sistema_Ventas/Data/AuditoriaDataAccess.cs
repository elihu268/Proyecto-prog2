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
                        Convert.ToInt32(row["id"]),
                        row["usuario"].ToString() ?? "",
                        row["accion"].ToString() ?? "",
                        Convert.ToDateTime(row["fecha_hora"]),
                        row["detalles"].ToString() ?? ""
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
    }
}
