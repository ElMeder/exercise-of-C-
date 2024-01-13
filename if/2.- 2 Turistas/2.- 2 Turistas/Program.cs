using System;

//Tarea de Jasmin Anguelique Pech Hernandez 

class Program
{
    static void Main()
    {
        // Datos del problema
        double distancia = 0.0;       // Distancia a recorrer en kilómetros
        double velocidadMoto = 80.0;  // Velocidad de la moto en km/h por galón
        double velocidadAuto = 55.0;  // Velocidad del auto en km/h por galón
        double costoCombustible = 12.0; // Costo del combustible por galón
        double presupuesto = 100.0;  // Presupuesto en soles

        // Solicitar al usuario ingresar la distancia a recorrer
        Console.Write("Ingrese la distancia a recorrer en kilómetros: ");
        if (double.TryParse(Console.ReadLine(), out distancia) && distancia > 0)
        {
            // Calcular el tiempo en moto y en auto
            double tiempoMoto = distancia / velocidadMoto;
            double tiempoAuto = distancia / velocidadAuto;

            // Calcular el costo del viaje en moto y en auto
            double costoMoto = (distancia / velocidadMoto) * costoCombustible;
            double costoAuto = (distancia / velocidadAuto) * costoCombustible;

            // Determinar el medio de transporte a utilizar
            string medioTransporte;
            if (costoMoto <= presupuesto && tiempoMoto <= tiempoAuto)
            {
                medioTransporte = "moto";
            }
            else
            {
                medioTransporte = "auto";
            }

            // Mostrar resultados
            Console.WriteLine("Distancia a recorrer: " + distancia + " kilómetros");
            Console.WriteLine("Tiempo en moto: " + tiempoMoto + " horas");
            Console.WriteLine("Tiempo en auto: " + tiempoAuto + " horas");
            Console.WriteLine("Costo en moto: " + costoMoto + " soles");
            Console.WriteLine("Costo en auto: " + costoAuto + " soles");
            Console.WriteLine("Utilizar medio de transporte: " + medioTransporte);
        }
        else
        {
            Console.WriteLine("Ingrese una distancia válida y mayor que cero.");
        }
    }
}
