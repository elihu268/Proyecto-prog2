using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Ventas.Model
{
    class Auditoria
    {
        
        public int Id { get; set; }

        [Required]
        public string Accion { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

        [MaxLength(45)]
        public string IpAcceso { get; set; }

        [MaxLength(100)]
        public string NombreEquipo { get; set; }

        [MaxLength(50)]
        public string Tipo { get; set; }

        public int? UsuarioId { get; set; }

        public int? IdMovimiento { get; set; }

        public Auditoria(string accion, string tipo, int? usuarioId, int? idMovimiento, string ip, string nombreqeuipo)
        {
            Accion = accion;
            Tipo = tipo;
            UsuarioId = usuarioId;
            IdMovimiento = idMovimiento;
            IpAcceso = ip;
            NombreEquipo = nombreqeuipo;
            Fecha = DateTime.Now;
        }
        public override string ToString()
        {
            return $"{Id} - {UsuarioId} - {Accion} - {Fecha}";
        }
    }
}
