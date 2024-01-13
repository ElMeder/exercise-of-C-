using System;

//Tarea de Jasmin Angelique Pech Hernandez

class Program
{
    static void Main()
    {
        //variables
        int Num;

        //dato de entrada
        Console.WriteLine("Por favor ingrese un numero entero(impar) y que sea positivo: ");
        //Parte de desarrollo o proceso
        int.TryParse(Console.ReadLine(), out Num);

        if (Num > 0)
        {
            for (int i = 1; i <= Num; i = i + 2)
            {
                Console.Write(i);
                if (i < Num - 1)
                {
                    Console.Write(",");
                }
            }
        }
        else
        {
            Console.WriteLine("Ingresa un numero entero y positivo");
        }

    }
}
