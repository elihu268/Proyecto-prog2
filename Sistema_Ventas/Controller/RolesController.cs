using Sistema_Ventas.Data;
using Sistema_Ventas.Utilities;
using NLog;
using Sistema_Ventas.Model;

namespace Sistema_Ventas.Controller
{
    /// <summary>
    /// Controlador para gestionar operaciones relacionadas con roles en el sistema.
    /// </summary>
    internal class RolesController
    {
        private static readonly Logger _logger = LoggingManager.GetLogger("Sistema_Ventas.Controller.RolesController");
        private readonly RolesDataAccess _rolesData;

        /// <summary>
        /// Constructor del controlador de roles.
        /// </summary>
        public RolesController()
        {
            try
            {
                _rolesData = new RolesDataAccess();
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al inicializar el controlador de roles");
                throw;
            }
        }

        /// <summary>
        /// Obtiene una lista de roles desde la base de datos.
        /// </summary>
        /// <returns>Lista de roles activos.</returns>
        public List<Rol> ObtenerRoles()
        {
            try
            {
                List<Rol> roles = _rolesData.ObtenerRoles();
                _logger.Info($"Se obtuvieron {roles.Count} roles");
                return roles;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener la lista de roles");
                throw;
            }
        }

        /// <summary>
        /// Registra un nuevo rol en el sistema.
        /// </summary>
        /// <param name="rol">Objeto rol con los datos a registrar.</param>
        /// <returns>Tupla con ID del nuevo rol y mensaje.</returns>
        public (int id, string mensaje) RegistrarRol(Rol rol)
        {
            try
            {
                if (_rolesData.ExisteCodigo(rol.Codigo))
                {
                    _logger.Warn($"Intento de registrar rol con código duplicado: {rol.Codigo}");
                    return (-2, $"El código '{rol.Codigo}' ya existe en el sistema.");
                }

                int idRol = _rolesData.InsertarRol(rol);

                if (idRol <= 0)
                {
                    return (-1, "Error al registrar el rol en la base de datos.");
                }

                _logger.Info($"Rol registrado exitosamente con ID: {idRol}");
                return (idRol, "Rol registrado exitosamente");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error inesperado al registrar el rol");
                return (-3, $"Error inesperado: {ex.Message}");
            }
        }

        /// <summary>
        /// Obtiene los detalles de un rol por su ID.
        /// </summary>
        /// <param name="id">ID del rol.</param>
        /// <returns>Objeto Rol o null si no se encuentra.</returns>
        public Rol? ObtenerDetalleRol(int id)
        {
            try
            {
                _logger.Debug($"Solicitando detalle del rol con ID: {id}");
                return _rolesData.ObtenerRolPorId(id);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al obtener detalles del rol con ID: {id}");
                throw;
            }
        }

        /// <summary>
        /// Obtiene el siguiente ID disponible para la tabla de roles.
        /// </summary>
        /// <returns>El siguiente ID sugerido para un nuevo rol.</returns>
        public int ObtenerSiguienteId()
        {
            try
            {
                int id = _rolesData.ObtenerSiguienteIdRol();
                _logger.Debug($"Siguiente ID sugerido desde controlador: {id}");
                return id;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener el siguiente ID desde el controlador");
                return 1; // valor por defecto
            }
        }

        /// <summary>
        /// Actualiza un rol existente en el sistema.
        /// </summary>
        /// <param name="rol">Objeto rol con datos actualizados.</param>
        /// <returns>Tupla con resultado y mensaje.</returns>
        public (bool exito, string mensaje) ActualizarRol(Rol rol)
        {
            try
            {
                if (rol == null || rol.IdRol <= 0)
                {
                    return (false, "Datos del rol no válidos");
                }

                var rolExistente = _rolesData.ObtenerRolPorId(rol.IdRol);
                if (rolExistente == null)
                {
                    return (false, $"No se encontró el rol con ID {rol.IdRol}");
                }

                if (rol.Codigo != rolExistente.Codigo && _rolesData.ExisteCodigo(rol.Codigo))
                {
                    return (false, $"El código '{rol.Codigo}' ya está registrado en el sistema");
                }

                _logger.Info($"Actualizando rol con ID: {rol.IdRol}, Código: {rol.Codigo}");
                bool actualizado = _rolesData.ActualizarRol(rol);

                if (!actualizado)
                {
                    _logger.Error($"Error al actualizar el rol con ID {rol.IdRol}");
                    return (false, "Error al actualizar el rol en la base de datos");
                }

                _logger.Info($"Rol con ID {rol.IdRol} actualizado exitosamente");
                return (true, "Rol actualizado exitosamente");
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error inesperado al actualizar el rol con ID {rol?.IdRol}");
                return (false, $"Error inesperado: {ex.Message}");
            }
        }

        /// <summary>
        /// Cambia el estatus (activo/inactivo) de un rol existente.
        /// </summary>
        /// <param name="idRol">ID del rol a modificar.</param>
        /// <param name="nuevoEstatus">Nuevo estatus booleano.</param>
        /// <returns>True si se realizó el cambio, false en caso contrario.</returns>
        public bool CambiarEstatus(int idRol, bool nuevoEstatus)
        {
            try
            {
                return _rolesData.CambiarEstatusRol(idRol, nuevoEstatus);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al cambiar estatus del rol con ID {idRol}");
                return false;
            }
        }

        /// <summary>
        /// Obtiene una lista de roles filtrados por código, descripción y estatus.
        /// Todos los parámetros son opcionales
        /// </summary>
        /// <param name="codigo">Código exacto del rol (opcional)</param>
        /// <param name="descripcion">Texto parcial para búsqueda en descripción (opcional)</param>
        /// <param name="estatus">1 para activos, 0 para inactivos, null para todos (opcional)</param>
        /// <returns>Lista de roles que coincidan con los filtros</returns>
        public List<Rol> ObtenerRolesFiltrados(string? codigo = null, string? descripcion = null, int? estatus = null)
        {
            try
            {
                var roles = _rolesData.ObtenerRolesFiltrados(codigo, descripcion, estatus);
                _logger.Info($"Se obtuvieron {roles.Count} roles con filtros aplicados.");
                return roles;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener roles filtrados desde el controlador.");
                return new List<Rol>();
            }
        }

    }
}
