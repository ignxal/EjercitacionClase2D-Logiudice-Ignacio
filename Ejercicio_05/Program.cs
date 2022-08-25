using System;

namespace Ejercicio_05
{
    internal class Program
    {
        static void Main()
        {
            string userInput;
            string userAnswer;
            bool inputWasParsed;

            do
            {
                Console.Write("Ingrese un numero: ");
                userInput = Console.ReadLine();
                inputWasParsed = int.TryParse(userInput, out int parsedNum);

                while (userInput != "salir" && inputWasParsed == false)
                {
                    Console.WriteLine("\n\nERROR. ¡Reingresar número!\n\n");
                    Console.Write("Ingrese un numero: ");
                    userInput = Console.ReadLine();
                    inputWasParsed = int.TryParse(userInput, out parsedNum);
                }

                if (userInput == "salir")
                {
                    Environment.Exit(0);
                }

                Console.WriteLine("\nNumeros centricos:");
                for (int i = 1; i <= parsedNum; i++)
                {
                    int numberCenter = getNumberCenter(i);
                    if (numberCenter != -1)
                    {
                        Console.Write(numberCenter + " - ");
                    }
                }

                Console.Write("\n\nDesear volver a operar? (si/no): ");
                userAnswer = Console.ReadLine();

                while (userAnswer != "si" && userAnswer != "no")
                {
                    Console.WriteLine("\n\nERROR. ¡Reingresar respuesta!\n\n");
                    Console.Write("Desear volver a operar? (si/no): ");
                    userAnswer = Console.ReadLine();
                }

            } while (userAnswer != "no");
        }

        static int getNumberCenter(int number)
        {
            int returnValue = -1;
            int previousNumbersSum = 0;

            for (int i = 1; i <= number; i++)
            {
                int nextNumbersSum = 0;

                for (int j = i+1; j <= number; j++)
                {
                    nextNumbersSum += j;
                }

                if (previousNumbersSum > 0 && nextNumbersSum > 0 && previousNumbersSum == nextNumbersSum)
                {
                    returnValue = i;
                    break;
                }
                previousNumbersSum += i;
            }

            return returnValue;
        }
    }
}
