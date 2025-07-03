
using SistemaReportes.Models;


namespace SistemaReportes.Repositories
{
    public class VentaRepository
    {
        public void Guardar(Venta venta)
        {
            // Simulación de guardado: por ahora solo podés loguear en consola o guardar en lista
            Console.WriteLine($"Venta guardada: {venta.Monto} - {venta.Fecha}");
        }

        private static readonly List<Venta> _ventas = new();

        public List<Venta> ObtenerTodas()
        {
            return _ventas.ToList(); // o usar return new List<Venta>(_ventas);
        }
    }
}