using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_VentasCore.Model
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public int IdPersona { get; set; }
        public int idRol { get; set; }
        public string Cuenta { get; set; }
        public string Constrasena { get; set; }
        public bool Estatus { get; set; }
        public Persona DatosPersonales { get; set; }

        public Usuario()
        {
            ;
            Cuenta = string.Empty;
            Constrasena = string.Empty;
            Estatus = true;
            DatosPersonales = new Persona();
        }
        public Usuario(int idrol, string cuenta, string constrasena, bool estatus, Persona datospersonales)
        {
            idRol = idrol;
            Cuenta = cuenta;
            Constrasena = constrasena;
            Estatus = estatus;
            DatosPersonales = datospersonales;
        }
        public Usuario(int idUsuario, int idPersona, int idRol, string cuenta, string constrasena, bool estatus, Persona datospersonale)
        {
            IdUsuario = idUsuario;
            IdPersona = idPersona;
            this.idRol = idRol;
            Cuenta = cuenta;
            Constrasena = constrasena;
            Estatus = estatus;
            DatosPersonales = datospersonale;
        }
        public Usuario(int idPersona, int idrol, string cuenta, string constrasena, bool estatus, Persona datospersonale)
        {
            IdPersona = idPersona;
            idRol = idrol;
            Cuenta = cuenta;
            Constrasena = constrasena;
            Estatus = estatus;
            DatosPersonales = datospersonale;
        }
        public Usuario(int idUsuario, int idPersona, int idrol, string cuenta, bool estatus, Persona datospersonale)
        {
            IdUsuario = idUsuario;
            IdPersona = idPersona;
            idRol = idrol;
            Cuenta = cuenta;
            Estatus = estatus;
            DatosPersonales = datospersonale;
        }
    }
}
