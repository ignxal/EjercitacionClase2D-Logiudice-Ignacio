using System;
using System.ComponentModel.DataAnnotations;

namespace _2_Ejercicio_03
{
    internal class Program
    {
        static void Main()
        {
            int number = 20;
            string numberInBinary;
            int binary = 010101;
            string binaryInDecimal;

            numberInBinary = Converter.ConvertDecimalToBinary(number);
            binaryInDecimal = Converter.ConvertBinaryToDecimal(binary);

            DisplayResults(number, numberInBinary, binary, binaryInDecimal);
        }

        static void DisplayResults(int number, string numberInBinary, int binary, string binaryInDecimal)
        {
            Console.WriteLine("\n\n##### Resultados #####\n");
            Console.WriteLine($"Numero original: {number}");
            Console.WriteLine($"Numero en binario: {numberInBinary}");

            Console.WriteLine($"Binario original: {binary}");
            Console.WriteLine($"Binario en decimal: {binaryInDecimal}");
        }
    }
}
