using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Ventas.Model
{
    public class Persona
    {
        //propiedades de la persona
        public int Id { get; set; }

        /// <summary>

        /// Nombre completo de la persona

        /// </summary>

        public string NombreCompleto { get; set; }

        /// <summary>

        /// Correo electrónico de la persona

        /// </summary>

        public string Correo { get; set; }

        /// <summary>

        /// Número de teléfono de la persona

        /// </summary>

        public string Telefono { get; set; }

        /// <summary>

        /// CURP (Clave Única de Registro de Población) de la persona

        /// </summary>


        public DateTime? FechaNacimiento { get; set; }//no es obligatoria puede ser nulo

        /// <summary>

        /// Indica si la persona está activa en el sistema

        /// </summary>

        public bool Estatus { get; set; }
        public string DescripcionEstatus => Estatus ? "Activo" : "Inactivo";

        //para recibir objeto con datos vacios, cuando se quiere depositar datos en el objeto
        public Persona()
        {
            NombreCompleto = string.Empty;
            Correo = string.Empty;
            Telefono = string.Empty;
            Estatus = true;

        }
        //para no objeto vacio, solo inserta datos obligatorios
        public Persona(string nombreCompleto, string correo, string telefono)
        {
            NombreCompleto = nombreCompleto;
            Correo = correo;
            Telefono = telefono;
            Estatus = true;

        }
        //constructor completo
        public Persona(int id, string nombreCompleto, string correo, string telefono, DateTime? fechaNacimiento, bool estatus)
        {
            Id = id;
            NombreCompleto = nombreCompleto;
            Correo = correo;
            Telefono = telefono;
            FechaNacimiento = fechaNacimiento;
            Estatus = estatus;
        }
}
}
