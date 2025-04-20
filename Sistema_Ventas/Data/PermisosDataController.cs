using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Ventas.Utilities;
using NLog;

namespace Sistema_Ventas.Data
{
    public class PermisosDataController
    {
        private static readonly Logger _logger = LoggingManager.GetLogger("Sistema_Ventas.Data.PermisosDataController");
        private readonly PostgreSQLDataAccess _dbAccess;
        public PermisosDataController()
        {
            try
            {
                _dbAccess = PostgreSQLDataAccess.GetInstance();
            }
            catch (Exception e)
            {
                _logger.Fatal(e, "Error al instializar PermisosDataController");
                throw;
            }
        }
    }
}
