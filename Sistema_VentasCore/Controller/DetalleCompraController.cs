﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_VentasCore.Data;
using Sistema_VentasCore.Utilities;
using Sistema_VentasCore.Bussines;
using NLog;
using System.Collections;
using System.Data;
using Sistema_VentasCore.Model;
namespace Sistema_VentasCore.Controller
{
    public class DetalleCompraController
    {
        private static readonly Logger _logger = LoggingManager.GetLogger("Sistema_Ventas.Controller.DetalleCompraController");
        private readonly ProductosController _productosController;
        private readonly DetalleCompraDataAccess _detalleData;

        public DetalleCompraController()
        {
            try
            {
                _productosController = new ProductosController();
                _detalleData = new DetalleCompraDataAccess();
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "error al inicializar el controlador de detalle compra");
                throw;
            }
        }
        /// <summary>
        /// para validar que la cantidad que desea comprar no supera la existencia
        /// </summary>
        /// <param name="codigo">saber que producto es</param>
        /// <param name="cantidad">cantidad que desea comprar</param>
        /// <returns>verdadero si encuentra el producto y que la cantidad que desea comprar ssea valida</returns>
        public bool ValidarCantidad(string codigo, string cantidad, int existencia)
        {
            try
            {
                bool resultado = CompraNegocio.CantidadEnRango(cantidad, existencia);
                return resultado;
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"No se pudo validar cantidad para realizar la compra del producto con código {codigo}.");
                return false;
            }
        }
        public bool AgregarProductoADetalle(int idCompra, Producto producto, int cantidad)
        {
            try
            {
                return _detalleData.AgregarProductoADetalle(idCompra, producto, cantidad);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"No se pudo agregar producto al detalle");
                return false;
            }
        }


        /// <summary>
        /// Obtiene la lista de detalles de una compra específica
        /// </summary>
        /// <param name="idCompra">ID de la compra</param>
        /// <returns>Lista de objetos DetalleCompra</returns>
        public List<DetalleCompra> ObtenerDetallePorCompra(int idCompra)
        {
            try
            {
                return _detalleData.ObtenerDetallePorCompra(idCompra);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, $"Error al obtener detalles de la compra con ID {idCompra}");
                return new List<DetalleCompra>();
            }
        }
    }
}
