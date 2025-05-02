using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Ventas.Model
{
    public class Cliente
    {

        /// <summary>
        /// Identificador único del estudiante
        /// </summary>
        public int Id { get; set; }//sin set para no modificar

        /// <summary>
        /// Identificador de la persona asociada con el estudiante
        /// </summary>
        public int IdPersona { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int Tipo { get; set; }
        public string DescripcionTipo => Tipo == 1 ? "Físico" : "Moral";

        /// <summary>
        /// fecha en la que se dio de alta o modifico
        /// </summary>
        public DateTime? FechaRegistro { get; set; }
        /// <summary>
        /// rfc(Registro Federal de Contribuyentes) del cliente
        /// </summary>
        public string Rfc { get; set; }
        /// <summary>
        /// indica si el cliente 
        /// </summary>
        public Persona DatosPersonales { get; set; }

        //CONSTRUCTORES
        public Cliente() { 
            Rfc = string.Empty;
            FechaRegistro = DateTime.Now;
            DatosPersonales = new Persona();
        }

        public Cliente(int tipo, string rfc, Persona datosPersonales)
        {
            this.Tipo = tipo;
            this.Rfc = rfc;
            this.FechaRegistro = DateTime.Now;
            this.DatosPersonales = datosPersonales;
        }

        public Cliente(int id,int idPersona,int tipo, DateTime fechaREgistro,string rfc, Persona persona) {
            this.Id = id;
            this.IdPersona = idPersona;
            this.Tipo = tipo;
            this.FechaRegistro = fechaREgistro;
            this.Rfc = rfc;
            DatosPersonales =persona;
        }//Propiedad auxiliar para mostrar el correo en el ComboBox
        public string Correo => DatosPersonales?.Correo ?? "";

        public string NombreCompletoCliente
        {
            get
            {
                return DatosPersonales != null ? DatosPersonales.NombreCompleto : "Desconocido";
            }
        }

    }

}
