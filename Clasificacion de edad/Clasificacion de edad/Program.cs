using System;

class Program
{
    // Función para clasificar la edad
    static string ClasificarEdad(int edad)
    {
        if (edad < 12)
        {
            return "Niño";
        }
        else if (edad >= 12 && edad <= 17)
        {
            return "Adolescente";
        }
        else if (edad >= 18 && edad <= 59)
        {
            return "Adulto";
        }
        else
        {
            return "Adulto mayor";
        }
    }

    static void Main()
    {
        // Solicitar la edad al usuario
        Console.Write("Introduce tu edad: ");
        int edad = int.Parse(Console.ReadLine());

        // Obtener la categoría según la edad
        string categoria = ClasificarEdad(edad);

        // Mostrar el resultado
        Console.WriteLine($"Con {edad} años, eres un(a) {categoria}.");
    }
}

