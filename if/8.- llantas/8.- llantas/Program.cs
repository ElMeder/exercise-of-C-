using System;

//Tarea de Jasmin Anguelique Pech Hernandez 
class Program
{
    static void Main()
    {
        // Solicitar al usuario el nombre del cliente
        Console.Write("Ingrese el nombre del cliente: ");
        string nombreCliente = Console.ReadLine();

        // Solicitar al usuario la cantidad de llantas compradas
        Console.Write("Ingrese la cantidad de llantas compradas: ");
        if (int.TryParse(Console.ReadLine(), out int cantidadLlantas) && cantidadLlantas >= 0)
        {
            double precioUnitario;
            double descuento;

            // Determinar el precio unitario y el descuento según la cantidad de llantas
            if (cantidadLlantas < 12)
            {
                precioUnitario = 2500;
                descuento = 0.08; // 8% de descuento
            }
            else
            {
                precioUnitario = 280;
                descuento = 0.12; // 12% de descuento
            }

            // Calcular el costo total
            double costoTotal = cantidadLlantas * precioUnitario;
            double montoDescuento = costoTotal * descuento;
            double costoTotalConDescuento = costoTotal - montoDescuento;

            // Mostrar el nombre del cliente y el costo total en la misma línea
            Console.WriteLine("Hola: " + nombreCliente + "!, El costo total de su compre es: $" + costoTotalConDescuento.ToString("F2"));
        }
        else
        {
            Console.WriteLine("Por favor, ingrese una cantidad válida de llantas (mayor o igual a cero).");
        }
    }
}
