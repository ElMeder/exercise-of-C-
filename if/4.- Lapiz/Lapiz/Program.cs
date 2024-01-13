using System;

//Tarea de Jasmin Anguelique Pech Hernandez 

class Program
{
    static void Main()
    {
        // Costo por lápiz
        double costoPorLapiz = 2.50;

        // Solicitar al usuario la cantidad de lápices
        Console.Write("Ingrese la cantidad de lápices: ");
        if (int.TryParse(Console.ReadLine(), out int cantidadLapices) && cantidadLapices >= 0)
        {
            double totalAPagar;

            // Calcular el total a pagar
            if (cantidadLapices >= 1000)
            {
                // Aplicar descuento del 7% si la cantidad es de 1000 o más
                double descuento = costoPorLapiz * cantidadLapices * 0.07;
                totalAPagar = costoPorLapiz * cantidadLapices - descuento;
            }
            else
            {
                // Sin descuento si la cantidad es menor a 1000
                totalAPagar = costoPorLapiz * cantidadLapices;
            }

            // Mostrar el resultado
            Console.WriteLine("Cantidad de lápices: " + cantidadLapices);
            Console.WriteLine("Total a pagar: S/. " + totalAPagar.ToString("F2"));
        }
        else
        {
            Console.WriteLine("Ingrese una cantidad válida de lápices (mayor o igual a cero).");
        }
    }
}
