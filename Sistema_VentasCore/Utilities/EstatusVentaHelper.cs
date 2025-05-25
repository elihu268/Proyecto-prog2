using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_VentasCore.Utilities
{
    public class EstatusVentaHelper
    {
        public static string ObtenerDescripcionEstatus(int estatus)
        {
            return estatus switch
            {
                1 => "Pendiente",
                2 => "Confirmado",
                3 => "Autorizado",
                0 => "Cancelado",
                _ => "Desconocido"
            };
        }

        public static Dictionary<int, string> ObtenerTodosLosEstatus()
        {
            return new Dictionary<int, string>
            {
                { 1, "Pendiente" },
                { 2, "Confirmado" },
                { 3, "Autorizado" },
                { 0, "Cancelado" }
            };
        }

        public static Color ObtenerColorEstatus(int estatus)
        {
            return estatus switch
            {
                1 => Color.Orange,      // Pendiente de Pago
                2 => Color.Blue,        // Confirmado
                3 => Color.Green,       // Autorizado
                0 => Color.Red,         // Cancelado
                _ => Color.Gray
            };
        }
    }
}
