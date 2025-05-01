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
        public static int IdRol { get; private set; }
        public static List<string> Permisos { get; set; } = new List<string>();

        public static void IniciarSesion(int idUsuario, string usuario, int idRol, List<string> permisos)
        {
            IdUsuario = idUsuario;
            UsuarioActual = usuario;
            IdRol = idRol;
            Permisos = permisos;
        }

        public static void CerrarSesion()
        {
            IdUsuario = 0;
            UsuarioActual = null;
            IdRol = 0;
            Permisos.Clear();
        }

        public static bool TienePermiso(string codigoPermiso)
        {
            return Permisos.Contains(codigoPermiso);
        }

    }
}
