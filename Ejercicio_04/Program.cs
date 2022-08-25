using System;

namespace Ejercicio_04
{
    internal class Program
    {
        static void Main()
        {
            int numFromIteration = 0;
            int totalPerfectNumFound = 0;

            Console.WriteLine("\nPrimeros 4 numeros perfectos:");
            while (totalPerfectNumFound < 4)
            {
                if (IsPerfectNum(numFromIteration))
                {
                    Console.Write(numFromIteration + " - ");
                    totalPerfectNumFound++;
                }
                numFromIteration++;
            }


        }

        static bool IsPerfectNum(int number)
        {
            bool returnValue = false;
            int numDividers = 0;

            for (int i = 1; i < number; i++)
            {
                if (number % i != 0)
                {
                    continue;
                }

                numDividers += i;
            }

            if(number - numDividers == 0)
            {
                returnValue = true;
            }

            return returnValue;
        }
    }
}
