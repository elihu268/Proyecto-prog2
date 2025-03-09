﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Ventas.Utilities
{
    internal class Formas
    {
        internal static void InicializaForma(Form form_child, Form formparent)
        {
            //Inicializamos la forna


            //Propiedades basicas. 
            form_child.MdiParent = formparent; // Asignar el padre MDI 
            form_child.FormBorderStyle = FormBorderStyle.Sizable; // Permitir redimensionar 
            form_child.MaximizeBox = true; // Permitir maximizar 
            form_child.MinimizeBox = true; // Permitir minimizar 
            form_child.WindowState = FormWindowState.Normal; // Estado inicial de la ventana 

            //Priopiedades de control 
            form_child.ControlBox = true; // Mostrar botones de control (minimizar, maximizar, cerrar) 
            form_child.ShowIcon = true; // Mostrar icono en la barra de título 
            form_child.ShowInTaskbar = false; // No mostrar en la barra de tareas                                         

            //Propiedades de tamaño 
            form_child.AutoScaleMode = AutoScaleMode.Font; // Modo de escalado 
            form_child.ClientSize = new Size(860, 600); // Tamaño inicial 
            form_child.MinimumSize = new Size(400, 300); // Tamaño minimo permitido 
            form_child.MaximumSize = new Size(3440, 1440); // Tamaño máximo permitido 

            //Propiedades de inicio
            form_child.StartPosition = FormStartPosition.CenterScreen; // Posición inicial                                                      

            //Propiedades de comportamiento 
            form_child.AutoScroll = true; // Permitir scroll si el contenido es mayor que la ventana 
            form_child.KeyPreview = true; // Permitir que el formulario reciba eventos de teclado

        }
    }
}
