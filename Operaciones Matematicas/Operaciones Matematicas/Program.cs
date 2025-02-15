using System;

namespace OperacionesBasicas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables numéricas (int)
            Console.WriteLine("Introduce el primer número entero (int):");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número entero (int):");
            int numero2 = int.Parse(Console.ReadLine());

            // Operaciones básicas con int
            Console.WriteLine("Suma: " + (numero1 + numero2));
            Console.WriteLine("Resta: " + (numero1 - numero2));
            Console.WriteLine("Multiplicación: " + (numero1 * numero2));
            Console.WriteLine("División: " + (numero1 / numero2));

            // Variables decimales (decimal)
            Console.WriteLine("Introduce el primer número decimal (decimal):");
            decimal numeroDecimal1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número decimal (decimal):");
            decimal numeroDecimal2 = decimal.Parse(Console.ReadLine());

            // Operaciones básicas con decimal
            Console.WriteLine("Suma: " + (numeroDecimal1 + numeroDecimal2));
            Console.WriteLine("Resta: " + (numeroDecimal1 - numeroDecimal2));
            Console.WriteLine("Multiplicación: " + (numeroDecimal1 * numeroDecimal2));
            Console.WriteLine("División: " + (numeroDecimal1 / numeroDecimal2));

            // Variables flotantes (float)
            Console.WriteLine("Introduce el primer número flotante (float):");
            float numeroFloat1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número flotante (float):");
            float numeroFloat2 = float.Parse(Console.ReadLine());

            // Operaciones básicas con float
            Console.WriteLine("Suma: " + (numeroFloat1 + numeroFloat2));
            Console.WriteLine("Resta: " + (numeroFloat1 - numeroFloat2));
            Console.WriteLine("Multiplicación: " + (numeroFloat1 * numeroFloat2));
            Console.WriteLine("División: " + (numeroFloat1 / numeroFloat2));

            // Variables de 16 bits (short)
            Console.WriteLine("Introduce el primer número entero de 16 bits (short):");
            short numeroShort1 = short.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número entero de 16 bits (short):");
            short numeroShort2 = short.Parse(Console.ReadLine());

            // Operaciones básicas con short
            Console.WriteLine("Suma: " + (numeroShort1 + numeroShort2));
            Console.WriteLine("Resta: " + (numeroShort1 - numeroShort2));
            Console.WriteLine("Multiplicación: " + (numeroShort1 * numeroShort2));
            Console.WriteLine("División: " + (numeroShort1 / numeroShort2));

            // Variables de tipo byte
            Console.WriteLine("Introduce el primer número byte:");
            byte numeroByte1 = byte.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número byte:");
            byte numeroByte2 = byte.Parse(Console.ReadLine());

            // Operaciones básicas con byte
            Console.WriteLine("Suma: " + (numeroByte1 + numeroByte2));
            Console.WriteLine("Resta: " + (numeroByte1 - numeroByte2));
            Console.WriteLine("Multiplicación: " + (numeroByte1 * numeroByte2));
            Console.WriteLine("División: " + (numeroByte1 / numeroByte2));
        }
    }
}
