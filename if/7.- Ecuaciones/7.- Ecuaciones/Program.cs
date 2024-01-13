using System;

//Tarea de Jasmin Anguelique Pech Hernandez 
class Program
{
    static void Main()
    {
        // Solicitar al usuario ingresar dos valores numéricos
        Console.Write("Ingrese el primer valor: ");
        if (double.TryParse(Console.ReadLine(), out double valor1))
        {
            Console.Write("Ingrese el segundo valor: ");
            if (double.TryParse(Console.ReadLine(), out double valor2))
            {
                // Calcular la suma
                double suma = valor1 + valor2;

                // Calcular la resta
                double resta = valor1 - valor2;

                // Calcular la multiplicación
                double multiplicacion = valor1 * valor2;

                // Verificar si la multiplicación es mayor o igual a 20
                if (multiplicacion >= 20)
                {
                    // Restar el resultado de la resta a la multiplicación
                    multiplicacion -= resta;
                    Console.WriteLine("La multiplicación es mayor o igual a 20.");
                }
                else
                {
                    // Añadirle la suma a la multiplicación
                    multiplicacion += suma;
                    Console.WriteLine("La multiplicación es menor que 20.");
                }

                // Calcular la división (verificar que el divisor no sea cero)
                double division = (valor2 != 0) ? valor1 / valor2 : double.NaN;

                // Mostrar los resultados
                Console.WriteLine("Suma: " + suma);
                Console.WriteLine("Resta: " + resta);
                Console.WriteLine("Multiplicación: " + multiplicacion);
                if (!double.IsNaN(division))
                {
                    Console.WriteLine("División: " + division);
                }
                else
                {
                    Console.WriteLine("No es posible dividir por cero.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un segundo valor numérico válido.");
            }
        }
        else
        {
            Console.WriteLine("Por favor, ingrese un primer valor numérico válido.");
        }
    }
}
