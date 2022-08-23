using System;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio_01
{
    internal class Program
    {
        static void Main()
        {
            string numInput;
            int total = 5;
            float max = 0;
            float min = 0;
            float acum = 0;
            float prom;
            for (int i = 0; i < total; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                numInput = Console.ReadLine();
                
                if(float.TryParse(numInput, out float parsedInput))
                {
                    if (i > 0)
                    {
                        if(parsedInput > max)
                        {
                            max = parsedInput;
                        }
                        if(parsedInput < min)
                        {
                            min = parsedInput;
                        }
                    }
                    else
                    {
                        max = parsedInput;
                        min = parsedInput;
                    }
                    acum += parsedInput;
                }
                else
                {
                    Console.WriteLine("\n\n### ERROR ###");
                    Console.WriteLine("Dato ingresado no es un numero.\n\n");
                    i--;
                }

            }

            prom = acum / total;

            Console.WriteLine($"Numero maximo: {max}");
            Console.WriteLine($"Numero minimo: {min}");
            Console.WriteLine($"Promedio: {prom}");


        }
    }
}
