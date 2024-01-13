using System;

class Program
{
    static void Main()
    {
        // Solicitar la longitud de la carrera y el tiempo del corredor al usuario
        Console.Write("Ingrese la longitud de la carrera en kilómetros: ");
        double longitudCarrera = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el tiempo en horas que tardó el corredor: ");
        double tiempoCorredor = Convert.ToDouble(Console.ReadLine());

        // Calcular la velocidad promedio del corredor
        double velocidadPromedio = longitudCarrera / tiempoCorredor;

        // Verificar si la velocidad promedio está dentro del rango de 10 a 18 km/h
        if (velocidadPromedio >= 10.0 && velocidadPromedio <= 18.0)
        {
            Console.WriteLine("El corredor ha completado la carrera y cumple con el promedio de velocidad.");
        }
        else
        {
            Console.WriteLine("El corredor ha sido descalificado debido a que no cumple con el promedio de velocidad.");
        }
    }
}