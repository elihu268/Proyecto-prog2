using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Ventas.Model
{
    public class Permiso
    {
            public int IdPermiso { get; set; }
            public string Codigo { get; set; }
            public string Descripcion { get; set; }
            public bool Estatus { get; set; }

            public Permiso(int idPermiso, string codigo, string descripcion, bool estatus)
            {
                IdPermiso = idPermiso;
                Codigo = codigo;
                Descripcion = descripcion;
                Estatus = estatus;
            }
       
    }
}
