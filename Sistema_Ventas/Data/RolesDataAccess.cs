using Sistema_Ventas.Utilities;
using Sistema_Ventas.Model;
using NLog;
using Npgsql;
using System.Data;

namespace Sistema_Ventas.Data
{
    /// <summary>
    /// Clase responsable del acceso a datos para la entidad "Rol".
    /// Proporciona métodos para CRUD y manipulación de roles en la base de datos PostgreSQL.
    /// </summary>
    public class RolesDataAccess
    {
        private static readonly Logger _logger = LoggingManager.GetLogger("Sistema_Ventas.Data.RolesDataAccess");
        private readonly PostgreSQLDataAccess _dbAccess;

        /// <summary>
        /// Constructor que inicializa la instancia de acceso a base de datos.
        /// </summary>
        public RolesDataAccess()
        {
            try
            {
                _dbAccess = PostgreSQLDataAccess.GetInstance();
            }
            catch (Exception e)
            {
                _logger.Fatal(e, "Error al inicializar RolesDataAccess");
                throw;
            }
        }


        /// <summary>
        /// Verifica si un código de rol ya existe en la base de datos.
        /// </summary>
        /// <param name="codigo">Código a verificar.</param>
        /// <returns>True si ya existe, False si no.</returns>
        public bool ExisteCodigo(string codigo)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM roles WHERE codigo = @Codigo";
                var parametro = _dbAccess.CreateParameter("@Codigo", codigo);

                _dbAccess.Connect();
                object? resultado = _dbAccess.ExecuteScalar(query, parametro);
                int cantidad = Convert.ToInt32(resultado);

                return cantidad > 0;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al verificar existencia del código '{codigo}'");
                return false;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }

