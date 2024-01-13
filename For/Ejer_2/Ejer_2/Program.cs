using System;

//Tarea de Jasmin Angelique Pech Hernandez

class Program
{
    static void Main()
    {
        int Edad;
        //declaramos las entradas y memoria de variable
        Console.WriteLine("Introduzca su edad: ");
        int.TryParse(Console.ReadLine(), out Edad);

        //inicio del bucle
        for (int i = Edad; i >= 1; i--)
        {
            //Salida 
            Console.WriteLine("Usted a cumplido: " + i);
        }


    }
}