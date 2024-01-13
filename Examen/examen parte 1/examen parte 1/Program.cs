using System;

class Program
{
    static void Main()
    {
        // Datos de entrada
        double distanciaOrigenAlCentro = 9.0; // km
        double distanciaCentroAlTec = 18.0; // km
        double velocidadCamion = 50.0; // km/h
        double velocidadColectivo = 75.0; // km/h
        double velocidadMotoTaxi = 90.0; // km/h
        double consumoCamion = 22.0; // km/l
        double consumoColectivo = 8.0; // km/l
        double consumoMotoTaxi = 35.0; // km/l
        double precioDiesel = 24.99; // pesos/litro
        double presupuesto = 100.0; // pesos

        // Cálculos para cada opción de transporte
        double tiempoCamion = (distanciaOrigenAlCentro + distanciaCentroAlTec) / velocidadCamion;
        double costoCamion = (distanciaOrigenAlCentro + distanciaCentroAlTec) / consumoCamion * precioDiesel;

        double tiempoColectivo = (distanciaOrigenAlCentro + distanciaCentroAlTec) / velocidadColectivo;
        double costoColectivo = (distanciaOrigenAlCentro + distanciaCentroAlTec) / consumoColectivo * precioDiesel;

        double tiempoMotoTaxi = (distanciaOrigenAlCentro + distanciaCentroAlTec) / velocidadMotoTaxi;
        double costoMotoTaxi = (distanciaOrigenAlCentro + distanciaCentroAlTec) / consumoMotoTaxi * precioDiesel;

        // Determinar la mejor opción
        string mejorOpcion = "";
        double tiempoMejorOpcion = double.MaxValue;
        double costoMejorOpcion = double.MaxValue;

        if (costoCamion <= presupuesto && tiempoCamion < tiempoMejorOpcion)
        {
            mejorOpcion = "Camión";
            tiempoMejorOpcion = tiempoCamion;
            costoMejorOpcion = costoCamion;
        }

        if (costoColectivo <= presupuesto && tiempoColectivo < tiempoMejorOpcion)
        {
            mejorOpcion = "Colectivo";
            tiempoMejorOpcion = tiempoColectivo;
            costoMejorOpcion = costoColectivo;
        }

        if (costoMotoTaxi <= presupuesto && tiempoMotoTaxi < tiempoMejorOpcion)
        {
            mejorOpcion = "Moto Taxi";
            tiempoMejorOpcion = tiempoMotoTaxi;
            costoMejorOpcion = costoMotoTaxi;
        }

        // Mostrar resultados
        if (mejorOpcion != "")
        {
            Console.WriteLine($"La mejor opción de traslado es {mejorOpcion}");
            Console.WriteLine($"Tiempo de viaje: {tiempoMejorOpcion:F2} horas");
            Console.WriteLine($"Costo: {costoMejorOpcion:F2} pesos");
        }
        else
        {
            Console.WriteLine("No hay opciones de traslado dentro del presupuesto.");
        }
    }
}