        /// <summary>
        /// Inserta un nuevo rol en la base de datos.
        /// </summary>
        /// <param name="rol">Objeto Rol con la información a insertar.</param>
        /// <returns>ID generado del nuevo rol o -1 en caso de error.</returns>
        public int InsertarRol(Rol rol)
        {
            try
            {
                // Verifica que no exista un código duplicado
                if (ExisteCodigo(rol.Codigo))
                {
                    _logger.Warn($"Ya existe un rol con el código '{rol.Codigo}'. No se puede insertar.");
                    return -1;
                }

                string query = @"INSERT INTO roles (codigo, descripcion, estatus)
                                 VALUES (@Codigo, @Descripcion, @Estatus)
                                 RETURNING id_rol";

                var parametros = new NpgsqlParameter[]
                {
                    _dbAccess.CreateParameter("@Codigo", rol.Codigo),
                    _dbAccess.CreateParameter("@Descripcion", rol.Descripcion),
                    _dbAccess.CreateParameter("@Estatus", rol.Estatus)
                };

                _dbAccess.Connect();
                object? resultado = _dbAccess.ExecuteScalar(query, parametros);
                int idGenerado = Convert.ToInt32(resultado);

                _logger.Info($"Rol insertado correctamente con ID: {idGenerado}");
                return idGenerado;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al insertar el rol");
                return -1;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }

        /// <summary>
        /// Actualiza la información de un rol existente en la base de datos.
        /// </summary>
        /// <param name="rol">Objeto Rol con la información actualizada.</param>
        /// <returns>True si se actualizó exitosamente, False en caso contrario.</returns>
        public bool ActualizarRol(Rol rol)
        {
            try
            {
                string query = @"UPDATE roles
                                 SET codigo = @Codigo,
                                     descripcion = @Descripcion,
                                     estatus = @Estatus
                                 WHERE id_rol = @IdRol";

                var parametros = new NpgsqlParameter[]
                {
                    _dbAccess.CreateParameter("@Codigo", rol.Codigo),
                    _dbAccess.CreateParameter("@Descripcion", rol.Descripcion),
                    _dbAccess.CreateParameter("@Estatus", rol.Estatus),
                    _dbAccess.CreateParameter("@IdRol", rol.IdRol)
                };

                _dbAccess.Connect();
                int filasAfectadas = _dbAccess.ExecuteNonQuery(query, parametros);

                bool exito = filasAfectadas > 0;
                if (!exito)
                {
                    _logger.Warn($"No se encontró el rol con ID {rol.IdRol} para actualizar");
                }
                else
                {
                    _logger.Info($"Rol con ID {rol.IdRol} actualizado correctamente");
                }

                return exito;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al actualizar el rol con ID {rol.IdRol}");
                return false;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }

        /// <summary>
        /// Obtiene la lista de roles desde la base de datos.
        /// </summary>
        /// <param name="soloActivos">Si es verdadero, solo devuelve roles con estatus activo.</param>
        /// <returns>Lista de objetos Rol.</returns>
        public List<Rol> ObtenerRoles(bool soloActivos = true)
        {
            List<Rol> roles = new List<Rol>();

            try
            {
                string query = "SELECT id_rol, codigo, descripcion, estatus FROM roles WHERE 1=1";
                if (soloActivos)
                {
                    query += " AND estatus = true";
                }

                _dbAccess.Connect();
                DataTable resultado = _dbAccess.ExecuteQuery_Reader(query);

                foreach (DataRow row in resultado.Rows)
                {
                    Rol rol = new Rol(
                        Convert.ToInt32(row["id_rol"]),
                        row["codigo"].ToString() ?? "",
                        row["descripcion"].ToString() ?? "",
                        Convert.ToBoolean(row["estatus"])
                    );
                    roles.Add(rol);
                }

                _logger.Info($"Se obtuvieron {roles.Count} roles");
                return roles;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener los roles");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }

        /// <summary>
        /// Obtiene un rol específico por su identificador.
        /// </summary>
        /// <param name="id">ID del rol a buscar.</param>
        /// <returns>Objeto Rol si se encuentra, null si no existe.</returns>
        public Rol? ObtenerRolPorId(int id)
        {
            try
            {
                string query = "SELECT id_rol, codigo, descripcion, estatus FROM roles WHERE id_rol = @IdRol";
                var parametro = _dbAccess.CreateParameter("@IdRol", id);

                _dbAccess.Connect();
                DataTable resultado = _dbAccess.ExecuteQuery_Reader(query, parametro);

                if (resultado.Rows.Count == 0)
                {
                    _logger.Warn($"No se encontró ningún rol con ID {id}");
                    return null;
                }

                DataRow row = resultado.Rows[0];
                return new Rol(
                    Convert.ToInt32(row["id_rol"]),
                    row["codigo"].ToString() ?? "",
                    row["descripcion"].ToString() ?? "",
                    Convert.ToBoolean(row["estatus"])
                );
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al obtener el rol con ID {id}");
                return null;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }

        /// <summary>
        /// Cambia el estatus (activo/inactivo) de un rol.
        /// </summary>
        /// <param name="idRol">ID del rol a modificar.</param>
        /// <param name="nuevoEstatus">Nuevo valor booleano del estatus.</param>
        /// <returns>True si la operación fue exitosa, False en caso contrario.</returns>
        public bool CambiarEstatusRol(int idRol, bool nuevoEstatus)
        {
            try
            {
                string query = "UPDATE roles SET estatus = @NuevoEstatus WHERE id_rol = @IdRol";

                var parametros = new NpgsqlParameter[]
                {
                    _dbAccess.CreateParameter("@NuevoEstatus", nuevoEstatus),
                    _dbAccess.CreateParameter("@IdRol", idRol)
                };

                _dbAccess.Connect();
                int filasAfectadas = _dbAccess.ExecuteNonQuery(query, parametros);
                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al cambiar el estatus del rol con ID {idRol}");
                return false;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }

        /// <summary>
        /// Obtiene una lista de roles desde la base de datos aplicando filtros opcionales:
        /// por código exacto, coincidencia parcial en descripción y estatus activo/inactivo.
        ///
        /// </summary>
        /// <param name="codigo">Código exacto del rol (opcional)</param>
        /// <param name="descripcion">Texto parcial de descripción (opcional)</param>
        /// <param name="estatus">1 para activos, 0 para inactivos, null para todos (opcional)</param>
        /// <returns>Lista de roles que coinciden con los filtros especificados.</returns>
        public List<Rol> ObtenerRolesFiltrados(string? codigo = null, string? descripcion = null, int? estatus = null)
        {
            List<Rol> roles = new List<Rol>();

            try
            {
                _dbAccess.Connect();

                string query = "SELECT id_rol, codigo, descripcion, estatus FROM roles WHERE 1=1";
                List<NpgsqlParameter> parametros = new List<NpgsqlParameter>();

                // Filtro por código exacto (ComboBox)
                if (!string.IsNullOrWhiteSpace(codigo))
                {
                    query += " AND codigo = @Codigo";
                    parametros.Add(_dbAccess.CreateParameter("@Codigo", codigo));
                }

                // Filtro por descripción con LIKE (TextBox)
                if (!string.IsNullOrWhiteSpace(descripcion))
                {
                    query += " AND LOWER(descripcion) LIKE LOWER(@Descripcion)";
                    parametros.Add(_dbAccess.CreateParameter("@Descripcion", $"%{descripcion.Trim()}%"));
                }

                // Filtro por estatus (ComboBox)
                if (estatus.HasValue)
                {
                    query += " AND estatus = @Estatus";
                    parametros.Add(_dbAccess.CreateParameter("@Estatus", estatus == 1));
                }

                query += " ORDER BY id_rol";

                DataTable resultado = _dbAccess.ExecuteQuery_Reader(query, parametros.ToArray());

                foreach (DataRow row in resultado.Rows)
                {
                    roles.Add(new Rol(
                        Convert.ToInt32(row["id_rol"]),
                        row["codigo"].ToString() ?? "",
                        row["descripcion"].ToString() ?? "",
                        Convert.ToBoolean(row["estatus"])
                    ));
                }

                _logger.Info($"Se recuperaron {roles.Count} roles con filtros aplicados.");
                return roles;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener roles filtrados.");
                return new List<Rol>();
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }

        /// <summary>
        /// Obtiene el siguiente ID disponible para la tabla de roles.
        /// Este valor se calcula consultando el máximo ID actual más uno.
        /// </summary>
        /// <returns>ID sugerido para el siguiente rol (int), o 1 si no hay registros.</returns>
        public int ObtenerSiguienteIdRol()
        {
            try
            {
                string query = "SELECT COALESCE(MAX(id_rol), 0) + 1 FROM roles";

                _dbAccess.Connect();
                object? resultado = _dbAccess.ExecuteScalar(query);
                int siguienteId = Convert.ToInt32(resultado);

                _logger.Debug($"Siguiente ID disponible para rol: {siguienteId}");
                return siguienteId;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener el siguiente ID disponible para roles");
                return 1;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }
    }
}
