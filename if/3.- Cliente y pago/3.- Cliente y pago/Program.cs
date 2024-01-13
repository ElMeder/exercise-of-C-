using System;

class Program
{
    static void Main()
    {
        // Solicitar al usuario el nombre del cliente
        Console.Write("Ingrese el nombre del cliente: ");
        string nombreCliente = Console.ReadLine();

        // Solicitar al usuario la cantidad de artículos comprados
        Console.Write("Ingrese la cantidad de artículos comprados: ");
        if (int.TryParse(Console.ReadLine(), out int cantidadArticulos) && cantidadArticulos >= 0)
        {
            string metodoPago;

            // Determinar el método de pago
            if (cantidadArticulos < 30)
            {
                metodoPago = "efectivo";
            }
            else if (cantidadArticulos < 60)
            {
                metodoPago = "tarjeta";
            }
            else
            {
                metodoPago = "cheque";
            }

            // Mostrar el resultado
            Console.WriteLine("Cliente: " + nombreCliente);
            Console.WriteLine("Cantidad de artículos comprados: " + cantidadArticulos);
            Console.WriteLine("Método de pago: " + metodoPago);
        }
        else
        {
            Console.WriteLine("Ingrese una cantidad válida de artículos (mayor o igual a cero).");
        }
    }
}
