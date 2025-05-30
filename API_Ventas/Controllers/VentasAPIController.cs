﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sistema_VentasCore.Controller;

namespace API_Ventas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentasAPIController : ControllerBase
    {
        private readonly CompraController _comprasController;
        private readonly ILogger<VentasAPIController> _logger;

        public VentasAPIController(CompraController compraController, ILogger<VentasAPIController> logger)
        {
            _comprasController = compraController;
            _logger = logger;
        }

        /// <summary>
        /// Obtiene las ventas generadas por artículo con filtros opcionales
        /// </summary>
        /// <param name="idProducto">ID del producto o artículo (opcional)</param>
        /// <param name="idCliente">ID del cliente (opcional)</param>
        /// <param name="fechaInicio">Fecha inicial del rango (opcional)</param>
        /// <param name="fechaFin">Fecha final del rango (opcional)</param>
        /// <param name="estatus">Estatus de la compra (opcional)</param>
        /// <returns>Lista de compras/ventas con detalles como fecha, número de venta, cliente, estatus, cantidad y costo</returns>
        [HttpGet("ventas_por_articulo")]
        public IActionResult GetVentasPorArticulo(
            [FromQuery] int? idProducto = null)
        {
            try
            {
                var compras = _comprasController.BuscarCompras(
                    null,
                    idProducto,
                    null,
                    null,
                    null);

                _logger.LogInformation($"Ventas por artículo obtenidas: {compras.Count} registros encontrados");
                return Ok(compras);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener ventas por artículo");
                return StatusCode(500, "Error interno del servidor: " + ex.Message);
            }
        }

        [HttpGet("resumen")]
        public IActionResult GetResumenVentasPorArticulo([FromQuery] string? codigoArticulo)
        {
            if (string.IsNullOrEmpty(codigoArticulo))
            {
                return BadRequest("El parámetro 'codigoArticulo' es obligatorio.");
            }

            try
            {
                var resumen = _comprasController.ObtenerResumenVentasPorArticulo(codigoArticulo);

                if (resumen == null)
                {
                    return NotFound($"No se encontraron ventas para el artículo {codigoArticulo}");
                }

                return Ok(resumen);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener resumen de ventas por artículo {CodigoArticulo}", codigoArticulo);
                return StatusCode(500, "Error interno del servidor: " + ex.Message);
            }
        }
    }
}
