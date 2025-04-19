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
        /// <summary>
        /// fecha en la que se dio de alta o modifico
        /// </summary>
        public DateTime FechaRegistro { get; set; }
        /// <summary>
        /// rfc(Registro Federal de Contribuyentes) del cliente
        /// </summary>
        public string Rfc { get; set; }
        /// <summary>
        /// indica si el cliente 
        /// </summary>
        public int Estatus { get; set; }
        public Persona DatosPersonales { get; set; }

        //CONSTRUCTORES
        public Cliente(int id,int idPersona,int tipo, DateTime fechaREgistro,string rfc,int estatus, Persona persona) {
            this.Id = id;
            this.IdPersona = idPersona;
            this.Tipo = tipo;
            this.FechaRegistro = fechaREgistro;
            this.Rfc = rfc;
            this.Estatus = estatus;
            DatosPersonales =persona;
        }
    }
}
