using System;
using System.ComponentModel.Design;

class Program
{
    static void Main()
    {
        //variables
        int Num;

        Console.Write("Porfavor ingrese un numero positivo y entero: ");
        if (int.TryParse(Console.ReadLine(), out Num));
        {
            if (Num > 0)
            {
                for (int i = Num; i >= 0; i--)
                {
                    Console.Write(i);

                    if (i <= Num - 0)
                    {
                        Console.Write(", ");
                    }
                }
            }
            else
            {
                Console.Write("INGRESA UN NUMERO ENTERO Y POSITIVO!");
            }
        }
        
    }
}