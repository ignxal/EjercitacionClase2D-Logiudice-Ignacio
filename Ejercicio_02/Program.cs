using System;

namespace Ejercicio_02
{
    internal class Program
    {
        static void Main()
        {
            string numInput;
            float parsedNum;

            Console.WriteLine("Ingrese un numero: ");
            numInput = Console.ReadLine();

            while (float.TryParse(numInput, out parsedNum) == false || parsedNum <= 0)
            {
                Console.WriteLine("\n\nERROR. ¡Reingresar número!\n\n");
                Console.WriteLine("Ingrese un numero: ");
                numInput = Console.ReadLine();
            }
   
            double squaredNum = Math.Pow(parsedNum, 2);
            double cubedNum = Math.Pow(parsedNum, 3);

            Console.WriteLine($"Numero al cuadrado: {squaredNum}");
            Console.WriteLine($"Numero al cuadrado: {cubedNum}");

        }
    }
}
