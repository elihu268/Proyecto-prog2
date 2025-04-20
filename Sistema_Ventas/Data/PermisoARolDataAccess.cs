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
       /* public List<Permiso> ObtenerPermisosPorRol(int codigoRol)
        {
            List<Permiso> lista = new List<Permiso>();

            _dbAccess.Connect();
            string query = @"
            SELECT p.codigo, p.descripcion, p.estatus
            FROM permisos p
            INNER JOIN permisos_a_puesto pp ON p.idpermiso = pp.idpermiso
            INNER JOIN roles r ON pp.idrol = r.idrol
            WHERE r.codigo = @codigoRol;
        ";

            using (NpgsqlCommand cmd = new NpgsqlCommand(query))
            {
                cmd.Parameters.AddWithValue("@codigoRol", codigoRol);

                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string codigo = reader.GetString(1);
                        string descripcion = reader.GetString(2);
                        bool estatus = reader.GetBoolean(3);
                        Permiso permiso = new Permiso(id, codigo, descripcion, estatus);
                        lista.Add(permiso);
                    }
                }
            }


            return lista;
        }
       */
    }
}
