using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sistema_Ventas.Model
{
    public class Rol
    {
        

            /// <summary>
            /// Corresponde a id_rol (clave primaria SERIAL)
            /// </summary>
            public int IdRol { get; set; }      
            /// <summary>
            /// Corresponde a codigo (VARCHAR(20) NOT NULL)
            /// </summary>
            public string Codigo { get; set; }        
            /// <summary>
            ///  Corresponde a descripcion (TEXT)
            /// </summary>
            public string Descripcion { get; set; }  
            /// <summary>
            /// Corresponde a estatus(BOOLEAN)
            /// </summary>
            public bool Estatus { get; set; }        

            public Rol(int idRol, string codigo, string descripcion, bool estatus) {
                this.IdRol = idRol;
                this.Codigo=codigo;
                this.Descripcion = descripcion;
                this.Estatus = estatus;
            }

    }
}
