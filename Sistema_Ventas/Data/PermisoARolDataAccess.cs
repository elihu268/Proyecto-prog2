using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Ventas.Utilities;
using NLog;
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

    }
}
