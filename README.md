# 📊 Sistema de Reportes de Marketing - Parcial 2 (Diseño de Sistemas)

Este proyecto es una API REST construida en **ASP.NET Core 8.0**, desarrollada como parte del **Parcial 2** de la materia **Diseño de Sistemas** en Da Vinci.

## 🧠 ¿Qué hace este proyecto?

Permite importar una lista de ventas en formato JSON y generar un **reporte resumen** con:

- Total de ventas
- Cantidad de ventas
- Fecha de generación
- Archivo Excel con los datos

## 🚀 ¿Cómo levantar el proyecto?

1. Clonar el repositorio:
   ```bash
   git clone https://github.com/AndreyNasonov-max/sistema-reportes-marketing-Parcial2-DisenoDeSistemas.git
   cd sistema-reportes-marketing-Parcial2-DisenoDeSistemas
Restaurar dependencias:

bash
Copy
Edit
dotnet restore
Ejecutar el proyecto:

bash
Copy
Edit
cd SistemaReportes
dotnet run
Acceder a la documentación Swagger:

http://localhost:5171/swagger

🧪 Endpoints disponibles
Método	Endpoint	Descripción
POST	/importar/ventas	Importa una lista de ventas (JSON)
GET	/reporte/excel	Devuelve un archivo Excel y datos resumen
