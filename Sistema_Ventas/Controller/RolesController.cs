using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Ventas.Data;
using Sistema_Ventas.Utilities;
using NLog;
using Sistema_Ventas.Model;
namespace Sistema_Ventas.Controller
{
    internal class RolesController
    {
        private static readonly Logger _logger = LoggingManager.GetLogger("Sistema_Ventas.Controller.RolesController");
        private readonly RolesDataAccess _rolesData;

        public RolesController()
        {
            try
            {
                _rolesData = new RolesDataAccess();

            }
            catch (Exception ex)
            {
                _logger.Error(ex, "error al inicializar el controlador de roles");
                throw;
            }
        }
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
    }
}
