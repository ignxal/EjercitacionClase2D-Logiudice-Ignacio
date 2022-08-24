using System;

namespace Ejercicio_03
{
    internal class Program
    {
        static void Main()
        {
            string userInput;
            string userAnswer;
            int parsedNum;
            bool wasParsed;

            do
            {
                Console.Write("Ingrese un numero: ");
                userInput = Console.ReadLine();
                wasParsed = int.TryParse(userInput, out parsedNum);

                while (userInput != "salir" && wasParsed == false)
                {
                    Console.WriteLine("\n\nERROR. ¡Reingresar número!\n\n");
                    Console.Write("Ingrese un numero: ");
                    userInput = Console.ReadLine();
                }

                if (userInput == "salir")
                {
                    Environment.Exit(0);
                }

                Console.WriteLine("\nNumeros primos:");
                for (int i = 2; i <= parsedNum; i++)
                {
                    
                    if (isPrime(i))
                    {   
                        Console.Write(i + " - ");
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

        static bool isPrime(int number)
        {
            bool returnValue = true;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0) 
                {
                    returnValue = false;
                    break;
                } 
            }

            return returnValue;
        }
    }
}
