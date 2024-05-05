// Crear un array de objetos para 2 clases de su proyecto
// Llenar el array
//Imprimir el array

using System;
using System.Collections.Generic;

// Definición de la clase OrdenProduccion
class OrdenProduccion {
    public string Estado { get; set; }
    public DateTime Fecha { get; set; }
    public DateTime FechaMeta { get; set; }
    public int Id { get; set; }
    public string Notas { get; set; }

    public OrdenProduccion(string estado, DateTime fecha, DateTime fechaMeta, int id, string notas) {
        Estado = estado;
        Fecha = fecha;
        FechaMeta = fechaMeta;
        Id = id;
        Notas = notas;
    }
}

// Definición de la clase DetalleOrden
class DetalleOrden {
    public int Cantidad { get; set; }
    public string Estado { get; set; }
    public int Id { get; set; }
    public int IdOrden { get; set; }
    public int IdProducto { get; set; }

    public DetalleOrden(int cantidad, string estado, int id, int idOrden, int idProducto) {
        Cantidad = cantidad;
        Estado = estado;
        Id = id;
        IdOrden = idOrden;
        IdProducto = idProducto;
    }
}

class Program {
    static void Main(string[] args) {
        // Crear un array de objetos para la clase OrdenProduccion
        var ordenesProduccion = new List<OrdenProduccion> {
            new OrdenProduccion("En proceso", DateTime.Now, DateTime.Now.AddDays(7), 1, "Detalles adicionales"),
            new OrdenProduccion("Completada", DateTime.Now.AddDays(-5), DateTime.Now.AddDays(2), 2, "Sin notas adicionales")
        };

        // Crear un array de objetos para la clase DetalleOrden
        var detallesOrden = new List<DetalleOrden> {
            new DetalleOrden(100, "En espera", 1, 1, 101),
            new DetalleOrden(50, "Procesando", 2, 1, 102),
            new DetalleOrden(75, "Completado", 3, 2, 103)
        };

        // Imprimir el array de objetos de la clase OrdenProduccion
        Console.WriteLine("Ordenes de Producción:");
        foreach (var orden in ordenesProduccion) {
            Console.WriteLine($"ID: {orden.Id}, Estado: {orden.Estado}, Fecha: {orden.Fecha}, Notas: {orden.Notas}");
        }

        // Imprimir el array de objetos de la clase DetalleOrden
        Console.WriteLine("\nDetalles de Orden:");
        foreach (var detalle in detallesOrden) {
            Console.WriteLine($"ID: {detalle.Id}, ID Orden: {detalle.IdOrden}, Cantidad: {detalle.Cantidad}, Estado: {detalle.Estado}");
        }
    }
}

