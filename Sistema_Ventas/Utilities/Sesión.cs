using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Ventas.Utilities
{
    class Sesión
    {
        public static int IdUsuario { get; private set; }
        public static string UsuarioActual { get; private set; }
        public static List<string> Permisos { get; private set; } = new List<string>();

        public static void IniciarSesion(int idUsuario, string usuario, List<string> permisos)
        {
            IdUsuario = idUsuario;
            UsuarioActual = usuario;
            Permisos = permisos;
        }

        public static void CerrarSesion()
        {
            IdUsuario = 0;
            UsuarioActual = null;
            Permisos.Clear();
        }

        public static bool TienePermiso(string codigoPermiso)
        {
            return Permisos.Contains(codigoPermiso);
        }

    }
}
