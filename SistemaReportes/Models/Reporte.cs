// Models/Reporte.cs
namespace SistemaReportes.Models
{
    public class Reporte
    {
        public DateTime FechaGeneracion { get; set; }
        public int CantidadVentas { get; set; }
        public decimal TotalVentas { get; set; }
    }
}
