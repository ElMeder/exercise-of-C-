using System;

//Tarea de Jasmin Anguelique Pech Hernandez 
class Program
{
    static void Main()
    {
        // Solicitar al usuario su nombre
        Console.Write("Ingrese su nombre: ");
        string nombre = Console.ReadLine();

        // Solicitar al usuario el mes de nacimiento
        Console.Write("Ingrese su mes de nacimiento (en formato numérico, por ejemplo, enero = 1, febrero = 2, etc.): ");
        if (int.TryParse(Console.ReadLine(), out int mesNacimiento) && mesNacimiento >= 1 && mesNacimiento <= 12)
        {
            string signoZodiacal = ObtenerSignoZodiacal(mesNacimiento);

            // Mostrar el resultado
            Console.WriteLine("Hola, " + nombre + ". Su signo zodiacal es: " + signoZodiacal);
        }
        else
        {
            Console.WriteLine("Por favor, ingrese un mes de nacimiento válido (un número entre 1 y 12).");
        }
    }

    static string ObtenerSignoZodiacal(int mesNacimiento)
    {
        string signo = "";

        switch (mesNacimiento)
        {
            case 1: // Enero
                signo = "Capricornio";
                break;
            case 2: // Febrero
                signo = "Acuario";
                break;
            case 3: // Marzo
                signo = "Piscis";
                break;
            case 4: // Abril
                signo = "Aries";
                break;
            case 5: // Mayo
                signo = "Tauro";
                break;
            case 6: // Junio
                signo = "Géminis";
                break;
            case 7: // Julio
                signo = "Cáncer";
                break;
            case 8: // Agosto
                signo = "Leo";
                break;
            case 9: // Septiembre
                signo = "Virgo";
                break;
            case 10: // Octubre
                signo = "Libra";
                break;
            case 11: // Noviembre
                signo = "Escorpio";
                break;
            case 12: // Diciembre
                signo = "Sagitario";
                break;
            default:
                signo = "Desconocido";
                break;
        }

        return signo;
    }
}
