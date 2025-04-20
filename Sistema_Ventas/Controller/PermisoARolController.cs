using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Ventas.Data;
using Sistema_Ventas.Utilities;
using NLog;
using Npgsql;
using Sistema_Ventas.Model;

namespace Sistema_Ventas.Controller
{
    public class PermisoARolController
    {
        private static readonly Logger _logger = LoggingManager.GetLogger("Sistema_Ventas.Controller.PermisoARolDataAccess");
        private readonly PermisoARolDataAccess _permisoARolData;
        public PermisoARolController()
        {
            try
            {
                _permisoARolData = new PermisoARolDataAccess();
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "error al inicializar el controlador de permisos a rol");
                throw;
            }
        }
        //asignar permiso

        public void AsignarPermisosARol(int idRol, int idPermiso)
        {
            try
            {

                _permisoARolData.AgregarPermisoARol(idRol, idPermiso);

                _logger.Debug($"se asigno el permiso{idPermiso} al rol: "+ idRol);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"error al asignar permiso{idPermiso} al rol: "+ idRol);
                throw;
            }
        }
        //eliminar
        public void  EliminarPermisos(int idRol)
        {
            try
            {
                // 1. Eliminar todos los permisos actuales del puesto
                _permisoARolData.EliminarPermisosDeRol(idRol);

                

                _logger.Debug($"Permisos eliminados para el rol: {idRol}");
            }
            catch (Exception ex)
            {
                _logger.Error($"Error al elimar permisos al rol: {idRol},{ex}");
            }
        }
        /*public List<Permiso> ObtenerPermisosPorRol(int idRol)
        {
            try
            {
                // 1. Eliminar todos los permisos actuales del puesto
                List<Permiso> listaPermisos= _permisoARolData.ObtenerPermisosPorRol(idRol);


                
                _logger.Debug($"se obtuvo la lista de permisos del rol: {idRol}");
                return listaPermisos;
            }
            catch (Exception ex)
            {
                _logger.Error($"no se pudo obtener la lista de permisos del rol: {idRol},{ex}");
            }
        }*/
    }
}
