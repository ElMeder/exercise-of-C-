using System.Numerics;
using System.Threading;

using System;

namespace Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] X = new int[3, 3];

            for (int n = 0; n < X.GetLength(0); n++)
            {
                for (int m = 0; m < X.GetLength(1); m++)
                {
                    Console.WriteLine("Rellene las casillas empezando en [{0},{1}]", n, m);
                    X[n, m] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Matriz original:");
            Matrixnor(X);

            Console.WriteLine("");

            Console.WriteLine("Matriz elevado al cubo:");
            Matrixalcubo(X);

            Console.ReadKey();
        }

        static void Matrixalcubo(int[,] do2)
        {
            for (int n = 0; n < do2.GetLength(0); n++)
            {
                Console.WriteLine("");
                for (int m = 0; m < do2.GetLength(1); m++)
                {

                    Console.ForegroundColor = (n == do2.GetLength(1) - m - 1) ? ConsoleColor.Blue : ConsoleColor.Gray;

                    int cubo = (int)Math.Pow(do2[n, m], 3);
                    Console.Write(" " + cubo);
                    
                    Console.ForegroundColor = ConsoleColor.Gray;

                }
            }
            Console.WriteLine("");

            
        }


        static void Matrixnor(int[,] matriz)
        {
            for (int n = 0; n < matriz.GetLength(0); n++)
            {
                Console.WriteLine("");
                for (int m = 0; m < matriz.GetLength(1); m++)
                {
                    Console.ForegroundColor = (n == m) ? ConsoleColor.Red : ConsoleColor.Gray;

                    Console.Write(" " + matriz[n, m]);

                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
            Console.WriteLine("");
        }
    }
}