using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sistema_VentasCore.Model
{
    /// <summary>
    /// Representa un rol dentro del sistema.
    /// </summary>
    public class Rol
    {
            /// <summary>
            /// Corresponde a id_rol (clave primaria SERIAL)
            /// </summary>
            public int IdRol { get; set; }

            /// <summary>
            /// Corresponde a código del rol (VARCHAR(20) NOT NULL)
            /// </summary>
            public string Codigo { get; set; }

            /// <summary>
            /// Corresponde a descripción del rol (TEXT)
            /// </summary>
            public string Descripcion { get; set; }

            /// <summary>
            /// Corresponde a estatus del rol (BOOLEAN) [Está activo o no]
            /// </summary>
            public bool Estatus { get; set; }
            
            /// <summary>
            /// Constructor por defecto.
            /// </summary>
            public Rol()
            {
                IdRol = 0; // Por defecto, el ID es 0
                Codigo = string.Empty;
                Descripcion = string.Empty;
                Estatus = true; // Por defecto, el rol se crea activo
            }

            /// <summary>
            /// Constructor completo.
            /// </summary>
            /// <param name="idRol">Identificador único del rol.</param>
            /// <param name="codigo">Código del rol.</param>
            /// <param name="descripcion">Descripción del rol.</param>
            /// <param name="estatus">Estatus del rol.</param>
            public Rol(int idRol, string codigo, string descripcion, bool estatus)
            {
                IdRol = idRol;
                Codigo = codigo;
                Descripcion = descripcion;
                Estatus = estatus;
            }
    }
}
