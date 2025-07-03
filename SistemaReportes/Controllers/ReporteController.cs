using Microsoft.AspNetCore.Mvc;
using SistemaReportes.Models;  
using SistemaReportes.Services;
using SistemaReportes.Utils;    


namespace SistemaReportes.Controllers
{
    [ApiController]
    [Route("reporte")]
    public class ReporteController : ControllerBase
    {
        private readonly ReporteService _service;

        public ReporteController(ReporteService service)
        {
            _service = service;
        }

        [HttpGet("excel")]
        public IActionResult DescargarExcel()
        {
            var ventas = _service.ObtenerTodasLasVentas();
            var (excelBytes, reporte) = _service.GenerarReporte(ventas);

            return File(excelBytes, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "reporte.xlsx");
        }
    }
}
