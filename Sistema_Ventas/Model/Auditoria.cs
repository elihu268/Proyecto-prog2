using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Ventas.Model
{
    class Auditoria
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Accion { get; set; }
        public DateTime FechaHora { get; set; }
        public string Detalles { get; set; }
        public Auditoria(int id, string usuario, string accion, DateTime fechaHora, string detalles)
        {
            Id = id;
            Usuario = usuario;
            Accion = accion;
            FechaHora = fechaHora;
            Detalles = detalles;
        }
        public override string ToString()
        {
            return $"{Id} - {Usuario} - {Accion} - {FechaHora} - {Detalles}";
        }
    }
}
