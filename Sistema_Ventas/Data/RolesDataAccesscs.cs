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
                string query = @"SELECT id_rol, codigo, descripcion, estatus FROM roles WHERE estatus=true";

                DataTable resultado = _dbAccess.ExecuteQuery_Reader(query);

                foreach (DataRow row in resultado.Rows)
                {
                    var idRol = Convert.ToInt32(row["id_rol"]);
                    var codigo = row["codigo"].ToString();
                    var descripcion = row.IsNull("descripcion") ? null : row["descripcion"].ToString();
                    var estatus = Convert.ToBoolean(row["estatus"]);

                    Rol rol = new Rol(idRol, codigo, descripcion, estatus);
                    roles.Add(rol);
                }

                return roles;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener información de los roles desde la base de datos");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }

    }
}
