using System;

//Tarea de Jasmin Anguelique Pech Hernandez 

class Program
{
    static void Main()
    {
        // Definir constantes
        const int jornadaLaboral = 48; // Jornada laboral en horas
        double valorPorHora = 5.42;   // Valor por hora de trabajo
        double horasTrabajadas;

        // Solicitar al usuario ingresar las horas trabajadas
        Console.Write("Ingrese las horas trabajadas: ");
        if (double.TryParse(Console.ReadLine(), out horasTrabajadas))
        {
            double salarioSinHorasExtras;
            double salarioHorasExtras;
            double salarioTotal;
            double horasExtrasTrabajadas;

            if (horasTrabajadas <= jornadaLaboral)
            {
                // Si no se excede de la jornada, no hay horas extras
                salarioSinHorasExtras = horasTrabajadas * valorPorHora;
                salarioHorasExtras = 0.0;
                horasExtrasTrabajadas = 0.0;
            }
            else
            {
                // Si se excede de la jornada, se calculan las horas extras
                salarioSinHorasExtras = jornadaLaboral * valorPorHora;
                horasExtrasTrabajadas = horasTrabajadas - jornadaLaboral;
                salarioHorasExtras = horasExtrasTrabajadas * (valorPorHora * 2.71); // Se paga 2.71 veces el valor por hora en horas extras
            }

            // Calcular el salario total
            salarioTotal = salarioSinHorasExtras + salarioHorasExtras;

            // Mostrar resultados en la consola
            Console.WriteLine("Horas trabajadas: " + horasTrabajadas);
            Console.WriteLine("Salario sin horas extras: " + salarioSinHorasExtras);
            Console.WriteLine("Salario de horas extras: " + salarioHorasExtras);
            Console.WriteLine("Salario total: " + salarioTotal);
            Console.WriteLine("Horas extras trabajadas: " + horasExtrasTrabajadas);
        }
        else
        {
            // Manejar entrada no válida
            Console.WriteLine("Entrada no válida. Por favor, ingrese un número válido de horas trabajadas.");
        }
    }
}
