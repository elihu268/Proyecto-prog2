﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_VentasCore.Model
{
    public class Auditoria
    {
        
        public int Id { get; set; }

        [Required]
        public string Accion { get; set; }

        public DateTime Fecha { get; set; }

        [MaxLength(45)]
        public string IpAcceso { get; set; }

        [MaxLength(100)]
        public string NombreEquipo { get; set; }

        [MaxLength(50)]
        public string Tipo { get; set; }

        public int? UsuarioId { get; set; }

        public int? IdMovimiento { get; set; }

        public String Movimiento { get; set; }

        public string NombreCompleto { get; set; }

        public string Cuenta { get; set; }

        public Persona Persona { get; set; }

        public Auditoria(string accion, string tipo, int? usuarioId, int? idMovimiento, string ip, string nombreEquipo)
        {
            Accion = accion;
            Tipo = tipo;
            UsuarioId = usuarioId;
            IdMovimiento = idMovimiento;
            IpAcceso = ip;
            NombreEquipo = nombreEquipo;
            Fecha = DateTime.Now;
        }

        //int usuario
        public Auditoria(int? usuarioid, string nombreCompleto, string cuenta, string accion, DateTime fecha, string ip, string nombreEquipo, string tipo, string idMovimiento)
        {
           UsuarioId = usuarioid;
            NombreCompleto = nombreCompleto;
            Cuenta = cuenta;
            Accion = accion;
            Fecha = fecha;
            IpAcceso = ip;
            NombreEquipo = nombreEquipo;
            Tipo = tipo;
            Movimiento = idMovimiento;
            
        }

        public Auditoria(string accion, DateTime fecha, string ip, string nombreEquipo, string tipo, int idUsuario, int idMovimiento)
        {
            Accion = accion;
            Fecha = fecha;
            IpAcceso = ip;
            NombreEquipo = nombreEquipo;
            Tipo = tipo;
            UsuarioId = idUsuario;
            IdMovimiento = idMovimiento;
        }
        public Auditoria(string accion, DateTime fecha, string ip, string nombreEquipo, string tipo, Persona persona)
        {
            Accion = accion;
            Fecha = fecha;
            IpAcceso = ip;
            NombreEquipo = nombreEquipo;
            Persona = persona;
        }
        public override string ToString()
        {
            return $"{Id} - {UsuarioId} - {Accion} - {Fecha}";
        }
    }
}
