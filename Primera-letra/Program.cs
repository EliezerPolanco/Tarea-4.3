using System;
using System.Linq;

class Programa
{
    static void Main()
    {
        Console.WriteLine("Ingrese su nombre:");

        string nombre = Console.ReadLine();

        if (!string.IsNullOrEmpty(nombre) && nombre.All(char.IsLetter))
        {
            char inicial = nombre[0];

            Console.WriteLine($"La inicial de tu nombre es: {inicial}");
        }
        else
        {
            Console.WriteLine("No ingresaste un nombre válido. Asegúrate de ingresar solo letras.");
        }
    }
}
