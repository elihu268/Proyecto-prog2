﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog.LayoutRenderers;

namespace Sistema_VentasCore.Model
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }

        public decimal Precio { get; set; }

        public string Descripcion { get; set; }
        public int Existencia { get; set; }
        public Producto() { }
        public Producto(int idProducto, string codigo,string nombre, decimal precio,string  descripcion) {
        this.IdProducto = idProducto;
            this.Codigo = codigo; 
            this.Nombre = nombre;
            this.Precio = precio;
            this.Descripcion = descripcion;
        }
        public Producto(string nombre, int existencia)
        {
            this.Nombre = nombre;
            this.Existencia = existencia;
        }


    }
}
