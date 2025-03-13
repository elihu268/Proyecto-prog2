using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Sistema_Ventas.Bussines
{
    class ClientesNegocio
    {
        public static bool ValidarRFC(string rfc)
        {
            string patron = @"^([A-ZÑ\x26]{3,4}([0-9]{2})(0[1-9]|1[0-2])(0[1-9]|1[0-9]|2[0-9]|3[0-1]))([A-Z\d]{3})?$";
            return Regex.IsMatch(patron, rfc);
        }
    }
}
