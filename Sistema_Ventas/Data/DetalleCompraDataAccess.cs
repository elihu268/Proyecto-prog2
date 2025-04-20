using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_Ventas.Utilities;
using NLog;
namespace Sistema_Ventas.Data
{
    public class DetalleCompraDataAccess
    {
        private static readonly Logger _logger = LoggingManager.GetLogger("Sistema_Ventas.Data.VlienteDataAccess");
      private readonly PostgreSQLDataAccess _dbAccess;

        public bool AgregarDetalleaCompra()
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {

            }
        }
    }
}
