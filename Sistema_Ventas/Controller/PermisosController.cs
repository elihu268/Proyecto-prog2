using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Ventas.Data;
using Sistema_Ventas.Model;
using Sistema_Ventas.Utilities;
using NLog;
namespace Sistema_Ventas.Controller
{
    internal class PermisosController
    {
        private static readonly Logger _logger = LoggingManager.GetLogger("Sistema_Ventas.Controller.PermisosController");
        private readonly PermisosDataAccess _permisosData;

        public PermisosController()
        {
            try
            {
                _permisosData = new PermisosDataAccess();

            }
            catch (Exception ex)
            {
                _logger.Error(ex, "error al inicializar el controlador de permisos");
                throw;
            }
        }
        public List<Permiso> ObtenerPermisos()
        {
            try
            {
                List<Permiso> permisos = _permisosData.obtenerPermisos();
                _logger.Info($"Se obtuvieron {permisos.Count} ");
                return permisos;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener la lista de permisos");
                throw;
            }
        }
        public List<Permiso> ObtenerPermisos()
        {
            try
            {
                List<Permiso> permisos = _permisosData.obtenerPermisos();
                _logger.Info($"Se obtuvieron {permisos.Count} ");
                return permisos;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener la lista de permisos");
                throw;
            }
        }
    }
}
