using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_VentasCore.Data;
using Sistema_VentasCore.Utilities;
using NLog;
using Npgsql;
using Sistema_VentasCore.Model;
using System.Security.Cryptography;

namespace Sistema_VentasCore.Controller
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

        public void AsignarPermisosARol(int idRol, List<int> permisos)
        {
            try
            {
                _permisoARolData.EliminarPermisosDeRol(idRol);//primero elimina los permisos que tenia, para que no se repitan
                foreach (int idPermiso in permisos) {
                    _permisoARolData.AgregarPermisoARol(idRol, idPermiso);

                    _logger.Debug($"se asigno el permiso{idPermiso} al rol: " + idRol);
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"error al asignar permisos al rol: "+ idRol);
                throw;
            }
        }
        
        public List<int> ObtenerIdsPermisosPorRol(int idRol)
        {
            try
            {
                // 1. Eliminar todos los permisos actuales del puesto
                List<int> listaPermisos= _permisoARolData.ObtenerIdsPermisosPorRol(idRol);
                
                _logger.Debug($"se obtuvo la lista de permisos del rol: {idRol}");
                return listaPermisos;
            }
            catch (Exception ex)
            {
                _logger.Error($"no se pudo obtener la lista de permisos del rol: {idRol},{ex}");
                return null;
            }
        }
    }
}
