using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Ventas.Utilities;
using NLog;
using Npgsql;
using Sistema_Ventas.Model;
using System.Data;
namespace Sistema_Ventas.Data
{
    public class PermisoARolDataAccess
    {
        private static readonly Logger _logger = LoggingManager.GetLogger("Sistema_Ventas.Data.PermisoARolDataAccess");

        private readonly PostgreSQLDataAccess _dbAccess;

        private readonly PermisosDataAccess _permisosData;
        public PermisoARolDataAccess()
        {
            try
            {
                _dbAccess = PostgreSQLDataAccess.GetInstance();
            }
            catch (Exception e)
            {
                _logger.Fatal(e, "Error al instializar PermisoARolDataAccess");
                throw;
            }
        }
        
            public void EliminarPermisosDeRol(int id_rol)
        {
            try
            {
                string query = "DELETE FROM permisos_rol WHERE id_puesto = @IdPuesto";

                // Crear parámetro
                NpgsqlParameter paramPuesto = _dbAccess.CreateParameter("@id_rol", id_rol);

                // Conectar y ejecutar
                _dbAccess.Connect();
                _dbAccess.ExecuteNonQuery(query, paramPuesto);

                _logger.Info($"Permisos eliminados correctamente para el rol: {id_rol}");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al eliminar permisos del rol: {id_rol}");
                throw; 
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }
        public bool AgregarPermisoARol(int idRol, int idPermiso)
        {
            try
            {
                string query = "INSERT INTO permisos_rol (id_puesto, id_permiso) VALUES (@IdPuesto, @IdPermiso)";

                // Crear parámetros
                NpgsqlParameter paramPuesto = _dbAccess.CreateParameter("@IdPuesto", idRol);
                NpgsqlParameter paramPermiso = _dbAccess.CreateParameter("@IdPermiso", idPermiso);

                // Conectar y ejecutar
                _dbAccess.Connect();
                _dbAccess.ExecuteNonQuery(query, paramPuesto, paramPermiso);

                _logger.Info($"Permiso {idPermiso} asignado correctamente al rol {idRol}");
                return true;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al agregar permiso {idPermiso} al rol {idRol}");
                return false;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }
        public List<int> ObtenerIdsPermisosPorRol(int idRol)
        {
            List<int> permisos = new List<int>();

            try
            {
                string query = "SELECT id_permiso FROM permisos_rol WHERE id_rol = @IdRol";

                NpgsqlParameter paramIdRol = _dbAccess.CreateParameter("@IdRol", idRol);

                _dbAccess.Connect();
                DataTable dt = _dbAccess.ExecuteQuery_Reader(query, paramIdRol);

                foreach (DataRow row in dt.Rows)
                {
                    permisos.Add(Convert.ToInt32(row["id_permiso"]));
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al obtener permisos del rol {idRol}");
            }
            finally
            {
                _dbAccess.Disconnect();
            }

            return permisos;
        }

        /* public List<Permiso> ObtenerPermisosDeRol(int idRol)
         {
             List<Permiso> permisos = new List<Permiso>();

             try
             {
                 string query = @"
             SELECT p.id_permiso, p.codigo, p.descripcion, p.estatus
             FROM permisos_rol pr
             INNER JOIN permisos p ON pr.id_permiso = p.id_permiso
             WHERE pr.id_rol = @IdRol";

                 NpgsqlParameter paramRol = _dbAccess.CreateParameter("@IdRol", idRol);

                 _dbAccess.Connect();
                 DataTable tablaPermisos = _dbAccess.ExecuteQuery_Reader(query, paramRol);

                 foreach (DataRow row in tablaPermisos.Rows)
                 {
                     Permiso permiso = new Permiso
                     {
                         IdPermiso = Convert.ToInt32(row["id_permiso"]),
                         Codigo = row["codigo"].ToString(),
                         Descripcion = row["descripcion"].ToString(),
                         Estatus = Convert.ToBoolean(row["estatus"])
                     };
                     permisos.Add(permiso);
                 }

                 _logger.Info($"Se recuperaron {permisos.Count} permisos para el rol con ID {idRol}");
             }
             catch (Exception ex)
             {
                 _logger.Error(ex, $"Error al obtener permisos para el rol con ID {idRol}");
             }
             finally
             {
                 _dbAccess.Disconnect();
             }

             return permisos;
         }*/


    }
}
