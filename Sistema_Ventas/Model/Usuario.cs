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
        public Persona DatosPersonales { get; }

        public Usuario()
        {;
            Cuenta = string.Empty;
            Constrasena = string.Empty;
            Estatus = 1;
            DatosPersonales = new Persona();
        }
        public Usuario(string cuenta, string constrasena, int estatus, Persona datospersonales)
        {
            Cuenta = cuenta;
            Constrasena = constrasena;
            Estatus = estatus;
            DatosPersonales = datospersonales;
        }
        public Usuario(int idPersona, int idRol, string cuenta, string constrasena, int estatus, Persona datospersonale)
        {
            IdPersona = idPersona;
            this.idRol = idRol;
            Cuenta = cuenta;
            Constrasena = constrasena;
            Estatus = estatus;
            DatosPersonales = datospersonale;
        }
    }
}
