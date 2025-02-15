using System;

namespace OperacionesLogicas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pedir dos valores numéricos al usuario
            Console.WriteLine("Introduce el primer número:");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número:");
            int numero2 = int.Parse(Console.ReadLine());

            // Comparaciones lógicas
            Console.WriteLine("Comparaciones:");
            Console.WriteLine($"¿Es {numero1} mayor que {numero2}? {numero1 > numero2}");
            Console.WriteLine($"¿Es {numero1} menor que {numero2}? {numero1 < numero2}");
            Console.WriteLine($"¿Es {numero1} igual a {numero2}? {numero1 == numero2}");

            // Uso de operadores lógicos AND (&&) y OR (||)
            Console.WriteLine("Operadores lógicos:");
            bool andResult = (numero1 > 0) && (numero2 > 0);
            bool orResult = (numero1 > 0) || (numero2 > 0);

            Console.WriteLine($"¿Son ambos números mayores que 0? {andResult}");
            Console.WriteLine($"¿Es al menos uno de los números mayor que 0? {orResult}");
        }
    }
}

