using System;

class Program
{
    static void Main()
    {
        // Pedir al usuario la cantidad a invertir, el interés anual y el número de años
        Console.WriteLine("Ingrese la cantidad a invertir: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal inversion) && inversion > 0)
        {
            Console.WriteLine("Ingrese el interés anual (porcentaje): ");
            if (decimal.TryParse(Console.ReadLine(), out decimal interes) && interes >= 0)
            {
                Console.WriteLine("Ingrese el número de años: ");
                if (int.TryParse(Console.ReadLine(), out int años) && años > 0)
                {
                    // Calcular y mostrar el capital obtenido cada año
                    decimal capital = inversion;

                    for (int i = 1; i <= años; i++)
                    {
                        capital += capital * (interes / 100);
                        Console.WriteLine($"Año {i}: {capital:C}");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número de años válido.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un interés anual válido.");
            }
        }
        else
        {
            Console.WriteLine("Por favor, ingrese una cantidad a invertir válida.");
        }
    }
}
