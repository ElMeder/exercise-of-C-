using System;

class Blucle
{
    static void Main()
    {
     //Solicita al Usuario ingresar una palabra 
        Console.WriteLine("ingreasa una palabra para iniciar el bucle: ");
        //Declaramos variables 
        string Palabra = Console.ReadLine();

        //iniciamos el bucle diciendo que empezamos desde 0 y terminamos con 10 repeticiones
        for (int i = 0; i < 10; i++)
        {
            //Declaramos lo que repetiremos
            Console.WriteLine(Palabra);
        }
        
    }
}