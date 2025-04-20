using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Ventas.Utilities;
using Sistema_Ventas.Model;
using NLog;
using System.Data;

namespace Sistema_Ventas.Data
{
    public class RolesDataAccesscs
    {
        private static readonly Logger _logger = LoggingManager.GetLogger("Sistema_Ventas.Data.RolesDataAccesscs");
        /// 
        private readonly PostgreSQLDataAccess _dbAccess;
        public RolesDataAccesscs()
        {
            try
            {
                _dbAccess = PostgreSQLDataAccess.GetInstance();
            }
            catch (Exception e)
            {
                _logger.Fatal(e, "Error al instializar RolesDataAccesscs");
                throw;
            }
        }

        public List<Rol> obtenerRoles()
        {
            List<Rol> roles = new List<Rol>();
            try
            {
                // Consulta SQL
                string query = @"
        ";

                // Ejecutar consulta 
                DataTable resultado = _dbAccess.ExecuteQuery_Reader(query);

                // Procesar 
                foreach (DataRow row in resultado.Rows)
                {
                    Rol rol = new Rol(
                        Convert.ToInt32(row["id_producto"]),
                        row["cod_producto"].ToString(),
                        row["nombre"].ToString(),
                        Convert.ToDouble(row["precio"]),
                        row["descripcion"].ToString(),
                        Convert.ToInt32(row["existencia"])
                    );
                    roles.Add(rol);
                }

                return roles;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener información de los productos desde la base de datos");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect(); // Siempre cerrar conexión
            }
        }
    }
}
