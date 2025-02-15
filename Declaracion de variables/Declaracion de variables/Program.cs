using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {

            int numeroEntero;
            double numeroDecimal;
            string texto;
            bool valorBooleano;

            Console.Write("Introduce un número entero: ");
            while (!int.TryParse(Console.ReadLine(), out numeroEntero))
            {
                Console.Write("Valor no válido. Introduce un número entero: ");
            }

            Console.Write("Introduce un número decimal: ");
            while (!double.TryParse(Console.ReadLine(), out numeroDecimal))
            {
                Console.Write("Valor no válido. Introduce un número decimal: ");
            }

            Console.Write("Introduce un texto: ");
            texto = Console.ReadLine();

            Console.Write("Introduce un valor verdadero o falso (true/false): ");
            while (!bool.TryParse(Console.ReadLine(), out valorBooleano))
            {
                Console.Write("Valor no válido. Introduce un valor verdadero o falso (true/false): ");
            }

            Console.WriteLine("El número entero es: " + numeroEntero);
            Console.WriteLine("El número decimal es: " + numeroDecimal);
            Console.WriteLine("El texto es: " + texto);
            Console.WriteLine("El valor verdadero o falso es: " + valorBooleano);
        }
    }
}