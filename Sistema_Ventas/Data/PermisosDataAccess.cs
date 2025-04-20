using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Ventas.Utilities;
using NLog;
using Sistema_Ventas.Model;
using System.Data;

namespace Sistema_Ventas.Data
{
    public class PermisosDataAccess
    {
        private static readonly Logger _logger = LoggingManager.GetLogger("Sistema_Ventas.Data.PermisosDataAccess");
        private readonly PostgreSQLDataAccess _dbAccess;
        public PermisosDataAccess()
        {
            try
            {
                _dbAccess = PostgreSQLDataAccess.GetInstance();
            }
            catch (Exception e)
            {
                _logger.Fatal(e, "Error al instializar PermisosDataAccess");
                throw;
            }
        }
        public List<Permiso> obtenerPermisos()
        {
            List<Permiso> permisos = new List<Permiso>();

            try
            {
                string query = @"SELECT id_permiso, codigo, descripcion, estatus FROM permisos";

                DataTable resultado = _dbAccess.ExecuteQuery_Reader(query);

                foreach (DataRow row in resultado.Rows)
                {
                    int idPermiso = Convert.ToInt32(row["id_permiso"]);
                    string codigo = row["codigo"].ToString();
                    string descripcion = row.IsNull("descripcion") ? null : row["descripcion"].ToString();
                    bool estatus =  Convert.ToBoolean(row["estatus"]);

                    Permiso permiso = new Permiso(idPermiso, codigo, descripcion, estatus);
                    permisos.Add(permiso);
                }

                return permisos;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error al obtener información de los permisos desde la base de datos");
                throw;
            }
            finally
            {
                _dbAccess.Disconnect();
            }
        }


    }
}
