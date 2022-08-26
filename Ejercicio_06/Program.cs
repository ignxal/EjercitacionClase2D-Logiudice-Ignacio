using System;
using System.Linq;

namespace Ejercicio_06
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
                Console.Write("Ingrese año de inicio: ");
                userInput = Console.ReadLine();
                inputWasParsed = int.TryParse(userInput, out int parsedInitialYear);

                while (userInput != "salir" && !inputWasParsed || parsedInitialYear < 1)
                {
                    Console.WriteLine("\n\nERROR. ¡Reingresar año!\n\n");
                    Console.Write("Ingrese año de inicio: ");
                    userInput = Console.ReadLine();
                    inputWasParsed = int.TryParse(userInput, out parsedInitialYear);
                }


                if (userInput == "salir")
                {
                    Environment.Exit(0);
                }

                Console.Write("Ingrese año de fin: ");
                userInput = Console.ReadLine();
                inputWasParsed = int.TryParse(userInput, out int parsedFinalYear);

                while (userInput != "salir" && !inputWasParsed || parsedFinalYear < 1 || parsedFinalYear < parsedInitialYear)
                {
                    Console.WriteLine("\n\nERROR. ¡Reingresar año!\n\n");
                    Console.Write("Ingrese año de fin: ");
                    userInput = Console.ReadLine();
                    inputWasParsed = int.TryParse(userInput, out parsedFinalYear);
                }

                if (userInput == "salir")
                {
                    Environment.Exit(0);
                }

                Console.WriteLine("\nAños bisiestos:");
                for (int i = parsedInitialYear; i <= parsedFinalYear; i++)
                {
                    if (IsLeapYear(i))
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

        static bool IsLeapYear(int year)
        {
            bool returnValue = false;

            if((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                returnValue = true;
            }

            return returnValue;
        }
    }
}
