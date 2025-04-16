using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Ventas.Model
{
    public class Usuario
    {
        public int IdPersona { get; set; }
        public int idRol { get; set; }
        public string Cuenta { get; set; }
        public string Constrasena { get; set; }
        public int Estatus { get; set; }
    }
}
