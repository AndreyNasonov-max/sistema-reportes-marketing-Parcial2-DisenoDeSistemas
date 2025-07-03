using ClosedXML.Excel;
using SistemaReportes.Models;

namespace SistemaReportes.Utils
{
    public class ExcelGenerator
    {
        public byte[] GenerarReporteVentas(List<Venta> ventas)
        {
            using var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Ventas");

            // Encabezados
            worksheet.Cell(1, 1).Value = "Fecha";
            worksheet.Cell(1, 2).Value = "Monto";
            worksheet.Cell(1, 3).Value = "ClienteId";

            // Contenido
            for (int i = 0; i < ventas.Count; i++)
            {
                worksheet.Cell(i + 2, 1).Value = ventas[i].Fecha;
                worksheet.Cell(i + 2, 2).Value = ventas[i].Monto;
                worksheet.Cell(i + 2, 3).Value = ventas[i].ClientId;
            }

            using var stream = new MemoryStream();
            workbook.SaveAs(stream);
            return stream.ToArray();
        }
    }
}
