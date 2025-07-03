namespace SistemaReportes.Models
{
    public class Venta
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public int ClientId { get; set; }
    }
}
