using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Ventas.Model
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public int IdPersona { get; set; }
        public int idRol { get; set; }
        public string Cuenta { get; set; }
        public string Constrasena { get; set; }
        public int Estatus { get; set; }
        public Persona DatosPersonales { get; set; }

        public Usuario()
        {;
            Cuenta = string.Empty;
            Constrasena = string.Empty;
            Estatus = 1;
            DatosPersonales = new Persona();
        }
        public Usuario(int idrol, string cuenta, string constrasena, int estatus, Persona datospersonales)
        {
            idRol = idrol;
            Cuenta = cuenta;
            Constrasena = constrasena;
            Estatus = estatus;
            DatosPersonales = datospersonales;
        }
        public Usuario(int idUsuario, int idPersona, int idRol, string cuenta, string constrasena, int estatus, Persona datospersonale)
        {
            IdUsuario = idUsuario;
            IdPersona = idPersona;
            this.idRol = idRol;
            Cuenta = cuenta;
            Constrasena = constrasena;
            Estatus = estatus;
            DatosPersonales = datospersonale;
        }
    }
}
