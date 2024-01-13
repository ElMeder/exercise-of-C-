using System;

//Tarea de Jasmin Anguelique Pech Hernandez 
class Program
{
    static void Main()
    {
        // Datos del empleado
        int edad = 34;
        int horasTrabajadas = 158;
        double salarioPorHora = 20.0;
        double descuentoSaludSocial = 0.07; // 7% de descuento por Salud Social
        double descuentoAFP = 0.1225; // 12.25% de descuento por AFP

        // Calcular el monto bruto
        double montoBruto = horasTrabajadas * salarioPorHora;

        // Calcular los montos de los descuentos
        double montoDescuentoSaludSocial = montoBruto * descuentoSaludSocial;
        double montoDescuentoAFP = montoBruto * descuentoAFP;

        // Calcular el monto total de los descuentos
        double montoTotalDescuentos = montoDescuentoSaludSocial + montoDescuentoAFP;

        // Calcular la remuneración líquida
        double remuneracionLiquida = montoBruto - montoTotalDescuentos;

        // Mostrar los resultados
        Console.WriteLine("Edad del empleado: " + edad + " años");
        Console.WriteLine("Horas trabajadas: " + horasTrabajadas);
        Console.WriteLine("Salario por hora: S/. " + salarioPorHora);
        Console.WriteLine("Monto bruto: S/. " + montoBruto);
        Console.WriteLine("Descuento por Salud Social (" + (descuentoSaludSocial * 100) + "%): S/. " + montoDescuentoSaludSocial);
        Console.WriteLine("Descuento por AFP (" + (descuentoAFP * 100) + "%): S/. " + montoDescuentoAFP);
        Console.WriteLine("Monto total de descuentos: S/. " + montoTotalDescuentos);

        if (horasTrabajadas >= 180)
        {
            // Proyección para el siguiente mes si trabaja 180 horas o más
            double salarioPorHoraSiguienteMes = 20.0; // El mismo salario por hora
            int horasTrabajadasSiguienteMes = 180;
            double montoBrutoSiguienteMes = horasTrabajadasSiguienteMes * salarioPorHoraSiguienteMes;

            Console.WriteLine("\nProyección para el siguiente mes:");
            Console.WriteLine("Horas trabajadas: " + horasTrabajadasSiguienteMes);
            Console.WriteLine("Monto bruto: S/. " + montoBrutoSiguienteMes);
        }
        else
        {
            Console.WriteLine("\nNo se realizó proyección para el siguiente mes debido a las horas trabajadas.");
        }

        Console.WriteLine("Remuneración líquida: S/. " + remuneracionLiquida);
    }
}
