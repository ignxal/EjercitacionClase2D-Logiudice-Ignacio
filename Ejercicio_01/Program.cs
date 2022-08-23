using System;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio_01
{
    internal class Program
    {
        static void Main()
        {
            string numInput;
            int totalInputs = 5;
            float maxNum = 0;
            float minNum = 0;
            float acumNum = 0;
            float promNum;
            for (int i = 0; i < totalInputs; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                numInput = Console.ReadLine();
                
                if(float.TryParse(numInput, out float parsedInput))
                {
                    if (i > 0)
                    {
                        if(parsedInput > maxNum)
                        {
                            maxNum = parsedInput;
                        }
                        if(parsedInput < minNum)
                        {
                            minNum = parsedInput;
                        }
                    }
                    else
                    {
                        maxNum = parsedInput;
                        minNum = parsedInput;
                    }
                    acumNum += parsedInput;
                }
                else
                {
                    Console.WriteLine("\n\n### ERROR ###");
                    Console.WriteLine("Dato ingresado no es un numero.\n\n");
                    i--;
                }

            }

            promNum = acumNum / totalInputs;

            Console.WriteLine($"Numero maximo: {maxNum}");
            Console.WriteLine($"Numero minimo: {minNum}");
            Console.WriteLine($"Promedio: {promNum}");


        }
    }
}
