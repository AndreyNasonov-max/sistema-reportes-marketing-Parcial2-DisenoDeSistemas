// Services/ReporteService.cs
using SistemaReportes.Models;
using SistemaReportes.Utils;
using SistemaReportes.Repositories; // Add this line if VentaRepository is in the Repositories namespace

namespace SistemaReportes.Services
{
    public class ReporteService
    {
        private readonly ExcelGenerator _excelGenerator;

        private readonly VentaRepository _ventaRepository;


    public ReporteService(VentaRepository ventaRepository)
{
    _ventaRepository = ventaRepository;
    _excelGenerator = new ExcelGenerator();
}


        public (byte[], Reporte) GenerarReporte(List<Venta> ventas)
        {
            var total = ventas.Sum(v => v.Monto);
            var cantidad = ventas.Count;

            var reporte = new Reporte
            {
                FechaGeneracion = DateTime.Now,
                CantidadVentas = cantidad,
                TotalVentas = total
            };

            var archivoExcel = _excelGenerator.GenerarReporteVentas(ventas);

            return (archivoExcel, reporte);
        }
        public List<Venta> ObtenerTodasLasVentas()
        {
            return _ventaRepository.ObtenerTodas();
        }

    }
}
