using Microsoft.AspNetCore.Mvc;
using SistemaReportes.Models;
using SistemaReportes.Repositories;
// This file is part of the SistemaReportes project
using SistemaReportes.Utils;
using SistemaReportes.Services;



namespace SistemaReportes.Controllers
{
    [ApiController]
    [Route("importar")]
    public class VentasController : ControllerBase
    {
        private readonly VentaRepository _ventaRepo;
        
        private readonly ReporteService _reporteService;


     

        public VentasController(VentaRepository ventaRepo, ReporteService reporteService)
        {
            _ventaRepo = ventaRepo;
            _reporteService = reporteService;
        }

        [HttpPost("ventas")]
        public IActionResult ImportarVentas([FromBody] List<Venta> ventas)
        {
            if (ventas == null || ventas.Count == 0)
                return BadRequest("No se recibieron datos de ventas.");

            foreach (var venta in ventas)
            {
                if (string.IsNullOrWhiteSpace(venta.Fecha.ToString()) || venta.Monto <= 0)
                    return BadRequest("Hay ventas inválidas.");

                _ventaRepo.Guardar(venta);
            }

            var (archivoExcel, resumen) = _reporteService.GenerarReporte(ventas);
            // Aquí podrías guardar el resumen en una base

         return File(archivoExcel,
         "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "reporte_ventas.xlsx");

        }
    }
}


