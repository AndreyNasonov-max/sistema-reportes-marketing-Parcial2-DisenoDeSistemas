
using SistemaReportes.Repositories;
using SistemaReportes.Models;
using System;

namespace SistemaReportes.Tests
{
    public class VentaRepositoryTests
    {
        
        public void Guardar_DeberiaImprimirVentaEnConsola()
        {
            // Arrange
            var repo = new VentaRepository();
            var venta = new Venta
            {
                Fecha = DateTime.Now,
                Monto = 100,
                ClientId = 1
            };

            // Act
            repo.Guardar(venta);

            // Assert
            // Por ahora no hay nada que verificar, ya que solo imprime en consola.
            // En el futuro podrías mockear o redirigir la consola para testearlo.
        }
    }
}
