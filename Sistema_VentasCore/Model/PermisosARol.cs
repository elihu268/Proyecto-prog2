using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_VentasCore.Model
{
    public class PermisosARol
    {
        private int id_permiso { get; set; }
        private string codigo { get; set; }
        private string descripcion { get; set; }
        private bool estatus { get; set; }
        private Rol rol { get; set; }
        public PermisosARol(int id_permiso, string codigo, string descripcion, bool estatus, Rol rol)
        {
            this.id_permiso = id_permiso;
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.estatus = estatus;
            this.rol = rol;
        }
    }
}
