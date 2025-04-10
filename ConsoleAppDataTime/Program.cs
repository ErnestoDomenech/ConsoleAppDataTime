using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese la hora de entrada (formato: yyyy-MM-dd HH:mm:ss):");
        string entradaStr = Console.ReadLine();

        Console.WriteLine("Ingrese la hora de salida (formato: yyyy-MM-dd HH:mm:ss):");
        string salidaStr = Console.ReadLine();

        // Intentamos parsear los datos a DateTime
        if (DateTime.TryParseExact(entradaStr, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime entrada)
            && DateTime.TryParseExact(salidaStr, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime salida))
        {
            // Validamos que la salida sea posterior a la entrada
            if (salida > entrada)
            {
                TimeSpan total = salida - entrada;

                Console.WriteLine("\n--- Resultado ---");
                Console.WriteLine($"Total trabajado: {total.Hours} horas, {total.Minutes} minutos, {total.Seconds} segundos");
                Console.WriteLine($"(Total en horas decimales: {total.TotalHours:F2} horas)");
            }
            else
            {
                Console.WriteLine("La hora de salida debe ser posterior a la de entrada.");
            }
        }
        else
        {
            Console.WriteLine("Formato incorrecto. Use el formato: yyyy-MM-dd HH:mm:ss");
        }

        Console.WriteLine("\nPresione una tecla para salir...");
        Console.ReadKey();
    }
}
